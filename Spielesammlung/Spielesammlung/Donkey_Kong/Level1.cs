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
        public static bool neustart = false;
        public bool levelbeendedt = false;
        public int affeHilf;

        #region Mario
        public static int marioXPositionen = 0;
        public static int marioYPositionen = 0;
        public static int xMario = 0;
        public static int yMario = 0;
        public static bool blickRichtungMario = false;
        public static bool marioSchritt = false;
        public static int marioZeahler = 0;
        public static int marioSprungHoehe = 0;
        public static bool mariospringen = false;
        public static int marioEbene = 1;
        public static int marioLeiterPositionHoch = 0;
        public static int marioLeiterPositionRunter = 0;
        public static int marioEbenenHilf = 0;
        public static int marioEbenenHilf2Left = 0;
        public static int marioEbenenHilf2Right = 0;
        #endregion

        #region Counter für die versätzt startenden Fässer
        public static int count1 = 0;
        public static int count2 = 0;
        public static int count3 = 0;
        #endregion

        #region Faesser
        #region Fass1
        public static int fass1XPositionen = 0;
        public static int fass1YPositionen = 0;
        public static int zufalllLeiterFallHilfe1 = 0;
        public static int zufall1 = new Random().Next(0, 2000);
        public static bool leiterLockFass1 = false;
        public static bool leiterEbene1LockFass1 = false;
        public static bool ebenenLock1Fass1 = false;
        public static bool ebenenLock2Fass1 = false;
        public static bool ebenenLock3Fass1 = false;
        public static bool ebenenLock4Fass1 = false;
        public static bool ebenenLock5Fass1 = false;
        public static bool ebenenLock6Fass1 = false;
        public static int faesserHilfFass1 = 0;
        public static bool fallenFass1 = false;
        public static bool gefallenFass1 = false;
        public static int fassYGesamtFass1 = 0;
        public static int fassHilf1 = 1;
        public static int yFassHilf1 = 0;
        public static bool randFass1 = false;
        public static int fass1Ebene = 6;
        public static int fass1EbenenHilfe = 0;
        public static int fass1EbenenHilfe2 = 0;
        #endregion

        #region Fass2
        public static int fass2XPositionen = 0;
        public static int fass2YPositionen = 0;
        public static int zufalllLeiterFallHilfe2 = 0;
        public static int zufall2 = new Random().Next(0, 2000);
        public static bool leiterLockFass2 = false;
        public static bool leiterEbene1LockFass2 = false;
        public static bool ebenenLock1Fass2 = false;
        public static bool ebenenLock2Fass2 = false;
        public static bool ebenenLock3Fass2 = false;
        public static bool ebenenLock4Fass2 = false;
        public static bool ebenenLock5Fass2 = false;
        public static bool ebenenLock6Fass2 = false;
        public static int faesserHilfFass2 = 0;
        public static bool fallenFass2 = false;
        public static bool gefallenFass2 = false;
        public static int fassYGesamtFass2 = 0;
        public static int fassHilf2 = 1;
        public static int yFassHilf2 = 0;
        public static bool randFass2 = false;
        public static int fass2Ebene = 6;
        public static int fass2EbenenHilfe = 0;
        public static int fass2EbenenHilfe2 = 0;
        #endregion

        #region Fass3
        public static int fass3XPositionen = 0;
        public static int fass3YPositionen = 0;
        public static int zufalllLeiterFallHilfe3 = 0;
        public static int zufall3 = new Random().Next(0, 2000);
        public static bool leiterLockFass3 = false;
        public static bool leiterEbene1LockFass3 = false;
        public static bool ebenenLock1Fass3 = false;
        public static bool ebenenLock2Fass3 = false;
        public static bool ebenenLock3Fass3 = false;
        public static bool ebenenLock4Fass3 = false;
        public static bool ebenenLock5Fass3 = false;
        public static bool ebenenLock6Fass3 = false;
        public static int faesserHilfFass3 = 0;
        public static bool fallenFass3 = false;
        public static bool gefallenFass3 = false;
        public static int fassYGesamtFass3 = 0;
        public static int fassHilf3 = 1;
        public static int yFassHilf3 = 0;
        public static bool randFass3 = false;
        public static int fass3Ebene = 6;
        public static int fass3EbenenHilfe = 0;
        public static int fass3EbenenHilfe2 = 0;
        #endregion

        #region Fass4
        public static int fass4XPositionen = 0;
        public static int fass4YPositionen = 0;
        public static int zufalllLeiterFallHilfe4 = 0;
        public static int zufall4 = new Random().Next(0, 2000);
        public static bool leiterLockFass4 = false;
        public static bool leiterEbene1LockFass4 = false;
        public static bool ebenenLock1Fass4 = false;
        public static bool ebenenLock2Fass4 = false;
        public static bool ebenenLock3Fass4 = false;
        public static bool ebenenLock4Fass4 = false;
        public static bool ebenenLock5Fass4 = false;
        public static bool ebenenLock6Fass4 = false;
        public static int faesserHilfFass4 = 0;
        public static bool fallenFass4 = false;
        public static bool gefallenFass4 = false;
        public static int fassYGesamtFass4 = 0;
        public static int fassHilf4 = 1;
        public static int yFassHilf4 = 0;
        public static bool randFass4 = false;
        public static int fass4Ebene = 6;
        public static int fass4EbenenHilfe = 0;
        public static int fass4EbenenHilfe2 = 0;
        #endregion
        #endregion

        public Level1(PaintEventArgs e, int affe, int fass1, int fass2, int fass3, int fass4, KeyEventArgs a)
        {
            affeHilf = affe;
            faesserHilfFass1 = fass1;
            faesserHilfFass2 = fass2;
            faesserHilfFass3 = fass3;
            faesserHilfFass4 = fass4;
            Level1Laden(e, a);
        }


        private void Level1Laden(PaintEventArgs e, KeyEventArgs a)
        {
            #region Leitern
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
            #endregion

            #region Ebenen
            Ebene1Lila(e);
            Ebene2Lila(e);
            Ebene3Lila(e);
            Ebene4Lila(e);
            Ebene5Lila(e);
            Ebene6Lila(e);
            Ebene7Lila(e);
            #endregion

            #region Affe
            if (affeHilf > 200)
            {
                AffeSetzen(e);
            }
            else if (affeHilf <= 200)
            {
                AffeSetzen(e).AendereBlickRichtung();
            }
            #endregion

            if ((((marioXPositionen == (fass1XPositionen - 8)) || ((marioXPositionen == (fass1XPositionen + 8)))) && (marioYPositionen >= (fass1YPositionen - 51)) && (marioYPositionen <= (fass1YPositionen + 2))) ||
                 ((marioXPositionen == (fass2XPositionen - 8)) && (marioYPositionen >= (fass2YPositionen - 51)) && (marioYPositionen <= (fass2YPositionen + 2))) ||
                 ((marioXPositionen == (fass3XPositionen - 8)) && (marioYPositionen >= (fass3YPositionen - 51)) && (marioYPositionen <= (fass3YPositionen + 2))) ||
                 ((marioXPositionen == (fass4XPositionen - 8)) && (marioYPositionen >= (fass4YPositionen - 51)) && (marioYPositionen <= (fass4YPositionen + 2))))
            {
                Neustart();
            }

            PeachSetzen(e);
            //HammerSetzen(e);            
            MarioSetzen(e, a);

            #region Fass1            
           if (fass1Ebene == 1 || fass1Ebene == 6)
           {
               fass1EbenenHilfe2 = 0;
           }
           else if ((fass1Ebene == 2) || (fass1Ebene == 3) || (fass1Ebene == 4) || (fass1Ebene == 5))
           {
                if (fass1EbenenHilfe2 > 14)
                {
                    fass1EbenenHilfe++;
                    fass1EbenenHilfe2 = 0;
                }               
                else if (fass1EbenenHilfe2 <= 14)
                {
                    fass1EbenenHilfe2++;
                }
           }           

           if (((fass1Ebene == 3) || (fass1Ebene == 4) || (fass1Ebene == 2)) && (leiterLockFass1 == false))
           {
                fassYGesamtFass1 = (fassYGesamtFass1 - 8);
                leiterLockFass1 = true;
           }

           if ((fass1Ebene == 1) && (leiterEbene1LockFass1 == false))
           {
                fassYGesamtFass1 = (fassYGesamtFass1 - 18);
                leiterEbene1LockFass1 = true;
            }

            if (fallenFass1 == true)
           {
                FassSetzen1(e).Fall();
           }
           else if (faesserHilfFass1 > 23)
           {
                FassSetzen1(e);
           }
           else if (faesserHilfFass1 <= 23)
           {
                FassSetzen1(e).Dreh();
           }
            #endregion

            count1++;
            count2++;
            count3++;

            if (count1 >= 650)
            {
                #region Fass2           
                if (fass2Ebene == 1 || fass2Ebene == 6)
                {
                    fass2EbenenHilfe2 = 0;
                }
                else if ((fass2Ebene == 2) || (fass2Ebene == 3) || (fass2Ebene == 4) || (fass2Ebene == 5))
                {
                    if (fass2EbenenHilfe2 > 14)
                    {
                        fass2EbenenHilfe++;
                        fass2EbenenHilfe2 = 0;
                    }
                    else if (fass2EbenenHilfe2 <= 14)
                    {
                        fass2EbenenHilfe2++;
                    }
                }

                if (((fass2Ebene == 3) || (fass2Ebene == 4) || (fass2Ebene == 2)) && (leiterLockFass2 == false))
                {
                    fassYGesamtFass2 = (fassYGesamtFass2 - 8);
                    leiterLockFass2 = true;
                }

                if ((fass2Ebene == 1) && (leiterEbene1LockFass2 == false))
                {
                    fassYGesamtFass2 = (fassYGesamtFass2 - 18);
                    leiterEbene1LockFass2 = true;
                }

                if (fallenFass2 == true)
                {
                    FassSetzen2(e).Fall();
                }
                else if (faesserHilfFass2 > 23)
                {
                    FassSetzen2(e);
                }
                else if (faesserHilfFass2 <= 23)
                {
                    FassSetzen2(e).Dreh();
                }
                #endregion
            }

            if (count2 >= 1300)
            {
                #region Fass3           
                if (fass3Ebene == 1 || fass3Ebene == 6)
                {
                    fass3EbenenHilfe2 = 0;
                }
                else if ((fass3Ebene == 2) || (fass3Ebene == 3) || (fass3Ebene == 4) || (fass3Ebene == 5))
                {
                    if (fass3EbenenHilfe2 > 14)
                    {
                        fass3EbenenHilfe++;
                        fass3EbenenHilfe2 = 0;
                    }
                    else if (fass3EbenenHilfe2 <= 14)
                    {
                        fass3EbenenHilfe2++;
                    }
                }

                if (((fass3Ebene == 3) || (fass3Ebene == 4) || (fass3Ebene == 2)) && (leiterLockFass3 == false))
                {
                    fassYGesamtFass3 = (fassYGesamtFass3 - 8);
                    leiterLockFass3 = true;
                }

                if ((fass3Ebene == 1) && (leiterEbene1LockFass3 == false))
                {
                    fassYGesamtFass3 = (fassYGesamtFass3 - 18);
                    leiterEbene1LockFass3 = true;
                }

                if (fallenFass3 == true)
                {
                    FassSetzen3(e).Fall();
                }
                else if (faesserHilfFass3 > 23)
                {
                    FassSetzen3(e);
                }
                else if (faesserHilfFass3 <= 23)
                {
                    FassSetzen3(e).Dreh();
                }
                #endregion
            }

            if (count3 >= 1950)
            {
                #region Fass4          
                if (fass4Ebene == 1 || fass4Ebene == 6)
                {
                    fass4EbenenHilfe2 = 0;
                }
                else if ((fass4Ebene == 2) || (fass4Ebene == 3) || (fass4Ebene == 4) || (fass4Ebene == 5))
                {
                    if (fass4EbenenHilfe2 > 14)
                    {
                        fass4EbenenHilfe++;
                        fass4EbenenHilfe2 = 0;
                    }
                    else if (fass4EbenenHilfe2 <= 14)
                    {
                        fass4EbenenHilfe2++;
                    }
                }

                if (((fass4Ebene == 3) || (fass4Ebene == 4) || (fass4Ebene == 2)) && (leiterLockFass4 == false))
                {
                    fassYGesamtFass4 = (fassYGesamtFass4 - 8);
                    leiterLockFass4 = true;
                }

                if ((fass4Ebene == 1) && (leiterEbene1LockFass4 == false))
                {
                    fassYGesamtFass4 = (fassYGesamtFass4 - 18);
                    leiterEbene1LockFass4 = true;
                }

                if (fallenFass4 == true)
                {
                    FassSetzen4(e).Fall();
                }
                else if (faesserHilfFass4 > 23)
                {
                    FassSetzen4(e);
                }
                else if (faesserHilfFass4 <= 23)
                {
                    FassSetzen4(e).Dreh();
                }
                #endregion
            }
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
            xPositionen[0] = (((17 * pixelGreosse) * 1) + (offset + 27)); xPositionen[1] = (((17 * pixelGreosse) * 2) + offset);
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


        public Mario MarioSetzen(PaintEventArgs e, KeyEventArgs a)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;

            Mario kong = new Mario(a);

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        kong
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            xPositionen[0] = (((18 * pixelGreosse) * 2) + offset + xMario);

            yPositionen[0] = (205 * pixelGreosse + yMario + marioEbenenHilf);

            if(marioEbene == 7)
            {
                levelbeendedt = true;
            }
            else if ((((a.KeyCode == Keys.Up) && ((xPositionen[0] >= 609) && (xPositionen[0] <= 629) && (marioEbene == 1)))) && marioLeiterPositionHoch <= 62)
            {
                yMario--;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioLeiterPositionHoch++;
                marioZeahler++;

            }
            else if ((((a.KeyCode == Keys.Up) && ((xPositionen[0] >= 483) && (xPositionen[0] <= 503) && (marioEbene == 2)))) && marioLeiterPositionHoch <= 90)
            {
                yMario--;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioLeiterPositionHoch++;
                marioZeahler++;
            }
            else if ((((a.KeyCode == Keys.Up) && ((xPositionen[0] >= 352) && (xPositionen[0] <= 372) && (marioEbene == 2)))) && marioLeiterPositionHoch <= 72)
            {
                yMario--;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioLeiterPositionHoch++;
                marioZeahler++;
            }
            else if ((((a.KeyCode == Keys.Up) && ((xPositionen[0] >= 517) && (xPositionen[0] <= 537) && (marioEbene == 3)))) && marioLeiterPositionHoch <= 85)
            {
                yMario--;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioLeiterPositionHoch++;
                marioZeahler++;
            }
            else if ((((a.KeyCode == Keys.Up) && ((xPositionen[0] >= 607) && (xPositionen[0] <= 627) && (marioEbene == 3)))) && marioLeiterPositionHoch <= 74)
            {
                yMario--;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioLeiterPositionHoch++;
                marioZeahler++;
            }
            else if ((((a.KeyCode == Keys.Up) && ((xPositionen[0] >= 443) && (xPositionen[0] <= 462) && (marioEbene == 4)))) && marioLeiterPositionHoch <= 85)
            {
                yMario--;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioLeiterPositionHoch++;
                marioZeahler++;
            }
            else if ((((a.KeyCode == Keys.Up) && ((xPositionen[0] >= 358) && (xPositionen[0] <= 378) && (marioEbene == 4)))) && marioLeiterPositionHoch <= 73)
            {
                yMario--;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioLeiterPositionHoch++;
                marioZeahler++;
            }
            else if ((((a.KeyCode == Keys.Up) && ((xPositionen[0] >= 607) && (xPositionen[0] <= 627) && (marioEbene == 5)))) && marioLeiterPositionHoch <= 70)
            {
                yMario--;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioLeiterPositionHoch++;
                marioZeahler++;
            }
            else if ((((a.KeyCode == Keys.Up) && ((xPositionen[0] >= 477) && (xPositionen[0] <= 497) && (marioEbene == 6)))) && marioLeiterPositionHoch <= 88)
            {
                yMario--;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioLeiterPositionHoch++;
                marioZeahler++;
            }
            else if ((((a.KeyCode == Keys.Up) && ((xPositionen[0] >= 291) && (xPositionen[0] <= 311) && (marioEbene == 6)))) && marioLeiterPositionHoch <= 88)
            {
                yMario--;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioLeiterPositionHoch++;
                marioZeahler++;
            }
            else if (((marioLeiterPositionHoch == 63) && (marioEbene == 1)) || ((marioLeiterPositionHoch == 91) && (marioEbene == 2)) ||
                     ((marioLeiterPositionHoch == 73) && (marioEbene == 2)) || ((marioLeiterPositionHoch == 86) && (marioEbene == 3)) ||
                     ((marioLeiterPositionHoch == 86) && (marioEbene == 4)) || ((marioLeiterPositionHoch == 75) && (marioEbene == 3)) ||
                     ((marioLeiterPositionHoch == 74) && (marioEbene == 4)) || ((marioLeiterPositionHoch == 71) && (marioEbene == 5)) ||
                     ((marioLeiterPositionHoch == 89) && (marioEbene == 6)))
            {
                marioEbene++;
                marioLeiterPositionHoch = 0;
            }
            else if ((yPositionen[0] >= 154) && ((a.KeyCode == Keys.Up)) &&
                    !((((xPositionen[0] >= 609) && (xPositionen[0] <= 629)) && marioEbene == 1) || (((xPositionen[0] >= 483) && (xPositionen[0] <= 503)) && marioEbene == 2) ||
                      (((xPositionen[0] >= 352) && (xPositionen[0] <= 372)) && marioEbene == 2) || (((xPositionen[0] >= 517) && (xPositionen[0] <= 537)) && marioEbene == 3) ||
                      (((xPositionen[0] >= 607) && (xPositionen[0] <= 627)) && marioEbene == 3) || (((xPositionen[0] >= 443) && (xPositionen[0] <= 462)) && marioEbene == 4) ||
                      (((xPositionen[0] >= 620) && (xPositionen[0] <= 640)) && marioEbene == 4) || (((xPositionen[0] >= 607) && (xPositionen[0] <= 627)) && marioEbene == 5)))
            {
                mariospringen = true;
            }
            else if (mariospringen == true)
            {
                if ((marioSprungHoehe < 50) && (marioSprungHoehe >= 0))
                {
                    if (blickRichtungMario == false)
                    {
                        yMario--;
                        kong.SpringenRechts();
                    }
                    else if (blickRichtungMario == true)
                    {
                        yMario--;
                        kong.SpringenLinks();
                    }
                    marioSprungHoehe++;
                }
                else if (marioSprungHoehe >= 50 && marioSprungHoehe <= 99)
                {
                    if (blickRichtungMario == false)
                    {
                        yMario++;
                        kong.SpringenRechts();
                    }
                    else if (blickRichtungMario == true)
                    {
                        yMario++;
                        kong.SpringenLinks();
                    }
                    marioSprungHoehe++;
                }
                else if (marioSprungHoehe >= 100)
                {
                    marioSprungHoehe = 0;
                    mariospringen = false;
                }
                else
                {
                    mariospringen = false;
                }
            }
            else if ((((a.KeyCode == Keys.Down) && ((xPositionen[0] >= 609) && (xPositionen[0] <= 629) && (marioEbene == 2)))) && marioLeiterPositionRunter <= 62)
            {
                yMario++;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioLeiterPositionRunter++;
                marioZeahler++;
            }
            else if ((((a.KeyCode == Keys.Down) && ((xPositionen[0] >= 483) && (xPositionen[0] <= 503) && (marioEbene == 3)))) && marioLeiterPositionRunter <= 90)
            {
                yMario++;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioLeiterPositionRunter++;
                marioZeahler++;
            }
            else if ((((a.KeyCode == Keys.Down) && ((xPositionen[0] >= 352) && (xPositionen[0] <= 372) && (marioEbene == 3)))) && marioLeiterPositionRunter <= 72)
            {
                yMario++;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioLeiterPositionRunter++;
                marioZeahler++;
            }
            else if ((((a.KeyCode == Keys.Down) && ((xPositionen[0] >= 517) && (xPositionen[0] <= 537) && (marioEbene == 4)))) && marioLeiterPositionRunter <= 85)
            {
                yMario++;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioLeiterPositionRunter++;
                marioZeahler++;
            }
            else if ((((a.KeyCode == Keys.Down) && ((xPositionen[0] >= 607) && (xPositionen[0] <= 627) && (marioEbene == 4)))) && marioLeiterPositionRunter <= 74)
            {
                yMario++;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioLeiterPositionRunter++;
                marioZeahler++;
            }
            else if ((((a.KeyCode == Keys.Down) && ((xPositionen[0] >= 443) && (xPositionen[0] <= 462) && (marioEbene == 5)))) && marioLeiterPositionRunter <= 85)
            {
                yMario++;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioLeiterPositionRunter++;
                marioZeahler++;
            }
            else if ((((a.KeyCode == Keys.Down) && ((xPositionen[0] >= 358) && (xPositionen[0] <= 378) && (marioEbene == 5)))) && marioLeiterPositionRunter <= 73)
            {
                yMario++;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioZeahler++;
                marioLeiterPositionRunter++;
            }
            else if ((((a.KeyCode == Keys.Down) && ((xPositionen[0] >= 607) && (xPositionen[0] <= 627) && (marioEbene == 6)))) && marioLeiterPositionRunter <= 70)
            {
                yMario++;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioZeahler++;
                marioLeiterPositionRunter++;
            }
            else if ((((a.KeyCode == Keys.Down) && ((xPositionen[0] >= 477) && (xPositionen[0] <= 497) && (marioEbene == 7)))) && marioLeiterPositionRunter <= 88)
            {
                yMario++;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioZeahler++;
                marioLeiterPositionRunter++;
            }
            else if ((((a.KeyCode == Keys.Down) && ((xPositionen[0] >= 291) && (xPositionen[0] <= 311) && (marioEbene == 7)))) && marioLeiterPositionRunter <= 88)
            {
                yMario++;

                if (marioZeahler < 9)
                {
                    kong.RechtsKlettern();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksKlettern();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }

                marioZeahler++;
                marioLeiterPositionRunter++;
            }
            else if (((marioLeiterPositionRunter == 63) && (marioEbene == 2)) || ((marioLeiterPositionRunter == 91) && (marioEbene == 3)) ||
                     ((marioLeiterPositionRunter == 73) && (marioEbene == 3)) || ((marioLeiterPositionRunter == 86) && (marioEbene == 4)) ||
                     ((marioLeiterPositionRunter == 86) && (marioEbene == 5)) || ((marioLeiterPositionRunter == 75) && (marioEbene == 4)) ||
                     ((marioLeiterPositionRunter == 74) && (marioEbene == 5)) || ((marioLeiterPositionRunter == 71) && (marioEbene == 6)) ||
                     ((marioLeiterPositionRunter == 89) && (marioEbene == 7)))
            {
                marioEbene--;
                marioLeiterPositionRunter = 0;
            }
            else if ((a.KeyCode == Keys.Right) && (xPositionen[0] < 685) && (marioLeiterPositionHoch == 0) && (marioLeiterPositionRunter == 0))
            {
                xMario++;
                marioEbenenHilf2Right++;

                if (marioEbenenHilf2Right > 16)
                {
                    if ((!(marioEbene == 1 || marioEbene == 6)) && ((marioEbene == 3) || (marioEbene == 5)))
                    {
                        marioEbenenHilf--;
                    }
                    else if ((!(marioEbene == 1 || marioEbene == 6)) && ((marioEbene == 2) || (marioEbene == 4)))
                    {
                        marioEbenenHilf++;
                    }

                    marioEbenenHilf2Right = 0;
                }

                if (marioZeahler < 9)
                {
                    kong.RechtsLauf();
                }
                else if (marioZeahler >= 9)
                {
                    kong.RechtsStehen();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }
                marioZeahler++;
                blickRichtungMario = false;
            }
            else if ((a.KeyCode == Keys.Left) && (xPositionen[0] >= 303) && (marioLeiterPositionHoch == 0) && (marioLeiterPositionRunter == 0))
            {
                xMario--;
                marioEbenenHilf2Left++;

                if (marioEbenenHilf2Left > 16)
                {
                    if ((!(marioEbene == 1 || marioEbene == 6)) && ((marioEbene == 2) || (marioEbene == 4)))
                    {
                        marioEbenenHilf--;
                    }
                    else if ((!(marioEbene == 1 || marioEbene == 6)) && ((marioEbene == 3) || (marioEbene == 5)))
                    {
                        marioEbenenHilf++;
                    }

                    marioEbenenHilf2Left = 0;
                }

                if (marioZeahler < 9)
                {
                    kong.LinksLauf();
                }
                else if (marioZeahler >= 9)
                {
                    kong.LinksStehen();

                    if (marioZeahler >= 17)
                    {
                        marioZeahler = 0;
                    }
                }
                marioZeahler++;
                blickRichtungMario = true;
            }
            else if (blickRichtungMario == false)
            {
                kong.RechtsStehen();
            }
            else if (blickRichtungMario == true)
            {
                kong.LinksStehen();
            }

            marioXPositionen = xPositionen[0];
            marioYPositionen = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (kong);
        }


        public Fass1 FassSetzen1(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;
            zufall1 = new Random().Next(0, 2000);

            Fass1 kong = new Fass1(fallenFass1);

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        kong
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            if ((fassHilf1 < 1 ) && (fass1Ebene == 1))
            {
                leiterLockFass1 = false;
                leiterEbene1LockFass1 = false;
                ebenenLock1Fass1 = false;
                ebenenLock2Fass1 = false;
                ebenenLock3Fass1 = false;
                ebenenLock4Fass1 = false;
                ebenenLock5Fass1 = false;
                ebenenLock6Fass1 = false;
                faesserHilfFass1 = 0;
                fallenFass1 = false;
                gefallenFass1 = false;
                fassYGesamtFass1 = 0;
                fassHilf1 = 1;
                yFassHilf1 = 0;
                randFass1 = false;
                fass1Ebene = 6;
                fass1EbenenHilfe = 0;
                fass1EbenenHilfe2 = 0;
            }

            if ((fassHilf1 == 380) && (gefallenFass1 == false))
            {
                randFass1 = true;
                fallenFass1 = true;
            }

            if ((fallenFass1 == true) && (gefallenFass1 == false))
            {
                yFassHilf1++;

                if (fass1Ebene == 6)
                {
                    if (yFassHilf1 >= 69)
                    {
                        fassYGesamtFass1 = fassYGesamtFass1 + yFassHilf1 + zufalllLeiterFallHilfe1;
                        fass1Ebene--;
                        yFassHilf1 = 0;
                        fallenFass1 = false;
                        gefallenFass1 = true;
                        leiterLockFass1 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }
                else if (fass1Ebene == 5)
                {
                    if (yFassHilf1 >= 68)
                    {
                        fassYGesamtFass1 = fassYGesamtFass1 + yFassHilf1 + zufalllLeiterFallHilfe1;
                        fass1Ebene--;
                        yFassHilf1 = 0;
                        fallenFass1 = false;
                        gefallenFass1 = true;
                        leiterLockFass1 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }
                else if (fass1Ebene == 4)
                {
                    if (yFassHilf1 >= 72)
                    {
                        fassYGesamtFass1 = fassYGesamtFass1 + yFassHilf1 + zufalllLeiterFallHilfe1;
                        fass1Ebene--;
                        yFassHilf1 = 0;
                        fallenFass1 = false;
                        gefallenFass1 = true;
                        leiterLockFass1 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }
                else if (fass1Ebene == 3)
                {
                    if (yFassHilf1 >= 68)
                    {
                        fassYGesamtFass1 = fassYGesamtFass1 + yFassHilf1 + zufalllLeiterFallHilfe1;
                        fass1Ebene--;
                        yFassHilf1 = 0;
                        fallenFass1 = false;
                        gefallenFass1 = true;
                        leiterLockFass1 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }
                else if (fass1Ebene == 2)
                {
                    if (yFassHilf1 >= 72)
                    {
                        fassYGesamtFass1 = fassYGesamtFass1 + yFassHilf1 + zufalllLeiterFallHilfe1;                       
                        fass1Ebene--;
                        yFassHilf1 = 0;
                        fallenFass1 = false;
                        gefallenFass1 = true;
                        leiterLockFass1 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }              

                xPositionen[0] = (17 * pixelGreosse) + offset + fassHilf1;

                yPositionen[0] = ((74 * pixelGreosse) + yFassHilf1 + fassYGesamtFass1 + fass1EbenenHilfe);                

            }
            else if ((fassHilf1 == 0) && (gefallenFass1 == false))
            {
                fallenFass1 = true;
            }
            else if ((fassHilf1 == 0) && (gefallenFass1 == true))
            {
                gefallenFass1 = false;

                xPositionen[0] = (17 * pixelGreosse) + offset + fassHilf1;

                yPositionen[0] = ((74 * pixelGreosse) + fassYGesamtFass1 + fass1EbenenHilfe);

                fassHilf1++;               

                if (randFass1 == false)
                {
                    randFass1 = true;
                }
                if (randFass1 == true)
                {
                     randFass1 = false;
                }               
            }
            else if ((fassHilf1 > 0) && (randFass1 == false))
            {
                gefallenFass1 = false;

                xPositionen[0] = (17 * pixelGreosse) + offset + fassHilf1;

                yPositionen[0] = ((74 * pixelGreosse) + fassYGesamtFass1 + fass1EbenenHilfe);

                fassHilf1++;
            }
            else if ((fassHilf1 > 0) && (randFass1 == true))
            {
                gefallenFass1 = false;

                xPositionen[0] = (17 * pixelGreosse) + offset + fassHilf1;

                yPositionen[0] = ((74 * pixelGreosse) + fassYGesamtFass1 + fass1EbenenHilfe);

                fassHilf1--;
            }

            //if (((zufall1 >= 1850) && (zufall1 < 2000)) && (((xPositionen[0] == 622) && (fass1Ebene == 2)) ||
            //    ((xPositionen[0] == 496) && (fass1Ebene == 3)) || ((xPositionen[0] == 365) && (fass1Ebene == 3)) ||
            //    ((xPositionen[0] == 530) && (fass1Ebene == 4)) || ((xPositionen[0] == 620) && (fass1Ebene == 4)) ||
            //    ((xPositionen[0] == 455) && (fass1Ebene == 5)) || ((xPositionen[0] == 366) && (fass1Ebene == 5)) ||
            //    ((xPositionen[0] == 620) && (fass1Ebene == 6))))
            //{
            //    if (randFass1 == false)
            //    {
            //        fallenFass1 = true;
            //        randFass1 = true;
            //    }
            //    else if (randFass1 == true)
            //    {
            //        fallenFass1 = true;
            //        randFass1 = false;
            //    }

            //    if(((xPositionen[0] == 455) && (fass1Ebene == 5)) || ((xPositionen[0] == 496) && (fass1Ebene == 3)) ||
            //        ((xPositionen[0] == 620) && (fass1Ebene == 4)))
            //    {
            //        if (fass1Ebene == 6)
            //        {
            //            zufalllLeiterFallHilfe1 = 10;
            //        }
            //        else if (fass1Ebene == 5)
            //        {
            //            zufalllLeiterFallHilfe1 = 25;
            //        }
            //        else if (fass1Ebene == 4)
            //        {
            //            zufalllLeiterFallHilfe1 = 30;
            //        }
            //        else if (fass1Ebene == 3)
            //        {
            //            zufalllLeiterFallHilfe1 = 30;
            //        }
            //        else if (fass1Ebene == 2)
            //        {
            //            zufalllLeiterFallHilfe1 = 20;
            //        }
            //    }
            //    else if (((xPositionen[0] == 620) && (fass1Ebene == 6)) || ((xPositionen[0] == 366) && (fass1Ebene == 5)) ||
            //             ((xPositionen[0] == 620) && (fass1Ebene == 4)) || ((xPositionen[0] == 365) && (fass1Ebene == 3)) ||
            //             ((xPositionen[0] == 624) && (fass1Ebene == 2)))
            //    {
            //        if (fass1Ebene == 6)
            //        {
            //            zufalllLeiterFallHilfe1 = 5;
            //        }
            //        else if (fass1Ebene == 5)
            //        {
            //            zufalllLeiterFallHilfe1 = 10;
            //        }
            //        else if (fass1Ebene == 4)
            //        {
            //            zufalllLeiterFallHilfe1 = 15;
            //        }
            //        else if (fass1Ebene == 3)
            //        {
            //            zufalllLeiterFallHilfe1 = 10;
            //        }
            //        else if (fass1Ebene == 2)
            //        {
            //            zufalllLeiterFallHilfe1 = 15;
            //        }
            //    }        
            //}

            fass1XPositionen = xPositionen[0];
            fass1YPositionen = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (kong);
        }


        public Fass2 FassSetzen2(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;
            zufall2 = new Random().Next(0, 2000);

            Fass2 kong = new Fass2(fallenFass2);

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        kong
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            if ((fassHilf2 < 1) && (fass2Ebene == 1))
            {
                leiterLockFass2 = false;
                leiterEbene1LockFass2 = false;
                ebenenLock1Fass2 = false;
                ebenenLock2Fass2 = false;
                ebenenLock3Fass2 = false;
                ebenenLock4Fass2 = false;
                ebenenLock5Fass2 = false;
                ebenenLock6Fass2 = false;
                faesserHilfFass2 = 0;
                fallenFass2 = false;
                gefallenFass2 = false;
                fassYGesamtFass2 = 0;
                fassHilf2 = 1;
                yFassHilf2 = 0;
                randFass2 = false;
                fass2Ebene = 6;
                fass2EbenenHilfe = 0;
                fass2EbenenHilfe2 = 0;
            }

            if ((fassHilf2 == 380) && (gefallenFass2 == false))
            {
                randFass2 = true;
                fallenFass2 = true;
            }

            if ((fallenFass2 == true) && (gefallenFass2 == false))
            {
                yFassHilf2++;

                if (fass2Ebene == 6)
                {
                    if (yFassHilf2 >= 69)
                    {
                        fassYGesamtFass2 = fassYGesamtFass2 + yFassHilf2 + zufalllLeiterFallHilfe2;
                        fass2Ebene--;
                        yFassHilf2 = 0;
                        fallenFass2 = false;
                        gefallenFass2 = true;
                        leiterLockFass2 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }
                else if (fass2Ebene == 5)
                {
                    if (yFassHilf2 >= 68)
                    {
                        fassYGesamtFass2 = fassYGesamtFass2 + yFassHilf2 + zufalllLeiterFallHilfe2;
                        fass2Ebene--;
                        yFassHilf2 = 0;
                        fallenFass2 = false;
                        gefallenFass2 = true;
                        leiterLockFass2 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }
                else if (fass2Ebene == 4)
                {
                    if (yFassHilf2 >= 72)
                    {
                        fassYGesamtFass2 = fassYGesamtFass2 + yFassHilf2 + zufalllLeiterFallHilfe2;
                        fass2Ebene--;
                        yFassHilf2 = 0;
                        fallenFass2 = false;
                        gefallenFass2 = true;
                        leiterLockFass2 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }
                else if (fass2Ebene == 3)
                {
                    if (yFassHilf2 >= 68)
                    {
                        fassYGesamtFass2 = fassYGesamtFass2 + yFassHilf2 + zufalllLeiterFallHilfe2;
                        fass2Ebene--;
                        yFassHilf2 = 0;
                        fallenFass2 = false;
                        gefallenFass2 = true;
                        leiterLockFass2 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }
                else if (fass2Ebene == 2)
                {
                    if (yFassHilf2 >= 72)
                    {
                        fassYGesamtFass2 = fassYGesamtFass2 + yFassHilf2 + zufalllLeiterFallHilfe2;
                        fass2Ebene--;
                        yFassHilf2 = 0;
                        fallenFass2 = false;
                        gefallenFass2 = true;
                        leiterLockFass2 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }

                xPositionen[0] = (17 * pixelGreosse) + offset + fassHilf2;

                yPositionen[0] = ((74 * pixelGreosse) + yFassHilf2 + fassYGesamtFass2 + fass2EbenenHilfe);

            }
            else if ((fassHilf2 == 0) && (gefallenFass2 == false))
            {
                fallenFass2 = true;
            }
            else if ((fassHilf2 == 0) && (gefallenFass2 == true))
            {
                gefallenFass2 = false;

                xPositionen[0] = (17 * pixelGreosse) + offset + fassHilf2;

                yPositionen[0] = ((74 * pixelGreosse) + fassYGesamtFass2 + fass2EbenenHilfe);

                fassHilf2++;

                if (randFass2 == false)
                {
                    randFass2 = true;
                }
                if (randFass2 == true)
                {
                    randFass2 = false;
                }
            }
            else if ((fassHilf2 > 0) && (randFass2 == false))
            {
                gefallenFass2 = false;

                xPositionen[0] = (17 * pixelGreosse) + offset + fassHilf2;

                yPositionen[0] = ((74 * pixelGreosse) + fassYGesamtFass2 + fass2EbenenHilfe);

                fassHilf2++;
            }
            else if ((fassHilf2 > 0) && (randFass2 == true))
            {
                gefallenFass2 = false;

                xPositionen[0] = (17 * pixelGreosse) + offset + fassHilf2;

                yPositionen[0] = ((74 * pixelGreosse) + fassYGesamtFass2 + fass2EbenenHilfe);

                fassHilf2--;
            }

            //if (((zufall2 >= 1850) && (zufall2 < 2000)) && (((xPositionen[0] == 622) && (fass2Ebene == 2)) ||
            //    ((xPositionen[0] == 496) && (fass2Ebene == 3)) || ((xPositionen[0] == 365) && (fass2Ebene == 3)) ||
            //    ((xPositionen[0] == 530) && (fass2Ebene == 4)) || ((xPositionen[0] == 620) && (fass2Ebene == 4)) ||
            //    ((xPositionen[0] == 455) && (fass2Ebene == 5)) || ((xPositionen[0] == 366) && (fass2Ebene == 5)) ||
            //    ((xPositionen[0] == 620) && (fass2Ebene == 6))))
            //{
            //    if (randFass2 == false)
            //    {
            //        fallenFass2 = true;
            //        randFass2 = true;
            //    }
            //    else if (randFass2 == true)
            //    {
            //        fallenFass2 = true;
            //        randFass2 = false;
            //    }

            //    if (((xPositionen[0] == 455) && (fass2Ebene == 5)) || ((xPositionen[0] == 496) && (fass2Ebene == 3)) ||
            //        ((xPositionen[0] == 620) && (fass2Ebene == 4)))
            //    {
            //        if (fass2Ebene == 6)
            //        {
            //            zufalllLeiterFallHilfe2 = 5;
            //        }
            //        else if (fass2Ebene == 5)
            //        {
            //            zufalllLeiterFallHilfe2 = 20;
            //        }
            //        else if (fass2Ebene == 4)
            //        {
            //            zufalllLeiterFallHilfe2 = 25;
            //        }
            //        else if (fass2Ebene == 3)
            //        {
            //            zufalllLeiterFallHilfe2 = 25;
            //        }
            //        else if (fass2Ebene == 2)
            //        {
            //            zufalllLeiterFallHilfe2 = 20;
            //        }
            //    }
            //    else if (((xPositionen[0] == 620) && (fass2Ebene == 6)) || ((xPositionen[0] == 366) && (fass2Ebene == 5)) ||
            //             ((xPositionen[0] == 620) && (fass2Ebene == 4)) || ((xPositionen[0] == 365) && (fass2Ebene == 3)) ||
            //             ((xPositionen[0] == 624) && (fass2Ebene == 2)))
            //    {
            //        if (fass2Ebene == 6)
            //        {
            //            zufalllLeiterFallHilfe2 = 3;
            //        }
            //        else if (fass2Ebene == 5)
            //        {
            //            zufalllLeiterFallHilfe2 = 10;
            //        }
            //        else if (fass2Ebene == 4)
            //        {
            //            zufalllLeiterFallHilfe2 = 5;
            //        }
            //        else if (fass2Ebene == 3)
            //        {
            //            zufalllLeiterFallHilfe2 = 10;
            //        }
            //        else if (fass2Ebene == 2)
            //        {
            //            zufalllLeiterFallHilfe2 = 5;
            //        }
            //    }
            //}

            fass2XPositionen = xPositionen[0];
            fass2YPositionen = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (kong);
        }


        public Fass3 FassSetzen3(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;
            zufall3 = new Random().Next(0, 2000);

            Fass3 kong = new Fass3(fallenFass3);

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        kong
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            if ((fassHilf3 < 1) && (fass3Ebene == 1))
            {
                leiterLockFass3 = false;
                leiterEbene1LockFass3 = false;
                ebenenLock1Fass3 = false;
                ebenenLock2Fass3 = false;
                ebenenLock3Fass3 = false;
                ebenenLock4Fass3 = false;
                ebenenLock5Fass3 = false;
                ebenenLock6Fass3 = false;
                faesserHilfFass3 = 0;
                fallenFass3 = false;
                gefallenFass3 = false;
                fassYGesamtFass3 = 0;
                fassHilf3 = 1;
                yFassHilf3 = 0;
                randFass3 = false;
                fass3Ebene = 6;
                fass3EbenenHilfe = 0;
                fass3EbenenHilfe2 = 0;
            }

            if ((fassHilf3 == 380) && (gefallenFass3 == false))
            {
                randFass3 = true;
                fallenFass3 = true;
            }

            if ((fallenFass3 == true) && (gefallenFass3 == false))
            {
                yFassHilf3++;

                if (fass3Ebene == 6)
                {
                    if (yFassHilf3 >= 69)
                    {
                        fassYGesamtFass3 = fassYGesamtFass3 + yFassHilf3 + zufalllLeiterFallHilfe3;
                        fass3Ebene--;
                        yFassHilf3 = 0;
                        fallenFass3 = false;
                        gefallenFass3 = true;
                        leiterLockFass3 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }
                else if (fass3Ebene == 5)
                {
                    if (yFassHilf3 >= 68)
                    {
                        fassYGesamtFass3 = fassYGesamtFass3 + yFassHilf3 + zufalllLeiterFallHilfe3;
                        fass3Ebene--;
                        yFassHilf3 = 0;
                        fallenFass3 = false;
                        gefallenFass3 = true;
                        leiterLockFass3 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }
                else if (fass3Ebene == 4)
                {
                    if (yFassHilf3 >= 72)
                    {
                        fassYGesamtFass3 = fassYGesamtFass3 + yFassHilf3 + zufalllLeiterFallHilfe3;
                        fass3Ebene--;
                        yFassHilf3 = 0;
                        fallenFass3 = false;
                        gefallenFass3 = true;
                        leiterLockFass3 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }
                else if (fass3Ebene == 3)
                {
                    if (yFassHilf3 >= 68)
                    {
                        fassYGesamtFass3 = fassYGesamtFass3 + yFassHilf3 + zufalllLeiterFallHilfe3;
                        fass3Ebene--;
                        yFassHilf3 = 0;
                        fallenFass3 = false;
                        gefallenFass3 = true;
                        leiterLockFass3 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }
                else if (fass3Ebene == 2)
                {
                    if (yFassHilf3 >= 72)
                    {
                        fassYGesamtFass3 = fassYGesamtFass3 + yFassHilf3 + zufalllLeiterFallHilfe3;
                        fass3Ebene--;
                        yFassHilf3 = 0;
                        fallenFass3 = false;
                        gefallenFass3 = true;
                        leiterLockFass3 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }

                xPositionen[0] = (17 * pixelGreosse) + offset + fassHilf3;

                yPositionen[0] = ((74 * pixelGreosse) + yFassHilf3 + fassYGesamtFass3 + fass3EbenenHilfe);

            }
            else if ((fassHilf3 == 0) && (gefallenFass3 == false))
            {
                fallenFass3 = true;
            }
            else if ((fassHilf3 == 0) && (gefallenFass3 == true))
            {
                gefallenFass3 = false;

                xPositionen[0] = (17 * pixelGreosse) + offset + fassHilf3;

                yPositionen[0] = ((74 * pixelGreosse) + fassYGesamtFass3 + fass3EbenenHilfe);

                fassHilf3++;

                if (randFass3 == false)
                {
                    randFass3 = true;
                }
                if (randFass3 == true)
                {
                    randFass3 = false;
                }
            }
            else if ((fassHilf3 > 0) && (randFass3 == false))
            {
                gefallenFass3 = false;

                xPositionen[0] = (17 * pixelGreosse) + offset + fassHilf3;

                yPositionen[0] = ((74 * pixelGreosse) + fassYGesamtFass3 + fass3EbenenHilfe);

                fassHilf3++;
            }
            else if ((fassHilf3 > 0) && (randFass3 == true))
            {
                gefallenFass3 = false;

                xPositionen[0] = (17 * pixelGreosse) + offset + fassHilf3;

                yPositionen[0] = ((74 * pixelGreosse) + fassYGesamtFass3 + fass3EbenenHilfe);

                fassHilf3--;
            }

            //if (((zufall3 >= 1850) && (zufall3 < 2000)) && (((xPositionen[0] == 622) && (fass3Ebene == 2)) ||
            //    ((xPositionen[0] == 496) && (fass3Ebene == 3)) || ((xPositionen[0] == 365) && (fass3Ebene == 3)) ||
            //    ((xPositionen[0] == 530) && (fass3Ebene == 4)) || ((xPositionen[0] == 620) && (fass3Ebene == 4)) ||
            //    ((xPositionen[0] == 455) && (fass3Ebene == 5)) || ((xPositionen[0] == 366) && (fass3Ebene == 5)) ||
            //    ((xPositionen[0] == 620) && (fass3Ebene == 6))))
            //{
            //    if (randFass3 == false)
            //    {
            //        fallenFass3 = true;
            //        randFass3 = true;
            //    }
            //    else if (randFass3 == true)
            //    {
            //        fallenFass3 = true;
            //        randFass3 = false;
            //    }

            //    if (((xPositionen[0] == 455) && (fass3Ebene == 5)) || ((xPositionen[0] == 496) && (fass3Ebene == 3)) ||
            //        ((xPositionen[0] == 620) && (fass3Ebene == 4)))
            //    {
            //        if (fass3Ebene == 6)
            //        {
            //            zufalllLeiterFallHilfe3 = 5;
            //        }
            //        else if (fass3Ebene == 5)
            //        {
            //            zufalllLeiterFallHilfe3 = 20;
            //        }
            //        else if (fass3Ebene == 4)
            //        {
            //            zufalllLeiterFallHilfe3 = 25;
            //        }
            //        else if (fass3Ebene == 3)
            //        {
            //            zufalllLeiterFallHilfe3 = 25;
            //        }
            //        else if (fass3Ebene == 2)
            //        {
            //            zufalllLeiterFallHilfe3 = 20;
            //        }
            //    }
            //    else if (((xPositionen[0] == 620) && (fass3Ebene == 6)) || ((xPositionen[0] == 366) && (fass3Ebene == 5)) ||
            //             ((xPositionen[0] == 620) && (fass3Ebene == 4)) || ((xPositionen[0] == 365) && (fass3Ebene == 3)) ||
            //             ((xPositionen[0] == 624) && (fass3Ebene == 2)))
            //    {
            //        if (fass3Ebene == 6)
            //        {
            //            zufalllLeiterFallHilfe3 = 3;
            //        }
            //        else if (fass3Ebene == 5)
            //        {
            //            zufalllLeiterFallHilfe3 = 10;
            //        }
            //        else if (fass3Ebene == 4)
            //        {
            //            zufalllLeiterFallHilfe3 = 5;
            //        }
            //        else if (fass3Ebene == 3)
            //        {
            //            zufalllLeiterFallHilfe3 = 10;
            //        }
            //        else if (fass3Ebene == 2)
            //        {
            //            zufalllLeiterFallHilfe3 = 5;
            //        }
            //    }
            //}

            fass3XPositionen = xPositionen[0];
            fass3YPositionen = yPositionen[0];
            #endregion

            verteilungFigur(figuren, xPositionen, yPositionen);

            FaerbenFigure(figuren, e, xPositionen, yPositionen);

            return (kong);
        }


        public Fass4 FassSetzen4(PaintEventArgs e)
        {
            int[] xPositionen;
            int[] yPositionen;
            int pixelGreosse = 3;
            int offset = 250;
            zufall4 = new Random().Next(0, 2000);

            Fass4 kong = new Fass4(fallenFass4);

            Figuren[] figuren;
            figuren = new Figuren[]
            {
                        kong
            };

            xPositionen = new int[figuren.GetLength(0)];
            yPositionen = new int[figuren.GetLength(0)];

            #region Position
            if ((fassHilf4 < 1) && (fass4Ebene == 1))
            {
                leiterLockFass4 = false;
                leiterEbene1LockFass4 = false;
                ebenenLock1Fass4 = false;
                ebenenLock2Fass4 = false;
                ebenenLock3Fass4 = false;
                ebenenLock4Fass4 = false;
                ebenenLock5Fass4 = false;
                ebenenLock6Fass4 = false;
                faesserHilfFass4 = 0;
                fallenFass4 = false;
                gefallenFass4 = false;
                fassYGesamtFass4 = 0;
                fassHilf4 = 1;
                yFassHilf4 = 0;
                randFass4 = false;
                fass4Ebene = 6;
                fass4EbenenHilfe = 0;
                fass4EbenenHilfe2 = 0;
            }

            if ((fassHilf4 == 380) && (gefallenFass4 == false))
            {
                randFass4 = true;
                fallenFass4 = true;
            }

            if ((fallenFass4 == true) && (gefallenFass4 == false))
            {
                yFassHilf4++;

                if (fass4Ebene == 6)
                {
                    if (yFassHilf4 >= 69)
                    {
                        fassYGesamtFass4 = fassYGesamtFass4 + yFassHilf4 + zufalllLeiterFallHilfe4;
                        fass4Ebene--;
                        yFassHilf4 = 0;
                        fallenFass4 = false;
                        gefallenFass4 = true;
                        leiterLockFass4 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }
                else if (fass4Ebene == 5)
                {
                    if (yFassHilf4 >= 68)
                    {
                        fassYGesamtFass4 = fassYGesamtFass4 + yFassHilf4 + zufalllLeiterFallHilfe4;
                        fass4Ebene--;
                        yFassHilf4 = 0;
                        fallenFass4 = false;
                        gefallenFass4 = true;
                        leiterLockFass4 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }
                else if (fass4Ebene == 4)
                {
                    if (yFassHilf4 >= 72)
                    {
                        fassYGesamtFass4 = fassYGesamtFass4 + yFassHilf4 + zufalllLeiterFallHilfe4;
                        fass4Ebene--;
                        yFassHilf4 = 0;
                        fallenFass4 = false;
                        gefallenFass4 = true;
                        leiterLockFass4 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }
                else if (fass4Ebene == 3)
                {
                    if (yFassHilf4 >= 68)
                    {
                        fassYGesamtFass4 = fassYGesamtFass4 + yFassHilf4 + zufalllLeiterFallHilfe4;
                        fass4Ebene--;
                        yFassHilf4 = 0;
                        fallenFass4 = false;
                        gefallenFass4 = true;
                        leiterLockFass4 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }
                else if (fass4Ebene == 2)
                {
                    if (yFassHilf4 >= 72)
                    {
                        fassYGesamtFass4 = fassYGesamtFass4 + yFassHilf4 + zufalllLeiterFallHilfe4;
                        fass4Ebene--;
                        yFassHilf4 = 0;
                        fallenFass4 = false;
                        gefallenFass4 = true;
                        leiterLockFass4 = false;
                        //zufalllLeiterFallHilfe1 = 0;
                        //zufalllLeiterFallHilfe2 = 0;
                        //zufalllLeiterFallHilfe3 = 0;
                        //zufalllLeiterFallHilfe4 = 0;
                    }
                }

                xPositionen[0] = (17 * pixelGreosse) + offset + fassHilf4;

                yPositionen[0] = ((74 * pixelGreosse) + yFassHilf4 + fassYGesamtFass4 + fass4EbenenHilfe);

            }
            else if ((fassHilf4 == 0) && (gefallenFass4 == false))
            {
                fallenFass4 = true;
            }
            else if ((fassHilf4 == 0) && (gefallenFass4 == true))
            {
                gefallenFass4 = false;

                xPositionen[0] = (17 * pixelGreosse) + offset + fassHilf4;

                yPositionen[0] = ((74 * pixelGreosse) + fassYGesamtFass4 + fass4EbenenHilfe);

                fassHilf4++;

                if (randFass4 == false)
                {
                    randFass4 = true;
                }
                if (randFass4 == true)
                {
                    randFass4 = false;
                }
            }
            else if ((fassHilf4 > 0) && (randFass4 == false))
            {
                gefallenFass4 = false;

                xPositionen[0] = (17 * pixelGreosse) + offset + fassHilf4;

                yPositionen[0] = ((74 * pixelGreosse) + fassYGesamtFass4 + fass4EbenenHilfe);

                fassHilf4++;
            }
            else if ((fassHilf4 > 0) && (randFass4 == true))
            {
                gefallenFass4 = false;

                xPositionen[0] = (17 * pixelGreosse) + offset + fassHilf4;

                yPositionen[0] = ((74 * pixelGreosse) + fassYGesamtFass4 + fass4EbenenHilfe);

                fassHilf4--;
            }

            //if (((zufall4 >= 1850) && (zufall4 < 2000)) && (((xPositionen[0] == 622) && (fass4Ebene == 2)) ||
            //    ((xPositionen[0] == 496) && (fass4Ebene == 3)) || ((xPositionen[0] == 365) && (fass4Ebene == 3)) ||
            //    ((xPositionen[0] == 530) && (fass4Ebene == 4)) || ((xPositionen[0] == 620) && (fass4Ebene == 4)) ||
            //    ((xPositionen[0] == 455) && (fass4Ebene == 5)) || ((xPositionen[0] == 366) && (fass4Ebene == 5)) ||
            //    ((xPositionen[0] == 620) && (fass4Ebene == 6))))
            //{
            //    if (randFass4 == false)
            //    {
            //        fallenFass4 = true;
            //        randFass4 = true;
            //    }
            //    else if (randFass4 == true)
            //    {
            //        fallenFass4 = true;
            //        randFass4 = false;
            //    }

            //    if (((xPositionen[0] == 455) && (fass4Ebene == 5)) || ((xPositionen[0] == 496) && (fass4Ebene == 3)) ||
            //        ((xPositionen[0] == 620) && (fass4Ebene == 4)))
            //    {
            //        if (fass4Ebene == 6)
            //        {
            //            zufalllLeiterFallHilfe4 = 5;
            //        }
            //        else if (fass4Ebene == 5)
            //        {
            //            zufalllLeiterFallHilfe4 = 20;
            //        }
            //        else if (fass4Ebene == 4)
            //        {
            //            zufalllLeiterFallHilfe4 = 25;
            //        }
            //        else if (fass4Ebene == 3)
            //        {
            //            zufalllLeiterFallHilfe4 = 25;
            //        }
            //        else if (fass4Ebene == 2)
            //        {
            //            zufalllLeiterFallHilfe4 = 20;
            //        }
            //    }
            //    else if (((xPositionen[0] == 620) && (fass4Ebene == 6)) || ((xPositionen[0] == 366) && (fass4Ebene == 5)) ||
            //             ((xPositionen[0] == 620) && (fass4Ebene == 4)) || ((xPositionen[0] == 365) && (fass4Ebene == 3)) ||
            //             ((xPositionen[0] == 624) && (fass4Ebene == 2)))
            //    {
            //        if (fass4Ebene == 6)
            //        {
            //            zufalllLeiterFallHilfe4 = 3;
            //        }
            //        else if (fass4Ebene == 5)
            //        {
            //            zufalllLeiterFallHilfe4 = 10;
            //        }
            //        else if (fass4Ebene == 4)
            //        {
            //            zufalllLeiterFallHilfe4 = 5;
            //        }
            //        else if (fass4Ebene == 3)
            //        {
            //            zufalllLeiterFallHilfe4 = 10;
            //        }
            //        else if (fass4Ebene == 2)
            //        {
            //            zufalllLeiterFallHilfe4 = 5;
            //        }
            //    }
            //}

            fass4XPositionen = xPositionen[0];
            fass4YPositionen = yPositionen[0];
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

        public void Neustart()
        {
            #region Mario
            marioXPositionen = 0;
            marioYPositionen = 0;
            xMario = 0;
            yMario = 0;
            blickRichtungMario = false;
            marioSchritt = false;
            marioZeahler = 0;
            marioSprungHoehe = 0;
            mariospringen = false;
            marioEbene = 1;
            marioLeiterPositionHoch = 0;
            marioLeiterPositionRunter = 0;
            marioEbenenHilf = 0;
            marioEbenenHilf2Left = 0;
            marioEbenenHilf2Right = 0;
            #endregion

            #region Counter für die versätzt startenden Fässer
            count1 = 0;
            count2 = 0;
            count3 = 0;
            #endregion

            #region Faesser
            #region Fass1
            fass1XPositionen = 0;
            fass1YPositionen = 0;
            zufalllLeiterFallHilfe1 = 0;
            zufall1 = new Random().Next(0, 2000);
            leiterLockFass1 = false;
            leiterEbene1LockFass1 = false;
            ebenenLock1Fass1 = false;
            ebenenLock2Fass1 = false;
            ebenenLock3Fass1 = false;
            ebenenLock4Fass1 = false;
            ebenenLock5Fass1 = false;
            ebenenLock6Fass1 = false;
            faesserHilfFass1 = 0;
            fallenFass1 = false;
            gefallenFass1 = false;
            fassYGesamtFass1 = 0;
            fassHilf1 = 1;
            yFassHilf1 = 0;
            randFass1 = false;
            fass1Ebene = 6;
            fass1EbenenHilfe = 0;
            fass1EbenenHilfe2 = 0;
            #endregion

            #region Fass2
            fass2XPositionen = 0;
            fass2YPositionen = 0;
            zufalllLeiterFallHilfe2 = 0;
            zufall2 = new Random().Next(0, 2000);
            leiterLockFass2 = false;
            leiterEbene1LockFass2 = false;
            ebenenLock1Fass2 = false;
            ebenenLock2Fass2 = false;
            ebenenLock3Fass2 = false;
            ebenenLock4Fass2 = false;
            ebenenLock5Fass2 = false;
            ebenenLock6Fass2 = false;
            faesserHilfFass2 = 0;
            fallenFass2 = false;
            gefallenFass2 = false;
            fassYGesamtFass2 = 0;
            fassHilf2 = 1;
            yFassHilf2 = 0;
            randFass2 = false;
            fass2Ebene = 6;
            fass2EbenenHilfe = 0;
            fass2EbenenHilfe2 = 0;
            #endregion

            #region Fass3
            fass3XPositionen = 0;
            fass3YPositionen = 0;
            zufalllLeiterFallHilfe3 = 0;
            zufall3 = new Random().Next(0, 2000);
            leiterLockFass3 = false;
            leiterEbene1LockFass3 = false;
            ebenenLock1Fass3 = false;
            ebenenLock2Fass3 = false;
            ebenenLock3Fass3 = false;
            ebenenLock4Fass3 = false;
            ebenenLock5Fass3 = false;
            ebenenLock6Fass3 = false;
            faesserHilfFass3 = 0;
            fallenFass3 = false;
            gefallenFass3 = false;
            fassYGesamtFass3 = 0;
            fassHilf3 = 1;
            yFassHilf3 = 0;
            randFass3 = false;
            fass3Ebene = 6;
            fass3EbenenHilfe = 0;
            fass3EbenenHilfe2 = 0;
            #endregion

            #region Fass4
            fass4XPositionen = 0;
            fass4YPositionen = 0;
            zufalllLeiterFallHilfe4 = 0;
            zufall4 = new Random().Next(0, 2000);
            leiterLockFass4 = false;
            leiterEbene1LockFass4 = false;
            ebenenLock1Fass4 = false;
            ebenenLock2Fass4 = false;
            ebenenLock3Fass4 = false;
            ebenenLock4Fass4 = false;
            ebenenLock5Fass4 = false;
            ebenenLock6Fass4 = false;
            faesserHilfFass4 = 0;
            fallenFass4 = false;
            gefallenFass4 = false;
            fassYGesamtFass4 = 0;
            fassHilf4 = 1;
            yFassHilf4 = 0;
            randFass4 = false;
            fass4Ebene = 6;
            fass4EbenenHilfe = 0;
            fass4EbenenHilfe2 = 0;
            #endregion
            #endregion

            neustart = false;
        }
    }
}
