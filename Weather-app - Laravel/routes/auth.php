<?php


use Illuminate\Support\Facades\Route;
use App\Http\Controllers\UserController;

Route::controller(UserController::class)->group(function () {
    Route::delete('/user/{id}', 'delete')->name('delete.user');

    Route::get('/login','go_to_login')->name('goto.login');
    Route::post('/login','login')->name('login.user');

    Route::get('/logout','logout')->name('logout.user');

    Route::get('/register','go_to_reg')->name('goto.register');
    Route::post('/register', 'store')->name('register.user');
});
