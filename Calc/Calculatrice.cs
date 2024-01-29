namespace Calc
{
    public class Calculatrice
    {
        // membres privés
        private decimal _nb1;
        private decimal _nb2;
        private decimal _resultat;

        public Calculatrice() // Constructeur par défaut
        {
            _nb1 = 0;
            _nb2 = 0;
            _resultat = 0;
        }
        public Calculatrice(decimal nb1, decimal nb2)  // Constructeur surchargé
        {
            _nb1 = nb1;
            _nb2 = nb2;
            _resultat = 0;
        }

        // Propriétés publiques
        public decimal Nb1  // Propriété Read/Write
        {
            get { return _nb1; }
            set { _nb1 = value; }
        }

        public decimal Nb2
        {
            get { return _nb2; }
            set { _nb2 = value; }
        }

        public decimal Resultat // Propriété Read Only
        {
            get { return _resultat; }
        }

        public void Additionner()
        {
            _resultat = _nb1 + _nb2;
        }

    }
}
