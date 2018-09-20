using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {


            //Task1 - BMI

            Console.WriteLine("This application calculates the BMI");
            Console.WriteLine("Please enter in your weight in Kg");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter in your height in cm");
            float height = float.Parse(Console.ReadLine()) /100;

            Console.WriteLine($"Your BMI is {BMI(weight, height)}");

            Console.ReadLine();


            //Task2 - BMI extension

            string category = "";

            Console.WriteLine($"{BMIcategory(category, BMI(weight,height))}");

            Console.ReadLine();


            //Task3 - Rounding up or down

            string round = "";

            Console.WriteLine("This application rounds up or down depending on the ending cents of a transaction");
            Console.WriteLine("Please enter in the amount of cents");
            int amount = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{Rounding(amount, round)}");

            Console.ReadLine();


            //Task4 - Language translation

            int userInput = 0;
            string[] language = { "Kia Ora", "Konnichiwa", "Namaste", "Bonjour", "Talofa" };
            Console.WriteLine("I can translate 'hello' in 5 different languages:");

            Console.WriteLine("Which language translation do you wish to see (1 to 5)");
            Console.WriteLine("1 for Maori");
            Console.WriteLine("2 for Japanese");
            Console.WriteLine("3 for Hindi");
            Console.WriteLine("4 for French");
            Console.WriteLine("5 for Samoan");

            Console.WriteLine($"Hello is translated as {Translate(userInput, language)}" );
            Console.ReadLine();


            //Task5 - Mathematical Operations


            float result = 0;

            Console.WriteLine("This application is a basic calculator");
            Console.WriteLine("Please enter in the first number");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter in the operator: +,-,*,/");
            string Operator = Console.ReadLine();

            Console.WriteLine("Please enter in the second number");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Your calculation is: {Calculate(num1,num2,result,Operator)}");

            Console.ReadLine();

        }
        
        public static float BMI (float weight, float height)
        {
            //Task1

            return weight/(height*height);
        }

        public static string BMIcategory(string category, float BMI)
        {
            //Task2

            category = "";

            if (BMI < 18.5)
            {
                Console.WriteLine("Your BMI category is Underweight");
            }
            else if (BMI >= 18.5 || BMI < 25)
            {
                Console.WriteLine("Your BMI category is Normal weight");
            }
            else if (BMI >= 25 || BMI < 30)
            {
                Console.WriteLine("Your BMI category is Overweight");
            }
            else
            {
                Console.WriteLine("Your BMI category is Obese");
            }

            return category;
                
        }
        public static string Rounding(int amount, string round)
        {
            //Task3

            round = ""; 
            switch (amount)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    round = "Round down";
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                    round = "Round up";
                    break;
            }

            return round;
        }
        public static string Translate(int userInput, string[]language)
        {
            
            userInput = Int32.Parse(Console.ReadLine());
            string greet = language[userInput - 1];
            Console.WriteLine($"You selected translation: {userInput}");

            return greet;
        }

        public static float Calculate(float num1, float num2, float result, string Operator)
        {

            if (Operator == "+")
            {
                result = num1 + num2;
            }
            else if (Operator == "-")
            {
                result = num1 - num2;
            }
            else if (Operator == "*")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

            return result;

        }

    }
}
