<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\TableController;

Route::get('/tables', [TableController::class, 'index'])->name('show_tables');

Route::get('/table/create', [TableController::class, 'create_page']);

Route::post('/table/create', [TableController::class, 'store'])->name('create_table');
