<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Task extends Model
{
    //use HasFactory;

    protected $fillable = [
        'title',
        'description',
        'status',
        'due_date',
        'user_id',
    ];

    protected $casts = [
        'due_date' => 'datetime',
    ];

}
