using System;

namespace WeekSevenAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            int counter = 0;
            while (1 < 3)
            {
                string Login;
                string Password;
                Console.WriteLine("Sisestage PIN");
                string PIN = Console.ReadLine();
                Console.WriteLine("Sisestage kasutajatunnus");
                Login = Console.ReadLine();

                Console.WriteLine("Sisestage palun parool");
                Password = Console.ReadLine();


                if (PIN == "1532")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else if ((Login == "user1") && (Password == "password1") && (PIN == "1532"))
                {
                    Console.WriteLine("Tere tulemast!");
                }
                else if ((Login != "admin") && (Password == "pass1234"))
                {
                    Console.WriteLine("Midagi läks valesti, proovige uuesti");
                }
                else if ((Login == "admin") && (Password != "pass1234"))
                {
                    Console.WriteLine("Midagi läks valesti, proovige uuesti");
                }
                else
                {
                    i++;
                    Console.WriteLine($"Proovi uuesti! {3 - i} katset on jäänud");
                }
            }
        }
    }
}
