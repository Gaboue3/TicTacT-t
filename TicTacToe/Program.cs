using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finJeu = false;
            while (finJeu == false)
            {
                Console.Clear();
                char[] plancheJeu = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
                int compteur = 0;
                char joueur = 'X';
                
                Console.WriteLine("Voulez vous jouer avec Quelqun(1) ou contre l'IA(2)?");
                int choix1 = Convert.ToInt32(Console.ReadLine());
                bool fin = false;
                while (fin == false)
                {
                    if (choix1 == 1)
                    {
                        jouerSansBot();
                    }
                    else
                    {
                        jouerAvecBot();
                    }
                }



                void jouerSansBot()
                {
                    Console.Clear();
                    afficherGrille();
                    tourJoueur();
                    determinerGagnant();
                    changerJoueur(joueur);
                }
                void jouerAvecBot()
                {
                    Console.Clear();
                    afficherGrille();
                    tourJoueur();
                    determinerGagnant();
                    changerJoueur(joueur);
                    tourDuBot();
                    determinerGagnant();
                    changerJoueur(joueur);
                }
                void afficherGrille()
                {
                    Console.WriteLine("[ " + plancheJeu[0] + "] " + "[ " + plancheJeu[1] + "] " + "[ " + plancheJeu[2] + "] ");
                    Console.WriteLine("[ " + plancheJeu[3] + "] " + "[ " + plancheJeu[4] + "] " + "[ " + plancheJeu[5] + "] ");
                    Console.WriteLine("[ " + plancheJeu[6] + "] " + "[ " + plancheJeu[7] + "] " + "[ " + plancheJeu[8] + "] ");
                }
                void tourJoueur()
                {
                    Console.WriteLine("Entrer la case a jouer");
                    int choix2 = Convert.ToInt32(Console.ReadLine());
                    plancheJeu[choix2] = joueur;
                }
                void determinerGagnant()
                {
                    if (plancheJeu[0] == joueur && plancheJeu[1] == joueur && plancheJeu[2] == joueur)
                    {
                        Console.Clear();
                        Console.WriteLine("Les " + joueur + " onts gagnes!");
                        Console.ReadKey();
                        fin = true;
                    }
                    else if (plancheJeu[3] == joueur && plancheJeu[4] == joueur && plancheJeu[5] == joueur)
                    {
                        Console.Clear();
                        Console.WriteLine("Les " + joueur + " onts gagnes!");
                        Console.ReadKey();
                        fin = true;
                    }
                    else if (plancheJeu[6] == joueur && plancheJeu[7] == joueur && plancheJeu[8] == joueur)
                    {
                        Console.Clear();
                        Console.WriteLine("Les " + joueur + " onts gagnes!");
                        Console.ReadKey();
                        fin = true;
                    }
                    else if (plancheJeu[0] == joueur && plancheJeu[4] == joueur && plancheJeu[8] == joueur)
                    {
                        Console.Clear();
                        Console.WriteLine("Les " + joueur + " onts gagnes!");
                        Console.ReadKey();
                        fin = true;
                    }
                    else if (plancheJeu[2] == joueur && plancheJeu[4] == joueur && plancheJeu[6] == joueur)
                    {
                        Console.Clear();
                        Console.WriteLine("Les " + joueur + " onts gagnes!");
                        Console.ReadKey();
                        fin = true;
                    }
                    else if (plancheJeu[0] == joueur && plancheJeu[3] == joueur && plancheJeu[6] == joueur)
                    {
                        Console.Clear();
                        Console.WriteLine("Les " + joueur + " onts gagnes!");
                        Console.ReadKey();
                        fin = true;
                    }
                    else if (plancheJeu[1] == joueur && plancheJeu[4] == joueur && plancheJeu[7] == joueur)
                    {
                        Console.Clear();
                        Console.WriteLine("Les " + joueur + " onts gagnes!");
                        Console.ReadKey();
                        fin = true;
                    }
                    else if (plancheJeu[2] == joueur && plancheJeu[5] == joueur && plancheJeu[8] == joueur)
                    {
                        Console.Clear();
                        Console.WriteLine("Les " + joueur + " onts gagnes!");
                        Console.ReadKey();
                        fin = true;
                    }
                    if (compteur == 8)
                    {
                        Console.Clear();
                        Console.WriteLine("DRAW");
                        Console.ReadKey();
                        fin = true;
                    }
                    compteur++;
                }
                void changerJoueur(char _joueurActuelle)
                {
                    if (_joueurActuelle == 'X')
                    {
                        joueur = 'O';
                    }
                    else
                    {
                        joueur = 'X';
                    }
                }
                void tourDuBot()
                {
                    Random alea = new Random();
                    int choix = alea.Next(0, 8);
                    bool tourIA = false;
                    while (tourIA == false)
                    {
                        if (plancheJeu[choix] != 'X' && plancheJeu[choix] != 'O')
                        {
                            plancheJeu[choix] = joueur;
                            tourIA = true;
                        }
                    }
                }
                Console.Clear();
                Console.WriteLine("Souhaitez vous rejouer? 1-Oui 2-Non");
                int choixfinale = Convert.ToInt32(Console.ReadLine());
                if (choixfinale == 1)
                {

                }
                else
                {
                    finJeu = true;
                }
            }

        }
           
    }
}
