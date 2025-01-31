<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Favorites extends Model
{
    public $timestamps = false;

    use HasFactory;

    protected $fillable = [
        'userID',
        'attractionID',
    ];

}
