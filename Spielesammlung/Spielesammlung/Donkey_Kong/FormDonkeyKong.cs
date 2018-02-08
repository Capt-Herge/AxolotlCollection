using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung.Donkey_Kong
{
    public partial class FormDonkeyKong : Form
    {
        public FormDonkeyKong()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Affe affe1 = new Affe();
            Fass fass1 = new Fass();
            Feuer feuer1 = new Feuer();
            Mario mario1 = new Mario();
            Peach peach1 = new Peach();

            Figuren[] figuren = new Figuren[]  {affe1, fass1, feuer1, mario1, peach1};
            int[,] positionen = new int[2, figuren.GetLength(0)];

            #region positionen([0, X] = xPositionen/ [1, Y] = yPositionen)
            positionen[0, 0] = 0; positionen[0, 1] = 500; positionen[0, 2] = 250; positionen[0, 3] = 0; positionen[0, 4] = 150;

            positionen[1, 0] = 0; positionen[1, 1] = 500; positionen[1, 2] = 250; positionen[1, 3] = 500; positionen[1, 4] = 0;
            #endregion

            verteilung(figuren, positionen);

            Faerben(affe1, e, affe1.xPosition, affe1.yPosition);
            Faerben(fass1, e, fass1.xPosition, fass1.yPosition);
            Faerben(feuer1, e, feuer1.xPosition, feuer1.yPosition);
            Faerben(mario1, e, mario1.xPosition, mario1.yPosition);
            Faerben(peach1, e, peach1.xPosition, peach1.yPosition);
        }

        private void Faerben(Figuren figur, PaintEventArgs e , int xPosition, int yPosition)
        {
            Graphics g = e.Graphics;

            for(int i = 0; i < figur.model.GetLength(0); i++)
            {
                for (int j = 0; j < figur.model.GetLength(1); j++)
                {
                    switch (figur.model[i, j].farbe)
                    {
                        case 0:
                            g.FillRectangle(Brushes.Black, new Rectangle((j * 5) + xPosition, (i * 5) + yPosition, 5, 5));
                            break;
                        case 1:
                            g.FillRectangle(Brushes.Beige, new Rectangle((j * 5) + xPosition, (i * 5) + yPosition, 5, 5));
                            break;
                        case 2:
                            g.FillRectangle(Brushes.Red, new Rectangle((j * 5) + xPosition, (i * 5) + yPosition, 5, 5));
                            break;
                        case 3:
                            g.FillRectangle(Brushes.Blue, new Rectangle((j * 5) + xPosition, (i * 5) + yPosition, 5, 5));
                            break;
                        case 4:
                            g.FillRectangle(Brushes.Brown, new Rectangle((j * 5) + xPosition, (i * 5) + yPosition, 5, 5));
                            break;
                        case 5:
                            g.FillRectangle(Brushes.Yellow, new Rectangle((j * 5) + xPosition, (i * 5) + yPosition, 5, 5));
                            break;
                        case 6:
                            g.FillRectangle(Brushes.Chocolate, new Rectangle((j * 5) + xPosition, (i * 5) + yPosition, 5, 5));
                            break;
                        case 7:
                            g.FillRectangle(Brushes.Orange, new Rectangle((j * 5) + xPosition, (i * 5) + yPosition, 5, 5));
                            break;
                        case 8:
                            g.FillRectangle(Brushes.Gray, new Rectangle((j * 5) + xPosition, (i * 5) + yPosition, 5, 5));
                            break;
                        case 9:
                            g.FillRectangle(Brushes.LightGoldenrodYellow, new Rectangle((j * 5) + xPosition, (i * 5) + yPosition, 5, 5));
                            break;
                        case 10:
                            g.FillRectangle(Brushes.Violet, new Rectangle((j * 5) + xPosition, (i * 5) + yPosition, 5, 5));
                            break;
                        case 11:
                            g.FillRectangle(Brushes.DarkBlue, new Rectangle((j * 5) + xPosition, (i * 5) + yPosition, 5, 5));
                            break;
                    }                  
                }
            }
        }

        private void verteilung(Figuren[] figuren, int[,] neuePositionen)
        {
            for(int k = 0; k < figuren.GetLength(0); k++)
            {
                figuren[k].xPosition = neuePositionen[0, k];
                figuren[k].yPosition = neuePositionen[1, k];
            }
        }

    }
}
