using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgfit2
{
    
    public class Manager
    {
        public void Run()
        {
            PrintMenu();
            UserInput();
        }

        private void UserInput()
        {
            Console.Write("Enter  your Menu option: ");

            bool tryParse = int.TryParse(Console.ReadLine(), out int menuOption);

            if (tryParse)
            {
                Console.WriteLine(menuOption);

                if (menuOption == 0)
                {
                    Console.WriteLine("Exit");
                    Environment.Exit(0);
                    
                }
                else if (menuOption == 1)
                {

                    Console.Clear();
                    Console.WriteLine("Your name and age: ");
                }
                else if (menuOption == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Buy tickets for the crowd"); ;
                }
                else if (menuOption == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Enter your age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine(BuyTicket());
                }
                else if (menuOption == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Write a meaning with minimum 3 words and the program will shouw you the third word");
                    Split();
                }
                else if (menuOption == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Printing program ");
                    PrintOut10TimesString();
                }
            }
            else
            {
                IncorrectMeny();
            }
        }

        private void IncorrectMeny()
        {
            Console.WriteLine("Incorrect menu option.");
            Console.WriteLine("press <enter> try again");
            Console.ReadLine();
            Console.Clear();
            PrintMenu();
        }

        public void PrintMenu()
        {
            Console.WriteLine("Welcome Management system!" + Environment.NewLine);
            Console.WriteLine("1. - Your name and age");
            Console.WriteLine("2. - Price information ");
            Console.WriteLine("3. - Enter you age ");          
            Console.WriteLine("4. - Split ");
            Console.WriteLine("5. - Printing program ");
            Console.WriteLine("0. - Exit");
        }
        public static void PrintOut10TimesString()
        {
            bool success = false;

            do
            {

                Console.WriteLine("Enter your desired text to print it out 10 times: ");
                string text = Console.ReadLine();

                Console.WriteLine($"Enter amout of times to print : {text}");
                if (int.TryParse(Console.ReadLine(), out int number))
                {

                    for (int i = 1; i <= number; i++)
                    {
                        Console.WriteLine($"input: {i}, {text}");

                    }
                }

                else
                {
                    Console.WriteLine("");
                }
            } while (success);

        }
        public static void Split()
        {
            do
            {
                Console.Write("Write your three words: ");
                string word = Console.ReadLine();
                string[] letter = word.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (letter.Length < 3)
                {
                    Console.WriteLine("You must write atleast 3 words");
                    break;
                }
                else
                {
                    Console.WriteLine("The third last word is:" + letter[2]);
                    break;
                }
            } while (true);

        }

        public static int AddAge(int age)
        {
            if (age < 20)
            {
                Console.WriteLine("You qualify for youth price. 80 SEK");
                return 80;
            }
            if (age > 64)
            {
                Console.WriteLine("You Qualify for pensioner price. 90 SEK");
                return 90;
            }
            else
            {
                Console.WriteLine("You qualify for Standard price. 120 SEK");
                return 120;
            }
        }
        public static int Add(int price, int age)
        {
            int sum = price + age;
            return sum;
        }

        static int BuyTicket()
        {
            const int youthPrice = 80;
            const int pensionerPrice = 90;
            const int standardPrice = 120;
            const int free = 0;

            string ageInput = "";
            int age;
            do
            {
                Console.WriteLine("How old: ");
                ageInput = Console.ReadLine();

            } while (!int.TryParse(ageInput, out age));

            if (age < 20)
            {
                Console.WriteLine("Your 80 SEK - Youth price");
                return youthPrice;

            }
            else if (age > 64)
            {
                Console.WriteLine("Your price 90 SEK Pensioner price");
                return pensionerPrice;
            }
            else
            {
                Console.WriteLine("Your 120 SEK standard price");
                return standardPrice;

            }
            while (true) ;

        }

        static void Crowd()
        {
            

            Console.WriteLine("How many People?: ");
            int input = Int32.Parse(Console.ReadLine());

            if (input > 8)
            {
                Console.WriteLine("max 8");

            }
            int sum = 0;

            for (int i = 0; i < input; i++)
            {
                sum += BuyTicket();

            }
            Console.WriteLine("Total persons: " + input);
            Console.WriteLine($"Total cost: {sum}");
        }



    }

}
