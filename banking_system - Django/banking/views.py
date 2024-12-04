from django.shortcuts import render, redirect, get_object_or_404  
from django.contrib.auth import authenticate, login, logout  
from django.contrib.auth.decorators import login_required 
from .forms import SignUpForm, ProfileForm, AccountForm, AccountUpdateForm, WithdrawForm, DepositForm, TransferForm 
from .models import Profile, Account,Transaction,User 

# Kezdőlap nézet
def home(request):
    """
    Megjeleníti a kezdőlapot.
    """
    if request.user.is_staff:
        return render(request, 'admin/home.html') 
    else:
        account = Account.objects.filter(user=request.user).first()
        transactions = Transaction.objects.filter(account_number = account)
        return render(request, 'home.html',{'transactions': transactions})  

# Regisztrációs nézet
def signup_view(request):
    """
    Új felhasználók regisztrációját kezeli.
    """
    if request.method == 'POST':
        form = SignUpForm(request.POST)  
        if form.is_valid():
            form.save()  
            return redirect('login')  
    else:
        form = SignUpForm()  

    return render(request, 'signup.html', {'form': form}) 

# Bejelentkezési nézet
def login_view(request):
    """
    Felhasználói bejelentkezést kezel.
    """
    if request.method == 'POST':
        username = request.POST['username']  
        password = request.POST['password']  
        user = authenticate(request, username=username, password=password)  
        if user is not None:
            login(request, user)  
            

            return redirect('home') 
        else:
            return render(request, 'login.html', {'error': 'Invalid login'}) 
    
    return render(request, 'login.html')  

# Kijelentkezési nézet
def logout_view(request):
    """
    Kijelentkezési folyamatot hajt végre.
    """
    logout(request) 
    return redirect('login')  

# Profil nézet
@login_required
def profile_view(request):
    """
    Profil megtekintése és szerkesztése.
    """
    try:
        profile = request.user.profile  
    except Profile.DoesNotExist:
        profile = Profile.objects.create(user=request.user)  

    if request.method == 'POST':
        form = ProfileForm(request.POST, request.FILES, instance=profile, user=request.user)  
        if form.is_valid():
            form.save()  
            return redirect('home') 
    else:
        form = ProfileForm(instance=profile, user=request.user)  
    return render(request, 'profile.html', {'form': form})  

# Számlák listázása
@login_required
def account_list_view(request):
    """
    Felhasználó összes számlájának megjelenítése.
    """
    accounts = Account.objects.filter(user=request.user)  
    return render(request, 'account_list.html', {'accounts': accounts})  

# Egyedi számla részletei
@login_required
def account_detail_view(request, pk):
    """
    Egy konkrét számla részleteinek megjelenítése.
    """
    account = get_object_or_404(Account, pk=pk, user=request.user) 
    return render(request, 'admin/account_detail.html', {'account': account})  

# Új számla létrehozása
@login_required
def account_create_view(request):

    if request.method == 'POST':
        form = AccountForm(request.POST)
        if form.is_valid():
            account = form.save(commit=False)    
            account.save()  
            return redirect('list_accounts')  
    else:
        form = AccountForm()  
    
    return render(request, 'account_form.html', {'form': form})  

# Számla módosítása
@login_required
def account_update_view(request, number):
    account = get_object_or_404(Account,account_number = number)
    if request.method == 'POST':
        form = AccountUpdateForm(request.POST, instance=account)  
        if form.is_valid():
            form.save()
            return redirect('account_list')
    else:
        form = AccountUpdateForm(instance=account)
    return render(request, 'account_form.html', {'form': form})  

@login_required
def account_delete_view(request, number):
    account = get_object_or_404(Account, account_number=number)
    transactions = get_object_or_404(Transaction,account_number = number)
    if request.method == 'POST':
        transactions.delete()
        account.delete()
        return redirect('account_list')
    return render(request, 'admin/account_confirm_delete.html', {'account': account})


@login_required
def toggle_balance(request):
    """
    Az egyenleg megjelenítésének be- vagy kikapcsolása.
    """
    profile = request.user.profile
    profile.show_balance = not profile.show_balance  
    profile.save()  
    return redirect('/home')  



