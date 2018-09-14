using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            int intelligence = 0;
            int choix = 0;
            Console.WriteLine("la magnifique et adorable princesse peach s'est une fois de plus faite kidnappée par le mechant et sournoix browser , mario  part à sa rescousse et compte sur vous pour l'aider dans ce sauvetage risqué dans la taniere de browser. Pour une debut il doit se choisir un coequiper taper 1 pour LUIGI OU 2 POUR YOSHI");
            choix = int.Parse(Console.ReadLine());
            if (choix == 1)
            {
                Console.WriteLine("mario y va avec luigi au royaume de browser sauver la princesse peach; si tu preferes  qu'ils y aillent en sautant tape 1 ou qu'ils y aillent sur un nuage magique tape 2");
                choix = int.Parse(Console.ReadLine());
                if (choix == 1)
                {
                    Console.WriteLine("arrivant au royaume de browser ils croisent des Bumps de browser  enragés . Que faire ? tape 1 pour tous les buté ou tape 2 pour tous les evité");
                    choix = int.Parse(Console.ReadLine());
                    if (choix == 1)
                    {
                        Console.WriteLine("ils les ont tous butés et maintenant ils voient une superfleurs apparetre devant eux. quel est selon toi leur  quotient intellectuel  ?");
                        intelligence = int.Parse(Console.ReadLine());
                    }
                    else if (choix == 2)
                    {
                        Console.WriteLine("ils les ont tous evités et ont trouvé une superfleur . quel est selon toi le quotient intellectuel leur quotient intellectuel?");
                        intelligence = int.Parse(Console.ReadLine());

                    }
                }
                else if (choix == 2)
                {
                    Console.WriteLine("arrivant au royaume de browser ils croisent des Bumps de browser  enragés . Que faire ? tape 1 pour tous les buté ou tape 2 pour tous les evité");
                    choix = int.Parse(Console.ReadLine());
                    if (choix == 1)
                    {
                        Console.WriteLine("ils les ont tous butés et maintenant ils voient une superfleurs apparetre devant eux. quel est selon toi leur  quotient intellectuel  ?");
                        intelligence = int.Parse(Console.ReadLine());
                    }
                    else if (choix == 2)
                    {
                        Console.WriteLine("ils les ont tous evités et ont trouvé une superfleur . quel est selon toi le quotient intellectuel leur quotient intellectuel?");
                        intelligence = int.Parse(Console.ReadLine());

                    }

                }


            }
            else if (choix == 2)//va avec yoshi
            {
                Console.WriteLine("mario y va avec yoshi au royaume de browser sauver la princesse peach; si tu preferes  qu'ils y aillent en sautant tape 1 ou qu'ils y aillent sur un nuage magique tape 2");
                choix = int.Parse(Console.ReadLine());
                if (choix == 1)
                {
                    Console.WriteLine("arrivant au royaume de browser ils croisent des Bumps de browser  enragés . Que faire ? tape 1 pour tous les buté ou tape 2 pour tous les evité");
                    choix = int.Parse(Console.ReadLine());
                    if (choix == 1)
                    {
                        Console.WriteLine("ils les ont tous butés et maintenant ils voient une superfleurs apparetre devant eux. quel est selon toi leur  quotient intellectuel  ?");
                        intelligence = int.Parse(Console.ReadLine());
                    }
                    else if (choix == 2)
                    {
                        Console.WriteLine("ils les ont tous evités et ont trouvé une superfleur . quel est selon toi le quotient intellectuel leur quotient intellectuel?");
                        intelligence = int.Parse(Console.ReadLine());

                    }
                }
                else if (choix == 2)
                {
                    Console.WriteLine("arrivant au royaume de browser ils croisent des Bumps de browser  enragés . Que faire ? tape 1 pour tous les buté ou tape 2 pour tous les evité");
                    choix = int.Parse(Console.ReadLine());
                    if (choix == 1)
                    {
                        Console.WriteLine("ils les ont tous butés et maintenant ils voient une superfleurs apparetre devant eux. quel est selon toi leur  quotient intellectuel  ?");
                        intelligence = int.Parse(Console.ReadLine());
                    }
                    else if (choix == 2)
                    {
                        Console.WriteLine("ils les ont tous evités et ont trouvé une superfleur . quel est selon toi le quotient intellectuel leur quotient intellectuel?");
                        intelligence = int.Parse(Console.ReadLine());

                    }

                }

            }
            if (intelligence > 10)
            {
                Console.WriteLine("ils ont pris la super fleurs . et son face a browser.que faire ? taper 1 pour lancer des boules de feu  ou 2 pour faire tomber du tonnerre sur la tete de browser");
                choix = int.Parse(Console.ReadLine());
                if (choix == 1)
                {
                    Console.WriteLine("browser est brulé et s'evanouit .que faire ? taper 1  pour le tuer definitivement ou 2 pour l'emprisonner a tout jamais ");
                    choix = int.Parse(Console.ReadLine());
                    if (choix == 1)
                    {
                        Console.WriteLine("felicitation  tu as sauvé ce royaume ");
                    }
                    else if (choix == 2)

                    {
                        Console.WriteLine("felicitation hero au grand coeur  , tu as sauvé ce  royaume");

                    }
                }
                else if (choix == 2)
                {
                    Console.WriteLine("browser est foudroye et sevanouit .que faire ? taper 1  pour le tuer definitivement ou 2 pour l'emprisonner a tout jamais  ");
                    choix = int.Parse(Console.ReadLine());
                    if (choix == 1)
                    {
                        Console.WriteLine("felicitation  tu as sauvé ce royaume ");
                    }
                    else if (choix == 2)

                    {
                        Console.WriteLine("felicitation hero au grand coeur  , tu as sauvé ce  royaume");

                    }
                }
            }
            else if (intelligence <= 10)
            {
                Console.WriteLine("ils pas pris la super fleurs . et son face a browser.que faire ? taper 1 pour lancer des parpings   ou 2 pour poignarder Browser");
                choix = int.Parse(Console.ReadLine());
                if (choix == 1)
                {
                    Console.WriteLine("browser  s'evanouit .que faire ? taper 1  pour le tuer definitivement ou 2 pour l'achever ");
                    choix = int.Parse(Console.ReadLine());
                    if (choix == 1)
                    {
                        Console.WriteLine("felicitation  tu as sauvé ce royaume ");
                    }
                    else if (choix == 2)
                        Console.WriteLine("felicitation hero au grand coeur  , tu as sauvé ce  royaume");

                    {
                        Console.WriteLine("felicitation hero au grand coeur  , tu as sauvé ce  royaume");

                    }
                }
                else if (choix == 2)
                {
                    Console.WriteLine("browser est poignader  par mario , commence a se vider de son sang  et sevanouit .que faire ? taper 1  pour le tuer definitivement ou 2 pour l'emprisonner a tout jamais  ");
                    choix = int.Parse(Console.ReadLine());
                    if (choix == 1)
                    {
                        Console.WriteLine("felicitation  tu as sauvé ce royaume ");
                    }
                    else if (choix == 2)

                    {
                        Console.WriteLine("felicitation hero au grand coeur  , tu as sauvé ce  royaume");

                    }

                }
            }


            Console.ReadKey();




        }
    }
}
