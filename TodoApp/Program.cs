using System;
using System.Collections.Generic;
using System.IO;

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
        static List<TodoItem> _tasks = new List<TodoItem>();
        static int _currentId = 1;
        static string filePath = "tasks.txt";

        static void Main(string[] args)
        {
            int option;
            
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Todo App");
                Console.WriteLine("------------");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("4. Exit");
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
                        RemoveTask();
                        break;
                    case 4:
                        Console.WriteLine("Exited successfully!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (option != 4);
        }

        static void AddTask()
        {
            Console.Write("Enter task: ");
            string task = Console.ReadLine() ?? "default value";
            if (string.IsNullOrEmpty(task))
            {
                Console.WriteLine("Task cannot be empty");
            }
            else
            {
                _tasks.Add(new TodoItem(_currentId++, task));
                Console.WriteLine("Task added successfully!");
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    for (int i = 0; i < _tasks.Count; i++)
                    {
                        writer.WriteLine($"{_tasks[i].Id}. {_tasks[i].Task}");
                    }
                }
            }
        }

        static void ViewTasks()
        {
            Console.WriteLine("Tasks:");
            for (int i = 0; i < _tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_tasks[i].Task}");
            }
        }

        static void RemoveTask()
        {
            Console.Write("Enter id to remove task: ");
            if (int.TryParse(Console.ReadLine(), out int id) && id > 0 && id <= _tasks.Count)
            {
                // string removedTask = tasks[id - 1].Task;
                _tasks.RemoveAt(id - 1);
                Console.WriteLine("Task removed successfully!");
            }
        }
    }
}

