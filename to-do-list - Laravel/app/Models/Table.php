<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Table extends Model
{
    public $timestamps = false;
    //
    protected $fillable = [
        'title',
        'user_id',
    ];
}
