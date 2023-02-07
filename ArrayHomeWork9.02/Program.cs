using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHomeWork9._02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1
            /*Console.WriteLine("Input size array:");
            int arrsize = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[arrsize];
            Console.WriteLine("Input 0 - Array add random numbers\nInput 1 - Array add user numbers\nInput number(0-1):");
            int boolnum = Convert.ToInt32(Console.ReadLine());
            switch (boolnum)
            {
                case 0:
                    Random r = new Random();
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Arr[i] = r.Next(1, 20);
                        Console.Write("{0,4}", Arr[i]);
                    };
                    break;
                case 1:
                    Console.WriteLine($"Input {arrsize} numbers:"); ;
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Arr[i] = Convert.ToInt32(Console.ReadLine());
                    };
                    Console.WriteLine("Your array:"); ;
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Console.Write("{0,4}", Arr[i]);
                    };
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            };
            int arrsizeodd=0;
            for(int i = 0; i < Arr.Length; i++) {
                if ((Arr[i] % 2) != 0)
                {
                    arrsizeodd++;
                }            
            };// просчет нечетных чисел для создания массива нечетных чисел
            int[] Arrodd = new int[arrsizeodd];
            int j = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                 

                    if ((Arr[i] % 2) != 0)
                    {
                        Arrodd[j] = Arr[i];
                    j++;
                    }
                 
                
            };//массив нечетных чисел
            Console.Write("\nArray odd numbers:");
            for(int i = 0; i < Arrodd.Length; i++) {
                Console.Write("{0,4}",Arrodd[i]);
            };
            Array.Sort(Arrodd);
            Console.Write($"\nArray odd max:{Arrodd[arrsizeodd-1]}");
            int maxnumber = Arrodd[arrsizeodd - 1];
            int position = Array.IndexOf(Arrodd, maxnumber);
            int mass2=0;
            for(int i = 0; i < position; i++) {
                mass2++;
            };
            int[] massodd2 = new int[mass2];
            Console.Write($"\n-------------------");
            for (int i = 0; i < massodd2.Length; i++)
            {
                massodd2[i] = Arr[i];
                Console.Write("{0,4}", massodd2[i]);
            };
            Console.ReadLine();*/
            #endregion
            #region Exercise 2
            /*Console.WriteLine("Input size array:");
            int arrsize = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[arrsize];
            Console.WriteLine("Input 0 - Array add random numbers\nInput 1 - Array add user numbers\nInput number(0-1):");
            int boolnum = Convert.ToInt32(Console.ReadLine());
            switch (boolnum)
            {
                case 0:
                    Random r = new Random();
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Arr[i] = r.Next(0, 20);
                        Console.Write("{0,4}", Arr[i]);
                    };
                    break;
                case 1:
                    Console.WriteLine($"Input {arrsize} numbers:"); ;
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Arr[i] = Convert.ToInt32(Console.ReadLine());
                    };
                    Console.WriteLine("Your array:"); ;
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Console.Write("{0,4}", Arr[i]);
                    };
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            };
            int nulp1=0;
            for(int i = 0; i < Arr.Length; i++) {
                if ((Arr[i]) == 0) {
                    nulp1++;
                }      
            };
            int[] nullarray = new int[nulp1];
            int j = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if ((Arr[i]) == 0)
                {

                    nullarray[j] = i;
                    j++;
                }
            };
            Console.Write($"\nPosition '0' numbers:");
            for (int i = 0; i < nullarray.Length; i++)
            {
                Console.Write("{0,4}",nullarray[i]);
            };
            int sum = 0;
            if (j != 0) {

                 
                for (int i = 0; i < Arr.Length; i++)
                {

                    if (i >= nullarray[0])
                    {
                        sum += Arr[i];
                        if (i >= nullarray[1])
                        {
                            break;
                        }
                    }
                };
            };
             
            Console.Write($"\nSumm:{sum}");
            Console.ReadLine();*/
            #endregion
            #region Exercise 3
            Console.WriteLine("Input size array:");
            int arrsize = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[arrsize];
            Console.WriteLine("Input 0 - Array add random numbers\nInput 1 - Array add user numbers\nInput number(0-1):");
            int boolnum = Convert.ToInt32(Console.ReadLine());
            switch (boolnum)
            {
                case 0:
                    Random r = new Random();
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Arr[i] = r.Next(0, 20);
                        Console.Write("{0,4}", Arr[i]);
                    };
                    break;
                case 1:
                    Console.WriteLine($"Input {arrsize} numbers:"); ;
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Arr[i] = Convert.ToInt32(Console.ReadLine());
                    };
                    Console.WriteLine("Your array:"); ;
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        Console.Write("{0,4}", Arr[i]);
                    };
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            };
            Console.Write("\nInput number:");
            int numtofind = Convert.ToInt32(Console.ReadLine());

            int sum = 0, k = 0;
            while (k<arrsize) {
                

            for (int i = k; i < Arr.Length; i++)
            {
                if (sum == numtofind)
                {
                    break;
                }
                    else 
                {

                    if (i == Arr.Length)
                    {
                        sum += Arr[i];
                    };



                }
            };
                Console.Write(k);
                k++;
        };//закрывается цикл while

        Console.ReadLine();
            #endregion
        }
    }
}
