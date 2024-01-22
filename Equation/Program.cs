﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Calcul des solutions de l'équation quadratique ax^2 + bx + c = 0");

//saisi a,b et c
Console.Write("Entrez la valeur de a : ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez la valeur de b : ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez la valeur de c : ");
double c = Convert.ToDouble(Console.ReadLine());

double discriminant = b * b - 4 * a * c;

if (discriminant > 0)
{
    double racinePos = (-b + Math.Sqrt(discriminant)) / (2 * a);
    double racineNeg = (-b - Math.Sqrt(discriminant)) / (2 * a);

    Console.WriteLine($"Les solutions de l'équation sont : {racinePos} et {racineNeg}");
}

else if (discriminant == 0)
{
    double racineUnique = -b / (2 * a);
    Console.WriteLine($"L'équation n'a qu'une solution : {racineUnique}");
}

else
{
    Console.WriteLine("L'équation n'a pas de solution réelle.");
}

Console.ReadLine();

    