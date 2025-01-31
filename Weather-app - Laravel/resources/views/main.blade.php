@extends('layouts.layout')

@section('content')

@push('styles')
    <link href="{{ asset('/css/mainn.css') }}" rel="stylesheet">
@endpush


        <select id="countyDropdown" style="margin-left: 170px;">
            @foreach ($counties as $c)
                <option value="/attractions/{{$c->County}}">{{$c->County}}</option>
            @endforeach
        </select>


    <script>
        document.getElementById('countyDropdown').addEventListener('change', function() {
            const selectedValue = this.value;
            if (selectedValue) {
                window.location.href = selectedValue; // Redirect to the selected URL
            }
        });
    </script>



<section name="popular">
        <div>Megyében található látványosságok</div<br>

            @foreach ($attractions as $a)
            @php

            //csak a város használható


            // OpenWeatherMap API kulcs
            $apiKey = '5dfcac390b06d011b8fde30042526b80';

            // Város neve
            $city = $a->City;

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

                $temperature = $weatherData['main']['temp'];

                // Páratartalom (%-ban)
                $feels_like = $weatherData['main']['feels_like'];

                // Szélsebesség (m/s)
                $windSpeed = $weatherData['wind']['speed'];

            } else {
                // Hibaüzenet, ha nem sikerült az adatok lekérdezése
                echo "Failed to fetch weather data.";
            }




                @endphp
            @if($temperature)
                <a href="/attraction/{{$a->AttractionName}}">
                    <div class="card">
                        <img src="path/to/image.jpg" alt="kep">
                        <h2>
                            {{$a->AttractionName}}

                        </h2>
                        <p>
                         Hőmérséklet: {{$temperature}}<br>
                         Időjárás:{{$weatherDescription}}
                        </p>
                    </div>
                </a>
            @endif
            @endforeach


    </section>
@endsection
