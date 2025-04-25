using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool keepPlaying = true;
            string playerChoice = "";
            string computerChoice = "";

            while (keepPlaying)
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("Type rock, paper, or scissors to play. Good luck!");
                    playerChoice = Console.ReadLine().ToLower();

                    if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
                    {
                        Console.WriteLine("Invalid choice. Press any key to type again...");
                        Console.ReadKey();
                    }
                } while (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors");

                int randNum = random.Next(1, 4);  
                switch (randNum)
                {
                    case 1:
                        computerChoice = "rock";
                        break;
                    case 2:
                        computerChoice = "paper";
                        break;
                    case 3:
                        computerChoice = "scissors";
                        break;
                }

                Console.WriteLine($"\nYou chose {playerChoice}");
                Console.WriteLine($"The computer chose {computerChoice}");

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((playerChoice == "rock" && computerChoice == "scissors") ||
                         (playerChoice == "paper" && computerChoice == "rock") ||
                         (playerChoice == "scissors" && computerChoice == "paper"))
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("Computer wins!");
                }

                Console.WriteLine("\nDo you want to play again? (y/n)");
                string answer = Console.ReadLine().ToLower();
                if (answer != "y" && answer != "yes")
                {
                    keepPlaying = false;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}
