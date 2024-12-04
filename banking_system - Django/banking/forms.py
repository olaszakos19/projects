from django import forms  # Django űrlapok kezelésére
from django.contrib.auth.forms import UserCreationForm  # Felhasználói regisztrációs űrlap alapja
from django.contrib.auth.models import User  # Beépített User modell
from .models import Account, Profile  # Az alkalmazás saját modelljei

# Felhasználói regisztrációs űrlap
class SignUpForm(UserCreationForm):
    email = forms.EmailField(required=True)  # Kötelező email mező hozzáadása

    class Meta:
        model = User  # Az űrlap a beépített User modellt használja
        fields = ['username', 'email', 'password1', 'password2']  # Megjelenő mezők a regisztrációs űrlapon


class AccountForm(forms.ModelForm):
    user = forms.ModelChoiceField(
        queryset=User.objects.filter(is_staff=False),  
        empty_label="Select User",  
        label="User"  
    )

    class Meta:
        model = Account
        fields = ['user', 'account_number', 'balance']


class AccountUpdateForm(forms.ModelForm):

    class Meta:
        model = Account
        fields = ['account_number', 'balance']


class ProfileForm(forms.ModelForm):
    active_account = forms.ModelChoiceField(queryset=Account.objects.none(), required=False)

    class Meta:
        model = Profile  
        fields = ['profile_picture', 'active_account']


    def __init__(self, *args, **kwargs):
        user = kwargs.pop('user') 
        super(ProfileForm, self).__init__(*args, **kwargs)
        self.fields['active_account'].queryset = Account.objects.filter(user=user)

class WithdrawForm(forms.Form):
    amount = forms.DecimalField(max_digits=22, decimal_places=2, min_value=0.01, label="Kivenni kívánt összeg")


class DepositForm(forms.Form):
    amount = forms.DecimalField(max_digits=22, decimal_places=2, min_value=0.01, label="Befizetni kívánt összeg")


class TransferForm(forms.Form):

    account_number = forms.CharField(max_length=50,label="Kedvezményezett számlaszáma")
    amount = forms.DecimalField(max_digits=22, decimal_places=2, min_value=0.01, label="Utalni kívánt összeg")
