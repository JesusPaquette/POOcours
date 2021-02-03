using System;

namespace tableau_et_nouvelle_matiere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            testChaineDeCaracteres();
        }
        static void tableau()
        {
            int[] tab = { 1, 2, 3, 4, 5, 6, 7 };
            for(int x = 0; x < 7; x++)
            {
                Console.WriteLine(tab[x]);
            }
            for (int x = 0; x < 7; x++)
            {
                Console.Write(tab[x] + ", ");
            }
            Console.WriteLine();//changer de ligne
            //for each 
            foreach (int item in tab)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();//changer de ligne
            //tableau de string
            string[] nomsMois = { "Janvier", "Fevrier", "mars","mai" };
            Console.WriteLine("le 2e mosi est : " + nomsMois[1]);
            nomsMois[3] = "avril";
            foreach (string item in nomsMois)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
        static void testChaineDeCaracteres()
        {
            string maChaine = "bonjour";
            // lengnt est disponnible pour les strings
            Console.WriteLine("Longueur de la chaine: " + maChaine.Length + "Le premier caractere est: " +
                maChaine[0] + ", LE DERNier est : " + maChaine[maChaine.Length - 1]);
            foreach (char item in maChaine)
            {
                Console.WriteLine(item);
            }
            //maChaine[1] = 'a'; impossible
            maChaine = "ceci est ";//peut changer la valeur au complet cest tout
            maChaine += "un test ";//peut ajouter comme sa "ceci est un test"
            maChaine += 't';// += fonctionne mais va toujours ajouter juste a la fin

            string[] mots = maChaine.Split(' ');
            foreach (string item in mots)
            {
                Console.WriteLine(item);
            }
            maChaine = "               Une chaine de caracteres avec des espace avant et apres.             ";
            Console.WriteLine("chaine original: \"{0}\"", maChaine);
            //trimstart
            //trimEnd
            //enleve espace debut ou fin
            maChaine.Trim();
            Console.WriteLine("chaine sans espace: \"{0}\"", maChaine);
            maChaine = maChaine.Trim();
            Console.WriteLine("chaine sans espace(pris2): \"{0}\"", maChaine);

            string aChercher = "une";
            if (maChaine.Contains(aChercher))
            {
                Console.WriteLine("contien :" + aChercher);
                if (maChaine.StartsWith(aChercher))
                {
                    Console.WriteLine("la chaine debut par :" + aChercher);
                }
                else
                {
                    Console.WriteLine("la chaine ne debut pas par :" + aChercher);
                }
            }
            else
            {
                Console.WriteLine("ne contient pas :" + aChercher);
            }
        }
        
    }
}
