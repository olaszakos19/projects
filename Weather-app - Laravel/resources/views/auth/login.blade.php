@extends('layouts.layout')

@section('content')

    <head>
        <link href="{{ asset('/css/auth.css') }}" rel="stylesheet">
    </head>

    <h1>Bejelentkezés</h1>


    <form action="{{ route('login.user') }}" method="POST">
        @csrf

        <label for="text">Email</label>
        <input type="text" name="email">

        <label for="password">Jelszó</label>
        <input type="password" name="password">
        <button type="submit">Bejelentkezés</button>
    </form>

    <p>Nincs jelszava?<a href="/register">Regisztráljon</a></p>
@endsection
