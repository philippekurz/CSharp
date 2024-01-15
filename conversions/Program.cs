// See https://aka.ms/new-console-template for more information
Console.WriteLine("Conversions!");

int i = 42;
string s = i.ToString();

//Console.WriteLine(s);

string s2 = "1234";
// Convertir une chaîne en entier

int i2 = int.Parse(s2);

// Convertir une chaîne en float
string sf = "1234,56";
float f = float.Parse(sf);

string chaine123 = "123";
int i123 = Convert.ToInt32(chaine123);

Console.Write("Entrez votre age : ");
string input = Console.ReadLine();
int age = int.Parse(input);
int annee = 2024 - age;
Console.WriteLine($"Vous êtes né en {annee}.");