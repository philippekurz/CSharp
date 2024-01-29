using System;

namespace TPCalc
{
    public class Calculatrice
    {
        public decimal Addition(decimal a, decimal b)
        {
            return a+b;
        }
        public decimal Soustraction(decimal a, decimal b)
        {
            return a-b;
        }
        public decimal Multiplication(decimal a, decimal b)
        {
            return a*b;
        }
        public decimal Division(decimal a, decimal b)
        {
            if (b == 0) return 0;
            else return a/b;
        }
        public decimal Modulo(decimal a, decimal b)
        {
            if (b == 0) return 0;
            else return a%b;
        }

    }
}