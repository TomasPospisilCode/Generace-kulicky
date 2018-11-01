using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kulička
{
    public partial class Form1 : Form
    {
        Random náhoda = new Random();

        //souřadnice středu kuličky
        // (na začátku "za okrajem", aby nebyla vidět)
        double x = -20, y = -20;
        //Složky rychlosti kuličky (na začátku stojí)
        double vx = 0, vy = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            //FillElipse potřebuje levý horní (LH) roh
            //opsaného obdelníka. Poloměr kuličky bude 5 pixelů

            int xLH = Convert.ToInt32(x - 5);
            int yLH = Convert.ToInt32(y - 5);

            kp.FillEllipse(Brushes.CornflowerBlue, xLH, yLH, 10, 10);
        }

        private void casovac_Tick(object sender, EventArgs e)
        {
            double čas = casovac.Interval * 0.001;
            x += vx * čas;
            y += vy * čas;
            Refresh();
        }

        private void btnKulicka_Click(object sender, EventArgs e)
        {

            //Kulička se umístí (vrátí) doprostřed okna
            x = ClientSize.Width / 2;
            y = ClientSize.Height / 2;

            //náhodně určíme rychlost kuličky
            vx = Convert.ToInt32(textBox1.Text);
            vy = Convert.ToInt32(textBox2.Text);




        }
    }
}
