<!DOCTYPE html>
<html lang="hu">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <head>
        <link href="{{ asset('/css/menu.css') }}" rel="stylesheet">
        @stack('styles')
    </head>

</head>

<body>
    <section name="menu">
        <a href="/">Főoldal</a>
        @if (session()->has('user'))
            <a href="/profile">Profilom</a>
            <a href="/favorites">Kedvencek</a>
            <a href="/visited">Meglátogatottak</a>
            <a href="/logout">Kilépés</a>
        @else
            <a href="/login">Bejelentkezés</a>
            <a href="/register">Regisztráció</a>
        @endif
    </section>



    @yield('content')


</body>

</html>
