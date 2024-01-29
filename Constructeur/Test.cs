namespace Constructeur
{
    public class Test
    {
        private decimal nb1;
        private decimal nb2;

        public decimal Nb1 {   // Propriété Nb1
            get {   // Accesseur en lecture
                return nb1;
            }
            set {   // Accesseur en écriture   
                nb1 = value;
            }
        }
        public Test(decimal p1, decimal p2)
        {
            Nb1 = p1;
            this.nb2 = p2; // this = objet courant
        }

    }
}