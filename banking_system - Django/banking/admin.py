from django.contrib import admin  
from .models import Profile, Account,Transaction  


@admin.register(Profile)
class ProfileAdmin(admin.ModelAdmin):
    """
    A Profile model megjelenítését szabályozza az admin felületen.
    """
    list_display = ('user', 'bio', 'profile_picture')  

@admin.register(Account)
class AccountAdmin(admin.ModelAdmin):
    """
    Az Account model megjelenítését szabályozza az admin felületen.
    """
    list_display = ('account_number', 'balance', 'user')  


@admin.register(Transaction)
class TransactionAdmin(admin.ModelAdmin):
    list_display = ('account_number','method','amount','date')