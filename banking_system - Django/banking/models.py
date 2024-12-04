from django.db import models  # Az adatbázis modellek definiálásához szükséges modul
from django.contrib.auth.models import User  # Beépített User modell a felhasználók kezeléséhez
from datetime import datetime   

class Profile(models.Model):

    user = models.OneToOneField(User, on_delete=models.CASCADE)
    

    bio = models.TextField(blank=True)
    

    profile_picture = models.ImageField(upload_to='profile_pictures/', blank=True, null=True)
    

    active_account = models.ForeignKey(
        'Account', 
        on_delete=models.SET_NULL, 
        null=True, 
        blank=True, 
        related_name="active_account"
    )
    

    show_balance = models.BooleanField(default=False)
    
    def __str__(self):
   
        return self.user.username



class Account(models.Model):

    user = models.ForeignKey(User, on_delete=models.CASCADE)
    

    account_number = models.CharField(max_length=20, unique=True)
    
  
    balance = models.DecimalField(max_digits=22, decimal_places=2)
    
    def __str__(self):
        return f"Számlaszám: {self.account_number} - Név: {self.user.username}"
    

class Transaction(models.Model):
    account_number = models.ForeignKey(Account, on_delete=models.CASCADE)
    method = models.CharField(max_length=50)
    amount =models.IntegerField(max_length=10)
    date = models.DateTimeField(default=datetime.now)
    transferedAccount = models.CharField(max_length=20,blank=True)
    def __str__(self):
        return f"{self.account_number} {self.method} - {self.amount} - {self.date}"


    def summary(self):
        return f"Tranzakció: {self.method}  összeg:{self.amount} tranzakció időpontja{self.date}"
    

    def transferInfo(self):
        return f"Átutalás Átutalt összzeg: {self.amount} Utalás napja: {self.date} Számlaszám: {self.transferedAccount}"
    

   