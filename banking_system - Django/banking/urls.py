from django.urls import path 
from .views import (  
    signup_view, login_view, logout_view, profile_view,
    account_list_view, account_detail_view, account_create_view,
    account_update_view, account_delete_view, toggle_balance,mk_withdraw,list_transactions,
    list_accounts,list_users,mk_deposit,mk_transfer
)
from . import views  


urlpatterns = [
    path('', login_view, name='login'),
    path('home', views.home, name='home'),
    
    
    path('signup/', signup_view, name='signup'),  
    path('login/', login_view, name='login'), 
    path('logout/', logout_view, name='logout'),  
    
  
    path('profile/', profile_view, name='profile'),  
    
   
    path('accounts/', account_list_view, name='account_list'),  
    path('accounts/<int:number>/', account_detail_view, name='account_detail'),  
    path('accounts/create/', account_create_view, name='account_create'),  
    path('accounts/<int:number>/edit/', account_update_view, name='account_edit'), 
    path('accounts/<int:number>/delete/', account_delete_view, name='account_delete'),  
    

    path('toggle_balance/', toggle_balance, name='toggle_balance'),  

    path('transactions/',list_transactions,name='transactions'),

    path('list_accounts/',list_accounts,name='list_accounts'),

    path('users/',list_users,name='list_users'),

    path('withdraw/', mk_withdraw, name='withdraw'),

    path('deposit/', mk_deposit, name='deposit'),

    path('transfer/',mk_transfer,name='transfer'),

    #path('transfer/<int:amount>/<int:number>/',mk_transfer,name='trasnfer'),

]
