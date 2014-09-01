using System;

namespace ISOConverter
{
    class Vector
    {
        // À la création du nouveau vecteur, on assigne les valeurs attribuées par l'utilisateur
        // Par défaut ces valeurs sont nulles
        public Vector(int x = 0, int y = 0)
        { 
            this.X = x;
            this.Y = y; 
        }

        // Paramètre de position X du vecteur
        public int X
        { get; set; }

        // Paramètre de position Y du vecteur
        public int Y
        { get; set; }

        // Retour de type string de la position globale
        public string ToString()
        { return "{" + X.ToString() + ";" + Y.ToString() + "}"; }

        // Retour de type booléen du test d'équivalence entre deux vecteurs
        public bool Equals(Vector Vector)
        {
            // Si le paramètre X du premier vecteur est identique au second
            // Et que le paramètre Y du premier vecteur est identique au second
            // Alors on retourne Vrai sinon, le test est faux et on retourne Faux
            if (Vector.X.Equals(X) && Vector.Y.Equals(Y))
                return true;
            else
                return false;
        }
    }
}
