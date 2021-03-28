using System;

namespace สอบ
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 , num2 , num3 ;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine()); 
            int round = 0; 
            while (num1 > 0 || num2 > 0 || num3 > 0 )   
                {
                char Numbox = char.Parse(Console.ReadLine());
                int take = int.Parse(Console.ReadLine());

                if (Numbox == '1')
                    {num1 = num1 - take;}

                    else if (Numbox == '2')
                    {num2 = num2 - take;}

                    else if (Numbox == '3')
                    {num3 =num3 - take;}

                    else { }
                    round++;
                }

            if (round % 2 == 0)
                 {Console.WriteLine("A");}
            else { Console.WriteLine("B"); }
           




            Console.ReadLine();
        }    
    }
}
