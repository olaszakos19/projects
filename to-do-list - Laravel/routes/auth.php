<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\UserController;


Route::get('/register',[UserController::class,'goToRegister'])->name('register_page');

Route::post('/login',[UserController::class,'loginUser'])->name('login_user');

Route::post('/register',[UserController::class,'registerUser'])->name('register_user');

Route::get('/logout',[UserController::class,'LogOut']);
