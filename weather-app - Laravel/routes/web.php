<?php


use Illuminate\Support\Facades\Route;
use App\Http\Controllers\PageController;

Route::get('/test', function () {
    return view('api');
});

Route::get('/', [PageController::class, 'LoadByCountry']);

Route::get('/main', [PageController::class, 'LoadByCountry']);

Route::get('/favorites', [PageController::class, 'LoadByCountry']);

Route::get('/visited', [PageController::class, 'LoadByCountry']);

Route::get('/profile', [PageController::class, 'LoadByCountry']);

Route::get('/attraction/{name}', [PageController::class, 'LoadAttraction']);


