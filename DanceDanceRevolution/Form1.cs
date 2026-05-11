using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace DanceDanceRevolution
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();
        Random rnd = new Random();
        int punteggio = 0;
        bool statosu = false;
        bool statodestra = false;
        bool statogiu = false;
        bool statosinistra = false;
        bool statocentro = false;
        List<int> passi = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.SoundLocation = "pumpupthemind-dance-revolution-243729.wav";
            player.PlayLooping();
            label2.Text = "Punteggio: " + punteggio;

            for (int i = 0; i < 2; i++)
            {
                passi.Add(rnd.Next(1, 6));
            }

            nuoviPassi();
            prossimoPasso();
        }

        private void nuoviPassi()
        {
            string preview = "Prossimi passi: ";
            for (int i = 0; i < passi.Count; i++)
            {
                if (passi[i] == 1)
                {
                    preview += "SU ";
                }
                else if (passi[i] == 2)
                {
                    preview += "DESTRA ";
                }
                else if (passi[i] == 3)
                {
                    preview += "GIU ";
                }
                else if (passi[i] == 4)
                {
                    preview += "SINISTRA ";
                }
                else if (passi[i] == 5)
                {
                    preview += "CENTRO ";
                }
            }
            label3.Text = preview;
        }

        private void prossimoPasso()
        {
            int n = rnd.Next(1, 6);
            passi.Add(n);

            int passoCorrente = passi[0];
            passi.RemoveAt(0);

            nuoviPassi();

            if (passoCorrente == 1)
            {
                FrecciaSu();
            }
            else if (passoCorrente == 2)
            {
                FrecciaDestra();
            }
            else if (passoCorrente == 3)
            {
                FrecciaGiu();
            }
            else if (passoCorrente == 4)
            {
                FrecciaSinistra();
            }
            else if (passoCorrente == 5)
            {
                Centro();
            }
        }

        private void FrecciaSu()
        {
            btnSu.BackColor = Color.Green;
            statosu = true;
        }

        private void FrecciaDestra()
        {
            btnDestra.BackColor = Color.Yellow;
            statodestra = true;
        }

        private void FrecciaGiu()
        {
            btnGiu.BackColor = Color.Blue;
            statogiu = true;
        }

        private void FrecciaSinistra()
        {
            btnSinistra.BackColor = Color.Fuchsia;
            statosinistra = true;
        }

        private void Centro()
        {
            btnCentro.BackColor = Color.Gold;
            statocentro = true;
        }

        private void btnSu_Click(object sender, EventArgs e)
        {
            if (statosu == true)
            {
                punteggio++;
                label2.Text = "Punteggio: " + punteggio;
                btnSu.BackColor = Color.White;
                statosu = false;
                prossimoPasso();
            }
            else
            {
                if (punteggio > 0)
                {
                    punteggio--;
                    label2.Text = "Punteggio: " + punteggio;
                }
                else
                {
                    punteggio = 0;
                    label2.Text = "Punteggio: " + punteggio;
                }
            }
        }

        private void btnDestra_Click(object sender, EventArgs e)
        {
            if (statodestra == true)
            {
                punteggio++;
                label2.Text = "Punteggio: " + punteggio;
                btnDestra.BackColor = Color.White;
                statodestra = false;
                prossimoPasso();
            }
            else
            {
                if (punteggio > 0)
                {
                    punteggio--;
                    label2.Text = "Punteggio: " + punteggio;
                }
                else
                {
                    punteggio = 0;
                    label2.Text = "Punteggio: " + punteggio;
                }
            }
        }

        private void btnGiu_Click(object sender, EventArgs e)
        {
            if (statogiu == true)
            {
                punteggio++;
                label2.Text = "Punteggio: " + punteggio;
                btnGiu.BackColor = Color.White;
                statogiu = false;
                prossimoPasso();
            }
            else
            {
                if (punteggio > 0)
                {
                    punteggio--;
                    label2.Text = "Punteggio: " + punteggio;
                }
                else
                {
                    punteggio = 0;
                    label2.Text = "Punteggio: " + punteggio;
                }
            }
        }

        private void btnSinistra_Click(object sender, EventArgs e)
        {
            if (statosinistra == true)
            {
                punteggio++;
                label2.Text = "Punteggio: " + punteggio;
                btnSinistra.BackColor = Color.White;
                statosinistra = false;
                prossimoPasso();
            }
            else
            {
                if (punteggio > 0)
                {
                    punteggio--;
                    label2.Text = "Punteggio: " + punteggio;
                }
                else
                {
                    punteggio = 0;
                    label2.Text = "Punteggio: " + punteggio;
                }
            }
        }

        private void btnCentro_Click(object sender, EventArgs e)
        {
            if (statocentro == true)
            {
                punteggio++;
                label2.Text = "Punteggio: " + punteggio;
                btnCentro.BackColor = Color.White;
                statocentro = false;
                prossimoPasso();
            }
            else
            {
                if (punteggio > 0)
                {
                    punteggio--;
                    label2.Text = "Punteggio: " + punteggio;
                }
                else
                {
                    punteggio = 0;
                    label2.Text = "Punteggio: " + punteggio;
                }
            }
        }
    }
}