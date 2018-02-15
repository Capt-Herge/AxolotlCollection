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
    class Level2
    {
        public static int zufall = new Random().Next(0, 200);

        public int affeHilf;

        public static int feuerHilf1 = 0;
        public static bool randFeuer1 = false;
        public static int feuerHilf2 = 0;
        public static bool randFeuer2 = false;
        public static int feuerHilf3 = 0;
        public static bool randFeuer3 = false;
        public static int feuerHilf4 = 0;
        public static bool randFeuer4 = false;

        public Level2(PaintEventArgs e, int affe)
        {
            affeHilf = affe;
            Level2Laden(e);
        }


        private void Level2Laden(PaintEventArgs e)
        {
            Ebene1Leiter1Blau(e);
            Ebene2Leiter1Blau(e);
            Ebene3Leiter1Blau(e);
            Ebene4Leiter1Blau(e);
            Ebene5Leiter1Blau(e);
            Ebene1Leiter2Blau(e);
            Ebene2Leiter2Blau(e);
            Ebene3Leiter2Blau(e);
            Ebene4Leiter2Blau(e);
            Ebene5Leiter2Blau(e);
            Ebene1Leiter3Blau(e);
            Ebene2Leiter3Blau(e);
            Ebene3Leiter3Blau(e);
            Ebene4Leiter3Blau(e);
            Ebene5Leiter3Blau(e);
            Ebene1Leiter4Blau(e);
            Ebene2Leiter4Blau(e);
            Ebene3Leiter4Blau(e);
            Ebene4Leiter4Blau(e);
            Ebene5Leiter4Blau(e);

            Ebene1Blau(e);
            Ebene2Blau(e);
            Ebene3Blau(e);
            Ebene4Blau(e);
            Ebene5Blau(e);
            Ebene6Blau(e);

            if (affeHilf > 200)
            {
                AffeSetzen(e);
            }
            if (affeHilf <= 200)
            {
                AffeSetzen(e).AendereBlickRichtung();
            }

            PeachSetzen(e);
            HammerSetzen(e);
            MarioSetzen(e);
            Feuer1Setzen(e);
            Feuer2Setzen(e);
            Feuer3Setzen(e);
            Feuer4Setzen(e);
        }


        #region Leitern
        public void Ebene1Leiter1Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((13 * pixelGreosse) * 2) + offset + 3);

            yPositionen[0] = (190 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene2Leiter1Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((13 * pixelGreosse) * 2) + offset + 3);

            yPositionen[0] = (164 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene3Leiter1Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((13 * pixelGreosse) * 2) + offset + 3);

            yPositionen[0] = (138 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene4Leiter1Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((13 * pixelGreosse) * 2) + offset + 3);

            yPositionen[0] = (112 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene5Leiter1Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((13 * pixelGreosse) * 2) + offset + 3);

            yPositionen[0] = (84 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene1Leiter2Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((28 * pixelGreosse) * 2) + offset);

            yPositionen[0] = (190 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene2Leiter2Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((28 * pixelGreosse) * 2) + offset);

            yPositionen[0] = (164 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene3Leiter2Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((28 * pixelGreosse) * 2) + offset);

            yPositionen[0] = (138 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene4Leiter2Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((28 * pixelGreosse) * 2) + offset);

            yPositionen[0] = (112 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene5Leiter2Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((28 * pixelGreosse) * 2) + offset);

            yPositionen[0] = (84 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene1Leiter3Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((54 * pixelGreosse) * 2) + offset);

            yPositionen[0] = (190 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene2Leiter3Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((54 * pixelGreosse) * 2) + offset);

            yPositionen[0] = (164 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene3Leiter3Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((54 * pixelGreosse) * 2) + offset);

            yPositionen[0] = (138 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene4Leiter3Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((54 * pixelGreosse) * 2) + offset);

            yPositionen[0] = (112 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene5Leiter3Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((54 * pixelGreosse) * 2) + offset);

            yPositionen[0] = (84 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene1Leiter4Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((68 * pixelGreosse) * 2) + offset + 3);

            yPositionen[0] = (190 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene2Leiter4Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((68 * pixelGreosse) * 2) + offset + 3);

            yPositionen[0] = (164 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene3Leiter4Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((68 * pixelGreosse) * 2) + offset + 3);

            yPositionen[0] = (138 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene4Leiter4Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((68 * pixelGreosse) * 2) + offset + 3);

            yPositionen[0] = (112 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene5Leiter4Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Blau leiter = new Leiter_Heil_Blau();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((68 * pixelGreosse) * 2) + offset + 3);

            yPositionen[0] = (84 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }
        #endregion


        #region Ebenen
        public void Ebene1Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            BlauesFragmentKurz fragment1 = new BlauesFragmentKurz();
            BlauesFragmentKurz fragment2 = new BlauesFragmentKurz();
            BlauesFragmentKurz fragment3 = new BlauesFragmentKurz();
            BlauesFragmentKurz fragment4 = new BlauesFragmentKurz();
            BlauesFragmentKurz fragment5 = new BlauesFragmentKurz();
            BlauesFragmentKurz fragment6 = new BlauesFragmentKurz();
            BlauesFragmentKurz fragment7 = new BlauesFragmentKurz();
            BlauesFragmentKurz fragment8 = new BlauesFragmentKurz();

            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        fragment1, fragment2, fragment3, fragment4, fragment5, fragment6, fragment7, fragment8
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((17 * pixelGreosse) * 1) + offset); xPositionen[1] = (((17 * pixelGreosse) * 2) + offset);
            xPositionen[2] = (((17 * pixelGreosse) * 3) + offset); xPositionen[3] = (((17 * pixelGreosse) * 4) + offset);
            xPositionen[4] = (((17 * pixelGreosse) * 5) + offset); xPositionen[5] = (((17 * pixelGreosse) * 6) + offset);
            xPositionen[6] = (((17 * pixelGreosse) * 7) + offset); xPositionen[7] = (((17 * pixelGreosse) * 8) + offset);


            yPositionen[0] = (209 * pixelGreosse); yPositionen[1] = (209 * pixelGreosse);
            yPositionen[2] = (209 * pixelGreosse); yPositionen[3] = (209 * pixelGreosse);
            yPositionen[4] = (209 * pixelGreosse); yPositionen[5] = (209 * pixelGreosse);
            yPositionen[6] = (209 * pixelGreosse); yPositionen[7] = (209 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene2Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            BlauesFragmentLang fragment1 = new BlauesFragmentLang();
            Falltuer fragment2 = new Falltuer();
            BlauesFragmentLang fragment3 = new BlauesFragmentLang();
            BlauesFragmentKurz fragment4 = new BlauesFragmentKurz();
            BlauesFragmentLang fragment5 = new BlauesFragmentLang();
            Falltuer fragment6 = new Falltuer();
            BlauesFragmentLang fragment7 = new BlauesFragmentLang();

            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        fragment1, fragment2, fragment3, fragment4, fragment5, fragment6, fragment7
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = ((17 * pixelGreosse) + offset);
            xPositionen[1] = ((25 * pixelGreosse) + xPositionen[0]);
            xPositionen[2] = ((9 * pixelGreosse) + xPositionen[1]);
            xPositionen[3] = ((25 * pixelGreosse) + xPositionen[2]);
            xPositionen[4] = ((17 * pixelGreosse) + xPositionen[3]);
            xPositionen[5] = ((25 * pixelGreosse) + xPositionen[4]);
            xPositionen[6] = ((9 * pixelGreosse) + xPositionen[5]);

            yPositionen[0] = (183 * pixelGreosse); yPositionen[1] = (183 * pixelGreosse);
            yPositionen[2] = (183 * pixelGreosse); yPositionen[3] = (183 * pixelGreosse);
            yPositionen[4] = (183 * pixelGreosse); yPositionen[5] = (183 * pixelGreosse);
            yPositionen[6] = (183 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene3Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            BlauesFragmentLang fragment1 = new BlauesFragmentLang();
            Falltuer fragment2 = new Falltuer();
            BlauesFragmentLang fragment3 = new BlauesFragmentLang();
            BlauesFragmentKurz fragment4 = new BlauesFragmentKurz();
            BlauesFragmentLang fragment5 = new BlauesFragmentLang();
            Falltuer fragment6 = new Falltuer();
            BlauesFragmentLang fragment7 = new BlauesFragmentLang();

            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        fragment1, fragment2, fragment3, fragment4, fragment5, fragment6, fragment7
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = ((17 * pixelGreosse) + offset);
            xPositionen[1] = ((25 * pixelGreosse) + xPositionen[0]);
            xPositionen[2] = ((9 * pixelGreosse) + xPositionen[1]);
            xPositionen[3] = ((25 * pixelGreosse) + xPositionen[2]);
            xPositionen[4] = ((17 * pixelGreosse) + xPositionen[3]);
            xPositionen[5] = ((25 * pixelGreosse) + xPositionen[4]);
            xPositionen[6] = ((9 * pixelGreosse) + xPositionen[5]);

            yPositionen[0] = (157 * pixelGreosse); yPositionen[1] = (157 * pixelGreosse);
            yPositionen[2] = (157 * pixelGreosse); yPositionen[3] = (157 * pixelGreosse);
            yPositionen[4] = (157 * pixelGreosse); yPositionen[5] = (157 * pixelGreosse);
            yPositionen[6] = (157 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene4Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            BlauesFragmentLang fragment1 = new BlauesFragmentLang();
            Falltuer fragment2 = new Falltuer();
            BlauesFragmentLang fragment3 = new BlauesFragmentLang();
            BlauesFragmentKurz fragment4 = new BlauesFragmentKurz();
            BlauesFragmentLang fragment5 = new BlauesFragmentLang();
            Falltuer fragment6 = new Falltuer();
            BlauesFragmentLang fragment7 = new BlauesFragmentLang();

            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        fragment1, fragment2, fragment3, fragment4, fragment5, fragment6, fragment7
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = ((17 * pixelGreosse) + offset);
            xPositionen[1] = ((25 * pixelGreosse) + xPositionen[0]);
            xPositionen[2] = ((9 * pixelGreosse) + xPositionen[1]);
            xPositionen[3] = ((25 * pixelGreosse) + xPositionen[2]);
            xPositionen[4] = ((17 * pixelGreosse) + xPositionen[3]);
            xPositionen[5] = ((25 * pixelGreosse) + xPositionen[4]);
            xPositionen[6] = ((9 * pixelGreosse) + xPositionen[5]);

            yPositionen[0] = (131 * pixelGreosse); yPositionen[1] = (131 * pixelGreosse);
            yPositionen[2] = (131 * pixelGreosse); yPositionen[3] = (131 * pixelGreosse);
            yPositionen[4] = (131 * pixelGreosse); yPositionen[5] = (131 * pixelGreosse);
            yPositionen[6] = (131 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene5Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            BlauesFragmentLang fragment1 = new BlauesFragmentLang();
            Falltuer fragment2 = new Falltuer();
            BlauesFragmentLang fragment3 = new BlauesFragmentLang();
            BlauesFragmentKurz fragment4 = new BlauesFragmentKurz();
            BlauesFragmentLang fragment5 = new BlauesFragmentLang();
            Falltuer fragment6 = new Falltuer();
            BlauesFragmentLang fragment7 = new BlauesFragmentLang();

            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        fragment1, fragment2, fragment3, fragment4, fragment5, fragment6, fragment7
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = ((17 * pixelGreosse) + offset);
            xPositionen[1] = ((25 * pixelGreosse) + xPositionen[0]);
            xPositionen[2] = ((9 * pixelGreosse) + xPositionen[1]);
            xPositionen[3] = ((25 * pixelGreosse) + xPositionen[2]);
            xPositionen[4] = ((17 * pixelGreosse) + xPositionen[3]);
            xPositionen[5] = ((25 * pixelGreosse) + xPositionen[4]);
            xPositionen[6] = ((9 * pixelGreosse) + xPositionen[5]);

            yPositionen[0] = (105 * pixelGreosse); yPositionen[1] = (105 * pixelGreosse);
            yPositionen[2] = (105 * pixelGreosse); yPositionen[3] = (105 * pixelGreosse);
            yPositionen[4] = (105 * pixelGreosse); yPositionen[5] = (105 * pixelGreosse);
            yPositionen[6] = (105 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene6Blau(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            BlauesFragmentOberstes fragment1 = new BlauesFragmentOberstes();
            BlauesFragmentOberstes fragment2 = new BlauesFragmentOberstes();
            BlauesFragmentOberstes fragment3 = new BlauesFragmentOberstes();
            BlauesFragmentOberstes fragment4 = new BlauesFragmentOberstes();
            BlauesFragmentOberstes fragment5 = new BlauesFragmentOberstes();
            BlauesFragmentOberstes fragment6 = new BlauesFragmentOberstes();
            BlauesFragmentOberstes fragment7 = new BlauesFragmentOberstes();
            BlauesFragmentOberstes fragment8 = new BlauesFragmentOberstes();

            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        fragment1, fragment2, fragment3, fragment4, fragment5, fragment6, fragment7, fragment8
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((17 * pixelGreosse) * 1) + offset); xPositionen[1] = (((17 * pixelGreosse) * 2) + offset);
            xPositionen[2] = (((17 * pixelGreosse) * 3) + offset); xPositionen[3] = (((17 * pixelGreosse) * 4) + offset);
            xPositionen[4] = (((17 * pixelGreosse) * 5) + offset); xPositionen[5] = (((17 * pixelGreosse) * 6) + offset);
            xPositionen[6] = (((17 * pixelGreosse) * 7) + offset); xPositionen[7] = (((17 * pixelGreosse) * 8) + offset);

            yPositionen[0] = (79 * pixelGreosse); yPositionen[1] = (79 * pixelGreosse);
            yPositionen[2] = (79 * pixelGreosse); yPositionen[3] = (79 * pixelGreosse);
            yPositionen[4] = (79 * pixelGreosse); yPositionen[5] = (79 * pixelGreosse);
            yPositionen[6] = (79 * pixelGreosse); yPositionen[7] = (79 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }
        #endregion


        #region Figuren
        public Affe AffeSetzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Affe kong = new Affe();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        kong
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((18 * pixelGreosse) * 1) + offset);

            yPositionen[0] = (57 * pixelGreosse);
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (kong);
        }


        public void PeachSetzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Peach kong = new Peach();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        kong
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((55 * pixelGreosse) * 1) + offset);

            yPositionen[0] = (61 * pixelGreosse);
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);
        }


        public void HammerSetzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Hammer kong = new Hammer();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        kong
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((16 * pixelGreosse) * 5) + offset + 4);

            yPositionen[0] = (115 * pixelGreosse);
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);
        }


        public void MarioSetzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Mario kong = new Mario();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        kong
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((18 * pixelGreosse) * 2) + offset);

            yPositionen[0] = (191 * pixelGreosse);
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);
        }


        public Feuer Feuer1Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;
            zufall = new Random().Next(0, 2000);

            Feuer kong = new Feuer();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        kong
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            if (feuerHilf1 >= 380)
            {
                randFeuer1 = true;
            }

            if (((zufall >= 1984) && (zufall < 1988)) && (feuerHilf1 < 380))
            {
                if(randFeuer1 == false)
                {
                    randFeuer1 = true;
                }
                if (randFeuer1 == true)
                {
                    randFeuer1 = false;
                }
            }

            if (feuerHilf1 == 0)
            {
                xPositionen[0] = (17 * pixelGreosse) + offset+ feuerHilf1;

                yPositionen[0] = (174 * pixelGreosse);

                feuerHilf1++;

                if(randFeuer1 == false)
                {
                    randFeuer1 = true;
                }
                if (randFeuer1 == true)
                {
                    randFeuer1 = false;
                }
            }

            if ((feuerHilf1 > 0) && (randFeuer1 == false))
            {
                xPositionen[0] = (17 * pixelGreosse) + offset + feuerHilf1;

                yPositionen[0] = (174 * pixelGreosse);

                feuerHilf1++;
            }

            if ((feuerHilf1 > 0) && (randFeuer1 == true))
            {
                xPositionen[0] = (17 * pixelGreosse) + offset + feuerHilf1;

                yPositionen[0] = (174 * pixelGreosse);

                kong.LinksSchweb();

                feuerHilf1--;
            }
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (kong);
        }


        public Feuer Feuer2Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;
            zufall = new Random().Next(0, 2000);

            Feuer kong = new Feuer();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        kong
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            if (feuerHilf2 >= 380)
            {
                randFeuer2 = true;
            }

            if (((zufall >= 1988) && (zufall < 1992)) && (feuerHilf2 < 380))
            {
                if (randFeuer2 == false)
                {
                    randFeuer2 = true;
                }
                if (randFeuer2 == true)
                {
                    randFeuer2 = false;
                }
            }

            if (feuerHilf2 == 0)
            {
                xPositionen[0] = (17 * pixelGreosse) + offset + feuerHilf2;

                yPositionen[0] = (148 * pixelGreosse);

                feuerHilf2++;

                if (randFeuer2 == false)
                {
                    randFeuer2 = true;
                }
                if (randFeuer2 == true)
                {
                    randFeuer2 = false;
                }
            }

            if ((feuerHilf2 > 0) && (randFeuer2 == false))
            {
                xPositionen[0] = (17 * pixelGreosse) + offset + feuerHilf2;

                yPositionen[0] = (148 * pixelGreosse);

                feuerHilf2++;
            }

            if ((feuerHilf2 > 0) && (randFeuer2 == true))
            {
                xPositionen[0] = (17 * pixelGreosse) + offset + feuerHilf2;

                yPositionen[0] = (148 * pixelGreosse);

                kong.LinksSchweb();

                feuerHilf2--;
            }
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (kong);
        }


        public Feuer Feuer3Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;
            zufall = new Random().Next(0, 2000);

            Feuer kong = new Feuer();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        kong
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            if (feuerHilf3 >= 380)
            {
                randFeuer3 = true;
            }

            if (((zufall >= 1992) && (zufall < 1996)) && (feuerHilf3 < 380))
            {
                if (randFeuer3 == false)
                {
                    randFeuer3 = true;
                }
                if (randFeuer3 == true)
                {
                    randFeuer3 = false;
                }
            }

            if (feuerHilf3 == 0)
            {
                xPositionen[0] = (17 * pixelGreosse) + offset + feuerHilf3;

                yPositionen[0] = (122 * pixelGreosse);

                feuerHilf3++;

                if (randFeuer3 == false)
                {
                    randFeuer3 = true;
                }
                if (randFeuer3 == true)
                {
                    randFeuer3 = false;
                }
            }

            if ((feuerHilf3 > 0) && (randFeuer3 == false))
            {
                xPositionen[0] = (17 * pixelGreosse) + offset + feuerHilf3;

                yPositionen[0] = (122 * pixelGreosse);

                feuerHilf3++;
            }

            if ((feuerHilf3 > 0) && (randFeuer3 == true))
            {
                xPositionen[0] = (17 * pixelGreosse) + offset + feuerHilf3;

                yPositionen[0] = (122 * pixelGreosse);

                kong.LinksSchweb();

                feuerHilf3--;
            }
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (kong);
        }


        public Feuer Feuer4Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;
            zufall = new Random().Next(0, 2000);

            Feuer kong = new Feuer();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        kong
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            if (feuerHilf4 >= 380)
            {
                randFeuer4 = true;
            }

            if ((zufall >= 1996) && (feuerHilf4 < 380))
            {
                if (randFeuer4 == false)
                {
                    randFeuer4 = true;
                }
                if (randFeuer4 == true)
                {
                    randFeuer4 = false;
                }
            }

            if (feuerHilf4 == 0)
            {
                xPositionen[0] = (17 * pixelGreosse) + offset + feuerHilf4;

                yPositionen[0] = (96 * pixelGreosse);

                feuerHilf4++;

                if (randFeuer4 == false)
                {
                    randFeuer4 = true;
                }
                if (randFeuer4 == true)
                {
                    randFeuer4 = false;
                }
            }

            if ((feuerHilf4 > 0) && (randFeuer4 == false))
            {
                xPositionen[0] = (17 * pixelGreosse) + offset + feuerHilf4;

                yPositionen[0] = (96 * pixelGreosse);

                feuerHilf4++;
            }

            if ((feuerHilf4 > 0) && (randFeuer4 == true))
            {
                xPositionen[0] = (17 * pixelGreosse) + offset + feuerHilf4;

                yPositionen[0] = (96 * pixelGreosse);

                kong.LinksSchweb();

                feuerHilf4--;
            }
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (kong);
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
                                g.FillRectangle(Brushes.Black, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
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
                        }
                    }
                }
            }
        }


        public void FaerbenEbene(Ebene[] ebenenElementeArray, PaintEventArgs e, int[] xPosition, int[] yPosition)
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
                                g.FillRectangle(Brushes.Black, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
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


        public void verteilungEbene(Ebene[] ebenenElemente, int[] neuexPositionen, int[] neueyPositionen)
        {
            for (int k = 0; k < ebenenElemente.GetLength(0); k++)
            {
                ebenenElemente[k].xPosition = neuexPositionen[k];
                ebenenElemente[k].yPosition = neueyPositionen[k];
            }
        }

    }
}

