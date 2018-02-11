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
    class Level1
    {
        public Level1(PaintEventArgs e)
        {
            Level1Laden(e);
        }


        private void Level1Laden(PaintEventArgs e)
        {
            Ebene1Leiter1Lila(e);
            Ebene1Leiter2Lila(e);
            Ebene2Leiter1Lila(e);
            Ebene2Leiter2Lila(e);
            Ebene3Leiter1Lila(e);
            Ebene3Leiter2Lila(e);
            Ebene3Leiter3Lila(e);
            Ebene4Leiter1Lila(e);
            Ebene4Leiter2Lila(e);
            Ebene4Leiter3Lila(e);
            Ebene5Leiter1Lila(e);
            Ebene5Leiter2Lila(e);
            Ebene6Leiter1Lila(e);
            Ebene6Leiter2Lila(e);


            Ebene1Lila(e);
            Ebene2Lila(e);
            Ebene3Lila(e);
            Ebene4Lila(e);
            Ebene5Lila(e);
            Ebene6Lila(e);
            Ebene7Lila(e);

            AffeSetzen(e);
            PeachSetzen(e);
            HammerSetzen(e);
            MarioSetzen(e);
            FassSetzen(e);
        }


        #region Ebenen
        public void Ebene1Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            LilaFragmentOberstes fragment1 = new LilaFragmentOberstes();
            LilaFragmentOberstes fragment2 = new LilaFragmentOberstes();
            LilaFragmentOberstes fragment3 = new LilaFragmentOberstes();
            LilaFragmentOberstes fragment4 = new LilaFragmentOberstes();
            LilaFragmentOberstes fragment5 = new LilaFragmentOberstes();
            LilaFragmentOberstes fragment6 = new LilaFragmentOberstes();
            LilaFragmentOberstes fragment7 = new LilaFragmentOberstes();
            LilaFragmentOberstes fragment8 = new LilaFragmentOberstes();

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

            yPositionen[0] = (223 * pixelGreosse); yPositionen[1] = (223 * pixelGreosse);
            yPositionen[2] = (223 * pixelGreosse); yPositionen[3] = (223 * pixelGreosse);
            yPositionen[4] = (223 * pixelGreosse); yPositionen[5] = (223 * pixelGreosse);
            yPositionen[6] = (223 * pixelGreosse); yPositionen[7] = (223 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene2Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            LilaFragment fragment1 = new LilaFragment();
            LilaFragment fragment2 = new LilaFragment();
            LilaFragment fragment3 = new LilaFragment();
            LilaFragment fragment4 = new LilaFragment();
            LilaFragment fragment5 = new LilaFragment();
            LilaFragment fragment6 = new LilaFragment();
            LilaFragment fragment7 = new LilaFragment();
            LilaFragmentHalbRechts fragment8 = new LilaFragmentHalbRechts();

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

            yPositionen[0] = (196 * pixelGreosse); yPositionen[1] = (197 * pixelGreosse);
            yPositionen[2] = (198 * pixelGreosse); yPositionen[3] = (199 * pixelGreosse);
            yPositionen[4] = (200 * pixelGreosse); yPositionen[5] = (201 * pixelGreosse);
            yPositionen[6] = (202 * pixelGreosse); yPositionen[7] = (203 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene3Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            LilaFragmentHalbLinks fragment1 = new LilaFragmentHalbLinks();
            LilaFragment fragment2 = new LilaFragment();
            LilaFragment fragment3 = new LilaFragment();
            LilaFragment fragment4 = new LilaFragment();
            LilaFragment fragment5 = new LilaFragment();
            LilaFragment fragment6 = new LilaFragment();
            LilaFragment fragment7 = new LilaFragment();
            LilaFragment fragment8 = new LilaFragment();

            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        fragment1, fragment2, fragment3, fragment4, fragment5, fragment6, fragment7, fragment8
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((17 * pixelGreosse) * 1) + (offset + 36)); xPositionen[1] = (((17 * pixelGreosse) * 2) + offset);
            xPositionen[2] = (((17 * pixelGreosse) * 3) + offset); xPositionen[3] = (((17 * pixelGreosse) * 4) + offset);
            xPositionen[4] = (((17 * pixelGreosse) * 5) + offset); xPositionen[5] = (((17 * pixelGreosse) * 6) + offset);
            xPositionen[6] = (((17 * pixelGreosse) * 7) + offset); xPositionen[7] = (((17 * pixelGreosse) * 8) + offset);

            yPositionen[0] = (173 * pixelGreosse); yPositionen[1] = (172 * pixelGreosse);
            yPositionen[2] = (171 * pixelGreosse); yPositionen[3] = (170 * pixelGreosse);
            yPositionen[4] = (169 * pixelGreosse); yPositionen[5] = (168 * pixelGreosse);
            yPositionen[6] = (167 * pixelGreosse); yPositionen[7] = (166 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene4Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            LilaFragment fragment1 = new LilaFragment();
            LilaFragment fragment2 = new LilaFragment();
            LilaFragment fragment3 = new LilaFragment();
            LilaFragment fragment4 = new LilaFragment();
            LilaFragment fragment5 = new LilaFragment();
            LilaFragment fragment6 = new LilaFragment();
            LilaFragment fragment7 = new LilaFragment();
            LilaFragmentHalbRechts fragment8 = new LilaFragmentHalbRechts();

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

            yPositionen[0] = (136 * pixelGreosse); yPositionen[1] = (137 * pixelGreosse);
            yPositionen[2] = (138 * pixelGreosse); yPositionen[3] = (139 * pixelGreosse);
            yPositionen[4] = (140 * pixelGreosse); yPositionen[5] = (141 * pixelGreosse);
            yPositionen[6] = (142 * pixelGreosse); yPositionen[7] = (143 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene5Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            LilaFragmentHalbLinks fragment1 = new LilaFragmentHalbLinks();
            LilaFragment fragment2 = new LilaFragment();
            LilaFragment fragment3 = new LilaFragment();
            LilaFragment fragment4 = new LilaFragment();
            LilaFragment fragment5 = new LilaFragment();
            LilaFragment fragment6 = new LilaFragment();
            LilaFragment fragment7 = new LilaFragment();
            LilaFragment fragment8 = new LilaFragment();

            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        fragment1, fragment2, fragment3, fragment4, fragment5, fragment6, fragment7, fragment8
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((17 * pixelGreosse) * 1) + (offset + 36)); xPositionen[1] = (((17 * pixelGreosse) * 2) + offset);
            xPositionen[2] = (((17 * pixelGreosse) * 3) + offset); xPositionen[3] = (((17 * pixelGreosse) * 4) + offset);
            xPositionen[4] = (((17 * pixelGreosse) * 5) + offset); xPositionen[5] = (((17 * pixelGreosse) * 6) + offset);
            xPositionen[6] = (((17 * pixelGreosse) * 7) + offset); xPositionen[7] = (((17 * pixelGreosse) * 8) + offset);

            yPositionen[0] = (113 * pixelGreosse); yPositionen[1] = (112 * pixelGreosse);
            yPositionen[2] = (111 * pixelGreosse); yPositionen[3] = (110 * pixelGreosse);
            yPositionen[4] = (109 * pixelGreosse); yPositionen[5] = (108 * pixelGreosse);
            yPositionen[6] = (107 * pixelGreosse); yPositionen[7] = (106 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene6Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            LilaFragment fragment1 = new LilaFragment();
            LilaFragment fragment2 = new LilaFragment();
            LilaFragment fragment3 = new LilaFragment();
            LilaFragment fragment4 = new LilaFragment();
            LilaFragment fragment5 = new LilaFragment();
            LilaFragment fragment6 = new LilaFragment();
            LilaFragment fragment7 = new LilaFragment();
            LilaFragmentHalbRechts fragment8 = new LilaFragmentHalbRechts();

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

            yPositionen[0] = (83 * pixelGreosse); yPositionen[1] = (83 * pixelGreosse);
            yPositionen[2] = (83 * pixelGreosse); yPositionen[3] = (83 * pixelGreosse);
            yPositionen[4] = (83 * pixelGreosse); yPositionen[5] = (83 * pixelGreosse);
            yPositionen[6] = (83 * pixelGreosse); yPositionen[7] = (83 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene7Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            LilaFragmentOberstes fragment1 = new LilaFragmentOberstes();
            LilaFragmentOberstes fragment2 = new LilaFragmentOberstes();
            LilaFragmentOberstes fragment3 = new LilaFragmentOberstes();
            LilaFragmentOberstes fragment4 = new LilaFragmentOberstes();

            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        fragment1, fragment2, fragment3, fragment4
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((17 * pixelGreosse) * 1) + offset); xPositionen[1] = (((17 * pixelGreosse) * 2) + offset);
            xPositionen[2] = (((17 * pixelGreosse) * 3) + offset); xPositionen[3] = (((17 * pixelGreosse) * 4) + offset);

            yPositionen[0] = (53 * pixelGreosse); yPositionen[1] = (53 * pixelGreosse);
            yPositionen[2] = (53 * pixelGreosse); yPositionen[3] = (53 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }
        #endregion


        #region Leitern
        public void Ebene1Leiter1Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Kaputt leiter = new Leiter_Kaputt();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = ((((17 * pixelGreosse) * 2) + offset) + ((((9 * pixelGreosse) * 4) + offset) / 3));

            yPositionen[0] = (208 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene1Leiter2Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Lila leiter = new Leiter_Heil_Lila();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = ((((17 * pixelGreosse) * 5) + offset) + ((((9 * pixelGreosse) * 4) + offset) / 3));

            yPositionen[0] = (208 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene2Leiter1Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Lila leiter = new Leiter_Heil_Lila();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = ((((17 * pixelGreosse) * 2) + offset) + ((((8 * pixelGreosse) * 2) + offset) / 2));

            yPositionen[0] = (179 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene2Leiter2Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Lila leiter = new Leiter_Heil_Lila();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau 
            xPositionen[0] = ((((9 * pixelGreosse) * 1) + offset) + ((((8 * pixelGreosse) * 1) + offset) / 3));

            yPositionen[0] = (179 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene3Leiter1Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Kaputt leiter = new Leiter_Kaputt();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau 
            xPositionen[0] = ((((17 * pixelGreosse) * 1) + offset) + ((((8 * pixelGreosse) * 1) + offset) / 2));

            yPositionen[0] = (149 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene3Leiter2Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Lila leiter = new Leiter_Heil_Lila();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau 
            xPositionen[0] = ((((17 * pixelGreosse) * 2) + offset) + ((((13 * pixelGreosse) * 3) + offset) / 2));

            yPositionen[0] = (149 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene3Leiter3Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Lila leiter = new Leiter_Heil_Lila();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau 
            xPositionen[0] = ((((17 * pixelGreosse) * 3) + offset) + ((((16 * pixelGreosse) * 4) + offset) / 2));

            yPositionen[0] = (149 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene4Leiter1Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Kaputt leiter = new Leiter_Kaputt();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau 
            xPositionen[0] = ((((15 * pixelGreosse) * 3) + offset) + ((((17 * pixelGreosse) * 3) + offset) / 2));

            yPositionen[0] = (119 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene4Leiter2Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Lila leiter = new Leiter_Heil_Lila();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau 
            xPositionen[0] = ((((17 * pixelGreosse) * 2) + offset) + ((((12 * pixelGreosse) * 2) + offset) / 3));

            yPositionen[0] = (119 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene4Leiter3Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Lila leiter = new Leiter_Heil_Lila();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = ((((10 * pixelGreosse) * 1) + offset) + ((((7 * pixelGreosse) * 1) + offset) / 3));

            yPositionen[0] = (119 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene5Leiter1Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Kaputt leiter = new Leiter_Kaputt();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = ((((17 * pixelGreosse) * 2) + offset) + ((((18 * pixelGreosse) * 3) + offset) / 3));

            yPositionen[0] = (89 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene5Leiter2Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Lila leiter = new Leiter_Heil_Lila();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = ((((19 * pixelGreosse) * 4) + offset) + ((((7 * pixelGreosse) * 2) + offset) / 2));

            yPositionen[0] = (89 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene6Leiter1Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Lila leiter = new Leiter_Heil_Lila();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = ((((17 * pixelGreosse) * 2) + offset) + ((((18 * pixelGreosse) * 3) + offset) / 3));

            yPositionen[0] = (59 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene6Leiter2Lila(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Leiter_Heil_Lila leiter = new Leiter_Heil_Lila();


            Ebene[] ebenenElemente;
            ebenenElemente = new Ebene[]
            {
                        leiter
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = ((9 * pixelGreosse) * 2) + offset;

            yPositionen[0] = (59 * pixelGreosse);
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

            yPositionen[0] = (31 * pixelGreosse);
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

            yPositionen[0] = (35 * pixelGreosse);
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
            xPositionen[0] = (((15 * pixelGreosse) * 2) + offset);

            yPositionen[0] = (92 * pixelGreosse);
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

            yPositionen[0] = (205 * pixelGreosse);
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);
        }


        public void FassSetzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Fass kong = new Fass();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        kong
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((13 * pixelGreosse) * 2) + offset);

            yPositionen[0] = (74 * pixelGreosse);
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);
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
