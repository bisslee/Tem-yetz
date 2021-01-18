<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

Route::get('tasks', 'App\Http\Controllers\TasksController@get');
Route::get('tasks/{task}', 'App\Http\Controllers\TasksController@getid');
Route::post('tasks', 'App\Http\Controllers\TasksController@post');
Route::patch('tasks/{task}', 'App\Http\Controllers\TasksController@put');
Route::delete('tasks/{task}', 'App\Http\Controllers\TasksController@delete');



Route::get('pagadores', 'App\Http\Controllers\PagadoresController@get');
//Route::get('pagadores/{pagador}', 'App\Http\Controllers\TasksController@getid');
Route::post('pagadores', 'App\Http\Controllers\PagadoresController@post');
//Route::patch('pagadores/{pagador}', 'App\Http\Controllers\TasksController@put');
//Route::delete('pagadores/{pagador}', 'App\Http\Controllers\TasksController@delete');



//Route::get('pagadores', 'App\Http\Controllers\PagadoresController@getPagadores');
//Route::post('pagadores', 'App\Http\Controllers\PagadoresController@postPagadores');


