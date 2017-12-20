using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoBaratinha
{
    public partial class Form1 : Form
    {
        int x = 0, y = 0, cont = 0, pontos = 0;
        Random gerRandomico = new Random();
        System.Media.SoundPlayer somJogando  = new System.Media.SoundPlayer(@"Alarm01.wav");

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x = gerRandomico.Next(30, 990);
            y = gerRandomico.Next(30, 700);

            pcbBaratinha.Location = new System.Drawing.Point(x, y);
        }

        private void pcbBaratinha_Click(object sender, EventArgs e)
        {
            pcbBaratinha.Image = Properties.Resources.mosca;
            somJogando.Stop();
            somGanhador.Play();

            DialogResult resposta = MessageBox.Show("Ganhou", "Parabéns", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                pcbBaratinha.Image = Properties.Resources.mosca;
                somGanhador.Stop();
                somJogando.Play();
            }
        }

        System.Media.SoundPlayer somGanhador = new System.Media.SoundPlayer(@"Alarm02.wav");

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
