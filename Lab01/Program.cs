using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in en söksträng: ");
            string input = Console.ReadLine();
            Console.WriteLine();
            Search(input);
        }

        private static void Search(string input)
        {
            long total = 0;
            int firstIndex = 0;
            foreach (char firstNumber in input)
            {
                var marked = "";
                var secondIndex = firstIndex+1;
                foreach (char secondNumber in input.Substring(secondIndex))
                {
                    if (secondNumber == firstNumber)
                    {
                        marked += input.Substring(firstIndex, secondIndex-firstIndex + 1);
                        Console.Write(input.Substring(0, firstIndex)); //Before the marked number
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(marked);  //The marked numbers
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(input.Substring(secondIndex+1));   //The rest of the string
                        Console.WriteLine();
                        total += long.Parse(marked);
                        break;
                    }
                    if (!char.IsDigit(secondNumber)) break; 

                    secondIndex++;
                }

                firstIndex++;
            }
            Console.WriteLine($"Totalen av alla markerade tal är: {total}");
        }
    }
}
