using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung.Frogger
{
    class Level1
    {
        public static bool neustart = false;
        public bool levelbeendedt = false;

        public Level1(PaintEventArgs e, KeyEventArgs a)
        {
            Level1Laden(e, a);
        }


        private void Level1Laden(PaintEventArgs e, KeyEventArgs a)
        {
            #region Extra Elemente
            
            #endregion

            #region Ebenen
            Ebene1(e);
            #endregion

            #region Frog
            FrogSetzen(e);
            #endregion
        }


        #region Ebenen
        public void Ebene1(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Rand fragment1 = new Rand();

            Level[] ebenenElemente;
            ebenenElemente = new Level[]
            {
                        fragment1
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((7 * pixelGreosse) * 1) + offset);

            yPositionen[0] = (223 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }
        #endregion


        #region Extra Elemente
        //public void Ebene1Dings(PaintEventArgs e)
        //{
        //    int[] xPositionen;
        //    int[] yPositionen;
        //    int pixelGreosse = 3;
        //    int offset = 250;

        //    Leiter_Kaputt leiter = new Leiter_Kaputt();


        //    Ebene[] ebenenElemente;
        //    ebenenElemente = new Ebene[]
        //    {
        //                leiter
        //    };

        //    xPositionen = new int[ebenenElemente.GetLength(0)];
        //    yPositionen = new int[ebenenElemente.GetLength(0)];

        //    #region Ebenen Aufbau
        //    xPositionen[0] = ((((17 * pixelGreosse) * 2) + offset) + ((((9 * pixelGreosse) * 4) + offset) / 3));

        //    yPositionen[0] = (208 * pixelGreosse);
        //    #endregion

        //    verteilungEbene(ebenenElemente, xPositionen, yPositionen);

        //    FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        //}
        #endregion


        #region Figuren
        public Frog FrogSetzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Frog frog = new Frog();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        frog
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((18 * pixelGreosse) * 1) + offset);

            yPositionen[0] = (31 * pixelGreosse);
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (frog);
        }
        #endregion


        public void FaerbenFigure(Figuren[] figurArray, PaintEventArgs e, int[] xPosition, int[] yPosition)
        {
            Graphics g = e.Graphics;
            int pixelGroesse = 3;

            for (int l = 0; l < figurArray.GetLength(0); l++)
            {
                for (int i = 0; i < figurArray[l].model.GetLength(0); i++)
                {
                    for (int j = 0; j < figurArray[l].model.GetLength(1); j++)
                    {
                        switch (figurArray[l].model[i, j].farbe)
                        {
                            case 0:
                                g.FillRectangle(Brushes.Transparent, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 1:
                                g.FillRectangle(Brushes.Beige, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 2:
                                g.FillRectangle(Brushes.Red, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 3:
                                g.FillRectangle(Brushes.Blue, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 4:
                                g.FillRectangle(Brushes.Brown, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 5:
                                g.FillRectangle(Brushes.Yellow, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 6:
                                g.FillRectangle(Brushes.Chocolate, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], 5, pixelGroesse));
                                break;
                            case 7:
                                g.FillRectangle(Brushes.Orange, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 8:
                                g.FillRectangle(Brushes.Gray, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 9:
                                g.FillRectangle(Brushes.LightGoldenrodYellow, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 10:
                                g.FillRectangle(Brushes.Violet, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 11:
                                g.FillRectangle(Brushes.DarkBlue, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 12:
                                g.FillRectangle(Brushes.Green, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 13:
                                g.FillRectangle(Brushes.OrangeRed, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 14:
                                g.FillRectangle(Brushes.Pink, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 15:
                                g.FillRectangle(Brushes.White, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 16:
                                g.FillRectangle(Brushes.LightBlue, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                        }
                    }
                }
            }
        }


        public void FaerbenEbene(Level[] ebenenElementeArray, PaintEventArgs e, int[] xPosition, int[] yPosition)
        {
            Graphics g = e.Graphics;

            int pixelGroesse = 3;

            for (int l = 0; l < ebenenElementeArray.GetLength(0); l++)
            {
                for (int i = 0; i < ebenenElementeArray[l].model.GetLength(0); i++)
                {
                    for (int j = 0; j < ebenenElementeArray[l].model.GetLength(1); j++)
                    {
                        switch (ebenenElementeArray[l].model[i, j].farbe)
                        {
                            case 0:
                                g.FillRectangle(Brushes.Transparent, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 1:
                                g.FillRectangle(Brushes.Beige, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 2:
                                g.FillRectangle(Brushes.Red, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 3:
                                g.FillRectangle(Brushes.Blue, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 4:
                                g.FillRectangle(Brushes.Brown, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 5:
                                g.FillRectangle(Brushes.Yellow, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 6:
                                g.FillRectangle(Brushes.Chocolate, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], 5, pixelGroesse));
                                break;
                            case 7:
                                g.FillRectangle(Brushes.Orange, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 8:
                                g.FillRectangle(Brushes.Gray, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 9:
                                g.FillRectangle(Brushes.LightGoldenrodYellow, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 10:
                                g.FillRectangle(Brushes.Violet, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 11:
                                g.FillRectangle(Brushes.DarkBlue, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 12:
                                g.FillRectangle(Brushes.Green, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 13:
                                g.FillRectangle(Brushes.OrangeRed, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 14:
                                g.FillRectangle(Brushes.Pink, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 15:
                                g.FillRectangle(Brushes.White, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                            case 16:
                                g.FillRectangle(Brushes.LightBlue, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                        }
                    }
                }
            }
        }


        public void verteilungFigur(Figuren[] figuren, int[] neuexPositionen, int[] neueyPositionen)
        {
            for (int k = 0; k < figuren.GetLength(0); k++)
            {
                figuren[k].xPosition = neuexPositionen[k];
                figuren[k].yPosition = neueyPositionen[k];
            }
        }


        public void verteilungEbene(Level[] ebenenElemente, int[] neuexPositionen, int[] neueyPositionen)
        {
            for (int k = 0; k < ebenenElemente.GetLength(0); k++)
            {
                ebenenElemente[k].xPosition = neuexPositionen[k];
                ebenenElemente[k].yPosition = neueyPositionen[k];
            }
        }

        public void Neustart()
        {
            neustart = false;
        }
    }
}
