﻿using System;

namespace Func_Meth_Csharp
{
    class Program
    {
        //task 1.
        /* 
         public static void welcome()
        {
            Console.WriteLine("Welcome!");
        }

        public static void HaveNice()
        {
            Console.WriteLine("Have a nice day!");
        }
    
        public static void Main()
        {
            welcome();
            HaveNice();
        
        } */
        
        //task ---2
       /*   
            public static void welcome(string name)
        {
            Console.WriteLine("Welcome friend " + name + "!");
        }

        public static void HaveNice()
        {
            Console.WriteLine("Have a nice day!");
        }
    
        public static void Main(string[] args)
        {
          string johnName;  
          Console.Write("Please input a name: ");
          johnName = Console.ReadLine();  
            welcome(johnName);
            HaveNice();
        }
        */
    //task 3 
/* 
            public static int Sum(int a, int b)
            {
                int total;
                total = a + b;
                return total;
            }
            public static void Main()
            {
                Console.Write("Please enter a number: ");
                int a = Convert.ToInt16(Console.ReadLine());
                Console.Write("Please enter a second number: ");
                int b = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("The sum of the two numbers is: {0}", Sum(a, b));

            } */

            ///TASK 4 ..!--.!-- 

            /* public static int test(string userString)
                {
                    int spaces = 0;
                    string wordHolder;
                    
                   
                    for (int i = 0; i < userString.Length; i++)
                        {
                            wordHolder = userString;
                            if (userString[i] == ' ')
                            {
                                spaces++;
                            }
                            
                        }
                    return spaces;
                }


            public static void Main()
            {
                string holder;
                Console.WriteLine("Please input a string");
                holder = Console.ReadLine();
                Console.Write(holder + " Has {0} spaces in it", test(holder));    

            } */

        //task 5 

        
    }
}
