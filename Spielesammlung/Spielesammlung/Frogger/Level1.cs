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
        #region Allgemein
        public static bool neustart = false;
        #endregion


        #region Zaehler für verschieden schnelle Bewegungen
        public static int zeitHilf1 = 0;
        public static int zeitHilf2 = 0;
        public static int zeitHilf3 = 0;
        public static int zeitHilf4 = 0;
        #endregion


        #region Frosch Hilfen
        public static bool tastensperre = false;
        public static int froschRichtung = 0;

        public static int froschXPosition = 0;
        public static int froschYPosition = 0;

        public static int froschYPositionInHuepfern = 0;

        public static int froschVerschiebungsZaehler1 = 0;
        public static int froschVerschiebungsZaehler2 = 0;
        public static int froschVerschiebungsZaehler3 = 0;
        public static int froschVerschiebungsZaehler4 = 0;

        public static bool hochLock = false;
        public static bool rechtsLock = false;
        public static bool runterLock = false;
        public static bool linksLock = false;
        #endregion


        #region Auto Zeahler
        public static int bewegungsZaehler1 = 0;
        public static int bewegungsZaehler2 = 0;

        public static int bewegungsZaehler3 = 0;
        public static int bewegungsZaehler4 = 0;

        public static int bewegungsZaehler5 = 0;
        public static int bewegungsZaehler6 = 0;
        public static int bewegungsZaehler7 = 0;
        public static int bewegungsZaehler8 = 0;

        public static int bewegungsZaehler9 = 0;
        public static int bewegungsZaehler10 = 0;

        public static int bewegungsZaehler11 = 0;
        public static int bewegungsZaehler12 = 0;
        #endregion


        #region Schildkroeten Zeahler und tauch
        public static int bewegungsZaehler13 = 0;
        public static int bewegungsZaehler14 = 0;
        public static int bewegungsZaehler15 = 0;

        public static int bewegungsZaehler16 = 0;
        public static int bewegungsZaehler17 = 0;
        public static int bewegungsZaehler18 = 0;

        public static int bewegungsZaehler19 = 0;
        public static int bewegungsZaehler20 = 0;

        public static int bewegungsZaehler21 = 0;
        public static int bewegungsZaehler22 = 0;

        public static bool tauch1 = false;
        public static bool tauch2 = true;
        #endregion


        #region Staemme Zeahler
        public static int bewegungsZaehler23 = 0;
        public static int bewegungsZaehler24 = 0;
        public static int bewegungsZaehler25 = 0;

        public static int bewegungsZaehler26 = 0;
        public static int bewegungsZaehler27 = 0;
        public static int bewegungsZaehler28 = 0;
        public static int bewegungsZaehler29 = 0;

        public static int bewegungsZaehler30 = 0;
        public static int bewegungsZaehler31 = 0;
        public static int bewegungsZaehler32 = 0;
        public static int bewegungsZaehler33 = 0;
        #endregion


        #region Tuempel Erreicht?
        public static bool tuempe1Erreicht = false;
        public static bool tuempe2Erreicht = false;
        public static bool tuempe3Erreicht = false;
        public static bool tuempe4Erreicht = false;
        public static bool tuempe5Erreicht = false;
        #endregion


        public Level1(PaintEventArgs e, KeyEventArgs a)
        {
            Level1Laden(e, a);           
        }


        private void Level1Laden(PaintEventArgs e, KeyEventArgs a)
        {

            #region Zaehler fuer unterschiedlich schnelle Bewegungen und Froschverschiebung
            bewegungsZaehler1++;
            bewegungsZaehler2++;
            bewegungsZaehler9++;
            bewegungsZaehler10++;
            bewegungsZaehler19++;
            bewegungsZaehler20++;
            bewegungsZaehler21++;
            bewegungsZaehler22++;
            bewegungsZaehler23++;
            bewegungsZaehler24++;
            bewegungsZaehler25++;
            bewegungsZaehler30++;
            bewegungsZaehler31++;
            bewegungsZaehler32++;
            bewegungsZaehler33++;

            if(froschYPositionInHuepfern == 10)
            {
                froschXPosition--;
                froschVerschiebungsZaehler1++;
            }

            if(froschYPositionInHuepfern == 8 || froschYPositionInHuepfern == 11)
            {
                froschXPosition++;
                froschVerschiebungsZaehler2++;

            }

            if (zeitHilf1 >= 2)
            {                
                bewegungsZaehler3++;
                bewegungsZaehler4++;
                bewegungsZaehler13++;
                bewegungsZaehler14++;
                bewegungsZaehler15++;
                bewegungsZaehler16++;
                bewegungsZaehler17++;
                bewegungsZaehler18++;

                if (froschYPositionInHuepfern == 7)
                {
                    froschXPosition--;
                    froschVerschiebungsZaehler3++;
                }

                zeitHilf1 = 0;
            }

            if(zeitHilf2 >= 3)
            {
                bewegungsZaehler5++;
                bewegungsZaehler6++;
                bewegungsZaehler7++;
                bewegungsZaehler8++;
                bewegungsZaehler11++;
                bewegungsZaehler12++;
                bewegungsZaehler26++;
                bewegungsZaehler27++;
                bewegungsZaehler28++;
                bewegungsZaehler29++;

                if (froschYPositionInHuepfern == 9)
                {
                    froschXPosition++;
                    froschVerschiebungsZaehler4++;
                }

                zeitHilf2 = 0;

            }

            if (zeitHilf3 >= 500)
            {
                if (tauch1)
                {
                    tauch1 = false;
                }
                else if (!tauch1)
                {
                    tauch1 = true;
                }

                zeitHilf3 = 0;
            }

            if(zeitHilf4 >= 200)
            {
                if (tauch2)
                {
                    tauch2 = false;
                }
                else if (!tauch2)
                {
                    tauch2 = true;
                }

                zeitHilf4 = 0;
            }

            zeitHilf1++;
            zeitHilf2++;
            zeitHilf3++;
            zeitHilf4++;

            #endregion


            #region Ebenen
            Ebene1(e);
            Ebene2(e);
            Ebene3(e);
            Ebene4(e);
            Ebene5(e);
            Ebene6(e);
            Ebene7(e);
            Ebene8(e);
            Ebene9(e);
            Ebene11(e);
            Ebene12(e);
            Ebene13(e);
            Ebene14(e);
            Ebene15(e);
            Ebene16(e);
            Ebene17(e);
            #endregion


            #region Extra Elemente
            SchildKroete schildKroete11 = SchildKroete11Setzen(e);
            SchildKroete schildKroete12 = SchildKroete12Setzen(e);
            SchildKroete schildKroete13 = SchildKroete13Setzen(e);
            SchildKroete schildKroete14 = SchildKroete14Setzen(e);
            SchildKroete schildKroete15 = SchildKroete15Setzen(e);
            SchildKroete schildKroete16 = SchildKroete16Setzen(e);

            SchildKroete schildKroete21 = SchildKroete21Setzen(e);
            SchildKroete schildKroete22 = SchildKroete22Setzen(e);
            SchildKroete schildKroete23 = SchildKroete23Setzen(e);
            SchildKroete schildKroete24 = SchildKroete24Setzen(e);

            StammLang StammLang11 = StammLang11Setzen(e);
            StammLang StammLang12 = StammLang12Setzen(e);
            StammLang StammLang13 = StammLang13Setzen(e);
            StammLang StammLang14 = StammLang14Setzen(e);

            StammLang Kurz21 = StammLang21Setzen(e);
            StammLang Kurz22 = StammLang22Setzen(e);
            StammLang Kurz23 = StammLang23Setzen(e);
            StammLang Kurz24 = StammLang24Setzen(e);

            StammKurz Kurz11 = StammKurz11Setzen(e);
            StammKurz Kurz12 = StammKurz12Setzen(e);
            StammKurz Kurz13 = StammKurz13Setzen(e);

            #region Siegbedingungen
            if (tuempe1Erreicht == true)
            {
                Tuempel1(e);
            }

            if (tuempe2Erreicht == true)
            {
                Tuempel2(e);
            }

            if (tuempe3Erreicht == true)
            {
                Tuempel3(e);
            }

            if (tuempe4Erreicht == true)
            {
                Tuempel4(e);
            }

            if (tuempe5Erreicht == true)
            {
                Tuempel5(e);
            }

            if((tuempe1Erreicht == true) && (tuempe2Erreicht == true) && (tuempe3Erreicht == true) && (tuempe4Erreicht == true) && (tuempe5Erreicht == true))
            {
                LevelBeendedt();
            }
            #endregion
            #endregion


            #region Figuren         
            Frog frosch = FrogSetzen(e, a);
            AutoOrange autoOrange1 = AutoOrange1Setzen(e);
            AutoOrange autoOrange2 = AutoOrange2Setzen(e);

            AutoLila autoLila1 = AutoLila1Setzen(e);
            AutoLila autoLila2 = AutoLila2Setzen(e);

            AutoGruen autoGruen1 = AutoGruen1Setzen(e);
            AutoGruen autoGruen2 = AutoGruen2Setzen(e);
            AutoGruen autoGruen3 = AutoGruen3Setzen(e);
            AutoGruen autoGruen4 = AutoGruen4Setzen(e);

            AutoPink autoPink1 = AutoPink1Setzen(e);
            AutoPink autoPink2 = AutoPink2Setzen(e);

            AutoWeiss autoWeiss1 = AutoWeiss1Setzen(e);
            AutoWeiss autoWeiss2 = AutoWeiss2Setzen(e);
            #endregion

            #region Kollisionsbehandlung(Des Todes)
            if(((((frosch.xPosition + 20) >= autoOrange1.xPosition) && (frosch.xPosition <= (autoOrange1.xPosition + 20)) || ((frosch.xPosition + 20) >= autoOrange2.xPosition) && (frosch.xPosition == (autoOrange2.xPosition + 20))) && (froschYPositionInHuepfern == 1)) ||
               ((((frosch.xPosition + 20) >= autoLila1.xPosition) && (frosch.xPosition <= (autoLila1.xPosition + 20)) || ((frosch.xPosition + 20) >= autoLila2.xPosition) && (frosch.xPosition <= (autoLila2.xPosition + 20))) && (froschYPositionInHuepfern == 2)) ||
               ((((frosch.xPosition + 20) >= autoGruen1.xPosition) && (frosch.xPosition <= (autoGruen1.xPosition + 20)) || ((frosch.xPosition + 20) >= autoGruen2.xPosition) && (frosch.xPosition <= (autoGruen2.xPosition + 20))) && (froschYPositionInHuepfern == 3)) ||
               ((((frosch.xPosition + 20) >= autoGruen3.xPosition) && (frosch.xPosition <= (autoGruen3.xPosition + 20)) || ((frosch.xPosition + 20) >= autoGruen4.xPosition) && (frosch.xPosition <= (autoGruen4.xPosition + 20))) && (froschYPositionInHuepfern == 3)) ||
               ((((frosch.xPosition + 20) >= autoPink1.xPosition) && (frosch.xPosition <= (autoPink1.xPosition + 20)) || ((frosch.xPosition + 20) >= autoPink2.xPosition) && (frosch.xPosition <= (autoPink2.xPosition + 20))) && (froschYPositionInHuepfern == 4)) ||
               ((((frosch.xPosition + 20) >= autoWeiss1.xPosition) && (frosch.xPosition <= (autoWeiss1.xPosition + 48)) || ((frosch.xPosition + 20) >= autoWeiss2.xPosition) && (frosch.xPosition <= (autoWeiss2.xPosition + 48))) && (froschYPositionInHuepfern == 5)) ||
                ((tauch1 && (froschYPositionInHuepfern == 7)) || (tauch2 && (froschYPositionInHuepfern == 10))) ||
              (!(((((frosch.xPosition + 14) >= schildKroete11.xPosition) && ((frosch.xPosition + 14) <= (schildKroete11.xPosition + 28))) || (((frosch.xPosition + 14) >= schildKroete12.xPosition) && ((frosch.xPosition + 14) <= (schildKroete12.xPosition + 28)))) ||
                 ((((frosch.xPosition + 14) >= schildKroete13.xPosition) && ((frosch.xPosition + 14) <= (schildKroete13.xPosition + 28))) || (((frosch.xPosition + 14) >= schildKroete14.xPosition) && ((frosch.xPosition + 14) <= (schildKroete14.xPosition + 28)))) ||
                 ((((frosch.xPosition + 14) >= schildKroete15.xPosition) && ((frosch.xPosition + 14) <= (schildKroete15.xPosition + 28))) || (((frosch.xPosition + 14) >= schildKroete16.xPosition) && ((frosch.xPosition + 14) <= (schildKroete16.xPosition + 28))))) && (froschYPositionInHuepfern == 7)) ||
              (!(((((frosch.xPosition + 14) >= schildKroete21.xPosition) && ((frosch.xPosition + 14) <= (schildKroete21.xPosition + 28))) || (((frosch.xPosition + 14) >= schildKroete22.xPosition) && ((frosch.xPosition + 14) <= (schildKroete22.xPosition + 28)))) ||
                 ((((frosch.xPosition + 14) >= schildKroete23.xPosition) && ((frosch.xPosition + 14) <= (schildKroete23.xPosition + 28))) || (((frosch.xPosition + 14) >= schildKroete24.xPosition) && ((frosch.xPosition + 14) <= (schildKroete24.xPosition + 28))))) && (froschYPositionInHuepfern == 10)) ||
              (!(((((frosch.xPosition + 14) >= StammLang11.xPosition) && ((frosch.xPosition + 14) <= (StammLang11.xPosition + 56))) || (((frosch.xPosition + 14) >= StammLang12.xPosition) && ((frosch.xPosition + 14) <= (StammLang12.xPosition + 56)))) ||
                 ((((frosch.xPosition + 14) >= StammLang13.xPosition) && ((frosch.xPosition + 14) <= (StammLang13.xPosition + 56))) || (((frosch.xPosition + 14) >= StammLang14.xPosition) && ((frosch.xPosition + 14) <= (StammLang14.xPosition + 56))))) && (froschYPositionInHuepfern == 9)) ||
              (!(((((frosch.xPosition + 14) >= Kurz21.xPosition) && ((frosch.xPosition + 14) <= (Kurz21.xPosition + 56))) || (((frosch.xPosition + 14) >= Kurz22.xPosition) && ((frosch.xPosition + 14) <= (Kurz22.xPosition + 56)))) ||
                 ((((frosch.xPosition + 14) >= Kurz23.xPosition) && ((frosch.xPosition + 14) <= (Kurz23.xPosition + 56))) || (((frosch.xPosition + 14) >= Kurz24.xPosition) && ((frosch.xPosition + 14) <= (Kurz24.xPosition + 56))))) && (froschYPositionInHuepfern == 11)) ||
              (!(((((frosch.xPosition + 14) >= Kurz11.xPosition) && ((frosch.xPosition + 14) <= (Kurz11.xPosition + 56))) || (((frosch.xPosition + 14) >= Kurz12.xPosition) && ((frosch.xPosition + 14) <= (Kurz12.xPosition + 56)))) ||
                 ((((frosch.xPosition + 14) >= Kurz13.xPosition) && ((frosch.xPosition + 14) <= (Kurz13.xPosition + 56))))) && (froschYPositionInHuepfern == 8)))
            {
                Neustart();
            }
            #endregion
        }


        #region Ebenen
        public void Ebene1(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            Rand fragment1 = new Rand();
            Rand fragment2 = new Rand();
            Rand fragment3 = new Rand();
            Rand fragment4 = new Rand();
            Rand fragment5 = new Rand();
            Rand fragment6 = new Rand();
            Rand fragment7 = new Rand();
            Rand fragment8 = new Rand();
            Rand fragment9 = new Rand();
            Rand fragment10 = new Rand();
            Rand fragment11 = new Rand();
            Rand fragment12 = new Rand();
            Rand fragment13 = new Rand();

            Level[] ebenenElemente;
            ebenenElemente = new Level[]
            {
                        fragment1, fragment2 ,fragment3 ,fragment4 ,fragment5 ,fragment6 ,fragment7 ,fragment8 ,fragment9 ,fragment10 ,fragment11, fragment12, fragment13
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((pixelGreosse) * 7) * 1) + offset; xPositionen[1] = (((pixelGreosse) * 7) * 2) + offset; xPositionen[2] = (((pixelGreosse) * 7) * 3) + offset;
            xPositionen[3] = (((pixelGreosse) * 7) * 4) + offset; xPositionen[4] = (((pixelGreosse) * 7) * 5) + offset; xPositionen[5] = (((pixelGreosse) * 7) * 6) + offset;
            xPositionen[6] = (((pixelGreosse) * 7) * 7) + offset; xPositionen[7] = (((pixelGreosse) * 7) * 8) + offset; xPositionen[8] = (((pixelGreosse) * 7) * 9) + offset;
            xPositionen[9] = (((pixelGreosse) * 7) * 10) + offset; xPositionen[10] = (((pixelGreosse) * 7) * 11) + offset; xPositionen[11] = (((pixelGreosse) * 7) * 12) + offset;
            xPositionen[12] = (((pixelGreosse) * 7) * 13) + offset;

            yPositionen[0] = (163 * pixelGreosse); yPositionen[1] = (163 * pixelGreosse); yPositionen[2] = (163 * pixelGreosse);
            yPositionen[3] = (163 * pixelGreosse); yPositionen[4] = (163 * pixelGreosse); yPositionen[5] = (163 * pixelGreosse);
            yPositionen[6] = (163 * pixelGreosse); yPositionen[7] = (163 * pixelGreosse); yPositionen[8] = (163 * pixelGreosse);
            yPositionen[9] = (163 * pixelGreosse); yPositionen[10] = (163 * pixelGreosse); yPositionen[11] = (163 * pixelGreosse);
            yPositionen[12] = (163 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene2(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            Rand fragment1 = new Rand();
            Rand fragment2 = new Rand();
            Rand fragment3 = new Rand();
            Rand fragment4 = new Rand();
            Rand fragment5 = new Rand();
            Rand fragment6 = new Rand();
            Rand fragment7 = new Rand();
            Rand fragment8 = new Rand();
            Rand fragment9 = new Rand();
            Rand fragment10 = new Rand();
            Rand fragment11 = new Rand();
            Rand fragment12 = new Rand();
            Rand fragment13 = new Rand();

            Level[] ebenenElemente;
            ebenenElemente = new Level[]
            {
                        fragment1, fragment2 ,fragment3 ,fragment4 ,fragment5 ,fragment6 ,fragment7 ,fragment8 ,fragment9 ,fragment10 ,fragment11, fragment12, fragment13
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((pixelGreosse) * 7) * 1) + offset; xPositionen[1] = (((pixelGreosse) * 7) * 2) + offset; xPositionen[2] = (((pixelGreosse) * 7) * 3) + offset;
            xPositionen[3] = (((pixelGreosse) * 7) * 4) + offset; xPositionen[4] = (((pixelGreosse) * 7) * 5) + offset; xPositionen[5] = (((pixelGreosse) * 7) * 6) + offset;
            xPositionen[6] = (((pixelGreosse) * 7) * 7) + offset; xPositionen[7] = (((pixelGreosse) * 7) * 8) + offset; xPositionen[8] = (((pixelGreosse) * 7) * 9) + offset;
            xPositionen[9] = (((pixelGreosse) * 7) * 10) + offset; xPositionen[10] = (((pixelGreosse) * 7) * 11) + offset; xPositionen[11] = (((pixelGreosse) * 7) * 12) + offset;
            xPositionen[12] = (((pixelGreosse) * 7) * 13) + offset;

            yPositionen[0] = (153 * pixelGreosse); yPositionen[1] = (153 * pixelGreosse); yPositionen[2] = (153 * pixelGreosse);
            yPositionen[3] = (153 * pixelGreosse); yPositionen[4] = (153 * pixelGreosse); yPositionen[5] = (153 * pixelGreosse);
            yPositionen[6] = (153 * pixelGreosse); yPositionen[7] = (153 * pixelGreosse); yPositionen[8] = (153 * pixelGreosse);
            yPositionen[9] = (153 * pixelGreosse); yPositionen[10] = (153 * pixelGreosse); yPositionen[11] = (153 * pixelGreosse);
            yPositionen[12] = (153 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene3(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            Rand fragment1 = new Rand();
            Rand fragment2 = new Rand();
            Rand fragment3 = new Rand();
            Rand fragment4 = new Rand();
            Rand fragment5 = new Rand();
            Rand fragment6 = new Rand();
            Rand fragment7 = new Rand();
            Rand fragment8 = new Rand();
            Rand fragment9 = new Rand();
            Rand fragment10 = new Rand();
            Rand fragment11 = new Rand();
            Rand fragment12 = new Rand();
            Rand fragment13 = new Rand();

            Level[] ebenenElemente;
            ebenenElemente = new Level[]
            {
                        fragment1, fragment2 ,fragment3 ,fragment4 ,fragment5 ,fragment6 ,fragment7 ,fragment8 ,fragment9 ,fragment10 ,fragment11, fragment12, fragment13
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((pixelGreosse) * 7) * 1) + offset; xPositionen[1] = (((pixelGreosse) * 7) * 2) + offset; xPositionen[2] = (((pixelGreosse) * 7) * 3) + offset;
            xPositionen[3] = (((pixelGreosse) * 7) * 4) + offset; xPositionen[4] = (((pixelGreosse) * 7) * 5) + offset; xPositionen[5] = (((pixelGreosse) * 7) * 6) + offset;
            xPositionen[6] = (((pixelGreosse) * 7) * 7) + offset; xPositionen[7] = (((pixelGreosse) * 7) * 8) + offset; xPositionen[8] = (((pixelGreosse) * 7) * 9) + offset;
            xPositionen[9] = (((pixelGreosse) * 7) * 10) + offset; xPositionen[10] = (((pixelGreosse) * 7) * 11) + offset; xPositionen[11] = (((pixelGreosse) * 7) * 12) + offset;
            xPositionen[12] = (((pixelGreosse) * 7) * 13) + offset;

            yPositionen[0] = (145 * pixelGreosse); yPositionen[1] = (145 * pixelGreosse); yPositionen[2] = (145 * pixelGreosse);
            yPositionen[3] = (145 * pixelGreosse); yPositionen[4] = (145 * pixelGreosse); yPositionen[5] = (145 * pixelGreosse);
            yPositionen[6] = (145 * pixelGreosse); yPositionen[7] = (145 * pixelGreosse); yPositionen[8] = (145 * pixelGreosse);
            yPositionen[9] = (145 * pixelGreosse); yPositionen[10] = (145 * pixelGreosse); yPositionen[11] = (145 * pixelGreosse);
            yPositionen[12] = (145 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene4(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            Rand fragment1 = new Rand();
            Bordstein fragment2 = new Bordstein();
            Bordstein fragment3 = new Bordstein();
            Bordstein fragment4 = new Bordstein();
            Bordstein fragment5 = new Bordstein();
            Bordstein fragment6 = new Bordstein();
            Bordstein fragment7 = new Bordstein();
            Bordstein fragment8 = new Bordstein();
            Bordstein fragment9 = new Bordstein();
            Bordstein fragment10 = new Bordstein();
            Bordstein fragment11 = new Bordstein();
            Bordstein fragment12 = new Bordstein();
            Rand fragment13 = new Rand();

            Level[] ebenenElemente;
            ebenenElemente = new Level[]
            {
                        fragment1, fragment2 ,fragment3 ,fragment4 ,fragment5 ,fragment6 ,fragment7 ,fragment8 ,fragment9 ,fragment10 ,fragment11, fragment12, fragment13
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((pixelGreosse) * 7) * 1) + offset; xPositionen[1] = (((pixelGreosse) * 7) * 2) + offset; xPositionen[2] = (((pixelGreosse) * 7) * 3) + offset;
            xPositionen[3] = (((pixelGreosse) * 7) * 4) + offset; xPositionen[4] = (((pixelGreosse) * 7) * 5) + offset; xPositionen[5] = (((pixelGreosse) * 7) * 6) + offset;
            xPositionen[6] = (((pixelGreosse) * 7) * 7) + offset; xPositionen[7] = (((pixelGreosse) * 7) * 8) + offset; xPositionen[8] = (((pixelGreosse) * 7) * 9) + offset;
            xPositionen[9] = (((pixelGreosse) * 7) * 10) + offset; xPositionen[10] = (((pixelGreosse) * 7) * 11) + offset; xPositionen[11] = (((pixelGreosse) * 7) * 12) + offset;
            xPositionen[12] = (((pixelGreosse) * 7) * 13) + offset;

            yPositionen[0] = (135 * pixelGreosse); yPositionen[1] = (135 * pixelGreosse); yPositionen[2] = (135 * pixelGreosse);
            yPositionen[3] = (135 * pixelGreosse); yPositionen[4] = (135 * pixelGreosse); yPositionen[5] = (135 * pixelGreosse);
            yPositionen[6] = (135 * pixelGreosse); yPositionen[7] = (135 * pixelGreosse); yPositionen[8] = (135 * pixelGreosse);
            yPositionen[9] = (135 * pixelGreosse); yPositionen[10] = (135 * pixelGreosse); yPositionen[11] = (135 * pixelGreosse);
            yPositionen[12] = (135 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene5(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            Rand fragment1 = new Rand();
            Rand fragment2 = new Rand();

            Level[] ebenenElemente;
            ebenenElemente = new Level[]
            {
                        fragment1, fragment2
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((pixelGreosse) * 7) * 1) + offset; xPositionen[1] = (((pixelGreosse) * 7) * 13) + offset;

            yPositionen[0] = (125 * pixelGreosse); yPositionen[1] = (125 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene6(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            Rand fragment1 = new Rand();
            Rand fragment2 = new Rand();

            Level[] ebenenElemente;
            ebenenElemente = new Level[]
            {
                        fragment1, fragment2
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((pixelGreosse) * 7) * 1) + offset; xPositionen[1] = (((pixelGreosse) * 7) * 13) + offset;

            yPositionen[0] = (115 * pixelGreosse); yPositionen[1] = (115 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene7(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            Rand fragment1 = new Rand();
            Rand fragment2 = new Rand();

            Level[] ebenenElemente;
            ebenenElemente = new Level[]
            {
                        fragment1, fragment2
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((pixelGreosse) * 7) * 1) + offset; xPositionen[1] = (((pixelGreosse) * 7) * 13) + offset;

            yPositionen[0] = (105 * pixelGreosse); yPositionen[1] = (105 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene8(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            Rand fragment1 = new Rand();
            Rand fragment2 = new Rand();

            Level[] ebenenElemente;
            ebenenElemente = new Level[]
            {
                        fragment1, fragment2
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((pixelGreosse) * 7) * 1) + offset; xPositionen[1] = (((pixelGreosse) * 7) * 13) + offset;

            yPositionen[0] = (95 * pixelGreosse); yPositionen[1] = (95 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene9(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            Rand fragment1 = new Rand();
            Rand fragment2 = new Rand();

            Level[] ebenenElemente;
            ebenenElemente = new Level[]
            {
                        fragment1, fragment2
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((pixelGreosse) * 7) * 1) + offset; xPositionen[1] = (((pixelGreosse) * 7) * 13) + offset;

            yPositionen[0] = (85 * pixelGreosse); yPositionen[1] = (85 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene11(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            Rand fragment1 = new Rand();
            Bordstein fragment2 = new Bordstein();
            Bordstein fragment3 = new Bordstein();
            Bordstein fragment4 = new Bordstein();
            Bordstein fragment5 = new Bordstein();
            Bordstein fragment6 = new Bordstein();
            Bordstein fragment7 = new Bordstein();
            Bordstein fragment8 = new Bordstein();
            Bordstein fragment9 = new Bordstein();
            Bordstein fragment10 = new Bordstein();
            Bordstein fragment11 = new Bordstein();
            Bordstein fragment12 = new Bordstein();
            Rand fragment13 = new Rand();

            Level[] ebenenElemente;
            ebenenElemente = new Level[]
            {
                        fragment1, fragment2 ,fragment3 ,fragment4 ,fragment5 ,fragment6 ,fragment7 ,fragment8 ,fragment9 ,fragment10 ,fragment11, fragment12, fragment13
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((pixelGreosse) * 7) * 1) + offset; xPositionen[1] = (((pixelGreosse) * 7) * 2) + offset; xPositionen[2] = (((pixelGreosse) * 7) * 3) + offset;
            xPositionen[3] = (((pixelGreosse) * 7) * 4) + offset; xPositionen[4] = (((pixelGreosse) * 7) * 5) + offset; xPositionen[5] = (((pixelGreosse) * 7) * 6) + offset;
            xPositionen[6] = (((pixelGreosse) * 7) * 7) + offset; xPositionen[7] = (((pixelGreosse) * 7) * 8) + offset; xPositionen[8] = (((pixelGreosse) * 7) * 9) + offset;
            xPositionen[9] = (((pixelGreosse) * 7) * 10) + offset; xPositionen[10] = (((pixelGreosse) * 7) * 11) + offset; xPositionen[11] = (((pixelGreosse) * 7) * 12) + offset;
            xPositionen[12] = (((pixelGreosse) * 7) * 13) + offset;

            yPositionen[0] = (75 * pixelGreosse); yPositionen[1] = (75 * pixelGreosse); yPositionen[2] = (75 * pixelGreosse);
            yPositionen[3] = (75 * pixelGreosse); yPositionen[4] = (75 * pixelGreosse); yPositionen[5] = (75 * pixelGreosse);
            yPositionen[6] = (75 * pixelGreosse); yPositionen[7] = (75 * pixelGreosse); yPositionen[8] = (75 * pixelGreosse);
            yPositionen[9] = (75 * pixelGreosse); yPositionen[10] = (75 * pixelGreosse); yPositionen[11] = (75 * pixelGreosse);
            yPositionen[12] = (75 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene12(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            Rand fragment1 = new Rand();
            Wasser fragment2 = new Wasser();
            Wasser fragment3 = new Wasser();
            Wasser fragment4 = new Wasser();
            Wasser fragment5 = new Wasser();
            Wasser fragment6 = new Wasser();
            Wasser fragment7 = new Wasser();
            Wasser fragment8 = new Wasser();
            Wasser fragment9 = new Wasser();
            Wasser fragment10 = new Wasser();
            Wasser fragment11 = new Wasser();
            Wasser fragment12 = new Wasser();
            Rand fragment13 = new Rand();

            Level[] ebenenElemente;
            ebenenElemente = new Level[]
            {
                        fragment1, fragment2 ,fragment3 ,fragment4 ,fragment5 ,fragment6 ,fragment7 ,fragment8 ,fragment9 ,fragment10 ,fragment11, fragment12, fragment13
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((pixelGreosse) * 7) * 1) + offset; xPositionen[1] = (((pixelGreosse) * 7) * 2) + offset; xPositionen[2] = (((pixelGreosse) * 7) * 3) + offset;
            xPositionen[3] = (((pixelGreosse) * 7) * 4) + offset; xPositionen[4] = (((pixelGreosse) * 7) * 5) + offset; xPositionen[5] = (((pixelGreosse) * 7) * 6) + offset;
            xPositionen[6] = (((pixelGreosse) * 7) * 7) + offset; xPositionen[7] = (((pixelGreosse) * 7) * 8) + offset; xPositionen[8] = (((pixelGreosse) * 7) * 9) + offset;
            xPositionen[9] = (((pixelGreosse) * 7) * 10) + offset; xPositionen[10] = (((pixelGreosse) * 7) * 11) + offset; xPositionen[11] = (((pixelGreosse) * 7) * 12) + offset;
            xPositionen[12] = (((pixelGreosse) * 7) * 13) + offset;

            yPositionen[0] = (65 * pixelGreosse); yPositionen[1] = (65 * pixelGreosse); yPositionen[2] = (65 * pixelGreosse);
            yPositionen[3] = (65 * pixelGreosse); yPositionen[4] = (65 * pixelGreosse); yPositionen[5] = (65 * pixelGreosse);
            yPositionen[6] = (65 * pixelGreosse); yPositionen[7] = (65 * pixelGreosse); yPositionen[8] = (65 * pixelGreosse);
            yPositionen[9] = (65 * pixelGreosse); yPositionen[10] = (65 * pixelGreosse); yPositionen[11] = (65 * pixelGreosse);
            yPositionen[12] = (65 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene13(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            Rand fragment1 = new Rand();
            Wasser fragment2 = new Wasser();
            Wasser fragment3 = new Wasser();
            Wasser fragment4 = new Wasser();
            Wasser fragment5 = new Wasser();
            Wasser fragment6 = new Wasser();
            Wasser fragment7 = new Wasser();
            Wasser fragment8 = new Wasser();
            Wasser fragment9 = new Wasser();
            Wasser fragment10 = new Wasser();
            Wasser fragment11 = new Wasser();
            Wasser fragment12 = new Wasser();
            Rand fragment13 = new Rand();

            Level[] ebenenElemente;
            ebenenElemente = new Level[]
            {
                        fragment1, fragment2 ,fragment3 ,fragment4 ,fragment5 ,fragment6 ,fragment7 ,fragment8 ,fragment9 ,fragment10 ,fragment11, fragment12, fragment13
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((pixelGreosse) * 7) * 1) + offset; xPositionen[1] = (((pixelGreosse) * 7) * 2) + offset; xPositionen[2] = (((pixelGreosse) * 7) * 3) + offset;
            xPositionen[3] = (((pixelGreosse) * 7) * 4) + offset; xPositionen[4] = (((pixelGreosse) * 7) * 5) + offset; xPositionen[5] = (((pixelGreosse) * 7) * 6) + offset;
            xPositionen[6] = (((pixelGreosse) * 7) * 7) + offset; xPositionen[7] = (((pixelGreosse) * 7) * 8) + offset; xPositionen[8] = (((pixelGreosse) * 7) * 9) + offset;
            xPositionen[9] = (((pixelGreosse) * 7) * 10) + offset; xPositionen[10] = (((pixelGreosse) * 7) * 11) + offset; xPositionen[11] = (((pixelGreosse) * 7) * 12) + offset;
            xPositionen[12] = (((pixelGreosse) * 7) * 13) + offset;

            yPositionen[0] = (55 * pixelGreosse); yPositionen[1] = (55 * pixelGreosse); yPositionen[2] = (55 * pixelGreosse);
            yPositionen[3] = (55 * pixelGreosse); yPositionen[4] = (55 * pixelGreosse); yPositionen[5] = (55 * pixelGreosse);
            yPositionen[6] = (55 * pixelGreosse); yPositionen[7] = (55 * pixelGreosse); yPositionen[8] = (55 * pixelGreosse);
            yPositionen[9] = (55 * pixelGreosse); yPositionen[10] = (55 * pixelGreosse); yPositionen[11] = (55 * pixelGreosse);
            yPositionen[12] = (55 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene14(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            Rand fragment1 = new Rand();
            Wasser fragment2 = new Wasser();
            Wasser fragment3 = new Wasser();
            Wasser fragment4 = new Wasser();
            Wasser fragment5 = new Wasser();
            Wasser fragment6 = new Wasser();
            Wasser fragment7 = new Wasser();
            Wasser fragment8 = new Wasser();
            Wasser fragment9 = new Wasser();
            Wasser fragment10 = new Wasser();
            Wasser fragment11 = new Wasser();
            Wasser fragment12 = new Wasser();
            Rand fragment13 = new Rand();

            Level[] ebenenElemente;
            ebenenElemente = new Level[]
            {
                        fragment1, fragment2 ,fragment3 ,fragment4 ,fragment5 ,fragment6 ,fragment7 ,fragment8 ,fragment9 ,fragment10 ,fragment11, fragment12, fragment13
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((pixelGreosse) * 7) * 1) + offset; xPositionen[1] = (((pixelGreosse) * 7) * 2) + offset; xPositionen[2] = (((pixelGreosse) * 7) * 3) + offset;
            xPositionen[3] = (((pixelGreosse) * 7) * 4) + offset; xPositionen[4] = (((pixelGreosse) * 7) * 5) + offset; xPositionen[5] = (((pixelGreosse) * 7) * 6) + offset;
            xPositionen[6] = (((pixelGreosse) * 7) * 7) + offset; xPositionen[7] = (((pixelGreosse) * 7) * 8) + offset; xPositionen[8] = (((pixelGreosse) * 7) * 9) + offset;
            xPositionen[9] = (((pixelGreosse) * 7) * 10) + offset; xPositionen[10] = (((pixelGreosse) * 7) * 11) + offset; xPositionen[11] = (((pixelGreosse) * 7) * 12) + offset;
            xPositionen[12] = (((pixelGreosse) * 7) * 13) + offset;

            yPositionen[0] = (45 * pixelGreosse); yPositionen[1] = (45 * pixelGreosse); yPositionen[2] = (45 * pixelGreosse);
            yPositionen[3] = (45 * pixelGreosse); yPositionen[4] = (45 * pixelGreosse); yPositionen[5] = (45 * pixelGreosse);
            yPositionen[6] = (45 * pixelGreosse); yPositionen[7] = (45 * pixelGreosse); yPositionen[8] = (45 * pixelGreosse);
            yPositionen[9] = (45 * pixelGreosse); yPositionen[10] = (45 * pixelGreosse); yPositionen[11] = (45 * pixelGreosse);
            yPositionen[12] = (45 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene15(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            Rand fragment1 = new Rand();
            Wasser fragment2 = new Wasser();
            Wasser fragment3 = new Wasser();
            Wasser fragment4 = new Wasser();
            Wasser fragment5 = new Wasser();
            Wasser fragment6 = new Wasser();
            Wasser fragment7 = new Wasser();
            Wasser fragment8 = new Wasser();
            Wasser fragment9 = new Wasser();
            Wasser fragment10 = new Wasser();
            Wasser fragment11 = new Wasser();
            Wasser fragment12 = new Wasser();
            Rand fragment13 = new Rand();

            Level[] ebenenElemente;
            ebenenElemente = new Level[]
            {
                        fragment1, fragment2 ,fragment3 ,fragment4 ,fragment5 ,fragment6 ,fragment7 ,fragment8 ,fragment9 ,fragment10 ,fragment11, fragment12, fragment13
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((pixelGreosse) * 7) * 1) + offset; xPositionen[1] = (((pixelGreosse) * 7) * 2) + offset; xPositionen[2] = (((pixelGreosse) * 7) * 3) + offset;
            xPositionen[3] = (((pixelGreosse) * 7) * 4) + offset; xPositionen[4] = (((pixelGreosse) * 7) * 5) + offset; xPositionen[5] = (((pixelGreosse) * 7) * 6) + offset;
            xPositionen[6] = (((pixelGreosse) * 7) * 7) + offset; xPositionen[7] = (((pixelGreosse) * 7) * 8) + offset; xPositionen[8] = (((pixelGreosse) * 7) * 9) + offset;
            xPositionen[9] = (((pixelGreosse) * 7) * 10) + offset; xPositionen[10] = (((pixelGreosse) * 7) * 11) + offset; xPositionen[11] = (((pixelGreosse) * 7) * 12) + offset;
            xPositionen[12] = (((pixelGreosse) * 7) * 13) + offset;

            yPositionen[0] = (35 * pixelGreosse); yPositionen[1] = (35 * pixelGreosse); yPositionen[2] = (35 * pixelGreosse);
            yPositionen[3] = (35 * pixelGreosse); yPositionen[4] = (35 * pixelGreosse); yPositionen[5] = (35 * pixelGreosse);
            yPositionen[6] = (35 * pixelGreosse); yPositionen[7] = (35 * pixelGreosse); yPositionen[8] = (35 * pixelGreosse);
            yPositionen[9] = (35 * pixelGreosse); yPositionen[10] = (35 * pixelGreosse); yPositionen[11] = (35 * pixelGreosse);
            yPositionen[12] = (35 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene16(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            Rand fragment1 = new Rand();
            Wasser fragment2 = new Wasser();
            Wasser fragment3 = new Wasser();
            Wasser fragment4 = new Wasser();
            Wasser fragment5 = new Wasser();
            Wasser fragment6 = new Wasser();
            Wasser fragment7 = new Wasser();
            Wasser fragment8 = new Wasser();
            Wasser fragment9 = new Wasser();
            Wasser fragment10 = new Wasser();
            Wasser fragment11 = new Wasser();
            Wasser fragment12 = new Wasser();
            Rand fragment13 = new Rand();

            Level[] ebenenElemente;
            ebenenElemente = new Level[]
            {
                        fragment1, fragment2 ,fragment3 ,fragment4 ,fragment5 ,fragment6 ,fragment7 ,fragment8 ,fragment9 ,fragment10 ,fragment11, fragment12, fragment13
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((pixelGreosse) * 7) * 1) + offset; xPositionen[1] = (((pixelGreosse) * 7) * 2) + offset; xPositionen[2] = (((pixelGreosse) * 7) * 3) + offset;
            xPositionen[3] = (((pixelGreosse) * 7) * 4) + offset; xPositionen[4] = (((pixelGreosse) * 7) * 5) + offset; xPositionen[5] = (((pixelGreosse) * 7) * 6) + offset;
            xPositionen[6] = (((pixelGreosse) * 7) * 7) + offset; xPositionen[7] = (((pixelGreosse) * 7) * 8) + offset; xPositionen[8] = (((pixelGreosse) * 7) * 9) + offset;
            xPositionen[9] = (((pixelGreosse) * 7) * 10) + offset; xPositionen[10] = (((pixelGreosse) * 7) * 11) + offset; xPositionen[11] = (((pixelGreosse) * 7) * 12) + offset;
            xPositionen[12] = (((pixelGreosse) * 7) * 13) + offset;

            yPositionen[0] = (25 * pixelGreosse); yPositionen[1] = (25 * pixelGreosse); yPositionen[2] = (25 * pixelGreosse);
            yPositionen[3] = (25 * pixelGreosse); yPositionen[4] = (25 * pixelGreosse); yPositionen[5] = (25 * pixelGreosse);
            yPositionen[6] = (25 * pixelGreosse); yPositionen[7] = (25 * pixelGreosse); yPositionen[8] = (25 * pixelGreosse);
            yPositionen[9] = (25 * pixelGreosse); yPositionen[10] = (25 * pixelGreosse); yPositionen[11] = (25 * pixelGreosse);
            yPositionen[12] = (25 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }


        public void Ebene17(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            Rand fragment1 = new Rand();
            Rand fragment2 = new Rand();
            Wasser fragment3 = new Wasser();
            Rand fragment4 = new Rand();
            Wasser fragment5 = new Wasser();
            Rand fragment6 = new Rand();
            Wasser fragment7 = new Wasser();
            Rand fragment8 = new Rand();
            Wasser fragment9 = new Wasser();
            Rand fragment10 = new Rand();
            Wasser fragment11 = new Wasser();
            Rand fragment12 = new Rand();
            Rand fragment13 = new Rand();

            Level[] ebenenElemente;
            ebenenElemente = new Level[]
            {
                        fragment1, fragment2 ,fragment3 ,fragment4 ,fragment5 ,fragment6 ,fragment7 ,fragment8 ,fragment9 ,fragment10 ,fragment11, fragment12, fragment13
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = (((pixelGreosse) * 7) * 1) + offset; xPositionen[1] = (((pixelGreosse) * 7) * 2) + offset; xPositionen[2] = (((pixelGreosse) * 7) * 3) + offset;
            xPositionen[3] = (((pixelGreosse) * 7) * 4) + offset; xPositionen[4] = (((pixelGreosse) * 7) * 5) + offset; xPositionen[5] = (((pixelGreosse) * 7) * 6) + offset;
            xPositionen[6] = (((pixelGreosse) * 7) * 7) + offset; xPositionen[7] = (((pixelGreosse) * 7) * 8) + offset; xPositionen[8] = (((pixelGreosse) * 7) * 9) + offset;
            xPositionen[9] = (((pixelGreosse) * 7) * 10) + offset; xPositionen[10] = (((pixelGreosse) * 7) * 11) + offset; xPositionen[11] = (((pixelGreosse) * 7) * 12) + offset;
            xPositionen[12] = (((pixelGreosse) * 7) * 13) + offset;

            yPositionen[0] = (15 * pixelGreosse); yPositionen[1] = (15 * pixelGreosse); yPositionen[2] = (15 * pixelGreosse);
            yPositionen[3] = (15 * pixelGreosse); yPositionen[4] = (15 * pixelGreosse); yPositionen[5] = (15 * pixelGreosse);
            yPositionen[6] = (15 * pixelGreosse); yPositionen[7] = (15 * pixelGreosse); yPositionen[8] = (15 * pixelGreosse);
            yPositionen[9] = (15 * pixelGreosse); yPositionen[10] = (15 * pixelGreosse); yPositionen[11] = (15 * pixelGreosse);
            yPositionen[12] = (15 * pixelGreosse);
            #endregion

            verteilungEbene(ebenenElemente, xPositionen, yPositionen);

            FaerbenEbene(ebenenElemente, e, xPositionen, yPositionen);
        }
        #endregion


        #region Extra Elemente


        #region Schildkroeten1
        public SchildKroete SchildKroete11Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            SchildKroete auto = new SchildKroete();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 12) + offset - bewegungsZaehler13);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler13 = 0;
            }

            yPositionen[0] = (66 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            if (tauch1)
            {
                auto.Tauchen();
            }

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public SchildKroete SchildKroete12Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            SchildKroete auto = new SchildKroete();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 11) + offset - bewegungsZaehler14);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler14 = -28;
            }

            yPositionen[0] = (66 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            if (tauch1)
            {
                auto.Tauchen();
            }

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public SchildKroete SchildKroete13Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            SchildKroete auto = new SchildKroete();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 10) + offset - bewegungsZaehler15);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler15 = -56;
            }

            yPositionen[0] = (66 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            if (tauch1)
            {
                auto.Tauchen();
            }

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public SchildKroete SchildKroete14Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            SchildKroete auto = new SchildKroete();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 7) + offset - bewegungsZaehler16);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler16 = -140;
            }

            yPositionen[0] = (66 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            if (tauch1)
            {
                auto.Tauchen();
            }

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public SchildKroete SchildKroete15Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            SchildKroete auto = new SchildKroete();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 6) + offset - bewegungsZaehler17);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler17 = -168;
            }

            yPositionen[0] = (66 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            if (tauch1)
            {
                auto.Tauchen();
            }

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public SchildKroete SchildKroete16Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            SchildKroete auto = new SchildKroete();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 5) + offset - bewegungsZaehler18);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler18 = -196;
            }

            yPositionen[0] = (66 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            if (tauch1)
            {
                auto.Tauchen();
            }

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }
        #endregion


        #region Kurze Staemme1
        public StammKurz StammKurz11Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            StammKurz auto = new StammKurz();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 2) + offset + bewegungsZaehler23);

            if (xPositionen[0] >= 687)
            {
                bewegungsZaehler23 = 0;
            }

            yPositionen[0] = (56 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public StammKurz StammKurz12Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            StammKurz auto = new StammKurz();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 5) + offset + bewegungsZaehler24);

            if (xPositionen[0] >= 687)
            {
                bewegungsZaehler24 = -85;
            }

            yPositionen[0] = (56 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public StammKurz StammKurz13Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            StammKurz auto = new StammKurz();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 8) + offset + bewegungsZaehler25);

            if (xPositionen[0] >= 687)
            {
                bewegungsZaehler25 = -170;
            }

            yPositionen[0] = (56 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }
        #endregion


        #region Lange Staemme 1
        public StammLang StammLang11Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            StammLang auto = new StammLang();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 2) + offset + bewegungsZaehler26);

            if (xPositionen[0] >= 687)
            {
                bewegungsZaehler26 = 0;
            }

            yPositionen[0] = (46 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public StammLang StammLang12Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            StammLang auto = new StammLang();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 4) + offset + bewegungsZaehler27);

            if (xPositionen[0] >= 687)
            {
                bewegungsZaehler27 = -56;
            }

            yPositionen[0] = (46 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public StammLang StammLang13Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            StammLang auto = new StammLang();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 6) + offset + bewegungsZaehler28);
            if (xPositionen[0] >= 687)
            {
                bewegungsZaehler28 = -112;
            }

            yPositionen[0] = (46 * pixelGreosse);
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public StammLang StammLang14Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            StammLang auto = new StammLang();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 8) + offset + bewegungsZaehler29);
            if (xPositionen[0] >= 687)
            {
                bewegungsZaehler29 = -168;
            }

            yPositionen[0] = (46 * pixelGreosse);
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }
        #endregion


        #region Schildkroeten2
        public SchildKroete SchildKroete21Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            SchildKroete auto = new SchildKroete();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 12) + offset - bewegungsZaehler19);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler19 = 0;
            }

            yPositionen[0] = (36 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            if (tauch2)
            {
                auto.Tauchen();
            }

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public SchildKroete SchildKroete22Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            SchildKroete auto = new SchildKroete();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 11) + offset - bewegungsZaehler20);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler20 = -28;
            }

            yPositionen[0] = (36 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            if (tauch2)
            {
                auto.Tauchen();
            }

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public SchildKroete SchildKroete23Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            SchildKroete auto = new SchildKroete();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 7) + offset - bewegungsZaehler21);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler21 = -140;
            }

            yPositionen[0] = (36 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            if (tauch2)
            {
                auto.Tauchen();
            }

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public SchildKroete SchildKroete24Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            SchildKroete auto = new SchildKroete();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 6) + offset - bewegungsZaehler22);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler22 = -168;
            }

            yPositionen[0] = (36 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            if (tauch2)
            {
                auto.Tauchen();
            }

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }
        #endregion


        #region Lange Staemme2
        public StammLang StammLang21Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            StammLang auto = new StammLang();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 2) + offset + bewegungsZaehler30);

            if (xPositionen[0] >= 687)
            {
                bewegungsZaehler30 = 0;
            }

            yPositionen[0] = (26 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public StammLang StammLang22Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            StammLang auto = new StammLang();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 4) + offset + bewegungsZaehler31);

            if (xPositionen[0] >= 687)
            {
                bewegungsZaehler31 = -56;
            }

            yPositionen[0] = (26 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public StammLang StammLang23Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            StammLang auto = new StammLang();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 7) + offset + bewegungsZaehler32);

            if (xPositionen[0] >= 687)
            {
                bewegungsZaehler32 = -140;
            }

            yPositionen[0] = (26 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public StammLang StammLang24Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            StammLang auto = new StammLang();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 9) + offset + bewegungsZaehler33);

            if (xPositionen[0] >= 687)
            {
                bewegungsZaehler33 = -196;
            }

            yPositionen[0] = (26 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }
        #endregion


        #region Tuempel
        public void Tuempel1(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;

            FroschSicher fragment1 = new FroschSicher();

            Figuren[] ebenenElemente;
            ebenenElemente = new Figuren[]
            {
                        fragment1
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = 434;

            yPositionen[0] = 64;
            #endregion

            verteilungFigur(ebenenElemente, xPositionen, yPositionen);

            FaerbenFigure(ebenenElemente, e, xPositionen, yPositionen);
        }

        public void Tuempel2(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;

            FroschSicher fragment1 = new FroschSicher();

            Figuren[] ebenenElemente;
            ebenenElemente = new Figuren[]
            {
                        fragment1
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = 490;

            yPositionen[0] = 64;
            #endregion

            verteilungFigur(ebenenElemente, xPositionen, yPositionen);

            FaerbenFigure(ebenenElemente, e, xPositionen, yPositionen);
        }

        public void Tuempel3(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;

            FroschSicher fragment1 = new FroschSicher();

            Figuren[] ebenenElemente;
            ebenenElemente = new Figuren[]
            {
                        fragment1
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = 546;

            yPositionen[0] = 64;
            #endregion

            verteilungFigur(ebenenElemente, xPositionen, yPositionen);

            FaerbenFigure(ebenenElemente, e, xPositionen, yPositionen);
        }

        public void Tuempel4(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;

            FroschSicher fragment1 = new FroschSicher();

            Figuren[] ebenenElemente;
            ebenenElemente = new Figuren[]
            {
                        fragment1
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = 602;

            yPositionen[0] = 64;
            #endregion

            verteilungFigur(ebenenElemente, xPositionen, yPositionen);

            FaerbenFigure(ebenenElemente, e, xPositionen, yPositionen);
        }

        public void Tuempel5(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;

            FroschSicher fragment1 = new FroschSicher();

            Figuren[] ebenenElemente;
            ebenenElemente = new Figuren[]
            {
                        fragment1
            };

            xPositionen = new int[ebenenElemente.GetLength(0)];
            yPositionen = new int[ebenenElemente.GetLength(0)];

            #region Ebenen Aufbau
            xPositionen[0] = 658;

            yPositionen[0] = 64;
            #endregion

            verteilungFigur(ebenenElemente, xPositionen, yPositionen);

            FaerbenFigure(ebenenElemente, e, xPositionen, yPositionen);
        }
        #endregion
        #endregion


        #region Figuren


        #region Frosch
        public Frog FrogSetzen(PaintEventArgs e, KeyEventArgs a)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            Frog frog = new Frog();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        frog
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];


            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 7) + offset + froschXPosition);

            yPositionen[0] = (136 * pixelGreosse + froschYPosition);

            frog.xPosition = xPositionen[0];
            frog.yPosition = yPositionen[0];

            #region Bewegung
            switch (a.KeyCode)
            {
                case Keys.Up:
                    if (!tastensperre && (froschYPositionInHuepfern != 12))
                    {
                        if (froschYPositionInHuepfern == 11)
                        {
                            if ((xPositionen[0] >= 429) && (xPositionen[0] <= 439))
                            {
                                xPositionen[0] = 434;
                                froschYPositionInHuepfern++;
                                froschYPosition = froschYPosition - 40;
                                tuempe1Erreicht = true;
                                Neustart();
                            }
                            else if ((xPositionen[0] >= 485) && (xPositionen[0] <= 495))
                            {
                                xPositionen[0] = 490;
                                froschYPositionInHuepfern++;
                                froschYPosition = froschYPosition - 40;
                                tuempe2Erreicht = true;
                                Neustart();
                            }
                            else if ((xPositionen[0] >= 541) && (xPositionen[0] <= 551))
                            {
                                xPositionen[0] = 546;
                                froschYPositionInHuepfern++;
                                froschYPosition = froschYPosition - 40;
                                tuempe3Erreicht = true;
                                Neustart();
                            }
                            else if ((xPositionen[0] >= 597) && (xPositionen[0] <= 607))
                            {
                                xPositionen[0] = 605;
                                froschYPositionInHuepfern++;
                                froschYPosition = froschYPosition - 40;
                                tuempe4Erreicht = true;
                                Neustart();
                            }
                            else if ((xPositionen[0] >= 653) && (xPositionen[0] <= 663))
                            {
                                xPositionen[0] = 658;
                                froschYPositionInHuepfern++;
                                froschYPosition = froschYPosition - 40;
                                tuempe5Erreicht = true;
                                Neustart();
                            }
                        }
                        else
                        {
                            froschYPositionInHuepfern++;
                            froschYPosition = froschYPosition - 40;
                        }
                    }

                    froschRichtung = 0;
                    tastensperre = true;
                    break;
                case Keys.Right:
                    if (!tastensperre && (xPositionen[0] != 686))
                    {
                        froschRichtung = 1;
                        froschXPosition = froschXPosition + 28;
                        tastensperre = true;
                    }
                    break;
                case Keys.Down:
                    if (!tastensperre && (froschYPositionInHuepfern != 0))
                    {
                        froschYPositionInHuepfern--;
                        froschRichtung = 2;
                        froschYPosition = froschYPosition + 40;
                        tastensperre = true;
                    }
                    break;
                case Keys.Left:
                    if (!tastensperre && (xPositionen[0] != 406))
                    {
                        froschRichtung = 3;
                        froschXPosition = froschXPosition - 28;
                        tastensperre = true;
                    }
                    break;
                case Keys.P:
                    tastensperre = false;
                    break;
                default:
                    break;
            }

            if(((froschYPositionInHuepfern == 7) || (froschYPositionInHuepfern == 8) || (froschYPositionInHuepfern == 9) ||
                (froschYPositionInHuepfern == 10) || (froschYPositionInHuepfern == 11)) && 
               ((xPositionen[0] == 405) || (xPositionen[0] == 687)))
            {
                Neustart();
            }
            
            #endregion

            #endregion


            verteilungFigur(figuren, xPositionen, yPositionen);


            #region Richtung
            switch (froschRichtung)
            {
                case 1:
                    frog.Rechts();
                    break;
                case 2:
                    frog.Runter();
                    break;
                case 3:
                    frog.Links();
                    break;
                default:
                    break;
            }
            #endregion


            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (frog);
        }
        #endregion


        #region Orange Autos
        public AutoOrange AutoOrange1Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            AutoOrange auto = new AutoOrange();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 12) + offset - bewegungsZaehler1);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler1 = 0;
            }

            yPositionen[0] = (126 * pixelGreosse);
   
            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public AutoOrange AutoOrange2Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            AutoOrange auto = new AutoOrange();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 6) + offset - bewegungsZaehler2);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler2 = -168;
            }

            yPositionen[0] = (126 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }
        #endregion


        #region Lila Autos
        public AutoLila AutoLila1Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            AutoLila auto = new AutoLila();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 2) + offset + bewegungsZaehler3);

            if (xPositionen[0] >= 687)
            {
                bewegungsZaehler3 = 0;
            }

            yPositionen[0] = (116 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public AutoLila AutoLila2Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            AutoLila auto = new AutoLila();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 6) + offset + bewegungsZaehler4);

            if (xPositionen[0] >= 687)
            {
                bewegungsZaehler4 = -115;
            }

            yPositionen[0] = (116 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }
        #endregion


        #region Gruene Autos
        public AutoGruen AutoGruen1Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            AutoGruen auto = new AutoGruen();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 12) + offset - bewegungsZaehler5);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler5 = 0;
            }

            yPositionen[0] = (106 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public AutoGruen AutoGruen2Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            AutoGruen auto = new AutoGruen();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 10) + offset - bewegungsZaehler6);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler6 = -56;
            }

            yPositionen[0] = (106 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public AutoGruen AutoGruen3Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            AutoGruen auto = new AutoGruen();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 7) + offset - bewegungsZaehler7);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler7 = -140;
            }

            yPositionen[0] = (106 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public AutoGruen AutoGruen4Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            AutoGruen auto = new AutoGruen();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 5) + offset - bewegungsZaehler8);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler8 = -196;
            }

            yPositionen[0] = (106 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }
        #endregion


        #region Pinks Autos
        public AutoPink AutoPink1Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            AutoPink auto = new AutoPink();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 2) + offset + bewegungsZaehler9);

            if (xPositionen[0] >= 687)
            {
                bewegungsZaehler9 = 0;
            }

            yPositionen[0] = (96 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public AutoPink AutoPink2Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            AutoPink auto = new AutoPink();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 6) + offset + bewegungsZaehler10);

            if (xPositionen[0] >= 687)
            {
                bewegungsZaehler10 = -108;
            }

            yPositionen[0] = (96 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }
        #endregion


        #region Weisse Autos
        public AutoWeiss AutoWeiss1Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            AutoWeiss auto = new AutoWeiss();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 11) + offset - bewegungsZaehler11);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler11 = 0;
            }

            yPositionen[0] = (86 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }


        public AutoWeiss AutoWeiss2Setzen(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 4;
            int offset = 350;

            AutoWeiss auto = new AutoWeiss();

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        auto
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((7 * pixelGreosse) * 6) + offset - bewegungsZaehler12);

            if (xPositionen[0] <= 405)
            {
                bewegungsZaehler12 = -140;
            }

            yPositionen[0] = (86 * pixelGreosse);

            auto.xPosition = xPositionen[0];
            auto.yPosition = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (auto);
        }
        #endregion
        #endregion


        public void FaerbenFigure(Figuren[] figurArray, PaintEventArgs e, int[] xPosition, int[] yPosition)
        {
            Graphics g = e.Graphics;
            int pixelGroesse = 4;

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
                            case 17:
                                g.FillRectangle(Brushes.LightGreen, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
                                break;
                        }
                    }
                }
            }
        }


        public void FaerbenEbene(Level[] ebenenElementeArray, PaintEventArgs e, int[] xPosition, int[] yPosition)
        {
            Graphics g = e.Graphics;

            int pixelGroesse = 4;

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
                            case 17:
                                g.FillRectangle(Brushes.LightGreen, new Rectangle((j * pixelGroesse) + xPosition[l], (i * pixelGroesse) + yPosition[l], pixelGroesse, pixelGroesse));
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
            #region Allgemein
            neustart = false;
            #endregion


            #region Zaehler für verschieden schnelle Bewegungen
            zeitHilf1 = 0;
            zeitHilf2 = 0;
            zeitHilf3 = 0;
            zeitHilf4 = 0;
            #endregion


            #region Frosch Hilfen
            tastensperre = false;
            froschRichtung = 0;

            froschXPosition = 0;
            froschYPosition = 0;
            froschYPositionInHuepfern = 0;

            hochLock = false;
            rechtsLock = false;
            runterLock = false;
            linksLock = false;
            #endregion


            #region Auto Zeahler
            bewegungsZaehler1 = 0;
            bewegungsZaehler2 = 0;

            bewegungsZaehler3 = 0;
            bewegungsZaehler4 = 0;

            bewegungsZaehler5 = 0;
            bewegungsZaehler6 = 0;
            bewegungsZaehler7 = 0;
            bewegungsZaehler8 = 0;

            bewegungsZaehler9 = 0;
            bewegungsZaehler10 = 0;

            bewegungsZaehler11 = 0;
            bewegungsZaehler12 = 0;
            #endregion


            #region Schildkroeten Zeahler und tauch
            bewegungsZaehler13 = 0;
            bewegungsZaehler14 = 0;
            bewegungsZaehler15 = 0;

            bewegungsZaehler16 = 0;
            bewegungsZaehler17 = 0;
            bewegungsZaehler18 = 0;

            bewegungsZaehler19 = 0;
            bewegungsZaehler20 = 0;

            bewegungsZaehler21 = 0;
            bewegungsZaehler22 = 0;

            tauch1 = false;
            tauch2 = true;
            #endregion


            #region Staemme Zeahler
            bewegungsZaehler23 = 0;
            bewegungsZaehler24 = 0;
            bewegungsZaehler25 = 0;

            bewegungsZaehler26 = 0;
            bewegungsZaehler27 = 0;
            bewegungsZaehler28 = 0;
            bewegungsZaehler29 = 0;

            bewegungsZaehler30 = 0;
            bewegungsZaehler31 = 0;
            bewegungsZaehler32 = 0;
            bewegungsZaehler33 = 0;
            #endregion
        }


        public void LevelBeendedt()
        {
            #region Allgemein
            neustart = false;
            #endregion


            #region Zaehler für verschieden schnelle Bewegungen
            zeitHilf1 = 0;
            zeitHilf2 = 0;
            zeitHilf3 = 0;
            zeitHilf4 = 0;

            #endregion


            #region Frosch Hilfen
            tastensperre = false;
            froschRichtung = 0;

            froschXPosition = 0;
            froschYPosition = 0;
            froschYPositionInHuepfern = 0;

            hochLock = false;
            rechtsLock = false;
            runterLock = false;
            linksLock = false;
            #endregion


            #region Auto Zeahler
            bewegungsZaehler1 = 0;
            bewegungsZaehler2 = 0;

            bewegungsZaehler3 = 0;
            bewegungsZaehler4 = 0;

            bewegungsZaehler5 = 0;
            bewegungsZaehler6 = 0;
            bewegungsZaehler7 = 0;
            bewegungsZaehler8 = 0;

            bewegungsZaehler9 = 0;
            bewegungsZaehler10 = 0;

            bewegungsZaehler11 = 0;
            bewegungsZaehler12 = 0;
            #endregion


            #region Schildkroeten Zeahler und tauch
            bewegungsZaehler13 = 0;
            bewegungsZaehler14 = 0;
            bewegungsZaehler15 = 0;

            bewegungsZaehler16 = 0;
            bewegungsZaehler17 = 0;
            bewegungsZaehler18 = 0;

            bewegungsZaehler19 = 0;
            bewegungsZaehler20 = 0;

            bewegungsZaehler21 = 0;
            bewegungsZaehler22 = 0;

            tauch1 = false;
            tauch2 = true;
            #endregion


            #region Staemme Zeahler
            bewegungsZaehler23 = 0;
            bewegungsZaehler24 = 0;
            bewegungsZaehler25 = 0;

            bewegungsZaehler26 = 0;
            bewegungsZaehler27 = 0;
            bewegungsZaehler28 = 0;
            bewegungsZaehler29 = 0;

            bewegungsZaehler30 = 0;
            bewegungsZaehler31 = 0;
            bewegungsZaehler32 = 0;
            bewegungsZaehler33 = 0;
            #endregion


            #region Tuempel Erreicht?
            tuempe1Erreicht = false;
            tuempe2Erreicht = false;
            tuempe3Erreicht = false;
            tuempe4Erreicht = false;
            tuempe5Erreicht = false;
            #endregion
        }
    }
}

