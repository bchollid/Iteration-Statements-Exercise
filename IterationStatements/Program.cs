namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below

        static void TwoThousandNumberPrintOut()
        {
            Console.WriteLine("Here is the two thousand number print out. Enjoy.");
            for(var i = 1000; i>=-1000; i--)
            {
                Console.WriteLine(i); //Limit line buffer won't show all digits.
            }
            Console.WriteLine("End of the two thousand number print out.");
        }

        static void CountByThrees()
        {
            for(var i = 3; i<=999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        static bool AreTheyEqual(int number1, int number2)
        {
            if(number1 == number2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void IsItEvenOrOdd(int numberToCheck)
        {
            if(numberToCheck % 2 == 0)
            {
                Console.WriteLine($"{numberToCheck} is even.");
            }
            else
            {
                Console.WriteLine($"{numberToCheck} is odd.");
            }
        }

        static void IsItPostiveOrNegative(int numberToCheck)
        {
            if(numberToCheck > 0)
            {
                Console.WriteLine($"{numberToCheck} is positive.");
            }
            else if (numberToCheck < 0)
            {
                Console.WriteLine($"{numberToCheck} is negative");
            }
            else
            {
                Console.WriteLine($"You trying to pull a fast one? {numberToCheck} is non-negative.");
            }
        }

        static void CanTheyVote(int age)
        {
            if (age < 18 && age > 0)
            {
                Console.WriteLine($"Nice try pal, you can't vote at {age}.");
            }
            else if (age >= 18 && age < 116)
            {
                Console.WriteLine($"Congrats, you can vote at {age}.");
            }
            else if (age < 0)
            {
                Console.WriteLine($"You sure you're ok? If you're {age} you haven't even been born yet.");
            }
            else if (age >= 116)
            {
                Console.WriteLine($"Please contact the Guinness Book of World Records. At {age}, you're the oldest person ever.");
            }

        }

        static void CheckIfNumberIsInRange(int userInput)
        {
            if(userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine($"{userInput} is within the range of -10 and 10.");
            }
            else
            {
                Console.WriteLine($"{userInput} is not within the range of -10 and 10.");
            }
        }

        static void MultiplicationTablePrintOut(int numberToMultiply)
        {
            for(var i = 0; i <= 12; i++)
            {
                Console.WriteLine($"{numberToMultiply} x {i} = {numberToMultiply * i}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Which method would you like to run?");
            Console.WriteLine("Press '1' for the two thousand number print out.");
            Console.WriteLine("Press '2' to count by 3s to 999.");
            Console.WriteLine("Press '3' to check if two numbers are equal.");
            Console.WriteLine("Press '4' to check if a number is even or odd.");
            Console.WriteLine("Press '5' to check if a number is negative or positive.");
            Console.WriteLine("Press '6' to check if someone is old enough to vote.");
            Console.WriteLine("Press '7' to check if a number is between -10 and 10.");
            Console.WriteLine("Press '8' to see a 12-line multiplication table for any number.");

            bool isItACorrectUserChoice;

            do
            {
                int userChoice;
                isItACorrectUserChoice = int.TryParse(Console.ReadLine(), out userChoice);

                if (isItACorrectUserChoice)
                {
                    switch (userChoice)
                    {
                        case 1:
                            TwoThousandNumberPrintOut();
                            break;

                        case 2:
                            CountByThrees();
                            break;

                        case 3:
                            Console.WriteLine("Enter the first number to check.");
                            var firstNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the second number to compare to the first number.");
                            var secondNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine($"It is {AreTheyEqual(firstNumber, secondNumber)} that {firstNumber} and {secondNumber} are equal.");
                            break;

                        case 4:
                            Console.WriteLine("Enter a number to check if it is even or odd.");
                            var evenOrOddCheck = int.Parse(Console.ReadLine());
                            IsItEvenOrOdd(evenOrOddCheck);
                            break;

                        case 5:
                            Console.WriteLine("Enter a number to check if it is negative or positive.");
                            var negativeOrPositiveCheck = int.Parse(Console.ReadLine());
                            IsItPostiveOrNegative(negativeOrPositiveCheck);
                            break;

                        case 6:
                            Console.WriteLine("Enter your age.");
                            var ageToCheck = int.Parse(Console.ReadLine());
                            CanTheyVote(ageToCheck);
                            break;

                        case 7:
                            Console.WriteLine("Enter a number to check if it's between -10 and 10.");
                            var numberInRange = int.Parse(Console.ReadLine());
                            CheckIfNumberIsInRange(numberInRange);
                            break;
                        case 8:
                            Console.WriteLine("Enter a number to see its multiplication table.");
                            var numberForMultiplicationTable = int.Parse(Console.ReadLine());
                            MultiplicationTablePrintOut(numberForMultiplicationTable);
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            } while (isItACorrectUserChoice != true);
        }    
    }
}
