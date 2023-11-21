using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ToDo_Appi
{
    public class Task
    {
        private int _id;
        private string _taskTitle;
        private string _taskDecription;
        DateTime due_date;
        Boolean completed;
        Boolean deleted;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string TaskTitle
        {
            get { return _taskTitle; }
            set { _taskTitle = value; }
        }

        public string TaskDescription
        {
            get { return _taskDecription; }
            set { _taskDecription = value; }
        }

        public DateTime Due_Date
        {
            get { return due_date; }
            set { due_date = value; }
        }

        public bool Completed
        {
            get { return completed; }
            set { deleted = value; }
        }

        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }

        public Task()
        {
            this.completed = false;
            this.deleted = false;
            System.Console.WriteLine("Task created.");

        }
        public Task(int id, string task_title, string task_description, DateTime due_date, bool completed, bool deleted)
        {
            this._id = id;
            this._taskTitle = task_title;
            this._taskDecription = task_description;
            this.due_date = due_date;
            this.completed = completed;
            this.deleted = deleted;
            System.Console.WriteLine("Task created.");
        }

        public void MarkTaskAsComplete()
        {
            completed = true;   
        }

        public int GetId()
        {
            return _id;
        }

        public string GetTaskTitle()
        {
            return _taskTitle;
        }
    }
}
