namespace ToDo_Appi
{
    class Program
    {
        public static void Main(string[] args)
        {
            //here is the Place Holder that make three tasks objects. 
            //one is unfinished(completed false and deleted false). 
            //one is deleted(completed true and deleted false) 
            //and one is completed(completed false and deleted true).
            List<Task> tasks = new List<Task>();
            tasks.Add(new Task(1, "Organize home!", "To do deep cleaning of a house.",new DateTime(year: 2023,7, 30), false, false));
            tasks.Add(new Task(2, "Organize office!", "To organize office tables and chairs.",new DateTime(2023,7, 30), true, false));
            tasks.Add(new Task(3, "Organize garden!", "To organize graden and water the plants.",new DateTime(year: 2023,7, 30), false, true));
              
            ToDoList todoList = new ToDoList(tasks);
            
            ConsoleUi ui = new ConsoleUi(todoList);
            ui.StartConsoleUi();
        }
    }
}