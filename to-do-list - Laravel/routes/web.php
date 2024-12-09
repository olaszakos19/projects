<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\TaskController;
use App\Http\Controllers\UserController;

Route::get('/', function () {
    return view('welcome');
});

Route::get('/tasks/show', [TaskController::class, 'showTasks'])->name('show_tasks');

Route::get('/task/{id}', [TaskController::class, 'showTask'])->name('show_task');

Route::get('/task/update/{id}',[TaskController::class,'updateTask'])->name('update_task');

Route::get('/task/delete/{id}',[TaskController::class,'deleteTask'])->name('delete_task');

Route::get('/tasks/create', [TaskController::class, 'goToCreate'])->name('create_task');

Route::get('/login',[UserController::class,'goToLogin'])->name('login_page');

Route::get('/register',[UserController::class,'goToRegister'])->name('register_page');

Route::post('/login',[UserController::class,'loginUser'])->name('login_user');

Route::post('/register',[UserController::class,'registerUser'])->name('register_user');

Route::post('/tasks/create', [TaskController::class, 'store'])->name('create_task');

Route::get('/logout',[UserController::class,'LogOut']);
