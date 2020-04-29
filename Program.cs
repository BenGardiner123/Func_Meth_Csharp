using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        //task 5 ----------------------------/* 
      /*       public static void Main(){
            
            int [] myArray = new int[5];
        
        
            Console.WriteLine("please enter 5 numbers into the console");
            
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.Write("thanks for that...");
            Console.WriteLine("Outputting the Sum");
            int sum = 0;
            
            foreach (var i in myArray)
            {
                sum += i;
            }

            Console.WriteLine("The sum if your numbers is {0} ", sum );
            
        }   */

    //////////TASK 6///////////////
/* 
            public static void Main(){
            int userIntA;
            int userIntB;
            int userIntC;

            Console.WriteLine("Please enter a number");
            userIntA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            userIntB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Just swapping your numbers..........");
            
            userIntC = userIntA;
            userIntA = userIntB;
            userIntB = userIntC;

            Console.WriteLine("Your first number is now " + userIntA );
            Console.WriteLine("Your second number is now " + userIntB );

        } */

        //////////TASK 7///////////////
        
       /*  public static void Main(string[] args){
            int a;
            int b;
            Console.WriteLine("Input Base number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Exponent");
            b = Convert.ToInt32(Console.ReadLine());
            int result = PowNum(a, b);
            Console.WriteLine("So the number "+ a + "^(to the power)"+ b + " = {0}", result);
        }  

            static int PowNum(int baseNum, int powNum)
            {
                int result = 1;

                for (int i = 0;i < powNum; i++)
                {
                    result = result * baseNum;
                }
                return result;
            } */

        //////////TASK 8///////////////////

        
        public static void Main(string[] args){
            int fibLimit;
            Console.WriteLine("Input number of Fibonacci Series: ");
            fibLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Fibonacci series of 5 numbers is: ");
            
            for (int i = 0; i < fibLimit; i++)
            {
                Console.Write("{0} ", fibSeq(i));
            }
            
        }

         public static int fibSeq(int n)
         {
             int firstNum = 0, secondNum = 1, result = 0;
            
            if (n == 0) return 0; 
            if (n == 1) return 1;
            
            for (int i = 2; i <= n; i++)
            
            {
                result = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = result;

            }
            return result;

         }

    }
}
