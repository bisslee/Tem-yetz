<?php

namespace Database\Seeders;

use Illuminate\Database\Seeder;

class TasksTableSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
       // factory(App\Models\Task::class)
        \App\Models\Task::factory()->create([
            'name'=> 'Estudar PHP',
            'complete'=> true
        ]);

        \App\Models\Task::factory()->create([
            'name'=> 'Estudar Laravel',
            'complete'=> false
        ]);

       \App\Models\Task::factory()->create([
            'name'=> 'Estudar JScript',
            'complete'=> false
        ]);

         \App\Models\Task::factory()->create([
            'name'=> 'Estudar Node.JS',
            'complete'=> false
        ]);

        
         \App\Models\Task::factory()->create([
            'name'=> 'Estudar PQP',
            'complete'=> false
        ]);
    }
}
