using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starcups
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] kahveler = { "Filtre kahve", "Expresso", "Sütlü Kahve", "Frappaccino", "Mocca", "Su" };
            double[] KahveFiyat = { 10, 10, 15, 20, 18, 5 };
            for(int i=0;i<6;i++)
            {
                LstKahve.Items.Add(i+1+". "+kahveler[i]+" - "+KahveFiyat[i]+" TL");
            }
            
        }
    }
}
