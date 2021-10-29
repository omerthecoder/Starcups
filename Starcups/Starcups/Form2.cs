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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Array.Resize(ref Form1.kahveler, Form1.kahveler.Length+1);
            Array.Resize(ref Form1.KahveFiyat, Form1.KahveFiyat.Length + 1);
            Form1.kahveler[Form1.kahveler.Length-1] = txtYeniIcecek.Text;
            Form1.KahveFiyat[Form1.KahveFiyat.Length-1] = Convert.ToDouble(txtfyt.Text);
            this.Close();
            
        }

        private void txtfyt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtYeniIcecek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
