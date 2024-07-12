namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void ReturnThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void EqualOrNot(int numOne, int numTwo)
        {
            var output = (numOne != numTwo) ? $"The numbers {numOne} and {numTwo} are NOT equal." : $"The numbers {numOne} and {numTwo} ARE equal.";
            Console.WriteLine(output);
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num)
        {
            var output = (num % 2 == 0) ? $"{num} is a Positive Number" : $"{num} is a Odd Number";
            Console.WriteLine(output);
        }
        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative(int num)
        {
            var output = (num < 0) ? $"{num} is a Negative Number" : $"{num} is a Positive Number";
            Console.WriteLine(output);
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanVote()
        {
            //Uses a bool to create a loop
            bool finish = false;
            
            while (!finish)
            {
                Console.WriteLine("What is your Age?");
                string userInput = Console.ReadLine();
                
                //Uses TryParse() to make sure input is an integer and outputs input into a new variable called age
                if (int.TryParse(userInput, out int age))
                {
                    var message = (age >= 18) ? "You are old enough to vote!" : "You are not old enough to vote.";
                    Console.WriteLine(message);
                    finish = true;
                }
                else
                {
                    //Return given if input is not a integer
                    Console.WriteLine("Invalid Input. Please input a Valid Integer");
                }
            }
            
            
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void InRange()
        {
            bool finish = false;
            
            while (!finish)
            {
                Console.WriteLine("Give me a Number");
                string userInput = Console.ReadLine();
                
                if (int.TryParse(userInput, out int num))
                {
                    var message = (num >= -10 & num <= 10) ? $"{num} is in range!" : $"{num} is not in range.";
                    Console.WriteLine(message);
                    finish = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please input a Valid Integer");
                }
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable()
        {
            bool finish = false;
            
            while (!finish)
            {
                Console.WriteLine("Give me a Number");
                string userInput = Console.ReadLine();
                
                if (int.TryParse(userInput, out int num))
                {
                    for (int multiple = 1; multiple < 13; multiple++)
                    {
                        int result = num * multiple;
                        Console.WriteLine($"{num} x {multiple} is {result}");
                    }
                    finish = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please input a Valid Integer");
                }
            }
            
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //ReturnThousand();
            //ByThree();
            //EqualOrNot(1,3);
            //EvenOrOdd(33);
            //PositiveOrNegative(-5731);
            //CanVote();
            //InRange();
            MultiplicationTable();
        }
    }
}
