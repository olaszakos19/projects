@extends('layouts.layout')

@section('content')
    @yield('guestlayout')

    @push('styles')
        <link href="{{ asset('/css/attraction.css') }}" rel="stylesheet">
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

                            $weatherData = getWeatherData($a->City);

                        @endphp

                            <a href="/attraction/{{ $a->AttractionName }}">
                                <div class="card">
                                    <img src="path/to/image.jpg" alt="kep">
                                    <h2>
                                        {{ $a->AttractionName }}

                                    </h2>
                                    <p>
                                        Hőmérséklet: {{formatTemperature($weatherData['main']['temp'])}}
                                        Időjárás: {{$weatherData['weather'][0]['description']}}
                                    </p>
                                </div>
                            </a>

                    @endforeach
                </div>
            </div>
        </div>


    </section>
@endsection
