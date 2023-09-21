﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FitApp
{
    public partial class FormPodajIlosc : Form
    {
        private readonly ModelXML _context = new ModelXML();
        private readonly Walidacja walidacja = new Walidacja();
        public int ProduktID { get; set; }
        public int WKtorym { get; set; }
        public int DzienID { get; set; }

        public FormPodajIlosc()
        {
            InitializeComponent();
            FormClosing += new FormClosingEventHandler((sender, e) => Powrot());
        }

        private void WyswietlNazweProduktu()
        {
            lblNazwa.Text = _context.DajProdukt(ProduktID).NazwaProduktu;
            lblNazwa.Location = new Point((Width - lblNazwa.Width)/2,10);
        }

        private void PodajLiczbeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Walidacja.PodajLiczbeTextBox(textBox1, e);
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            int dodawanyProduktID = 0;

            foreach (var produkt in _context.Produkty())
            {
                if (produkt.ProduktId == ProduktID)
                {
                    dodawanyProduktID = ProduktID;
                }
            }

            if (int.TryParse(textBox1.Text, out _))
            {
                if (!(int.Parse(textBox1.Text) == 0))
                {
                    List<Posilek> posilki = _context.Posilki();
                    posilki.Add(new Posilek()
                    {
                        DzienId = DzienID,
                        Gramatura = int.Parse(textBox1.Text),
                        PosilekId = _context.AutoIncrementPosilki(_context.Posilki()),
                        ProduktId = dodawanyProduktID,
                        WKtorym = WKtorym
                    });

                    _context.ZapiszPosilki(posilki);

                    Form form1 = new Form1 { 
                        StartPosition = FormStartPosition.CenterScreen, 
                        DzienID = DzienID,
                        KlientID = _context.DajKlientaPoDniuID(DzienID)
                    };
                    
                    form1.Show();
                    Hide();
                }
                else
                {
                    walidacja.PokazBlad();
                }
            }
            else
            {
                walidacja.PokazBlad();
            }
        }


        private void Powrot()
        {
            FormDodawania form = new FormDodawania
            {
                DzienID = DzienID,
                WKtorym = WKtorym
            };

            form.FormClosing += new FormClosingEventHandler((sender, e) => form.ZamknijForme());
            form.Show();
        }

        private void TxtBoxPodajIlosc_TextChanged(object sender, EventArgs e)
        {
            walidacja.WalidacjaTextBoxa(textBox1, 4, false, 9999);
            new ObliczCele().WyswietlKcalIMakro(lblKcal, lblMakro, textBox1, ProduktID, _context);
        }

        private void FormPodajIlosc_Load(object sender, EventArgs e)
        {
            WyswietlNazweProduktu();
        }

        private void lblKcal_Click(object sender, EventArgs e)
        {

        }
    }
}
