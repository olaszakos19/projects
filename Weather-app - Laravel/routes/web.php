<?php


use Illuminate\Support\Facades\Route;
use App\Http\Controllers\PageController;
use App\Http\Controllers\AttractionController;

Route::get('/test', function () {
    return view('api');
});



Route::controller(PageController::class)->group(function () {
    Route::get('/', 'LoadAll')->name('main');
    Route::get('/favorites', 'LoadFavorites')->name('show_favorites');
    Route::get('/visited', 'LoadVisited')->name('show_visited');
    Route::get('/profile', 'show_profile')->name('show_profile');
    Route::get('/attraction/{name}', 'LoadAttraction')->name('show_attraction_detail');
    Route::get('/attractions/{county}', 'LoadByCountry')->name('show_main');

});

Route::controller(AttractionController::class)->group(function () {
    Route::get('/favorites/{id}','favorites_store')->name('add_favorites');
    Route::post('/visited/{id}','visited_store')->name('add_visited');
});

require __DIR__ . '/auth.php';
require __DIR__ . '/api.php';
