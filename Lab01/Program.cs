using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in en söksträng: ");
            var input = Console.ReadLine();
            Console.WriteLine();
            Search(input);
        }

        static void Search(string input)
        {
            long total = 0;
            var firstIndex = 0;
            foreach (var firstNumber in input)
            {
                var marked = "";
                var secondIndex = firstIndex + 1;
                foreach (var secondNumber in input.Substring(secondIndex))
                {
                    if (secondNumber == firstNumber)
                    {
                        marked += input.Substring(firstIndex, secondIndex - firstIndex + 1);

                        //Before the marked number
                        Console.Write(input.Substring(0, firstIndex));

                        //The marked numbers
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(marked);
                        Console.ForegroundColor = ConsoleColor.Gray;

                        //The rest of the string
                        Console.WriteLine(input.Substring(secondIndex + 1));

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
