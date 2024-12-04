<!DOCTYPE html>
<html lang="hu">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="{{ asset('/css/main.css') }}" rel="stylesheet">

</head>

<body>
    <section name="menu">
        <a href="#">profilom</a>
        <a href="#">kedvencek</a>
        <a href="#">meglátogatottak</a>
        <a href="#">kilépés</a>
    </section>

    @yield('content')


</body>

</html>
