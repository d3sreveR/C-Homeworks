using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two numbers");
            int nubmerOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("chose what to do: + , - , * , / ");
            string op = Console.ReadLine();

            
            
            switch (op)
            {
                case "+":
                    Console.WriteLine(nubmerOne + numberTwo);
                    break;

                case "-":
                    Console.WriteLine(nubmerOne - numberTwo);
                    break;

                case "*":
                    if (nubmerOne == 0 || numberTwo == 0)
                    {
                        Console.WriteLine("One of your number was 0");
                    }
                    else
                    {
                        Console.WriteLine(nubmerOne * numberTwo);
                    }

                    
                    break;

                case "/":
                    if (nubmerOne == 0 || numberTwo == 0)
                    {
                        Console.WriteLine("One of your number was 0");
                    }
                    else
                    {
                        Console.WriteLine(nubmerOne / numberTwo);
                    }
                    
                    break;

                default:
                    Console.WriteLine("One or more of your inputs are not supported in this version.");
                    break;
            }
        }
    }
}
