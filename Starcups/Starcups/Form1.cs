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
        #region Global Variables
        public static string[] kahveler = { "Filtre kahve", "Expresso", "Sütlü Kahve", "Frappaccino", "Mocca", "Su" };
        public static string[] ekstralar = { "Çikolata", "Sandviç", "Pasta", "Cookie", "Lokum" };
        public static double[] ekstraFiyat = { 5, 10, 15, 8, 5 };
        public static double[] KahveFiyat = { 10, 10, 15, 20, 18, 5 };
        string[] siparislist = new string[0];
        double siparisToplami = 0;
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < kahveler.Length; i++)
            {
                LstKahve.Items.Add(i + 1 + ". " + kahveler[i] + " - " + KahveFiyat[i] + " TL");

            }
            for (int i = 0; i < ekstralar.Length; i++)
            {
                clbEkstra.Items.Add(ekstralar[i]);
            }
            rbKucuk.Checked = true;

        }

        private void btnSiparisOnay_Click(object sender, EventArgs e)
        {

            if (txtAd.Text != "" && txtKahveSecim.Text != "")
            {
                try
                {
                    lstSiparisOzeti.Items.Clear();
                    Array.Resize(ref siparislist, siparislist.Length + 1);
                    siparislist[siparislist.Length - 1] = kahveler[Convert.ToInt32(txtKahveSecim.Text) - 1];
                    #region Ekstralar
                    foreach (var ekstra in clbEkstra.CheckedItems)
                    {
                        Array.Resize(ref siparislist, siparislist.Length + 1);
                        siparislist[siparislist.Length - 1] = ekstra.ToString();
                        siparisToplami += ekstraFiyat[Array.IndexOf(ekstralar, ekstra)];

                    } 
                    #endregion
                    lstSiparisOzeti.Items.Add("Sipariş Sahibi: " + txtAd.Text);
                    lstSiparisOzeti.Items.Add("                                        --Siparişler--");
                    foreach (var sipraris in siparislist)
                    {
                        lstSiparisOzeti.Items.Add(sipraris);

                    }

                    if (rbBuyuk.Checked)
                    {
                        siparisToplami += (Convert.ToDouble(KahveFiyat[Convert.ToInt32(txtKahveSecim.Text) - 1]) * 1.5);
                    }
                    else if (rbOrta.Checked)
                    {
                        siparisToplami += (Convert.ToDouble(KahveFiyat[Convert.ToInt32(txtKahveSecim.Text) - 1]) * 1.25);
                    }
                    else if (rbKucuk.Checked)
                    {
                        siparisToplami += (Convert.ToDouble(KahveFiyat[Convert.ToInt32(txtKahveSecim.Text) - 1]));
                    }


                    lstSiparisOzeti.Items.Add("Toplam Tutar = " + siparisToplami);
                }
                catch (Exception ex)
                {
                    Array.Resize(ref siparislist, siparislist.Length - 1);
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Lütfen eksik alanları doldurunuz.");
            }
        }


        private void btnIcecekEkle_Click(object sender, EventArgs e)
        {

        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKahveSecim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void btnIcecekEkle_Click_1(object sender, EventArgs e)
        {
            
            Form2 kahveEklemeFormu = new Form2();
            kahveEklemeFormu.Show();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            LstKahve.Items.Clear();
            for (int i = 0; i < kahveler.Length; i++)
            {
                LstKahve.Items.Add(i + 1 + ". " + kahveler[i] + " - " + KahveFiyat[i] + " TL");

            }
        }
    }
}