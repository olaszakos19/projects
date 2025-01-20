<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Table;
use Illuminate\Support\Facades\Session;

class TableController extends Controller
{
    //
    public function index(){

        if (!Session::has('user')) {
            return redirect()->route('login_page')->with('error', 'You must be logged in to access this page.');
        }
        Session::forget('table_id');
        $user = Session::get('user');

        $tables = Table::where('user_id',$user->id)->get();

        return view('main',compact('tables'));
    }

    public function store(Request $request){
        if (!Session::has('user')) {
            return redirect()->route('login_page')->with('error', 'You must be logged in to access this page.');
        }

        $user = Session::get('user');

        $table = $request->all();
        $table['user_id'] = $user->id;
        Table::create($table);

       return view('tables.create')->with('succes','Table created!');

    }

    public function create_page(){
        if (!Session::has('user')) {
            return redirect()->route('login_page')->with('error', 'You must be logged in to access this page.');
        }

       return view('tables.create');
    }

    /*
    public function update(){

    }

    public function delete(){

    }
    */

}
