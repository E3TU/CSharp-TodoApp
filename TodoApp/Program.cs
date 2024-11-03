using System;

namespace TodoApp
{
    class TodoApp
    {
        static void Main(string[] args)
        {
            int option;
            
            Console.WriteLine("Todo App");
            Console.WriteLine("------------");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Mark Task AsDone");
            Console.WriteLine("4. Remove Task");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            
            option = Convert.ToInt32(Console.ReadLine());
            
            
            switch (option)
            {
                case 1:
                    Console.Write("Enter Task Description: ");
                    break;
                case 2:
                    Console.WriteLine("Which task you want to mark as done:");
                    break;
                case 3:
                    Console.WriteLine("Which task you want to remove:");
                    break;
                case 4:
                    Console.WriteLine("Do you want to exit?");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}

