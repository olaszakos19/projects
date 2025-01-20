<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Tábláim</title>
</head>
<body>
    @include('alert')

    <a href='/table/create'>Új tábla létrehozása</a><br>
    <a href='/logout'>Kijelentkezés</a><br>

    @if($tables)
        @foreach ($tables as $table)
            <h3><a href="{{ route('show_tasks', ['table_id' => $table->id]) }}">{{$table->title}}</a></h3>
        @endforeach
    @else
        <h1>Még nincs táblája</h1><a href='/table/create'>Új tábla létrehozása</a><br>
    @endif



</body>
</html>
