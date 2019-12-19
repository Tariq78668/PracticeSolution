using System;

namespace PracticeSolution
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("First Code on this Pc");
            Console.Write("Enter number of rows\n");
            int input=int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.Write("\n");

            for (int i = 1; i <= input; i++)
            {
                for (int j = input; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }


            Console.Write("\n");
            Console.Write("Enter number of rows\n");
            int input1 = int.Parse(Console.ReadLine());
            
            for(int i=1; i <= input1; i++)
            {
                for(int j =1; j <= input1 - i; j++)
                {
                    Console.Write(" ");
                }

                for(int k=1;k <=i; k++)
                {
                    Console.Write("*");

                }
                Console.WriteLine(" ");


            }

            for (int i = input1; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                Console.Write(" ");
            }

            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");

            }
            Console.WriteLine(" ");
        }


            Console.Write("\n");

            int b , c;
            //int value = 5;
            //for (int i = 1; i <= value; i++)
            //{
            //    for(b=1; b<= value - i;b++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(c=1;c<=i;c++)
            //    {
            //        Console.Write("*");
            //    }
            //    for(c=i-1;c>=1; c--)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}



            int a, e, f;
            //for (a = 5; a >= 1; a--)
            //{
            //    for (e = 5; e > a; e--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (f = 1; f < (a * 2); f++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            Console.Write("Enter number of rows\n");
            int input2 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input2; i++)
            {
                for (b = 1; b <= input2 - i; b++)
                {
                    Console.Write(" ");
                }

                for (c = 1; c <= i; c++)
                {
                    Console.Write("*");
                }
                for (c = i - 1; c >= 1; c--)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

            for (a = input2; a >= 1; a--)
            {
                for (e = input2; e > a; e--)
                {
                    Console.Write(" ");
                }
                for (f = 1; f < (a * 2); f++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.Write("Enter number of rows\n");
            int input3 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input3; i++)
            {
                for (int j = i; j < input3; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = input3; i >= 1; i--)
            {
                for (int j = i; j <= input3; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



            Console.WriteLine("Added through Git Test");

        }
    }
}
