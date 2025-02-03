<?php

if (!function_exists('formatTemperature')) {
    function formatTemperature($temp)
    {
        return number_format($temp, 1) . ' °C';
    }
}


if(!function_exists('getWeatherData')){
    function getWeatherData($CITY){

        $apiKey = '5dfcac390b06d011b8fde30042526b80';

        // Város neve
        $city = $CITY;

        // API hívás URL
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
             //$id = $weatherData['id'];

            $temperature = formatTemperature($weatherData['main']['temp']);

            // Páratartalom (%-ban)
            $feels_like = $weatherData['main']['feels_like'];

            // Szélsebesség (m/s)
            $windSpeed = $weatherData['wind']['speed'];

        } else {
            // Hibaüzenet, ha nem sikerült az adatok lekérdezése
            echo "Failed to fetch weather data.";
        }



        return $weatherData;



    }
}


if (!function_exists('generateAttractionCard')) {
    function generateAttractionCard($a, $weatherData)
    {
        // Formázott hőmérséklet
        $formattedTemp = formatTemperature($weatherData['main']['temp']);

        // A HTML kód generálása és visszaadása
        return '
            <a href="/attraction/' . $a->AttractionName . '">
                <div class="card">
                    <img src="path/to/image.jpg" alt="kep">
                    <h2>' . $a->AttractionName . '</h2>
                    <p>
                        Hőmérséklet: ' . $formattedTemp . '<br>
                        Időjárás: ' . $weatherData['weather'][0]['description'] . '
                    </p>
                </div>
            </a>
        ';
    }
}

