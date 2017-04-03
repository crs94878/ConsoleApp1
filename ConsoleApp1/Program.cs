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

        Int64 X0;
        Int64 X1, X2;
     

        Int64 A = 0, C = 0;
        public static Int64 ResultA { get; set; }
        public static Int64 ResultC { get; set; }

        public RandomNumber(Int64 z1, Int64 z2,Int64 z3)
        {

            X0 = z1;
            X1 = z2;
            X2 = z3;
        }

        public void ResultDeRandom()
        {
            Int64 M = 1000000;
            Int64 res=0;
            Int64 res2=0;
            bool IsTrue = false;
            for (A = 0; A <= M; A++)
            {
                for (C = 0; C <= M; C++)
                {
                    res= (A * X0 + C) % M;      //получение второго числа   
                   
            if (res == X1)
            {
                        Console.WriteLine("При Х1=" + res+"||||||||"+res+"="+"("+A+"*"+ X0 +"+"+ C+")"+ "%"+ M);
                        Console.WriteLine("Члены выражения--->  A:{0}|||||C:{1}", A, C);
                        res2 = (A * res + C) % M;    // получение 3-его числа
                        if (res2 == X2)
                        {
                            Console.WriteLine("При Х2=" + res2 + "||||||||" + res2 + "=" + "(" + A + "*" + res + "+" + C + ")" + "%" + M);
                            Console.WriteLine("Члены выражения--->  A:{0}|||||C:{1}", A, C);
                            IsTrue = true;
                            break;
                        }
            }
                    
                }
                if (IsTrue == true)
                    break;
            }
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("Найдены члены-----------> A:{0}|||||C:{1}", A, C);
            Console.ReadLine();

        }
     




        class Program
        {
            static void Main(string[] args)
            {

                Int64 a, b,c;
                a = Convert.ToInt64(Console.ReadLine());
                b = Convert.ToInt64(Console.ReadLine());
                c = Convert.ToInt64(Console.ReadLine());
                RandomNumber rand = new RandomNumber(a, b,c);
                rand.ResultDeRandom();
            
                   }
        }

    }
}