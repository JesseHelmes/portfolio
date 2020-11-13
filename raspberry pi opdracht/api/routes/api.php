<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

//sudo php artisan serve
Route::get('/temperature', 'TemperatureController@temperature');
Route::get('/temperature/cpu', 'TemperatureController@cpu');
Route::get('/temperatures', 'TemperatureController@temperatures');

Route::get('/leds', 'LedController@leds');
Route::post('/leds', 'LedController@led');
Route::post('/leds/morse', 'LedController@morse');