<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\PageController;

Route::get('/', function () {
    return view('welcome');
});


Route::get('/main', [PageController::class, 'goToMain'])->name('show_main');
