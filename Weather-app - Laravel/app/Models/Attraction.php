<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Attraction extends Model
{
    use HasFactory;

    protected $table = 'touristattractions';

    protected $fillable = [
        'AttractionName',
        'County',
        'City',
        'Address',
        'Description'
    ];


}
