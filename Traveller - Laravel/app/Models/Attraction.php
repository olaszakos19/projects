<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Attraction extends Model
{
    //
    protected $fillable = [
        'name',
        'description',
        'pictures',
        'county',
        'addres',
    ];
}
