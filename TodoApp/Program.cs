using System;

namespace TodoApp
{
    public class TodoItem
    {
        public int Id { get; set; }
        public bool IsDone { get; set; }
        public string Task { get; set; }

        public TodoItem(int id, string task)
        {
            Id = id;
            Task = task;
            IsDone = false;
        }
    }
    class TodoApp
    {
        static List<TodoItem> tasks = new List<TodoItem>();
        static int currentId = 1;
        static void Main(string[] args)
        {
            
            int option;

            do
            {
                Console.WriteLine("Todo App");
                Console.WriteLine("------------");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Mark Task AsDone");
                Console.WriteLine("4. Remove Task");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
            
                option = Convert.ToInt32(Console.ReadLine());
                
                switch (option)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        ViewTasks();
                        break;
                    case 3:
                        Console.WriteLine("Which task do you want to mark as done?");
                        break;
                    case 4:
                        Console.WriteLine("Which task do you want to remove?");
                        break;
                    case 5:
                        Console.WriteLine("Exited successfully!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (option != 5);
        }

        static void AddTask()
        {
            Console.Write("Enter task: ");
            string task = Console.ReadLine() ?? "default value";
            if (string.IsNullOrEmpty(task))
            {
                Console.WriteLine("Task cannot be empty");
            }
            tasks.Add(new TodoItem(currentId++, task));
        }

        static void ViewTasks()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i].Task}");
            }
        }
    }
}

