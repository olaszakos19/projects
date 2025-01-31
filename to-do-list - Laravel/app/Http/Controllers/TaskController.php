<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Task;
use App\Models\Table;
use Illuminate\Support\Facades\Session;
use Carbon\Carbon;

class TaskController extends Controller
{
    //

    public function showTasks($table_id)
    {
        if (!Session::has('user')) {
            return redirect()->route('login_page')->with('error', 'You must be logged in to access this page.');
        }

        $user = Session::get('user');
        //$table = Table::where('id',$table_id);
        Session::put('table_id', $table_id);
        $toDoTasks = Task::where('status', 0)->where('table_id', $table_id)->get();
        $ongoingTask = Task::where('status', 1)->where('table_id', $table_id)->get();
        $finishedTasks = Task::where('status', 2)->where('table_id', $table_id)->get();

        $this->AutoDelete($finishedTasks);

        return view('tasks.list', compact('toDoTasks', 'ongoingTask', 'finishedTasks'));
    }




    public function AutoDelete($tasks){

        $currentDate = Carbon::now();

        foreach ($tasks as $task) {
            echo $task->updated_at->diffInDays($currentDate);
            if ($task->updated_at->diffInDays($currentDate) > 4) {
                $task->delete();
            }
        }
    }

    public function goToCreate(){
        return view('tasks.create');
    }

    public function showTask($id){

        if (!Session::has('user')) {
            return redirect()->route('login_page')->with('error', 'You must be logged in to access this page.');
        }
        $task = Task::find($id);
        return view('tasks.detail',['task' => $task]);

    }

    public function updateTask($id){

        if (!Session::has('user')) {
            return redirect()->route('login_page')->with('error', 'You must be logged in to access this page.');
        }
        $task = Task::find($id);

        $task->update([
            'status' => $task->status+1
        ]);

        return redirect()->route('show_tasks',['table_id' => $task->table_id])->with('success','Task updated succesfully');

    }

    public function deleteTask($id){
        if (!Session::has('user')) {
            return redirect()->route('login_page')->with('error', 'You must be logged in to access this page.');
        }
        $task = Task::find($id);
        $task->delete();

        return redirect()->route('show_tasks',['table_id' => $task->table_id])->with('success','Task deleted succesfully');

    }

    public function store(Request $request){
        if (!Session::has('user')) {
            return redirect()->route('login_page')->with('error', 'You must be logged in to access this page.');
        }
        $user = Session::get('user');
        $table_id = Session::get('table_id');
        $task = $request->all();
        $task['table_id'] = $table_id;
        Task::create($task);

        return redirect()->route('show_tasks', ['table_id' => $table_id])->with('success', 'Task created successfully!');

    }
}
