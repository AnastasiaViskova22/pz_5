using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; // задание 1 
            for (a = 0; a <= 90; a++) Console.WriteLine(" " + a);
            Console.ReadLine();
            char simvol = 'b'; //задание 2 
            simvol++;
            Console.WriteLine(simvol);
            Console.ReadLine();
            for (int n = 0; n <= 4; n++) //задание3
            {
                for (int m = 0; m <= 5; m++)
                    Console.WriteLine("#");
                Console.ReadLine();
                for (int smb = 0; smb <= 100; smb++)//задание4
                    if (smb % 7 == 0)
                        Console.WriteLine("" + smb);
                Console.ReadLine();
                int i = 1;
                int j = 40;
                for(; ; )
                
                    if (i != 20 && j != 20) ;
                
               
                 else if (j != 20) j--;
                    else break;
                    Console.WriteLine(i + "," + j);
                    Console.ReadLine();
                

                
            }



        }
        






    }

}
