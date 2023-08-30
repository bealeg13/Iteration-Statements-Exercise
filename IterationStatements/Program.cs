namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void FirstMethod()
        {
            int x = 0;
            for (x = 0; x <= 1000; x++)
            {
                Console.WriteLine(x);
            }
        }
        
        
        
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void SecondMethod()
        {
            int y = 0;
            for (y = 3; y <= 999; y += 3)
            {
                Console.WriteLine(y);
            }
        }



        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool ThirdMethod(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine("These numbers are the same");
            }
            else 
            {
                Console.WriteLine("These numbers are different");
            }
            return true;
        }






        //Write a method to check whether a given number is even or odd
        public static int FourthMethod(int c)
        {
            if (c % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            return c;
        }







        //Write a method to check whether a given number is positive or negative
        public static int fifthMethod(int d)
        {
            if (d < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }
            return d;
        }







        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void SixthMethod()
        {
            Console.WriteLine("Enter your age :");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote!");
            }
            else
            {
                Console.WriteLine("You are not old enough to vote yet.");
            }

        }
        
        
        
        
        
        
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void SeventhMethod()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            if (number >= -10 && number <= 10)
            {
                Console.WriteLine($"{number} is within range");
            }
            else
            {
                Console.WriteLine($"{number} is not within range");
            }
        }






        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void EighthMethod()
        {
            int number = 6;
            int e = 0;
            
            for (e = 1; e <= 12; e++)
            {
                int result = number * e;
                Console.WriteLine(result);
            }
        }




        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //Program.FirstMethod();
            //Program.SecondMethod();
            //Program.ThirdMethod(5, 6);
            //Program.FourthMethod(23);
            //Program.fifthMethod(-45);
            //Program.SixthMethod();
            //Program.SeventhMethod();
            Program.EighthMethod();
        }
    }
}
