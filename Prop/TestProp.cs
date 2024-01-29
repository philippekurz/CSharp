using System;

namespace Prop
{
    public class TestProp
    {
        // data = membre de la classe
        private decimal nb1;
        private decimal nb2 = 20;

        public decimal Nb1{
            get {   // Accesseur en lecture
                return nb1;
            }
            set {   // Accesseur en écriture   
                nb1 = value;
            }
        }   // Propriété Nb1
        public decimal Nb2{   // Propriété Nb2
            get {   // Accesseur en lecture
                return nb2;
            }
            set {   // Accesseur en écriture   
                if (value == 0)
                    throw new Exception("Erreur : Risque de division par zéro");
                else
                    nb2 = value;
            }            
        } 
        public decimal Somme()
        {
            return Nb1+Nb2;
        }
        public decimal Quotient()
        {
            return Nb1/Nb2;
        }
    }
}
