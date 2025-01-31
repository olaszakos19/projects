<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Attraction;
use App\Models\Visited;
use App\Models\Favorites;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Session;

class AttractionController extends Controller
{
    //

    public function favorites_store($id){

        $user = Session::get('user');

        $favorite = Favorites::create([
            'userID' => $user->id,
            'attractionID' => $id
        ]);





    }

    public function visited($id){

    }


}
