using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Form1()
        {
            InitializeComponent();
            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            player.SoundLocation = "pumpupthemind-dance-revolution-243729.wav";
            player.PlayLooping();
            label2.Text = "Punteggio: " + punteggio;
            await Task.Delay(3000);
            generaNumero();
        }
        private  void generaNumero()
        {
            int n = rnd.Next(1, 6);
           
            if (n == 1)
            {   
               
                FrecciaSu();
            }
            else if (n == 2)
            {
                
                FrecciaDestra();
            }
            else if (n == 3)
            {
               
                FrecciaGiu();
            }
            else if (n == 4)
            {
               
                FrecciaSinistra();
            }
            else if(n == 5)
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
                generaNumero();
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
                generaNumero();
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
                generaNumero();
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
                generaNumero();
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
                generaNumero();
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