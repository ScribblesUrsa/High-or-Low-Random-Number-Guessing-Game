using System.Transactions;

namespace High_or_Low_Random_Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the guessing game!!!");

            //Variables for maximum and minimum range and provide flexibility on the number of guesses allowed
            const int MIN_VALUE = 0;
            const int MAX_VALUE = 100;
            const int NUMBER_OF_GUESSES = 10;

            Random range = new Random();
            int randomNumber = range.Next(MIN_VALUE, (MAX_VALUE + 1));//(maxValue + 1 to give the true random number range
            Console.WriteLine(randomNumber);//Just a guideline on whether or not the code works

            Console.WriteLine($"Hello! Guess a whole number that the computer will generate between {MIN_VALUE}  to {MAX_VALUE}:");
            int userNumber = Convert.ToInt32(Console.ReadLine()); //To avoid error since readline is normally accepting string inputs, the input must be converted to 
                                                                  //an integer or equivalent         
            if (randomNumber == userNumber)
            {
                Console.WriteLine("You guessed it right in one go!");
            }

            if (userNumber > MAX_VALUE)//For the input a number higher than maxValue
            {
                Console.WriteLine($"Please Enter a number that is lower than {MAX_VALUE}.");
                userNumber = Convert.ToInt32(Console.ReadLine());
            }

            if (userNumber < MIN_VALUE)//For the input a number lower than minValue
            {
                Console.WriteLine($"Please Enter a number that is lower than {MIN_VALUE}.");
                userNumber = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = NUMBER_OF_GUESSES; i >= 1 && (userNumber != randomNumber); i--)//Countdown to number of guesses, it will iterate as long as the guesses remain above 
                                                                                    //or is equa to one and as long as userNumber is not equal to randomNumber
            {
                if (userNumber > randomNumber)//Provides the code for wwhen the user guesses a number that is higher than what the random number actually is
                {
                    Console.WriteLine($"The number you have entered is too high, please try again.");
                }

                if (userNumber < randomNumber)
                {
                    Console.WriteLine("The number you have entered is too low, please try again.");
                }
                    Console.WriteLine("You have " + i + " tries left.");
                    userNumber = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    Console.WriteLine("Too many tries, better luck next time.");
                }
                
                if (userNumber == randomNumber)
                {
                    Console.WriteLine("You guessed it correctly! Congratulations!");
                }
            }


        }
    }
}