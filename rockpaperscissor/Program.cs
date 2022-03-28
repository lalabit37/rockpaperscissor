// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace gameTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int restart = 1; 

            while (restart == 1)
            {
                
                int pointA = 0;
                int pointB = 0;
                int i = 0;
                Console.WriteLine("*** Welcome to Rock Paper Scissors Lizard Spock Game ***");
                Console.WriteLine();

                do
                {
                    int r = i + 1;
                    Console.WriteLine();
                    Console.WriteLine("=======================================================================");
                    Console.WriteLine("ROUND" + r);
                    Console.WriteLine("=======================================================================");
                    Console.WriteLine();
                    Console.WriteLine("Choose your weapon:\n1->Rock\n2->Paper\n3->Scissors\n4->Lizard\n5->Spock");
                    Console.WriteLine("Enter 1,2,3,4 or 5");
                    Console.WriteLine("*You will lose one round if entering invalid input");
                    Console.WriteLine();
                    Console.WriteLine("Enter your choice Player A:");
                    string playerA = Console.ReadLine();
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                    Console.WriteLine("Enter your choice Player B:");
                    string playerB = Console.ReadLine();
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);


                    if (playerA == "3" && playerB == "2")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Scissors cuts Paper");
                        Console.WriteLine("Player A WIN!");
                        pointA += 1;
                    }
                    else if (playerA == "2" && playerB == "1")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Paper covers Rock");
                        Console.WriteLine("Player A WIN!");
                        pointA += 1;
                    }
                    else if (playerA == "1" && playerB == "4")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Rock crushes Lizard");
                        Console.WriteLine("Player A WIN!");
                        pointA += 1;
                    }
                    else if (playerA == "4" && playerB == "5")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Lizard poisons Spock");
                        Console.WriteLine("Player A WIN!");
                        pointA += 1;
                    }
                    else if (playerA == "5" && playerB == "1")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Spock smashes Scissors");
                        Console.WriteLine("Player A WIN!");
                        pointA += 1;
                    }
                    else if (playerA == "3" && playerB == "4")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Scissors decapitates Lizard");
                        Console.WriteLine("Player A WIN!");
                        pointA += 1;
                    }
                    else if (playerA == "4" && playerB == "2")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Lizard eats Paper");
                        Console.WriteLine("Player A WIN!");
                        pointA += 1;
                    }
                    else if (playerA == "2" && playerB == "5")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Paper disproves Spock");
                        Console.WriteLine("Player A WIN!");
                        pointA += 1;
                    }
                    else if (playerA == "5" && playerB == "1")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Spock vaporizes Rock");
                        Console.WriteLine("Player A WIN!");
                        pointA += 1;
                    }
                    else if (playerA == "1" && playerB == "3")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Rock crushes Scissors");
                        Console.WriteLine("Player A WIN!");
                        pointA += 1;
                    }
                    else if (playerB == "3" && playerA == "2")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Scissors cuts Paper");
                        Console.WriteLine("Player B WIN!");
                        pointB += 1;
                    }
                    else if (playerB == "2" && playerA == "1")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Paper covers Rock");
                        Console.WriteLine("Player B WIN!");
                        pointB += 1;
                    }
                    else if (playerB == "1" && playerA == "4")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Rock crushes Lizard");
                        Console.WriteLine("Player B WIN!");
                        pointB += 1;
                    }
                    else if (playerB == "4" && playerA == "5")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Lizard poisons Spock");
                        Console.WriteLine("Player B WIN!");
                        pointB += 1;
                    }
                    else if (playerB == "5" && playerA == "1")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Spock smashes Scissors");
                        Console.WriteLine("Player B WIN!");
                        pointB += 1;
                    }
                    else if (playerB == "3" && playerA == "4")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Scissors decapitates Lizard");
                        Console.WriteLine("Player B WIN!");
                        pointB += 1;
                    }
                    else if (playerB == "4" && playerA == "2")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Lizard eats Paper");
                        Console.WriteLine("Player B WIN!");
                        pointB += 1;
                    }
                    else if (playerB == "2" && playerA == "5")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Paper disproves Spock");
                        Console.WriteLine("Player B WIN!");
                        pointB += 1;
                    }
                    else if (playerB == "5" && playerA == "1")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Spock vaporizes Rock");
                        Console.WriteLine("Player B WIN!");
                        pointB += 1;
                    }
                    else if (playerB == "1" && playerA == "3")
                    {
                        Console.WriteLine("**********");
                        Console.WriteLine("Player A chose " + playerA);
                        Console.WriteLine("Player B chose " + playerB);
                        Console.WriteLine("**********");
                        Console.WriteLine("Rock crushes Scissors");
                        Console.WriteLine("Player B WIN!");
                        pointB += 1;
                    }
                    else if (playerA == playerB)
                    {
                        Console.WriteLine("It is a draw");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Input");
                    }

                    i++;
                }
                while (i < 5);

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Total Point Player A: " + pointA);
                Console.WriteLine("Total Point Player B: " + pointB);

                if (pointA > pointB)
                {
                    Console.WriteLine();
                    Console.WriteLine("######################");
                    Console.WriteLine("Congrats Player A");
                    Console.WriteLine("You are the Winner!!!");
                    Console.WriteLine("######################");
                }
                else if (pointA < pointB)
                {
                    Console.WriteLine();
                    Console.WriteLine("######################");
                    Console.WriteLine("Congrats Player B");
                    Console.WriteLine("You are the Winner!!!");
                    Console.WriteLine("######################");
                }
                else
                { 
                    Console.WriteLine();
                    Console.WriteLine("######################");
                    Console.WriteLine("0-0 It's a Draw!!!");
                    Console.WriteLine("######################");                  
                }

                Console.WriteLine();
                Console.WriteLine("Play again? (Enter 1 or 2)");
                Console.WriteLine("1. Yes\n2. No");
                Console.ReadLine();

            }
            
        }
    }
}
