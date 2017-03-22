using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
        class RandomNumber
        {
            //Thread tr;
            int X0;
            int Xi;
            int X1; 
            int A = 0, C = 261011, A1=0,C1=0;
        public static int ResultA { get; set; }
            public static int ResultC { get; set; }

            public RandomNumber(int z1, int z2,int z3)
            {
                //tr=new Thread()
                X0 = z1;
                Xi = z2;
                X1 = z3;
            
            }

            public bool ResultDeRandom()
            {
                int M = 1000000;
            
                for (A=0; A <= M; A++)
                {
                    for (C= 0; C <= M; C++)
                    {
                    if (Xi == (A * X0 + C) % M)
                    
                        if ((Xi == (A * X0 + C) % M) & (Result2(A,C)))
                        {


                        return true;

                       
                        }
                    }
                }
            return false;

        }
        public bool Result2(int a, int c)
        {
            int M = 1000000;
            if (X1 == (a * Xi + c) % M)
            {
                return true;
            }          
            return false;

        }
        public void PrintNims()
            {
                 Console.WriteLine("{0}:::{1}", A, C);
                 Console.ReadLine();
            }

        }
    

    class Program
    {
        static void Main(string[] args)
        {
            
            int a, b,c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            RandomNumber rand = new RandomNumber(a, b,c);
            if (rand.ResultDeRandom())
            {
                rand.PrintNims();
            }
            else
            {
                Console.WriteLine("Ne naideno");
                Console.ReadLine();
            }
            //rand.ResultDeRandom()/*;*/
        }
    }
}
