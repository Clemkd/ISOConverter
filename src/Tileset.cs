using System;
using System.Drawing;

namespace ISOConverter
{
    class Tileset
    {
        // xTiles correspondant au nombre maximal de tiles horizontales sur l'image Tileset
        // width & height correspondants à la taille d'un tile universel sur l'image Tileset
        private int xTiles, width, height;
        // tilesetPicture correspondant à l'image Tileset
        private Bitmap tilesetPicture;

        public Tileset(Bitmap image, int tileWidth, int tileHeight)
        {
            // On assigne la valeur TILE_WIDTH à celle utilisé dans la classe
            this.width = tileWidth;
            // On assigne la valeur TILE_HEIGHT à celle utilisé dans la classe
            this.height = tileHeight;
            // On assigne la valeur Image à celle utilisé dans la classe
            this.tilesetPicture = image;
            // On calcul le nombre maximal de tiles horizontales
            this.xTiles = (int)(image.Width / tileWidth);
        }

        public Vector GetTilePosition(int index)
        {
            // On calcul la position Y du tile comportant l'index inséré
            int y = (int)(index / xTiles) * width;
            // On calcul la position X du tile comportant l'index inséré
            int x = (index - (y * xTiles) / width) * width;
            // On retourne la position globale sous forme vectorielle
            return new Vector(x, y);
        }

        public int TilesCount()
        {
            // On calcul et retourne le nombre maximal de tiles disponibles sur l'image Tileset
            return (tilesetPicture.Width / width) * (tilesetPicture.Height / height);
        }

        public Bitmap GetTile(Vector Position)
        {
            // On retourne l'image d'un unique tile sur l'image Tileset
            return tilesetPicture.Clone(new Rectangle(Position.X, Position.Y, width, height), tilesetPicture.PixelFormat);
        }
    }
}
