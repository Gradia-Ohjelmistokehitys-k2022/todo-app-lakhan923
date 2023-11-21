using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ToDo_Appi
{
    public class ConsoleUi
    {
        private List<Task> tehtavat;
        public List<Task> Tehtavat
        {
            get { return tehtavat; }
            set { tehtavat = value; }
        }

        public ConsoleUi(ToDoList todoList)
        {
            tehtavat = todoList.Tehtavat;
        }

        public void StartConsoleUi()
        {
            Console.WriteLine("Enter the number from 1-6: \r\n1 Prints List items\r\n2 Prints completed items\r\n3 prints unfinished items\r\n4 Prints deleted items\r\n5 Prints the tasks.\r\n6 Prints the new todoList items.\r\n7 Exits the program.");
            string input;
            while ((input = Console.ReadLine()) != "7")
            {
                if (input == "1")
                {
                    ShowListItems();
                }
                else if (input == "2")
                {
                    ShowDone();
                }
                else if (input == "3")
                {
                    ShowUnFinished();
                }
                else if (input == "4")
                {
                    ShowDeleted();
                }
                else if (input == "5")
                {
                    AddTask();
                }
                else if (input == "6")
                {
                    AddNewTodoList();
                }
                else if(input == "7")
                {
                    break;
                }
            }
        }

        public void AddNewTodoList()
        {
            while (true)
            {
                // creating new task object
                Task newTask = new Task();
                tehtavat.Add(newTask);

                // asks user to input task title
                System.Console.WriteLine("Enter the task title: ");
                var userInput = Console.ReadLine();
                if (userInput ==  "Exit")
                {
                    break;
                }
                else
                {
                    newTask.TaskTitle = userInput;
                    Console.WriteLine("Task title set to: " + userInput);
                }

                // asks user to input task description
                Console.WriteLine("Enter the task description: ");
                var Input = Console.ReadLine();
                if (Input == "Exit")
                {
                    break;
                }
                else
                {
                    newTask.TaskDescription = Input;
                    Console.WriteLine("Task description set to: " + Input);
                }

                // asks user to input due date
                Console.WriteLine("Enter the due date: ");
                var user = Console.ReadLine();
                if (DateTime.TryParse(user, out DateTime result))
                {
                    newTask.Due_Date = result;
                    Console.WriteLine("Due date set to:" + result);

                }
                else
                {
                    Console.WriteLine("Invalid date and time formate. Try again (yyyy-mm-dd)");
                }


                Console.WriteLine("Entered tasks:");
                // this line prints all the data asked by the user.
                Console.WriteLine("Task title: " + newTask.TaskTitle + ", " + "Task description: " + newTask.TaskDescription + ", " + "Due date: " + newTask.Due_Date);
                break;
            }

        }

        public void AddTask()
        {
            while (true)
            {
                // creating new task object
                Task newTask = new Task();
                tehtavat.Add(newTask);

                // asks user to input task title
                System.Console.WriteLine("Enter the task title: ");
                string userInput = Console.ReadLine();
                if (userInput == "Exit")
                {
                    break;
                }
                else
                {
                    newTask.TaskTitle = userInput;
                    Console.WriteLine("Task title set to: " + userInput);
                }

                // asks user to input task description
                Console.WriteLine("Enter the task description: ");
                var Input = Console.ReadLine();
                if (Input == "Exit")
                {
                    break;
                }
                else
                {
                    newTask.TaskDescription = Input;
                    Console.WriteLine("Task description set to: " + Input);
                }

                // asks user to input due date
                Console.WriteLine("Enter the due date: ");
                var user = Console.ReadLine();
                if (DateTime.TryParse(user, out DateTime result))
                {
                    newTask.Due_Date = result;
                    Console.WriteLine("Due date set to:" + result);

                }
                else
                {
                    Console.WriteLine("Invalid date and time formate. Try again (yyyy-mm-dd)");
                }


                Console.WriteLine("Entered tasks:");
                // this line prints all the data asked by the user.
                Console.WriteLine("Task title: " + newTask.TaskTitle + ", " + "Task description: " + newTask.TaskDescription + ", " + "Due date: " + newTask.Due_Date);
                break;
            }
        }

        public void ShowListItems()
        {
            Console.WriteLine("show List items:");
            foreach (Task task in tehtavat)
            {
                Console.WriteLine("Task id: " + task.Id + " " + "Task title: " + task.TaskTitle + " " + "Task description: " + task.TaskDescription);
            }
        }



        public void ShowDone()
        {
            Console.WriteLine("Show completed items:");
            foreach (Task task in tehtavat)
            {
                if (task.Completed)
                {
                    Console.WriteLine("Task id: " + task.Id + " " + "Task title: " + task.TaskTitle + " " + "Task description: " + task.TaskDescription);
                }
            }
        }

        public void ShowUnFinished()
        {
            Console.WriteLine("Show unfinished items:");
            foreach (Task task in tehtavat)
            {
                if (!task.Completed)
                {
                    Console.WriteLine("Task id: " + task.Id + " " + "Task title: " + task.TaskTitle + " " + "Task description: " + task.TaskDescription);
                }
            }
        }

        public void ShowDeleted()
        {
            Console.WriteLine("Show deleted items:");
            foreach (Task task in tehtavat)
            {
                if (task.Deleted)
                {
                    Console.WriteLine("Task id: " + task.Id + " " + "Task title: " + task.TaskTitle + " " + "Task description: " + task.TaskDescription);
                }
            }
        }
    }
}