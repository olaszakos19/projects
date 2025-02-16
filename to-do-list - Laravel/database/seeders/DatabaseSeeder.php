<?php

namespace Database\Seeders;

use App\Models\User;
use App\Models\Table;
// use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;

class DatabaseSeeder extends Seeder
{
    /**
     * Seed the application's database.
     */
    public function run(): void
    {
        // User::factory(10)->create();

        User::create([
            'name' => 'Test User',
            'email' => 'akos.olasz17@gmail.com',
            'password' => 'test',
        ]);

        // Táblázat létrehozása
        Table::create([
            'title' => 'To-do-list',
            'user_id' => 1, // Feltételezve, hogy az első felhasználó az ID=1
        ]);


    }
}
