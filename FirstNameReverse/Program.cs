using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            string UserFirstName = Console.ReadLine();
            
            if  (UserFirstName.Length >= 5)
            {
                for (int i = UserFirstName.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(UserFirstName[i]);
                }

            }
           else
           {
                Console.WriteLine(UserFirstName);
           }
        }
    }
}
