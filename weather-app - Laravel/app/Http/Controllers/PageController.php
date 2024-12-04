<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Attraction;
use Illuminate\Support\Facades\DB;

class PageController extends Controller
{


    public function LoadByCountry(){
        $attractions = DB::table('touristattractionsv2')->where('County','Pest')->get();

        $counties = DB::table('touristattractionsv2')->select('County')->groupBy('County')->get();

        return view('main',compact('attractions','counties'));

    }

    public function LoadAttraction($name){
        $attraction = DB::table('touristattractionsv2')->where('AttractionName',$name)->get();

        return view('attraction', compact('attraction'));

    }


    public function LoadFavorites(){

    }

    public function LoadVisited(){

    }

    public function LoadProfile(){

    }


}
