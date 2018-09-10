using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Array_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean restart = true;

            do
            {

                Console.WriteLine("Please choose which task you want to execute");
                Console.WriteLine("For task 1 push 1");
                Console.WriteLine("For task 2 push 2");
                Console.WriteLine("For task 3 push 3");
                Console.WriteLine("For task 4 push 4");
                int choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Task1();
                }
                else if (choice == 2)
                {
                    Task2();
                }
                else if (choice == 3)
                {
                    Task3();
                }
                else
                {
                    Task4();
                }

                Console.WriteLine("Do you want to run another task, Y/N");

                var check = Console.ReadLine().ToUpper();
                if (check == "N")
                {
                    restart = false;
                }
                Console.Clear();
            } while (restart);


        }
        public static void Task1()
        {
            //Question 1

            string[] winners = new string[3];

            Console.WriteLine("Please enter the name of the GOLD medal winner");
            winners[0] = Console.ReadLine();

            Console.WriteLine("Please enter the name of the SILVER medal winner");
            winners[1] = Console.ReadLine();

            Console.WriteLine("Please enter the name of the BRONZE medal winner");
            winners[2] = Console.ReadLine();

            Console.WriteLine("\nWhich medal holder would you like to see displayed?");
            Console.WriteLine("Press 1 for the gold medal winner");
            Console.WriteLine("Press 2 for the silver medal winner");
            Console.WriteLine("Press 3 for the bronze medal winner");
            int input = Int32.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine($"Gold medal went to {winners[0]}");
            }
            else if (input == 2)
            {
                Console.WriteLine($"Silver medal went to{winners[1]}");
            }
            else
            {
                Console.WriteLine($"Bronze medal went to{winners[2]}");
            }

            Console.ReadLine();
        }
        public static void Task2()
        {
            //Question 2


            string[] names = new string[5];

            Console.WriteLine("Please enter in 5 names");

            for (int i=0; i < names.Length; i++)
            {
                Console.WriteLine($"Please enter in name {i + 1}:");
                names[i] = Console.ReadLine();
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i}{names[i]}");
                
            }
            Console.WriteLine($"The first name entered is {names[0]}");
            Console.WriteLine($"The last name entered is {names[4]}");

            Console.ReadLine();




        }
        public static void Task3()
        {
            //Question 3

            string[] tickets = new string[20];


            for (int i = 0; i < tickets.Length; i++)
            {
                Console.WriteLine($"Please enter in name {i + 1}:");
                tickets[i] = Console.ReadLine();
            }

            Random rnd = new Random();
            Console.WriteLine($"The winner is: {tickets[rnd.Next(0,19)]}");

            //int winner = rnd.Next(0, 19);
           

            Console.ReadLine();

        }
        public static void Task4()
        {
            //Question 4

            string[] language = {"Kia Ora", "Konnichiwa", "Namaste", "Bonjour", "Talofa"};
            Console.WriteLine("I can translate 'hello' in 5 different languages:");

            Console.WriteLine("Which language translation do you wish to see (1 to 5)");
            Console.WriteLine("1 for Maori");
            Console.WriteLine("2 for Japanese");
            Console.WriteLine("3 for Hindi");
            Console.WriteLine("4 for French");
            Console.WriteLine("5 for Samoan");
            int userInput = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"You selected translation: {userInput}");
            Console.WriteLine($"Hello is translated as:" +language[userInput-1]);
            Console.ReadLine();


        }

    }
}
