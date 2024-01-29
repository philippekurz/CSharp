﻿using TPCalc;

// Class = Calculatrice (=type)
// Objet = calc
Calculatrice calc = new Calculatrice();
int a = 13;


decimal a = 13.4m;
decimal b = 10;

Console.WriteLine(calc.Addition(a,b));
Console.WriteLine(calc.Soustraction(a,b));
Console.WriteLine(calc.Multiplication(a,b));
Console.WriteLine(calc.Division(a,b));
Console.WriteLine(calc.Modulo(a,b));