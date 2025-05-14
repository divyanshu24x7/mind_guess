using System;
using System.Linq;
using System.Threading;

namespace MindGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            int[] array = ReadSortedArray();
            PromptSecretNumber();

            int low = 0, high = array.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = array[mid];

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"\nIs it {guess}? ");
                Console.ResetColor();
                Console.Write("(enter “higher”, “lower”, or “correct”): ");

                string response = Console.ReadLine().Trim().ToLower();
                if (response == "correct")
                {
                    Celebrate(guess);
                    return;
                }
                else if (response == "higher")
                {
                    low = mid + 1;
                }
                else if (response == "lower")
                {
                    high = mid - 1;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please type only “higher”, “lower”, or “correct.”");
                    Console.ResetColor();
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nHmm… it seems there’s been a mismatch. Did you pick a number from the array?");
            Console.ResetColor();
        }

        static void PrintHeader()
        {
            Console.Clear();
            string title = "🧠 Mind Guess: Interactive Binary Search Game 🧠";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(new string('═', title.Length + 4));
            Console.WriteLine($"═ {title} ═");
            Console.WriteLine(new string('═', title.Length + 4));
            Console.ResetColor();
        }

        static int[] ReadSortedArray()
        {
            while (true)
            {
                Console.Write("\nEnter a **sorted** list of integers (space-separated): ");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    continue;

                var parts = input.Trim().Split();
                int[] nums;
                try
                {
                    nums = parts.Select(int.Parse).ToArray();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input: please enter integers only.");
                    Console.ResetColor();
                    continue;
                }

                if (!nums.SequenceEqual(nums.OrderBy(x => x)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please make sure the numbers are in non-decreasing order.");
                    Console.ResetColor();
                    continue;
                }

                return nums;
            }
        }

        static void PromptSecretNumber()
        {
            Console.WriteLine("\nThink of one number from your list and keep it secret.");
            Console.Write("When you’re ready, press Enter to start the game…");
            Console.ReadLine();
        }

        static void Celebrate(int found)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n🎉 I’ve got it! Your number is {found}! 🎉");
            Console.ResetColor();
        }
    }
}
