using System;

namespace MethodExercise
{
    class Program
    {   
        public static void StoryTime ()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine($"There once was a child named {name}.");
            Console.WriteLine($"And {name} thought the sky was {favColor}.");
            Console.WriteLine($"Now every time {name} sees a {favAnimal} moving about,");
            Console.WriteLine($"Little {name} hears {favBand} playing music in the background.");
        }

        public static int Addition ()
        {
            Console.WriteLine("Enter the first number to be Added.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number to be Added.");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine($"The result is {sum}.");
            return sum;
        }

        public static int Subtraction ()
        {
            Console.WriteLine("Enter the first number to be Subtracted.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number to be Subtracted.");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 - num2;
            Console.WriteLine($"The result is {sum}.");
            return sum;
        }

        public static int Multiplication()
        {
            Console.WriteLine("Enter the first number to be Multiplied.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number to be Multiplied.");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 * num2;
            Console.WriteLine($"The result is {sum}.");
            return sum;
        }
        public static int Division()
        {
            Console.WriteLine("Enter the first number to be Divided.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number to be Divided.");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 / num2;
            Console.WriteLine($"The result is {sum}."); 
            return sum;
        }
        public static int Modulus()
        {
            Console.WriteLine("Enter the first number to be operated on by modulus.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number to be operated on by modulus.");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 % num2;
            Console.WriteLine($"The result is {sum}."); 
            return sum;
        }
        static void Main(string[] args)
        {

            StoryTime();
            Addition();   
            Subtraction();
            Multiplication();
            Division();
            Modulus();
        }

        
    }
}
