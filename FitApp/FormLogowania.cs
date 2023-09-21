﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FitApp
{
    public partial class FormLogowania : Form
    {
        private readonly ModelXML _context = new ModelXML();

        public FormLogowania()
        {
            InitializeComponent();
        }

        private void FormLogowania_Load(object sender, EventArgs e)
        {
            WypiszZapamietanych();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool czyZalogowano = false;
            foreach(var klient in _context.Klienci())
            {
                if(cmbLogin.Text.ToLower() == klient.Login.ToLower() && txtHaslo.Text == klient.Haslo)
                {
                    czyZalogowano = true;
                    ZapamietajMnie(klient.KlientID);
                    Hide();
                    Form1 form1 = new Form1 { KlientID = klient.KlientID };
                    form1.Show();
                }
            }

            if (!czyZalogowano)
            { 
                if (string.IsNullOrEmpty(txtHaslo.Text))
                {
                    if (string.IsNullOrEmpty(cmbLogin.Text))
                    {
                        MessageBox.Show("Введите свой логин и пароль!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Введите пароль!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                else if (string.IsNullOrEmpty(cmbLogin.Text))
                {
                    MessageBox.Show("Введите свой логин!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Walidacja.Error("Неправильный логин и/или пароль!");
                }

                txtHaslo.Text = "";
            }
        }

        public void CloseApp(object sender, EventArgs e)
        {
            try { Application.ExitThread(); }
            catch { }
        }


        private void ZapamietajMnie(int klientID)
        {

            List<Klient> klienci = _context.Klienci();
            foreach (var item in klienci)
            {
                if (item.KlientID == klientID)
                {
                    item.CzyPamietac = rememberMe.Checked;
                }
            }

            _context.ZapiszKlientow(klienci);
        }


        private void WypiszZapamietanych()
        {
            foreach (var klient in _context.Klienci())
            {
                if (klient.CzyPamietac)
                {
                    cmbLogin.Items.Add(klient.Login);
                }
            }

            if (cmbLogin.Items.Count > 0)
            {
                cmbLogin.SelectedIndex = 0;
            }
            else
            {
                cmbLogin.DropDownStyle = ComboBoxStyle.Simple;
                cmbLogin.Height = 24;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            new FormRejestracji().Show();
        }

        private void NiePozwalajNaBialeZnaki(object sender, EventArgs e)
        {
            Walidacja.NiePozwalajNaBialeZnaki(sender);
        }

        private void CmbBoxLoginUsunBialeZnaki(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            comboBox.Text = Walidacja.UsunBialeZnakiZeStringa(comboBox.Text);
        }
    }
}
