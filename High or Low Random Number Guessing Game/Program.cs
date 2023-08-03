namespace Guessing_Game_Again
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                String userInput = "";
                int userNumber = 0;

                for (int i = NUMBER_OF_GUESSES; i >= 0 && (userNumber != randomNumber); i--)//Countdown to number of guesses, it will iterate as long as the guesses remain above 
                                                                                            //or is equa to one and as long as userNumber is not equal to randomNumber
                {

                    userInput = Console.ReadLine();                               
                    bool validInput = Int32.TryParse(userInput, out userNumber);

                    while (userNumber > MAX_VALUE | userNumber < MIN_VALUE | !validInput)//For the input a number higher than maxValue
                    {

                        if (!validInput) //Incase, the user enters a letter after passing the initial scan for numerical input
                        {
                            Console.WriteLine("Please enter a numerical input:");
                        }

                        if (userNumber > MAX_VALUE)
                        {
                            Console.WriteLine($"Please Enter a number that is lower or equal to {MAX_VALUE}.");
                        }

                        if (userNumber < MIN_VALUE)
                        {
                            Console.WriteLine($"Please Enter a number that is higher than {MIN_VALUE}.");
                        }

                        userInput = Console.ReadLine();
                        validInput = Int32.TryParse(userInput, out userNumber);

                    }

                    Console.WriteLine("You have " + i + " tries left.");

                    if ((userNumber >= (randomNumber - 5) && userNumber <= (randomNumber + 5)) && (userNumber != randomNumber))
                    {
                        Console.WriteLine("You're close!");
                    }

                    if (userNumber > randomNumber && userNumber <= MAX_VALUE && validInput)//Provides the code for when the user guesses a number that is higher than what the random number actually is
                    {
                        Console.WriteLine($"The number you have entered is too high, please try again.");
                    }

                    if (userNumber < randomNumber && userNumber >= MIN_VALUE && validInput)
                    {
                        Console.WriteLine("The number you have entered is too low, please try again.");
                    }                   

                }

                if (randomNumber == userNumber)
                {
                    Console.WriteLine("You guessed it correctly! Congratulations!");
                }

                else
                {
                    Console.WriteLine("Too many tries, better luck next time.");
                }
            }
        }
    }
}
