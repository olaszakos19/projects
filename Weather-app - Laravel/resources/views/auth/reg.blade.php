@extends('layouts.layout')

@section('content')

    <head>
        <link href="{{ asset('/css/auth.css') }}" rel="stylesheet">
    </head>

    <body>

        <h1>Regsiztráció</h1>

        <form action="{{ route('register.user') }}" method="POST">
            @csrf
            <label for="name">Név</label>
            <input type="text" name="name">

            <label for="email">Email</label>
            <input type="text" name="email">

            <label for="password">Jelszó</label>
            <input type="password" name="password">
            <button type="submit">Regisztráció</button>
        </form>
    @endsection
