using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FitApp
{
    public partial class FormRejestracji : Form
    {
        private readonly Style style;
        private readonly ModelXML _context;
        private bool czyLoginZly = false;
        private bool czyHasloZle = false;
        private bool czyPotwierdzZle = false;

        public FormRejestracji()
        {
            style = new Style();
            _context = new ModelXML();
            InitializeComponent();
            FormClosing += new FormClosingEventHandler((sender, e) => Frm_FormClosing());
            Paint += new PaintEventHandler((sender, e) => Form1_Paint(e));
        }

        private void Frm_FormClosing()
        {
            Hide();
            new FormLogowania().Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            JesliNiePodano();
            Zarejestruj();
        }

        private void Zarejestruj()
        {
            if (!czyHasloZle && !czyLoginZly && !czyPotwierdzZle)
            {
                bool czyZajeta = false;

                foreach (var klient in _context.Klienci())
                {
                    if (klient.Login.ToLower() == txtLogin.Text.ToLower())
                    {
                        czyZajeta = true;
                        MessageBox.Show("Имя пользователя, которое вы ввели, уже занято!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (!czyZajeta)
                {
                    SprawdzPoprawnosc();
                }
            }
        }

        private void SprawdzPoprawnosc()
        {
            if (txtPass1.Text == txtPass2.Text)
            {
                if (txtPass1.Text.Length < 7)
                {
                    if (txtLogin.Text.Length < 7)
                    {
                        Walidacja.Error("Пароль и логин должны содержать не менее 7 символов!");
                    }
                    else
                    {
                        Walidacja.Error("Пароль должен содержать не менее 7 символов!");
                    }
                }
                else if (txtLogin.Text.Length < 7)
                {
                    Walidacja.Error("Логин должен содержать не менее 7 символов!");
                }
                else
                {
                    DodajKlienta();
                }
            }
            else
            {
                Walidacja.Error("Введенные пароли не совпадают!");
                txtPass1.Text = "";
                txtPass2.Text = "";
            }
        }


        private void DodajKlienta()
        {    
            List<Klient> klienci = _context.Klienci();
            int klientID = _context.AutoIncrementKlientow(klienci);
            klienci.Add(new Klient()
            {
                KlientID = klientID,
                Login = txtLogin.Text,
                Haslo = txtPass1.Text,
            });

            _context.ZapiszKlientow(klienci);
            MessageBox.Show("Успешная регистрация.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            // FormUstawien formUstawien = new FormUstawien(klientID, _context.DajDzisiajID(klientID), true);
            // formUstawien.Show();
            Form1 form1 = new Form1()
            {
                KlientID = klientID
            };
            form1.Show();
        }


        private void JesliNiePodano()
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text)) { lblLogin.ForeColor = Color.Red; czyLoginZly = true; }
            else { lblLogin.ForeColor = Color.White; czyLoginZly = false; }

            if (string.IsNullOrWhiteSpace(txtPass1.Text)) { lblHaslo.ForeColor = Color.Red; czyHasloZle = true; }
            else { lblHaslo.ForeColor = Color.White; czyHasloZle = false; }

            if (string.IsNullOrWhiteSpace(txtPass2.Text)) { lblPotwierdz.ForeColor = Color.Red; czyPotwierdzZle = true; }
            else { lblPotwierdz.ForeColor = Color.White; czyPotwierdzZle = false; }

            Refresh();
        }

        private void Form1_Paint(PaintEventArgs e)
        {
            style.RysujLubZresetuj(czyHasloZle, txtPass1, e);
            style.RysujLubZresetuj(czyPotwierdzZle, txtPass2, e);
            style.RysujLubZresetuj(czyLoginZly, txtLogin, e);
        }

        private void NiePozwalajNaBialeZnaki(object sender, EventArgs e)
        {
            Walidacja.NiePozwalajNaBialeZnaki(sender);
        }
    }
}
