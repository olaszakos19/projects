<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Attraction;
use App\Models\Visited;
use App\Models\Favorites;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Session;

class PageController extends Controller
{


    public function LoadByCountry($county){
        $attractions = DB::table('touristattractions')->where('County',$county)->get();

        $counties = DB::table('touristattractions')->select('County')->groupBy('County')->get();

        return view('main',compact('attractions','counties'));

    }

    public function LoadAll(){
        $attractions = DB::table('touristattractions')->where('County','Veszprém megye')->get();
        $attractions = DB::table('touristattractions')->where('County','Veszprém megye')->paginate(3);
        $counties = DB::table('touristattractions')->select('County')->groupBy('County')->get();

        return view('main',compact('attractions','counties'));

    }


    public function LoadAttraction($name){
        $attraction = DB::table('touristattractions')->where('AttractionName',$name)->get();
        $county = DB::table('touristattractions')->where('AttractionName',$name)->first();
        $attractions = DB::table('touristattractions')->where('County',$county->County)->where('AttractionName','!=',$name)->get();
        return view('attraction', compact('attraction', 'attractions'));


    }


    public function LoadFavorites() {
        $user = Session::get('user');

        if (!$user) {
            return redirect()->route('login')->with('error', 'Nincs bejelentkezve');
        }

        $favorites = Favorites::where('userID', $user->id)->get();
        $attractions = [];

        foreach ($favorites as $f) {
            $attraction = Attraction::where('AttractionName', $f->attractionID)->first();
            if ($attraction) {
                $attractions[] = $attraction;
            }
        }

        return view('favorites', compact('favorites', 'attractions'));
    }


    public function LoadVisited(){

        return view('visited');

    }

    public function show_profile(){

        return view('myProfile');

    }


}
