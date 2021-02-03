// Mon premier programme C#
using System;


class Program
{​​​​​​
    static void Main()
    {​​​​​​
        TestDeValeurs();

        Console.WriteLine("Appuyer sur une touche pour continuer");
        Console.ReadKey();
    }​​​​​​
 
    static void TestDeBase()
    {​​​​​​
        // WrtieLine inclue le changement de ligne
        Console.WriteLine("Bonjour tout le monde");

        Console.WriteLine("Appuyer sur une touche pour continuer");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("Bienvenue au cours de\nProgrammation Orientée Objet");

        //Types de bases
        int entier = 12;
        double nombreReel = 34.56;
        char caractere = 'C';
        bool booleen = true;
        //Types complexes
        string chaineDeCaracteres = "Bonjour";
        //Constantes
        const double Pi = 3.1416;

        // C + W + TAB + TAB = Console.WriteLine
        Console.WriteLine("Entier: " + entier + " réel: " + nombreReel + ", caractère: " + caractere
        + ", booléen: " + booleen + ", chaine: " + chaineDeCaracteres);

        Console.WriteLine("Entier: {​​​​​​0}​​​​​​, réel: {​​​​​​1}​​​​​​, chaineDeCaracteres: {​​​​​​2}​​​​​​, l'entier est toujours: {​​​​​​0}​​​​​​",
            /*position 0*/entier, /*1*/nombreReel, /*2*/chaineDeCaracteres);

        //Lecture de la console
        Console.Write("Entrez du texte: ");
        string lecture = Console.ReadLine();
        Console.WriteLine("Texte: \"" + lecture + "\"");

        ;
    }​​​​​​
 
    //Lit une chaîne de caractère et retourne sa conversion en entier
    static int ObtenirEntier(int min, int max)
    {​​​​​​
        Console.WriteLine("Entrez un entier entre " + min + " et " + max + ": ");
        string ligne = Console.ReadLine();

        //On ne valide pas les erreurs, le programme va planter si l'utilisateur ne donne pas un entier
        return Convert.ToInt32(ligne);
    }​​​​​​
 
    static void TestDeControles()
    {​​​​​​
        const int Min = 1;
        const int Max = 10;

        for (int i = 0; i < 2; ++i)
        {​​​​​​
            Console.WriteLine("Tentative " + i + 1 + "/2");

            while (true)
            {​​​​​​
                int entier = ObtenirEntier(Min, Max);
                if (entier >= Min && entier <= Max)
                {​​​​​​
                    switch (entier)
                    {​​​​​​
                       case 1:
                                Console.WriteLine("Un");
                        break;
                        case 2: 
                                Console.WriteLine("Deux");
                        break;
                        case 3:
                                Console.WriteLine("Trois");
                        break;
                        
                                Console.WriteLine("Quatre");
                        break;
                        default:
                                Console.WriteLine("Autre valeur");
                        break;
                    }
                }​​​​​​
                else
            {​​​​​​
                    Console.WriteLine("Valeur incorrect, esseyez de nouveau");
            }​​​​​​
            
        }​​​​​​
 
        Console.Write("entrez un chiffre textuellement: ");
        string chiffreEnTexte = Console.ReadLine();
 
        switch (chiffreEnTexte)
        {​​​​​​
 
            // Un case doit absolumentavoir un break si une instruction est executée
            case "un":
            case "Un":
                Console.WriteLine("Le chiffre est 1");
                break;
            case "deux":
            case "Deux":
                Console.WriteLine("Le chiffre est 1");
                break;
            case "trois":
            case "Trois":
                Console.WriteLine("Le chiffre est 1");
                break;
            default:
                Console.WriteLine("Chiffre inconnu");
                break;
        }​​​​​​
    }​​​​​​
}
 
 static void TestDeValeurs()
{​​​​​​
    int nombre1 = 10;
    int nombre2 = 20;
    int nombre3 = 30;

    //ObtenirValeurs(nombre1, nombre2, nombre3);
    Console.WriteLine("Valeurs d'origine: " + nombre1 + ", " + nombre2 + ", " + nombre3);

    ModifierValeurs(ref nombre1, ref nombre2, ref nombre3);
    Console.WriteLine("Valeurs modifiées: " + nombre1 + ", " + nombre2 + ", " + nombre3);
}​​​​​​
 

    static void ModifierValeurs(ref int valeur1, ref int valeur2, ref int valeur3)
{​​​​​​
        valeur1 = valeur2 * 5;
    valeur2 += 100;
    valeur3 = (valeur2 + 3) % 7;

}​​​