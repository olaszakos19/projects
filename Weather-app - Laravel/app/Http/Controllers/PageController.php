<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Attraction;
use App\Models\Visited;
use App\Models\Favorites;
use Illuminate\Support\Facades\DB;


class PageController extends Controller
{


    public function LoadByCountry($county){
        $attractions = Attraction::where('County',$county)->get();

        $counties = DB::table('touristattractions')->select('County')->groupBy('County')->get();

        return view('main',compact('attractions','counties'));

    }

    public function LoadAll(){
        $attractions = DB::table('touristattractions')->where('County','Veszprém megye')->get();

        $counties = DB::table('touristattractions')->select('County')->groupBy('County')->get();

        return view('main',compact('attractions','counties'));

    }


    public function LoadAttraction($name){
        $attraction = DB::table('touristattractions')->where('AttractionName',$name)->get();
        $county = DB::table('touristattractions')->where('AttractionName',$name)->first();
        $attractions = Attraction::where('County',$county->County)->where('AttractionName','!=',$name)->get();
        return view('attraction', compact('attraction', 'attractions'));


    }


    public function LoadFavorites(){


        return view('favorites');


    }

    public function LoadVisited(){

        return view('visited');

    }

    public function show_profile(){

        return view('myProfile');

    }


}
