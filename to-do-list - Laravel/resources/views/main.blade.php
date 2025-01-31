<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Tábláim</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">

    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
            background-color: #f4f4f4;
            text-align: center;
        }

        a {
            text-decoration: none;
            font-weight: bold;
            padding: 10px 15px;
            background-color: #007bff;
            color: white;
            border-radius: 5px;
            transition: background 0.3s;
            display: inline-block;
            margin: 10px;
        }

        a:hover {
            background-color: #0056b3;
        }

        .parent {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            grid-gap: 20px;
            max-width: 1200px;
            margin: 20px auto;
        }

        .table-card {
            background-color: #ffffff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0px 4px 6px rgba(0, 0, 0, 0.1);
            text-align: center;
            position: relative;
            min-height: 180px;
            display: flex;
            flex-direction: column;
            justify-content: space-between;
            align-items: center;
        }

        .table-card h3 {
            flex-grow: 1;
            /* A cím kihasználja a helyet */
            display: flex;
            align-items: center;
            justify-content: center;
            text-align: center;
            font-size: 1.2em;
        }

        .table-card a {
            color: #ffffff;
            background-color: #007bff;
            padding: 10px 15px;
            border-radius: 5px;
            text-decoration: none;
            display: inline-block;
            width: 100%;
            box-sizing: border-box;
        }

        .table-card a:hover {
            background-color: #0056b3;
        }

        .delete-btn {
            background-color: #ff4d4d;
            color: white;
            border: none;
            padding: 8px 12px;
            border-radius: 5px;
            cursor: pointer;
            transition: background 0.3s;
            width: 100%;
        }

        .delete-btn:hover {
            background-color: #cc0000;
        }


        h1 {
            color: #ff4d4d;
        }

        .nav-link {
            color: black !important;
            background: none !important;
            padding: 10px 15px;

        }



        .nav a {
            margin: 0px;

        }


        .nav-link:hover {
            color: black !important;
            background: none !important;

        }
    </style>
</head>

<body>

    @include('alert')

    <ul class="nav">
        <li class="nav-item">
            <a class="nav-link" href='/table/create'>Új tábla létrehozása</a>
        </li>
        <li class="nav-item">
            <a class="nav-link " href='/logout'>Kijelentkezés</a>
        </li>
    </ul>



    <div class="parent">
        @if ($tables && count($tables) > 0)
            @foreach ($tables as $table)
                <div class="table-card">
                    <h3><a href="{{ route('show_tasks', ['table_id' => $table->id]) }}">{{ $table->title }}</a></h3>
                    <form action="{{ route('delete_table', ['table_id' => $table->id]) }}" method="POST"
                        onsubmit="return confirm('Biztosan törölni szeretné ezt a táblát?');">
                        @csrf
                        @method('DELETE')
                        <button type="submit" class="delete-btn">Törlés</button>
                    </form>
                </div>
            @endforeach
        @else
            <h1>Még nincs táblája</h1>
            <a href='/table/create'>Új tábla létrehozása</a>
        @endif
    </div>

</body>

</html>
