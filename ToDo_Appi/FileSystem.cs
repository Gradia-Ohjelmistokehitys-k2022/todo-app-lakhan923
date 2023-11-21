using System.Text.Json;

namespace ToDo_Appi
{
    public class FileSystem
    {

        private string fileLocation = "./todolist/";

        public string FileLocation
        {
            get { return fileLocation; }
            set { fileLocation = value; }
        }

        public string CreateFolder()
        {
            string folderPath = "todolist";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Folder created successfully.");
            }
            else
            {
                Console.WriteLine("Folder already exists.");
            }
            return folderPath;
        }

        public string FolderExists()
        {
            string folderExists = "todolist";
            if (Directory.Exists(folderExists))
            {
                System.Console.WriteLine("Yes folder exists.");
            }
            else
            {
                System.Console.WriteLine("The folder does not exists.");
            }
            return folderExists;

        }

        public string FileExists()
        {

            string fileExists = fileLocation + "tasks.txt";
            if (File.Exists(fileExists))
            {
                System.Console.WriteLine("Yes file exists.");
            }
            else
            {
                System.Console.WriteLine("The file does not exists.");
            }
            return fileExists;
        }

        public string CreateFile()
        {
            string filePath = fileLocation + "tasks.txt";
            try
            {
                FileStream fs = File.Create(filePath);
                {
                    Console.WriteLine("File created successfully.");
                }
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred :" + ex.Message);
            }
            return filePath;

        }

        public void AppendFile(List<Task> tasks)
        {
            StreamWriter sw = File.AppendText(fileLocation + "tasks.txt");
            foreach (Task task in tasks)
            {
                sw.WriteLine("Task id: " + task.Id + "," + "Task description: " + task.TaskDescription);
            }
            sw.Close();

        }

        public void SaveToFile(List<Task> tasks)
        {
            StreamWriter writer = new StreamWriter(fileLocation + "tasks.txt");
            foreach (Task task in tasks)
            {
                writer.WriteLine("Task id: " + task.Id + "," + "Task description: " + task.TaskDescription + "," + "Task title: " + task.TaskTitle + "," + "Task date and time: " + task.Due_Date);
            }
            writer.Close();
        }


        public void SaveJson(List<Task> tasks)
        {
            try
            {
                // Serialize tasks to JSON and write to the file
                string jsonString = JsonSerializer.Serialize(tasks);
                File.WriteAllText(fileLocation + "tasks.Json", jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        public List<Task> ReadJson()
        {
            
            //this method write task objects to a .json file. 
            //it makes a list of task objects from already stored .json file.
            string path = "./todolist/tasks.Json";
            List<Task> objList = new List<Task>();
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                objList = JsonSerializer.Deserialize<List<Task>>(json);
            }
            return objList;

        }
    }
}