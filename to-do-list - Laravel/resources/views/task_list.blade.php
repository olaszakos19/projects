
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Tasks</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.bundle.min.js"></script>

    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
            background-color: #f4f4f4;
        }

        a {
            text-decoration: none;
            color: #333;
            font-weight: bold;
        }

        a:hover {
            color: #007BFF;
        }

        .alert {
            padding: 15px;
            background-color: #4CAF50;
            color: white;
            margin-bottom: 20px;
        }

        .parent {
            display: grid;
            grid-template-columns: repeat(7, 1fr);
            grid-template-rows: repeat(5, auto);
            grid-column-gap: 10px;
            grid-row-gap: 20px;
            max-width: 1200px;
            margin: 0 auto;
        }

        .div1, .div2, .div3, .div4, .div5, .div6 {
            background-color: #ffffff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0px 4px 6px rgba(0, 0, 0, 0.1);
        }

        .div1, .div3, .div5 {
            font-size: 1.5em;
            font-weight: bold;
            text-align: center;
            background-color: #f0f0f0;
            border: 2px solid #e0e0e0;
        }

        .div2, .div4, .div6 {
            font-size: 1.1em;
            color: #555;
        }

        .div1 {
            grid-area: 1 / 2 / 2 / 3;
        }

        .div2 {
            grid-area: 2 / 2 / 3 / 3;
            overflow-y: auto;
            max-height: 200px;
        }

        .div3 {
            grid-area: 1 / 4 / 2 / 5;
        }

        .div4 {
            grid-area: 2 / 4 / 3 / 5;
            overflow-y: auto;
            max-height: 200px;
        }

        .div5 {
            grid-area: 1 / 6 / 2 / 7;
        }

        .div6 {
            grid-area: 2 / 6 / 3 / 7;
            overflow-y: auto;
            max-height: 200px;
        }

        .parent a {
            display: block;
            margin-bottom: 10px;
        }

        .parent a:last-child {
            margin-bottom: 0;
        }


        @media (max-width: 768px) {
            .parent {
                grid-template-columns: repeat(3, 1fr);
                grid-template-rows: auto;
            }

            .div1, .div3, .div5 {
                font-size: 1.2em;
            }
        }
    </style>

</head>
<body>

    @include('alert')

    <a href='/tasks/create'>Új feladat létrehozása</a><br>
    <a href='/logout'>Kijelentkezés</a><br>


    <div class="parent">
        <div class="div1">To-Do </div>
        <div class="div2">
        @foreach ($toDoTasks as $task)
           <a href="/task/{{$task->id}}"> {{$task->title}}</a><br>

        @endforeach
        </div>

        <div class="div3">Doing</div>
        <div class="div4">
        @foreach ($ongoingTask as $oTask)
            <a href="/task/{{$oTask->id}}"> {{$oTask->title}}</a><br>

         @endforeach
        </div>

        <div class="div5">Done</div>
        <div class="div6">
        @foreach ($finsihedTasks as $fTask)
            <a href="/task/{{$fTask->id}}"> {{$fTask->title}}</a><br>

         @endforeach
        </div>

    </div>

</body>
</html>

