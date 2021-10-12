using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            string UserFirstName = Console.ReadLine();
            Random rnd = new Random();
            int index = rnd.Next(0, UserFirstName.Length);
            Console.WriteLine(UserFirstName[index]);

        }
    }
}
