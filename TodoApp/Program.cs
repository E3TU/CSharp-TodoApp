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
            Console.WriteLine("2. Mark Task AsDone");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("4. Exit");
            
            option = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}

