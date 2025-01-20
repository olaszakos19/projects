<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\TableController;
use App\Http\Controllers\UserController;
use App\Http\Controllers\TaskController;



Route::get('/',[UserController::class,'goToLogin'])->name('login_page');


require __DIR__ . '/table.php';
require __DIR__ . '/auth.php';
require __DIR__ . '/tasks.php';
