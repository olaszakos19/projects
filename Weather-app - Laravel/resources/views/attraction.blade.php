@extends('layouts.layout')

@section('content')
    @yield('guestlayout')

    @push('styles')
        <link href="{{ asset('/css/attractionn.css') }}" rel="stylesheet">
    @endpush

    <section name="main">




        <div class="parent">
            <div class="div1">
                @foreach ($attraction as $a)
                    <img src="" alt="{{ $a->AttractionName }}">

                    <h2>{{ $a->AttractionName }}</h2>
                    <p>{{ $a->County }}</p>
                @endforeach
            </div>

            <div class="div2">
                <a href="/favorites/{{ $a->AttractionName }}">Hozzá adás kedvenchez</a><br>
                <a href="/visited/{{ $a->AttractionName }}">Hozzáadás meglátogatotthoz</a>
            </div>

            <div class="div3">
                leírás
            </div>

            <div class="div4">
                <div name="other-attractions">
                    <h3>További látványosságok a megyében:</h3>
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
                                $temperature = $weatherData['main']['temp'];

                                // Páratartalom (%-ban)
                                $feels_like = $weatherData['main']['feels_like'];

                                // Szélsebesség (m/s)
                                $windSpeed = $weatherData['wind']['speed'];
                            } else {
                                // Hibaüzenet, ha nem sikerült az adatok lekérdezése
                                echo 'Failed to fetch weather data.';
                            }

                        @endphp
                        @if ($temperature)
                            <a href="/attraction/{{ $a->AttractionName }}">
                                <div class="card">
                                    <img src="path/to/image.jpg" alt="kep">
                                    <h2>
                                        {{ $a->AttractionName }}

                                    </h2>
                                    <p>
                                        Hőmérséklet: {{ $temperature }}<br>
                                        Időjárás:{{ $weatherDescription }}
                                    </p>
                                </div>
                            </a>
                        @endif
                    @endforeach
                </div>
            </div>
        </div>


    </section>
@endsection
