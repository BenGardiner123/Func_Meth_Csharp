using System;

namespace Func_Meth_Csharp
{
    class Program
    {/* 
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

    }
}
