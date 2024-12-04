@extends('layouts.layout')

@section('content')



<section name="main">
    <div>
    @foreach ($attraction as $a)
        <img src="" alt="{{$a->AttractionName}}">

        <h2>{{$a->AttractionName}}</h2>
        <p>{{$a->County}}</p>



        @endforeach
    </div>

    <div name="other-attractions">
        <h3>További látványosságok a megyében:</h3>

    </div>
</section>

@endsection
