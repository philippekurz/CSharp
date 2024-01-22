﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Présentation
Console.WriteLine("Bonjour et bienvenue dans le jeu : 'Devine quelle nombre je suis !'");
const int MAX = 1000;

// Création de la variable random
Random rnd = new Random();
int variable_mystere = rnd.Next(0, MAX);

// Création des variables
bool trouver = false;
int nb_essais = 1;
string nombre = "0";
int nombre_choisi = 0;
int plus_petit = 0;
int plus_grand = 1000;

List<int> nombresProposes = new List<int>();


// Boucle
while (!trouver)
{

    Console.WriteLine("Nombres déjà proposés : " + string.Join(", ", nombresProposes));

    Console.WriteLine("Veuiller rentrer un nombre entre 0 et 1000 :");
    nombre = Console.ReadLine();

    if (int.TryParse(nombre, out nombre_choisi))
    {
        // Vérifier si le nombre a déjà été proposé
        if (nombresProposes.Contains(nombre_choisi))
        {
        Console.WriteLine($"Vous avez déjà proposé le nombre {nombre_choisi}. Essayez à nouveau.");
        continue; // Revenir au début de la boucle
        }

        // Ajouter le nombre à la liste des nombres proposés
        nombresProposes.Add(nombre_choisi);

        switch (nombre_choisi)
        {
            case int n when (n > variable_mystere):
                nb_essais += 1;
                plus_grand = nombre_choisi;
                Console.WriteLine($"Le nombre est plus petit ! Il est entre {plus_petit} et {plus_grand}!");
                break;

            case int n when (n < variable_mystere):
                nb_essais += 1;
                plus_petit = nombre_choisi;
                Console.WriteLine($"Le nombre est plus grand ! Il est entre {plus_petit} et {plus_grand}!");
                break;

            case int n when (n == variable_mystere):
                Console.WriteLine($"Félicitations, vous avez trouvé le bon nombre soit {nombre_choisi} !");
                trouver = true;
                break;
        }
    }
}

Console.WriteLine($"Vous avez réussi en {nb_essais} essais !");
