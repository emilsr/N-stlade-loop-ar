using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nastlade_loopar
{
    //övning2 

    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int y = 0; y < 11; y++)
            {

                for (int x = 0; x < 11; x++)
                {
                    if (y % 2 == 0)
                    {


                        if (x % 2 == 0)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write("o");
                        }
                    }

                    else
                    {
                        if (x%2==0)
                        {
                            Console.Write("o");
                        }

                        else
                        {
                            Console.Write("#");
                        }
                    }


                        {


                        }
                    }
                Console.WriteLine();
            }
                
            Console.ReadKey();
            }
        */






            //Övning 3
            /*
            for (int i = 10; i > 0; i--)
            {
            for (int y = 0; y < i; y++)
            {
               Console.Write("#");
            }
            Console.WriteLine();
            }
            Console.ReadKey();

                


            //övning4
            for (int i = 0; i < 10; i++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (x < i)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("#");
                    }

                }
                Console.WriteLine();
            }
            Console.ReadKey();
      


            //övning5 
            for (int i = 0; i < 7; i++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if (x == i || i + x == 6)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                        
                    }
                    Console.WriteLine();
                }
                 Console.ReadKey();
                 */

            //övning6 
            for (int i = 0; i < 7; i++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if ((x - i<0 || i + x < 6) && (x - i>0 || i + x > 6))
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                }
                Console.WriteLine();
            }
            Console.ReadKey();




        }


    }

        
}