@login_required
def list_transactions(request):
    if request.user.is_staff:
        transactions = Transaction.objects.all()
        return render(request, 'admin/transactions.html', {'transactions': transactions})
    else:
        return redirect('home')
    
@login_required
def list_transactions_withFilter(request,number):
    if request.user.is_staff:
        transactions = Transaction.objects.filter(account_number = number).all()
        return render(request, 'admin/transactions.html', {'transactions': transactions})
    else:
        return redirect('home')
    
@login_required
def list_users(request):
    if request.user.is_staff:
        profiles = Profile.objects.all()
        return render(request, 'admin/users.html', {'profiles': profiles})
    else:
        return redirect('home')

@login_required
def list_accounts(request):
    if request.user.is_staff:
        accounts = Account.objects.all()
        return render(request, 'admin/account_list.html', {'accounts': accounts})
    else:
        return redirect('home')
    

@login_required
def mk_withdraw(request):
    try:
        account = Account.objects.filter(user=request.user).first()
    except Account.DoesNotExist:
        return redirect('home')

    if request.method == 'POST':
        form = WithdrawForm(request.POST)
        if form.is_valid():
            amount = int(request.POST['amount'])
            

            if account.balance >= amount:
                account.balance -= amount
                account.save()
                
                Transaction.objects.create(
                    account_number=account,
                    method="Kivétel",
                    amount=amount*-1
                )
                                
                return redirect('home')
            else:
                return redirect('withdraw')
    else:
        form = WithdrawForm()

    return render(request, 'withdraw.html', {'form': form, 'account': account})

@login_required
def mk_deposit(request):
    try:
        account = Account.objects.filter(user=request.user).first()
    except Account.DoesNotExist:
        return redirect('home')

    if request.method == 'POST':
        form = DepositForm(request.POST)
        if form.is_valid():
            amount = int(request.POST['amount'])
            

            
            account.balance += amount
            account.save()

            Transaction.objects.create(
                    account_number=account,
                    method= "Befizetés",
                    amount=amount
            )
                                
            return redirect('home')

    else:
        form = WithdrawForm()

    return render(request, 'deposit.html', {'form': form, 'account': account})


@login_required
def mk_transfer(request):
    try:
        account = Account.objects.filter(user=request.user).first()
    except Account.DoesNotExist:
        return redirect('home')

    if request.method == 'POST':
        form = TransferForm(request.POST)
        if form.is_valid():
            amount = int(request.POST['amount'])
            account_number = request.POST['account_number']

            toAccount = Account.objects.filter(account_number = account_number).first()

            if toAccount:
                if account.balance >= amount:
                    account.balance -= amount
                    account.save()

                    Transaction.objects.create(
                        account_number=account,
                        method= "Átutalás",
                        amount=amount*-1,
                        transferedAccount = toAccount
                    )

                    #jóváírás
                    toAccount.balance += amount
                    toAccount.save()

                    Transaction.objects.create(
                        account_number=toAccount,
                        method= "Átutalás",
                        amount=amount,
                        transferedAccount = toAccount
                    )

                    return redirect('home')
                else:
                    return redirect('home')
            else:
                return redirect('home')
    else:
        form = TransferForm()

    return render(request, 'trasnfer.html', {'form': form, 'account': account})


# Client update
@login_required
def user_update_view(request, pk):
    account = get_object_or_404(Account, pk=pk, user=request.user)
    if request.method == 'POST':
        form = AccountForm(request.POST, instance=account)  
        if form.is_valid():
            form.save()
            return redirect('account_list')
    else:
        form = AccountForm(instance=account)
    return render(request, 'account_form.html', {'form': form})  

# Client törlése
@login_required
def user_delete_view(request, pk):
    """
    Számla törlésének megerősítése és végrehajtása.
    """
    user = get_object_or_404(User, pk=pk)
    if request.method == 'POST':
        user.delete()  
        return redirect('list_users')
    return render(request, 'account_confirm_delete.html', {'user': user})  