<?php


use Illuminate\Support\Facades\Route;
use App\Http\Controllers\ApiController;


Route::get('/api/attractions', [ApiController::class, 'loadAll']);


Route::get('/api/hello', function () {
    return response()->json(['message' => 'Hello']);
});
