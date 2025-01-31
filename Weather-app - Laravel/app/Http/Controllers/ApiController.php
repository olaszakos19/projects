<?php

namespace App\Http\Controllers;

use App\Models\Attraction;
use App\Models\Visited;
use App\Models\Favorites;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Http;

class ApiController extends Controller
{
    //



    public function loadAll()
    {
        // Turisztikai látványosságok lekérése
        $attractions = DB::table('touristattractions')
            ->where('County', 'Veszprém megye')
            ->get();

        // Megyék lekérése
        $counties = DB::table('touristattractions')
            ->select('County')
            ->groupBy('County')
            ->get();

        $apiKey = env('OPENWEATHER_API_KEY');


        foreach ($attractions as $attraction) {
            $city = $attraction->City;


            $apiUrl = "http://api.openweathermap.org/data/2.5/weather?q=$city&appid=$apiKey&lang=hu&units=metric";

            // API hívás Laravel HTTP klienssel
            $response = Http::get($apiUrl);
            $weatherData = $response->json();


            if ($response->successful() && isset($weatherData['cod']) && $weatherData['cod'] == 200) {
                $attraction->desc = $weatherData['weather'][0]['description'];
                $attraction->temperature = $weatherData['main']['temp'];
/*                $attraction->weather = [
                    'city' => $weatherData['name'],
                    'description' => $weatherData['weather'][0]['description'],
                    'temperature' => $weatherData['main']['temp'],
                    'humidity' => $weatherData['main']['humidity'],
                    'wind_speed' => $weatherData['wind']['speed']
                ];
                */
            } else {
                $attraction->weather = ['error' => 'Failed to fetch weather data'];
            }
        }

        // JSON válasz visszaadása
        return response()->json([
            'attractions' => $attractions,
            'counties' => $counties
        ]);
    }

}
