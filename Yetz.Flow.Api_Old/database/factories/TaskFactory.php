<?php

namespace Database\Factories;

use App\Models\Task;
use Illuminate\Database\Eloquent\Factories\Factory;

class TaskFactory extends Factory
{
    /**
     * The name of the factory's corresponding model.
     *
     * @var string
     */
    protected $model =  Task::class;

    /**
     * Define the model's default state.
     *
     * @return array
     */

 

    public function definition()
    {
        //return [
        //    'name'=>$faker->name,
        //    'complete'=>false
        //];

         return [
            'name' => $this->faker->text(50),
            'complete'  => $this->faker->boolean
        ];
    }
}
