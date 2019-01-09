using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_0101
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1();

            // Q2();

            //Q3();

            // Q4();

           // Q6HW0101();

        }

        private static void Q6HW0101()
        {
            int size = 0;
            int stars = size - 1;
            Console.WriteLine();


            Console.WriteLine(" please enter a size:");
            size = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= size; i++)
            {

                for (int m = 1; m <= i; m++)
                {
                    Console.Write(m);
                }
                for (int m = i + 1; m <= size; m++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }

        private static void Q4()
        {
            Console.WriteLine("please enter a size:");
            int size = Convert.ToInt32(Console.ReadLine());
            int lines = size / 2 + 1;
            int spaces = size / 2;
            int stars = 1;
            Console.WriteLine();

            for (int i = 1; i <= lines; i++) // lines
            {
                for (int m = 1; m <= spaces; m++) // spaces
                {
                    Console.Write(' ');


                }
                for (int m = 1; m <= stars; m++) // stars
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                spaces--;
                stars = stars + 2;

            }
        }

        private static void Q3()
        {
            Console.WriteLine("please enter a size:");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= size; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }

            for (int i = size - 1; i >= 1; i--)
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write(x);
                }
                Console.WriteLine();

            }

        }

        private static void Q2()
        {
            Console.WriteLine("Number of students:");
            int stud = Convert.ToInt32(Console.ReadLine());

            int class100 = stud / 100;
            Console.WriteLine($"{class100} x class of 100 students");
            stud = stud % 100;

            int class30 = stud / 30;
            Console.WriteLine($"{class30} x class of 30 students");
            stud = stud % 30;

            int class10 = stud / 10;
            Console.WriteLine($"{class10} x class of 10 students");
            stud = stud % 10;


            Console.WriteLine($"{stud} students need to go home");
        }

        private static void Q1()
        {

            int x,i;


            do { Console.WriteLine("please enter a number:");
            x = Convert.ToInt32(Console.ReadLine());
            i = 2;
            while ( x % i != 0 && i < x )
            {
                i++;
            }
            
                if ( i == x)
                {
                    Console.WriteLine($"{x} is a prime number");
                   
                }
                else
                {
                    Console.WriteLine($"{x} in NOT a prime number");
                   
                    
                }
                
                
                 }
            while (x != i);







        }
    }
}
