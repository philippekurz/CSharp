﻿using TPCalc;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Calculatrice maCalculatrice = new Calculatrice();

decimal resultatAddition = maCalculatrice.Addition(10, 5);
Console.WriteLine($"Addition : {resultatAddition}");

decimal resultatSoustraction = maCalculatrice.Soustraction(1, 52);
Console.WriteLine("Soustraction : " + resultatSoustraction);

decimal resultatMultiplication = maCalculatrice.Multiplication(5, 3);
Console.WriteLine("Multiplication : " + resultatMultiplication);

decimal resultatDivision = maCalculatrice.Division(13, 2);
Console.WriteLine("Division : " + resultatDivision);

decimal resultatModulo = maCalculatrice.Modulo(8, 9);
Console.WriteLine("Modulo : " + resultatModulo);