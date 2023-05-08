using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
       static int a = 1;
       static int b = 3;
        static int c= int.Parse(Console.ReadLine());
        static int d= int.Parse(Console.ReadLine());
        static void Main(string[] args)
        {
            var sumShowed = returnSum(a,b);
           Console.WriteLine(sumShowed);
            printMessage();
            greetMe();
            printArgs(args);
            printLengthOfArgs(args);
            var result = checkIfNumbersAreEaqual(c, d);
            Console.WriteLine("do both numbers match?" + result);
           var nemNumber=  multiplyOradd(c, d);
            Console.WriteLine( nemNumber);
            var oneOfThreeIsThirty= checkIfThirty(c,d);
            Console.WriteLine("er en av de lik 30?"+oneOfThreeIsThirty);
            //Console.WriteLine(d);
        }

        static int returnSum (int a, int b)
        { int sum= a + b;
            return sum;
        }
        static void printMessage()
        { Console.WriteLine("denne metoden returnerer ingenting"); }
        static void greetMe()
        {
            Console.WriteLine("hei, hva heter du?");
            var name= Console.ReadLine();
            Console.WriteLine("Velkommen " + name); 
        }
        static void printArgs(string[] words)
        { foreach (var argument in words)
            { Console.WriteLine(argument); } }

        static void printLengthOfArgs(string[]a)
        { Console.WriteLine(a.Length); }

        static bool checkIfNumbersAreEaqual(int c, int d)
        { //c= int.Parse(Console.ReadLine());
         // d= int.Parse(Console.ReadLine());
            return c == d; }

        static int multiplyOradd(int c, int d)
        {
          //  c = int.Parse(Console.ReadLine());
           // d = int.Parse(Console.ReadLine());
            if (checkIfNumbersAreEaqual(c, d))
            {
                return c * d;

            }
            else return c + d;
        }

        static bool checkIfThirty(int c, int d)
        {
           var sum = c + d;
            if (c == 30 || d == 30 || sum == 30)
            {
                return true;

            }
            else return false;
        }
    }
    

}