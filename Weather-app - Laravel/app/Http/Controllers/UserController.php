<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\User;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Facades\Session;


class UserController extends Controller
{
    //

    public function go_to_reg(){
        return view('auth.reg');
    }

    public function go_to_login(){
        return view('auth.login');
    }


    public function store(Request $request){
        $email = $request->email;

        $isAlreadyUser = User::where('email',$email)->first();

        if($isAlreadyUser){
            //return redirect()->route('register_page')->with('error','This email is already taken');
        }


        $user = $request->all();

        User::create($user);
    }


    public function login(Request $request){
        $email = $request->email;
        $password = $request->password;

        $user = User::where('email',$email)->first();



        if ($user && $user->email == $email && $user->password == $password){
            Session::put('user',$user);

            return redirect()->route('main');
            //return redirect()->route('show_tasks')->with('success','You have succesfully logged in');
        }

        return redirect()->route('goto.login');

        //return redirect()->route('login_page')->with('error','Wrong creditential');
    }

    public function logout(){

        Session::flush('user');
        return redirect()->route('main');

    }

}
