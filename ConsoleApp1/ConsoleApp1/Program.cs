using System;

namespace ConsoleApp1 
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string fight1, fight2;
             string[] fighters = new string[10] { "Makhachev", " Tsarukyan", "Oliveira", "Geitji", "Porye", "Gamroth", "Chandler", "Dariush", "Physiology", "Holloway", };
            
           
            do
            {
                fight1 = (fighters[new Random().Next(0, 10)]);
                fight2 = (fighters[new Random().Next(0, 10)]);

            } 
            while (fight1==fight2);
           
            x = (new Random().Next(0,2));
            if (x == 1) 
            { 
                Console.WriteLine(fight1);
            }
            else
            {
                Console.WriteLine(fight2);
            }

            
        }
    }
}