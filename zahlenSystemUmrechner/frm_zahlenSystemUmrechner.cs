using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class frm_zahlenSystemUmrechner : Form
    {
        public frm_zahlenSystemUmrechner()
        {
            InitializeComponent();

            if (ModifierKeys == Keys.D1)
            {
                MessageBox.Show("Test", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_berechnung_Click(object sender, EventArgs e)
        {
            int eingabe = 0;

            if (!Regex.IsMatch(tb_eingabe.Text.ToString(), @"[^a-fA-F0-9\s]$"))
            {
                if (rb_dezimal.Checked)
                {
                    try
                    {
                        eingabe = Convert.ToInt32(tb_eingabe.Text);
                        tb_dezimal.Text = eingabe.ToString();
                        tb_binär.Text = zuBinär(eingabe);
                        tb_ternär.Text = zuTernär(eingabe);
                        tb_oktal.Text = zuOktal(eingabe);
                        tb_hex.Text = zuHex(eingabe).ToString();
                    }
                    catch
                    {
                        Fehler();
                    }

                }

                else if (rb_binär.Checked)
                {
                    try
                    {
                        eingabe = Convert.ToInt32(tb_eingabe.Text);
                        int eingabeDezimal = Convert.ToInt32(eingabe.ToString(), 2);
                        tb_binär.Text = eingabe.ToString();
                        tb_dezimal.Text = eingabeDezimal.ToString();
                        tb_ternär.Text = zuTernär(eingabeDezimal);
                        tb_oktal.Text = zuOktal(eingabeDezimal);
                        tb_hex.Text = zuHex(eingabeDezimal);
                    }
                    catch
                    {
                        Fehler();
                    }
                }

                else if (rb_ternär.Checked)
                {
                    try
                    {
                        eingabe = Convert.ToInt32(tb_eingabe.Text);
                        int eingabeDezimal = TernärZuDezimal(eingabe);
                        tb_ternär.Text = eingabe.ToString();
                        tb_binär.Text = zuBinär(eingabeDezimal);
                        tb_dezimal.Text = eingabeDezimal.ToString();
                        tb_hex.Text = zuHex(eingabeDezimal);
                        tb_oktal.Text = zuOktal(eingabeDezimal);
                    }
                    catch
                    {
                        Fehler();
                    }
                }

                else if (rb_oktal.Checked)
                {
                    try
                    {
                        eingabe = Convert.ToInt32(tb_eingabe.Text);
                        int eingabeDezimal = Convert.ToInt32(eingabe.ToString(), 8);
                        tb_binär.Text = zuBinär(eingabeDezimal);
                        tb_dezimal.Text = eingabeDezimal.ToString();
                        tb_hex.Text = zuHex(eingabeDezimal);
                        tb_ternär.Text = zuTernär(eingabeDezimal);
                        tb_oktal.Text = eingabe.ToString();
                    }
                    catch
                    {
                        Fehler();
                    }
                }

                else if (rb_hex.Checked)
                {
                    try
                    {
                        string eingabeHex = Convert.ToString(tb_eingabe.Text);
                        int eingabeDezimal = Convert.ToInt32(eingabeHex, 16);
                        tb_hex.Text = eingabeHex.ToString().ToUpper();
                        tb_binär.Text = zuBinär(eingabeDezimal);
                        tb_dezimal.Text = eingabeDezimal.ToString();
                        tb_ternär.Text = zuTernär(eingabeDezimal);
                        tb_oktal.Text = zuOktal(eingabeDezimal);
                    }
                    catch
                    {
                        Fehler();
                    }
                }
            }
            else
            {
                Fehler();
            }
        }

        void Fehler()
        {
            MessageBox.Show("Bitte geben Sie eine gültige Zahl ein!", "Fehler: ungültige Zahl", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string zuBinär(int eingabe)
        {
            List<int> ausgabe = new List<int>();
            int zahl = eingabe;
            int rest = 0;

            while (zahl != 0)
            {
                rest = zahl % 2;
                zahl = zahl / 2;

                if (rest > 0)
                {
                    ausgabe.Add(rest);
                }
                else
                {
                    ausgabe.Add(0);
                }
            }
            string binärzahl = string.Join("", ausgabe.ToArray().Reverse());
            return binärzahl;
        }

        private string zuTernär(int eingabe)
        {
            List<int> ausgabe = new List<int>();
            int zahl = eingabe;
            int rest = 0;

            while (zahl != 0)
            {
                rest = zahl % 3;
                zahl = zahl / 3;

                if (rest > 0)
                {
                    ausgabe.Add(rest);
                }
                else
                {
                    ausgabe.Add(0);
                }
            }
            string ternärzahl = string.Join("", ausgabe.ToArray().Reverse());
            return ternärzahl;
        }

        private string zuOktal(int eingabe)
        {
            List<int> ausgabe = new List<int>();
            int zahl = eingabe;
            int rest = 0;

            while (zahl != 0)
            {
                rest = zahl % 8;
                zahl = zahl / 8;

                if (rest > 0)
                {
                    ausgabe.Add(rest);
                }
                else
                {
                    ausgabe.Add(0);
                }
            }
            string oktalzahl = string.Join("", ausgabe.ToArray().Reverse());
            return oktalzahl;
        }

        private string zuHex(int eingabe)
        {
            int zahl = eingabe;
            int rest = 0;

            Dictionary<int, string> hexBuchstaben = new Dictionary<int, string>();
            hexBuchstaben.Add(10, "A");
            hexBuchstaben.Add(11, "B");
            hexBuchstaben.Add(12, "C");
            hexBuchstaben.Add(13, "D");
            hexBuchstaben.Add(14, "E");
            hexBuchstaben.Add(15, "F");


            List<string> zahlen = new List<string>();

            while (zahl != 0)
            {
                rest = zahl % 16;
                zahl = zahl / 16;

                if (rest > 9 && rest <= 15)
                {
                    string ergebnis = hexBuchstaben[rest];
                    zahlen.Add(ergebnis);
                }
                else
                {
                    zahlen.Add(rest.ToString());
                }
            }
            string hexzahl = string.Join("", zahlen.ToArray().Reverse());
            return hexzahl;
        }

        private int TernärZuDezimal(int eingabe)
        {
            string eingabeString = eingabe.ToString();
            int ausgabe = 0;
            int pot = 1;
            for (int i = 0; i < eingabeString.Length; i++)
            {
                // Es wird zuerst zu einem String konvertiert, da es sonst bei der Umwandlung von Char zu Int zu einem ASCII-Wert konvertiert wird.
                ausgabe += Convert.ToInt32(eingabeString[eingabeString.Length - 1 - i].ToString()) * pot;
                pot *= 3;
            }
            return ausgabe;
        }

        private void tb_eingabe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Return))
            {
                btn_berechnung.PerformClick();
            }
        }
    }
}