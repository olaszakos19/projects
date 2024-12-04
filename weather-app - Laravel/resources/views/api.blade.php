<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>main</title>
</head>
<body>
    @php

    //csak a város használható


    // OpenWeatherMap API kulcs
    $apiKey = '5dfcac390b06d011b8fde30042526b80';

    // Város neve
    $city = '4071';

    // API hívás URL
    //irányítószám alapján
    //$apiUrl = "https://api.openweathermap.org/data/2.5/weather?zip=1013,hu&appid={$apiKey}&lang=hu";

    //városnév alapján
    $apiUrl = "http://api.openweathermap.org/data/2.5/weather?q=$city&appid=$apiKey&lang=hu&units=metric";

    // API hívás és válasz olvasása
    $weatherData = file_get_contents($apiUrl);

    // JSON válasz dekódolása asszociatív tömbbe
    $weatherData = json_decode($weatherData, true);

    // Időjárás adatok ellenőrzése
    if ($weatherData && $weatherData['cod'] == 200) {
        // Város neve
        $cityName = $weatherData['name'];

        // Időjárás leírása
        $weatherDescription = $weatherData['weather'][0]['description'];

        // Hőmérséklet (Celsius fokban)
        $temperature = $weatherData['main']['temp'];

        // Páratartalom (%-ban)
        $humidity = $weatherData['main']['humidity'];

        // Szélsebesség (m/s)
        $windSpeed = $weatherData['wind']['speed'];

        // Kiírás
        echo "Current weather in $cityName:<br>";
        echo "Description: $weatherDescription<br>";
        echo "Temperature: $temperature °C<br>";
        echo "Humidity: $humidity%<br>";
        echo "Wind Speed: $windSpeed m/s<br>";
    } else {
        // Hibaüzenet, ha nem sikerült az adatok lekérdezése
        echo "Failed to fetch weather data.";
    }


        @endphp

    <section name="popular">

    </section>

    <section name="goodweather">

    </section>

</body>
</html>
