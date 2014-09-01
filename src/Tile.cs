using System;
using System.Drawing;

namespace ISOConverter
{
    class Tile
    {
        private static Bitmap RotateBitmap_Returner(Bitmap Image, float Angle)
        {
            // Calcul des diagonales
            int Diagonale = Diagonale_Returner(Image);
            // Création du nouveau bitmap recepteur
            Bitmap bImage = new Bitmap(Diagonale, Diagonale);
            // Création du gestionaire graphique
            Graphics gImage = Graphics.FromImage(bImage);
            // Selection du milieu du bitmap comme origine de transformation
            gImage.TranslateTransform(Diagonale / 2, Diagonale / 2);
            // Rotation du bitmap tampon
            gImage.RotateTransform(Angle);
            // Déselection du milieu du bitmap
            gImage.TranslateTransform(-(float)Image.Width / 2, -(float)Image.Height / 2);
            // Dessin de l'image sur le bitmap
            gImage.DrawImage(Image, new Point(0, 0));
            // Retour de la fonction
            return bImage;
        }

        private static Bitmap ResizeBitmap_Returner(Bitmap Image, Size NewSize)
        {
            // Retour de la fonction de redimensionnement
            return new Bitmap(Image, NewSize);
        }

        private static int Diagonale_Returner(Bitmap Image)
        {
            // Retour des mesures des diagonales
            return (int)Math.Sqrt(Math.Pow(Image.Width, 2) + Math.Pow(Image.Height, 2));
        }

        public static Bitmap ToISO(Bitmap Image)
        {
            // Rotation de l'image
            Bitmap bImage = RotateBitmap_Returner(Image, 45);
            // Calcul des diagonales
            int Diagonale = Diagonale_Returner(Image);
            // Redimensionnement de l'image
            bImage = ResizeBitmap_Returner(bImage, new Size(Diagonale, Diagonale / 2));
            // Retour de l'image
            return bImage;
        }
    }
}
