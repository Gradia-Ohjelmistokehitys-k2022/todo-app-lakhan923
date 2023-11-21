using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo_Appi
{
    public class ToDoList
    {
        private List<Task> tehtavat = new List<Task>();
        FileSystem fileSystem = new FileSystem();

        public List<Task> Tehtavat
        {
            get { return tehtavat; }
            set { tehtavat = value; }
        }

        public ToDoList()
        {
            tehtavat = fileSystem.ReadJson();
        }

        public ToDoList(List<Task> tasks)
        {
            this.tehtavat = tasks;

            string createFolder = fileSystem.CreateFolder();
            Console.WriteLine("Folder name: " + createFolder);
            fileSystem.FolderExists();

            // This creates and checks *.txt file only
            string createFile = fileSystem.CreateFile();
            Console.WriteLine("File name: " + createFile);
            fileSystem.FileExists();
            fileSystem.SaveToFile(tehtavat);
            fileSystem.AppendFile(tehtavat);

            // this create a json file and write serailized tasks to it
            fileSystem.SaveJson(tehtavat);
        }
     
        public void ToDoItem(string content)
        {
            Task obj = new Task();
            obj.TaskDescription = content;
            AddItemToList(obj);
        }

        //This method is used to store a new Task object in the tehtavat
        //tehtavat is of type List(Task)
        public void AddItemToList(Task item)
        {
            tehtavat.Add(item);
            fileSystem.SaveJson(tehtavat);
            System.Console.WriteLine("Task added to the list.");
        }

        public void RemoveItemFromList(Task item)
        {
            tehtavat.Remove(item);
            fileSystem.SaveToFile(tehtavat);
            System.Console.WriteLine("Task removed from the list.");
        }

        public static void SoftRemoveItem(Task item)
        {
            item.Deleted = true;
            System.Console.WriteLine("Task is softremoved");
        }

        public List<Task> PendingItems()
        {
            return tehtavat.Where(t => t.Completed == false && t.Deleted == false).ToList();
        }

        public List<Task> DeletedItems()
        {
            return tehtavat.Where(t => t.Deleted == false).ToList();
        }

        public void CompleteItem(int id)
        {
            var item = tehtavat.FirstOrDefault(o => o.Id == id);
            item.MarkTaskAsComplete();
        }
    }
}