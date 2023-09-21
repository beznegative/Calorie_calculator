﻿using System;
using System.Windows.Forms;

namespace FitApp
{
    public class ObliczCele
    {
        static public int ObliczCelKalorii(int zapotrzebowanie, short celZmian, decimal tempo)
        {
            //-----------------------------Снижение веса--------------------------
            if (celZmian == 1)
            {
                int celKcal = (int)(zapotrzebowanie - (tempo * 1100));

                if (celKcal <= 1000)
                {
                    return 1000;
                }
                else
                {
                    return celKcal;
                }
            }

            //-----------------------------Увеличение веса--------------------------
            if (celZmian == 3)
            {
                int celKcal = (int)(zapotrzebowanie + (tempo * 1100));

                if (celKcal <= 1000)
                {
                    return 1000;
                }
                else
                {
                    return celKcal;
                }
            }

            //-----------------------------Обслуживание--------------------------
            if (zapotrzebowanie < 1000)
            {
                return 1000;
            }
            else
            {
                return zapotrzebowanie;
            }
        }


        static public int ObliczZapotrzebowanie(bool plec, DateTime dataUrodzenia, int wzrost, double waga)
        {
            int BMR;
            int wiek = ObliczWiek(dataUrodzenia);

            if (plec)
            {
                BMR = (int)(66 + (13.7 * waga) + (5 * wzrost) - (6.76 * wiek));         //
            }                                                                           //
            else                                                                        // Метод Харриса-Бенедикта
            {                                                                           //
                BMR = (int)(655 + (9.6 * waga) + (1.85 * wzrost) - (4.7 * wiek));       //
            }

            return (int)(BMR * 1.5);

        }

        static public int ObliczCelBialko(double waga, int celKalorii)
        {
            int bialko = (int)(1.5 * waga);
            if (bialko < celKalorii)
            {
                return bialko;
            }
            else
            {
                return (int)(0.5 * celKalorii);
            }
           
        }

        static public int ObliczCelTluszcze(int celKalorii)
        {
            return celKalorii / 36;    //25% потребности в жирах (каждый грамм жира содержит 9 ккал)
        }

        static public int ObliczCelWegle(int celKalorie, int celBialko, int celTluszcze)
        {
            return (celKalorie - ((celBialko * 4) + (celTluszcze * 9))) / 4;
        }

        static public int ObliczWiek(DateTime dataUrodzenia)
        {
            int age = DateTime.Today.Year - dataUrodzenia.Year;
            if (dataUrodzenia.Date > DateTime.Today.AddYears(-age)) age--;
            return age;
        }

        public void WyswietlKcalIMakro(Label lblKcal, Label lblMakro, TextBox textBox, int produktID, ModelXML _context)
        {
            int kalorie = 0, bialko = 0, wegle = 0, tluszcze = 0;
            try
            {
                Produkt produkt = _context.DajProdukt(produktID);
                int podanaIlosc = int.Parse(textBox.Text);
                kalorie = (produkt.Kalorie * podanaIlosc) / 100;
                bialko = (int)(produkt.Bialko * podanaIlosc / 100);
                tluszcze = (int)(produkt.Tluszcze * podanaIlosc / 100);
                wegle = (int)(produkt.Weglowodany * podanaIlosc / 100);
            }
            catch { }

            lblKcal.Text = "Ккал: " + kalorie + " kcal";
            lblMakro.Text = "Б: " + bialko + "g, У: " + wegle + "g, Ж: " + tluszcze + "g";
        }
    }
}
