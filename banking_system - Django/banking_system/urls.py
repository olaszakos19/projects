"""
URL configuration for banking_system project.

The `urlpatterns` list routes URLs to views. For more information please see:
    https://docs.djangoproject.com/en/5.1/topics/http/urls/
    
    Példák:
    - Function views: Nézetek, amelyek egyszerű függvények.
    - Class-based views: Osztály-alapú nézetek.
    - Másik URL konfiguráció beillesztése: Több alkalmazás URL-jeinek kezelése.
"""

from django.contrib import admin  # Adminisztrációs felülethez szükséges modul
from django.conf import settings  # A projekt beállításaihoz tartozó objektum
from django.conf.urls.static import static  # Statikus és médiatartalmak kiszolgálására
from django.urls import path, include  # URL-konfigurációhoz szükséges funkciók

# URL-minták listája
urlpatterns = [
    # Adminisztrációs felület URL-je
    path('admin/', admin.site.urls),
    
    # Az alapértelmezett ('') URL-t a banking alkalmazás URL-jeihez irányítja
    path('', include('banking.urls')),
]

# Csak fejlesztési környezetben:
# Ha a DEBUG beállítás igaz, akkor szolgáltassuk ki a médiatartalmakat is
if settings.DEBUG:
    urlpatterns += static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT)
