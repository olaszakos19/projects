<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Task</title>

    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            height: 100vh;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .parent {
            display: grid;
            /*grid-template-columns: repeat(5, 1fr);*/
            grid-template-rows: repeat(5, auto);
            grid-column-gap: 20px;
            grid-row-gap: 20px;
            max-width: 1200px;
            padding: 20px;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
            justify-items: center;
            align-items: center;
        }

        .div1, .div2, .div3, .div4 {
            background-color: #ffffff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0px 4px 6px rgba(0, 0, 0, 0.1);
            font-size: 1.2em;
            text-align: center;
        }

        .div1, .div2, .div3 {
            font-weight: bold;
            background-color: #f9f9f9;
        }

        .div4 {
            grid-column: span 3;
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: space-between;
            background-color: #f9f9f9;
        }

        .div4 a, .div4 button {
            margin-top: 10px;
            padding: 10px;
            font-size: 1.1em;
            cursor: pointer;
            border: none;
            background-color: #007BFF;
            color: white;
            border-radius: 5px;
        }

        .div4 button {
            background-color: #28a745;
        }

        .div4 a:hover, .div4 button:hover {
            opacity: 0.8;
        }


        @media (max-width: 768px) {
            .parent {
                grid-template-columns: repeat(3, 1fr);
                grid-template-rows: auto;
            }

            .div1, .div2, .div3, .div4 {
                font-size: 1em;
            }

            .div4 {
                grid-column: span 3;
            }
        }
    </style>
</head>
<body>
    <a href="/tasks/{{$task->table_id}}">Vissza a fő oldalra</a>
    <div class="parent">
        <div class="div1">Feladat neve: {{$task->title}}</div>
        <div class="div2">Határidő: {{$task->due_date}}</div>
        <div class="div3">Feladat leírása: {{$task->description}}</div>

        <div class="div4">

            @if ($task->status == 0)
                <a href="/task/update/{{$task->id}}">Folyamatban</a>
            @endif

            @if ($task->status == 1)
            <a href="/task/update/{{$task->id}}">Elkészült</a>
            @endif


            <a href="/task/delete/{{$task->id}}">Töröl</a>
        </div>
    </div>

</body>
</html>
