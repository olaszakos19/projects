<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\TaskController;


Route::post('/tasks/create', [TaskController::class, 'store'])->name('create_task');

Route::get('/tasks/{table_id}', [TaskController::class, 'showTasks'])->name('show_tasks');

Route::get('/task/{id}', [TaskController::class, 'showTask'])->name('show_task');

Route::get('/task/update/{id}',[TaskController::class,'updateTask'])->name('update_task');

Route::get('/task/delete/{id}',[TaskController::class,'deleteTask'])->name('delete_task');

Route::get('/create',[TaskController::class,'goToCreate'])->name('go_to_create_task');


//Route::get('/create',[TaskController::class,'asd'])->name('asd');
