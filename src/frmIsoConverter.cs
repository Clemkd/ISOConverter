using System;
using System.Drawing;
using System.Windows.Forms;

namespace ISOConverter
{
    public partial class frmIsoConverter : Form
    {
        public frmIsoConverter()
        {
            InitializeComponent();
        }

        private Tileset tiles;
        private int maxTiles;

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            StartConversion();
        }

        private void btn_Path_Click(object sender, EventArgs e)
        {
            DialogResult Result = openFile.ShowDialog();
            if (Result == DialogResult.OK)
                txt_Path.Text = openFile.FileName;
        }

        private void InitializeConversion()
        {
            progress.Value = 0;

            Bitmap bImage = new Bitmap(txt_Path.Text);
            int tmpWidth = int.Parse(txt_Width.Text);
            int tmpHeight = int.Parse(txt_Height.Text);
            tiles = new Tileset(bImage, tmpWidth, tmpHeight);

            maxTiles = tiles.TilesCount();

            progress.Maximum = maxTiles;
        }

        private void StartConversion()
        {
            try
            {
                InitializeConversion();

                for (int tileIndex = 0; tileIndex < maxTiles; tileIndex++)
                {
                    Bitmap tile = Tile.ToISO(tiles.GetTile(tiles.GetTilePosition(tileIndex)));
                    tile.Save(@"Contents\ISO\tile" + tileIndex.ToString() + ".png");

                    incrementProgress();
                    incrementResultList(tileIndex);

                    Application.DoEvents();
                }
            }
            catch(Exception e) { MessageBox.Show(e.Message); }
        }

        private void incrementProgress()
        {
            progress.Value++;

            int percent = (int)(((double)progress.Value / (double)progress.Maximum) * 100);
            progress.CreateGraphics().DrawString(percent.ToString() + "%",
                new Font("Arial", (float)8.25, FontStyle.Regular),
                Brushes.Black,
                new PointF(progress.Width / 2 - 10, progress.Height / 2 - 7));
        }

        private void incrementResultList(int index)
        {
            listBox1.Items.Add("-- tile" + index.ToString() + ".png - Générée [ " + (index + 1).ToString() + " / " + maxTiles.ToString() + " ]");
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
    }
}
