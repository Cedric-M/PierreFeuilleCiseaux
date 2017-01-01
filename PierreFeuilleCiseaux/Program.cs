using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierreFeuilleCiseaux
{
    class Program
    {

        static void Main(string[] args)
        {
            RunGame();
        }

        private static void RunGame()
        {
            int userChoice;
            string userInput;
            bool restart = true;

            while(restart == true)
            {
                do
                {
                    Console.WriteLine("\nBonjour et Bienvenu dans le jeu du Shifumi (ou Pierre Feuille ciseaux) !\n");
                    Console.WriteLine("Veuillez entrer 1, 2 ou 3 (Respectivement pour Pierre / Feuille / Ciseaux)");

                    userInput = Console.ReadLine();
                    if (int.TryParse(userInput, out userChoice) == true)

                    {
                        // I) : User's turn 

                        //Next line is used for debug
                        //Console.WriteLine("Vous avez choisis {0}", userChoice);
                        switch (userChoice)
                        {
                            case 1:
                                Console.WriteLine("Vous avez choisis : Pierre\n");
                                break;
                            case 2:
                                Console.WriteLine("Vous avez choisis : Feuille\n");
                                break;
                            case 3:
                                Console.WriteLine("Vous avez choisis : Ciseaux\n");
                                break;
                        }


                        // II) : Bot's turn 

                        Random randomNumber = new Random();
                        int botChoice = randomNumber.Next(1, 3);  // 1 <= botChoice <= 3

                        //Next line is used for debug
                        //Console.WriteLine("Le bot a choisis {0}", botChoice);

                        //The Bot Part v2
                        switch (botChoice)
                        {
                            case 1:
                                Console.WriteLine("Le Bot a choisis : Pierre\n");
                                break;
                            case 2:
                                Console.WriteLine("Le Bot a choisis : Feuille\n");
                                break;
                            case 3:
                                Console.WriteLine("Le Bot a choisis : Ciseaux\n");
                                break;
                        }


                        // III) Result

                        if (userChoice == botChoice)
                        {
                            Console.WriteLine("Egalité, essayez encore !");
                        }

                        else if (userChoice == 1 && botChoice == 2 || userChoice == 2 && botChoice == 3 || userChoice == 3 && botChoice == 1)
                        {
                            Console.WriteLine("Dommage, le bot gagne pour cette fois !");
                            switch (botChoice)
                            {
                                case 1:
                                    Console.WriteLine("Explication :La pierre gagne face aux ciseaux. Elle les broie.\n");
                                    break;
                                case 2:
                                    Console.WriteLine("Explication : La feuille bat la pierre en l’enveloppant.\n");
                                    break;
                                case 3:
                                    Console.WriteLine("Explication : Les ciseaux l’emportent face à la feuille qu’ils coupent.\n");
                                    break;
                            }
                        }
                        else if (userChoice == 2 && botChoice == 1 || userChoice == 3 && botChoice == 2 || userChoice == 1 && botChoice == 3)
                        {
                            Console.WriteLine("Bravo, vous avez gagné !");
                            switch (botChoice)
                            {
                                case 1:
                                    Console.WriteLine("Explication : La feuille bat la pierre en l’enveloppant.\n");
                                    break;
                                case 2:
                                    Console.WriteLine("Explication : Les ciseaux l’emportent face à la feuille qu’ils coupent.\n");
                                    break;
                                case 3:
                                    Console.WriteLine("Explication :La pierre gagne face aux ciseaux. Elle les broie.\n");
                                    break;
                            }
                        }
                        

                        // IV) Restart

                        Console.WriteLine("\nSouhaitez-vous rejouer ? (y/n)");
                       
                        string playAgain = Console.ReadLine();

                        //Next line is used for debug
                        //Console.WriteLine("Vous avez tapé {0}", playAgain);

                        if (playAgain.Equals("y", StringComparison.OrdinalIgnoreCase))
                        {
                            restart = true;
                        }
                        else Environment.Exit(0);
                    }

                    else
                    {
                        //Next line is used for debug
                        //Console.WriteLine("Vous avez écrit {0}", userChoice);

                        Console.WriteLine("Ce choix n'est pas valide");
                    }

                } while (int.TryParse(userInput, out userChoice) != true);
            }              
        }
    }
}