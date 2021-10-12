using System;

namespace CakeReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string CakeReplace = "The c4ke i3 4 l1e".ToLower();
            CakeReplace = CakeReplace.Replace('4', 'a');
            CakeReplace = CakeReplace.Replace('1', 'i');
            CakeReplace = CakeReplace.Replace('3', 's');

            Console.WriteLine(CakeReplace);
        }
    }
}
