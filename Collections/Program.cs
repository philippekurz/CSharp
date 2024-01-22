// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Collections!");

// Syntaxe générique
//type[] nomDuTableau = new type[tailleDuTableau];

// Exemple
/*
int[] tableauEntiers = new int[5];
tableauEntiers[0] = 11;  // Elément 0 du tableau (premier élément)
tableauEntiers[1] = 21;
tableauEntiers[2] = 15;
tableauEntiers[3] = 7;
tableauEntiers[4] = 101;
*/

int[] tableauEntiers = new int[] {11, 21, 15, 7, 101};

string[] tableauChaines = new string[] {"Bonjour", "à", "tous"};

string[] mois = new string[] {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet",  "Août", "Septembre", "Octobre", "Novembre", "Décembre"};

Console.WriteLine(mois[0]); // Affiche "Janvier"
//01/12/2024 -> 01 janvier 2024
//Console.WriteLine(jour + " " + mois[mois-1] + " " + annee);

Console.WriteLine("<select>"); 
for (int i = 0; i < mois.Length; i++)
{
    //Console.WriteLine($"<option value = {i+1}>{mois[i]}</option>");
}
Console.WriteLine("</select>"); 

// Les Listes

// Syntaxe générique
// List<type> nomDeLaListe = new List<type>();

// Exemple
List<int> listeEntiers = new List<int>();
listeEntiers.Add(11);
listeEntiers.Add(21);
listeEntiers.Add(15);

//Console.WriteLine(listeEntiers[0]); // Affiche 11
//Console.WriteLine(listeEntiers[1]); // Affiche 11
//Console.WriteLine(listeEntiers[2]); // Affiche 11
//listeEntiers.Remove(21);
//listeEntiers.RemoveAt(0);
listeEntiers.Reverse();
Console.WriteLine($"{listeEntiers.Count} éléments dans la liste"); // Affiche 3
listeEntiers.Insert(0, 121);
for (int i = 0; i < listeEntiers.Count; i++)
{
    Console.WriteLine(listeEntiers[i]);
}

//Console.WriteLine(listeEntiers.Contains(121)); // Affiche True
