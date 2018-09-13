using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {


            //Task 1

            Console.WriteLine("Please enter a number: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"The input {number} changed is: {ChangeSign(number)}");

            Console.ReadLine();

            
            //Task2

            Console.WriteLine("Please enter a number of miles: ");
            float miles = float.Parse(Console.ReadLine());
            Console.WriteLine($"The input of {miles} miles to kilometres is {MilesToKm(miles)}");

            Console.ReadLine();


            //Task3

            

            Console.WriteLine("Please enter the radius of a circle: ");
            float radius = float.Parse(Console.ReadLine());
            Console.WriteLine($"The circumference of your circle is {Circumference(radius)}");
            Console.WriteLine($"The area of your circle is {Area(radius)}");

            Console.ReadLine();


            //Task4

            string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine("Please enter a number that will display a corresponding day");
            int num = Int32.Parse(Console.ReadLine());
            CheckDay(num, day);
            

            Console.ReadLine();



        }

        public static int ChangeSign(int number)
        {
            //Task 1

            return number*-1;
        }

        public static double MilesToKm(float kilometre)
        {
            //Task2

            return kilometre/ 0.62137;
        }

        public static double Circumference(float radius)
        {
            //Task3

            return 2 * 3.1416 * radius;
        }
        
        public static double Area(float radius)
        {
            //Task3

            return 3.1416 * (radius * radius);
        }

        public static void CheckDay(int num, string[] day)
        {

            Console.WriteLine($"You chose {num}, the day is {day [num -1]}");
        }

    }
}
