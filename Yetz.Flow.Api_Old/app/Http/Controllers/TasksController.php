<?php

namespace App\Http\Controllers;

use App\Models\Task;
use Illuminate\Http\Request;

class TasksController extends Controller
{
    public function get()
    {      
        return Task::all();
    }

    
    public function post(Request $request){

        $request->validate([
            'name'=>'required|max:255' ,
            'complete'=>'required'          
        ]);

        $task = Task::create([
            'name'=>$request->input('name'),
            'complete'=>$request->input('complete')
        ]);
        
        return  $task;
    }

    public function getid(Task $task){
        return $task;
    }

    public function put(Request $request, Task $task){

        $request->validate([
            'name'=>'required|max:255'      
        ]);

        $task->name = $request->input('name');
        $task->save();
        return $task;
    }

    public function delete(Task $task){
        $task->delete();
        return response()->json(['sucess'=>true]);
    }

}
