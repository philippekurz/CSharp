using Calc;

Calculatrice calc1 = new Calculatrice();
Calculatrice calc2 = new Calculatrice(10, 30);

calc2.Additionner();
Console.WriteLine($"Résultat de l'addition : {calc2.Resultat}");

calc1.Nb1 = 5;
calc1.Nb2 = 10;
calc1.Additionner();
Console.WriteLine($"Résultat de l'addition : {calc1.Resultat}");