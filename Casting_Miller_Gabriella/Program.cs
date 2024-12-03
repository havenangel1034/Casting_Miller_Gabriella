using System;
namespace Casting_Miller_Gabriella
{

        class Program
    {

        static void Main(string[] args)
        {
            //Asks user to input a number
            Console.WriteLine("Could you please enter a whole number, User?");
            //Converts the Console.Readline string to an int
            int myFavNum = Convert.ToInt32(Console.ReadLine());
            //confirms the user's favorite number
            Console.WriteLine("Your favorite number is " + myFavNum);
            //asks the user to answer the question with either true or false
            Console.WriteLine("Do you like writing? (Please enter 'TRUE' or 'FALSE')");
            //converts the Console.Readline to a boolean
            bool isTrue = Convert.ToBoolean(Console.ReadLine());
            //confirms the user's answer if true or false
            Console.WriteLine($"It is {isTrue} that I like writing!");
        }
    }
}
