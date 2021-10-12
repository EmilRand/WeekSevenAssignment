using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            string UserFirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string UserLastName = Console.ReadLine();

            Console.WriteLine($"Hello {UserFirstName[0]}. {UserLastName[0]}.");
        }
    }
}
