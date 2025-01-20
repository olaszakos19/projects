<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\User;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Facades\Session;


class UserController extends Controller
{
    //

    public function goToRegister(){
        return view('auth.register');
    }

    public function goToLogin(){
        return view('auth.login');
    }

    public function registerUser(Request $request){

        //register

        $email = $request->email;

        $isAlreadyUser = User::where('email',$email)->first();

        if($isAlreadyUser){
            return redirect()->route('register_page')->with('error','This email is already taken');
        }


        $user = $request->all();

        User::create($user);

        return redirect()->route('login_page')->with('success','You have succesfully registered');
    }

    public function loginUser(Request $request){

        //login

        $email = $request->email;
        $password = $request->password;

        $user = User::where('email',$email)->first();



        if ($user && $user->email == $email && $user->password == $password){
            Session::put('user',$user);
            return redirect()->route('show_tables')->with('success','You have succesfully logged in');
        }



        return redirect()->route('login_page')->with('error','Wrong creditential');

        //
    }

    public function LogOut(){
        Session::forget('user');
        Session::forget('table_id');
        return redirect()->route('login_page')->with('success', 'You have been logged out.');
    }
}
