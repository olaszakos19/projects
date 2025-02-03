@extends('layouts.layout')

@section('content')

@if (!$attractions)
    Még nincs elmentett kedvenc
@endif

<section name="main">
    <div>
    @foreach ($attractions as $a)
        <img src="" alt="{{$a->AttractionName}}">

        <h2>{{$a->AttractionName}}</h2>
        <p>{{$a->County}}</p>



        @endforeach
    </div>
</section>

@endsection
