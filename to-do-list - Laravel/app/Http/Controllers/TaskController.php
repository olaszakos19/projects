<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Task;
use Illuminate\Support\Facades\Session;
use Carbon\Carbon;

class TaskController extends Controller
{
    //

    public function showTasks(){

        if (!Session::has('user')) {
            return redirect()->route('login_page')->with('error', 'You must be logged in to access this page.');
        }

        $user = Session::get('user');

        $toDoTasks = Task::where('status',0)->where('user_id',$user->id)->get();
        $ongoingTask = Task::where('status',1)->where('user_id',$user->id)->get();
        $finsihedTasks = Task::where('status',2)->where('user_id',$user->id)->get();

        $this->AutoDelete($finsihedTasks);

        return view('task_list',compact('toDoTasks','ongoingTask','finsihedTasks'));
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
        return view('create_task');
    }

    public function showTask($id){

        if (!Session::has('user')) {
            return redirect()->route('login_page')->with('error', 'You must be logged in to access this page.');
        }
        $task = Task::find($id);
        return view('task_detail',['task' => $task]);

    }

    public function updateTask($id){

        if (!Session::has('user')) {
            return redirect()->route('login_page')->with('error', 'You must be logged in to access this page.');
        }
        $task = Task::find($id);

        $task->update([
            'status' => $task->status+1
        ]);

        return redirect()->route('show_tasks')->with('success','Task updated succesfully');

    }

    public function deleteTask($id){
        if (!Session::has('user')) {
            return redirect()->route('login_page')->with('error', 'You must be logged in to access this page.');
        }
        $task = Task::find($id);
        $task->delete();

        return redirect()->route('show_tasks')->with('success','Task deleted succesfully');

    }

    public function store(Request $request){
        if (!Session::has('user')) {
            return redirect()->route('login_page')->with('error', 'You must be logged in to access this page.');
        }
        $user = Session::get('user');
        $task = $request->all();
        $task['user_id'] = $user->id;
        Task::create($task);

        return redirect()->route('create_task')->with('success', 'Task created successfully!');
    }
}
