@extends('layouts.layout')

@section('content')

@push('styles')
    <link href="{{ asset('/css/mainnn.css') }}" rel="stylesheet">
@endpush


        <select id="countyDropdown" style="margin-left: 13%;margin-top: 2%;">
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
                $weatherData = getWeatherData($a->City);
            @endphp

                <a href="/attraction/{{$a->AttractionName}}">
                    <div class="card">
                        <img src="path/to/image.jpg" alt="kep">
                        <h2>
                            {{$a->AttractionName}}

                        </h2>
                        <p>
                            Hőmérséklet: {{formatTemperature($weatherData['main']['temp'])}}
                            Időjárás: {{$weatherData['weather'][0]['description']}}
                        </p>
                    </div>
                </a>

            @endforeach


    </section>
@endsection
