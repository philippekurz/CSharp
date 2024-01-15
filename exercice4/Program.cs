using System;
Console.WriteLine("Veillez rentrer votre nom :");
string nom = Console.ReadLine();
Console.WriteLine("Veillez rentrer votre age :");
string age = Console.ReadLine();
string texte = $"Bonjour, {nom} a {age}";
Console.WriteLine(texte);