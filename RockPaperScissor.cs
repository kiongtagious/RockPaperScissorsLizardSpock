using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blahblah
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputPlayer, inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {


                    Console.Write("Choose between ROCK, PAPER, SCISSORS, LIZARD, OR SPOCK:    ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1,4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!! PAPER COVERS ROCK!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!! ROCK CRUSHES SCISSORS!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "LIZARD")
                            {
                                Console.WriteLine("CPU WINS!! ROCK CRUSHES LIZARD!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SPOCK")
                            {
                                Console.WriteLine("PLAYER WINS!! SPOCK VAPORIZES ROCK!\n\n");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!! PAPER COVERS ROCK!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!! SCISSORS CUTS PAPER!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "LIZARD")
                            {
                                Console.WriteLine("PLAYER WINS!! LIZARD EATS PAPER!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SPOCK")
                            {
                                Console.WriteLine("CPU WINS!! PAPER DISPROVES SPOCK!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!! ROCK CRUSHES SCISSORS!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!! SCISSORS CUTS PAPER!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SPOCK")
                            {
                                Console.WriteLine("PLAYER WINS!! SPOCK SMASHES SCISSORS!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "LIZARD")
                            {
                                Console.WriteLine("CPU WINS!! SCISSORS DECAPITATES LIZARD!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                        case 4:
                            inputCPU = "LIZARD";
                            Console.WriteLine("Computer chose LIZARD");
                            if (inputPlayer == "LIZARD")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!! ROCK CRUSHES LIZARD!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!! LIZARD EATS PAPER!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!! SCISSORS DECAPITATES LIZARD!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SPOCK")
                            {
                                Console.WriteLine("CPU WINS!! LIZARD POISONS SPOCK!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                        case 5:
                            inputCPU = "SPOCK";
                            Console.WriteLine("Computer chose SPOCK");
                            if (inputPlayer == "SPOCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!! SPOCK VAPORIZES ROCK\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!! PAPER DISPROVES SPOCK!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!! SPOCK SMASHES SCISSORS!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "LIZARD")
                            {
                                Console.WriteLine("PLAYER WINS!! LIZARD POISONS SPOCK!\n\n");
                                scorePlayer++;
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);

                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!");
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {

                }

            }
        }
    }
}






