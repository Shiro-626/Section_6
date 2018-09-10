using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practice
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
            //Question 1 Reverse

            int[] numbers = new int [5];

            Console.WriteLine("Please enter 5 numbers");

            for (int i = 0; i <5; i++)
            {
                Console.WriteLine($"Please enter number {i+1} (Array index {i})");
                numbers[i] = Int32.Parse(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("Numbers displayed in as entered");

            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine($"Number {j+1} (Array index {j})" + numbers[j]);
            }

            Console.WriteLine("\nNumbers displayed in reverse");

            for (int k= 5; k > 0; k--)
            {
                Console.WriteLine($"Number {k} (Array index {k-1})" +numbers[k-1]);
            }

            Console.ReadLine();


        }
        public static void Task2()
        {
            //Question 2 Total

            

            int total = 0;

            Console.WriteLine("How many numbers do you want to store in the array?");
            int userNum = Int32.Parse(Console.ReadLine());
            int[] store = new int[userNum];

            for (int i = 0; i < userNum; i++)
            {
                Console.WriteLine($"Please enter Number {i+1} (Array index {i}:)");
                total +=  store[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Array items entered:");
            for (int j = 0; j <userNum; j++)
            {
                Console.Write(+store[j] );
            }
            Console.WriteLine($"\nTotal of these array items is: {total}");

            Console.ReadLine();

            /*
            for (int i = 0; i < userNum; i++)
            {
                Console.WriteLine($"Please enter Number {i+1} (Array index {i}:)");
                total +=  store[i] = Int32.Parse(Console.ReadLine());
            }
            
            foreach (int x in store)
            {
                Console.WriteLine(x);
                total += x;
            }
            Console.WriteLine($"\nTotal of these array items is: {total}");

            Console.ReadLine();


             */



        }
        public static void Task3()
        {
            //Question 3

            int[] array1 = new int[5];
            int[] array2 = new int[5];

            Console.WriteLine("Enter 5 numbers into the first array");

            for (int i=0; i <5; i++)
            {
                Console.WriteLine($"Enter number {i+1} (Array Index {i})");
                array1[i] = Int32.Parse(Console.ReadLine());
            }

            for (int j = 0; j <5; j++)
            {
                array2[j] = array1[j];
            }
            Console.WriteLine("Items have been copied from the first array to the second array");

            Console.WriteLine("\nSecond array items: ");
            for (int k = 0; k<5; k++)
            {
                Console.Write(+array2[k] );
            }

            Console.ReadLine();


        }
        public static void Task4()
        {
            //Question 4

            int[] userArray = new int[5];

            Console.WriteLine("Please enter 5 numbers");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter number {i+1} (Array Index {i}:)");
                userArray[i] = Int32.Parse(Console.ReadLine());
            }


            int min = userArray[0];
            int max = userArray[0];
            for (int j = 0; j <5; j++)
            {
                if (min >= userArray[j])
                {
                    min = userArray[j];
                }
                if (userArray[j] > max)
                {
                    max = userArray[j];
                }
            }

            Console.WriteLine($"The minimum number is: {min}");
            Console.WriteLine($"The maximum number is: {max}");

            Console.ReadLine();
            }

            
        }
    }

