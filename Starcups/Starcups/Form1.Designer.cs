namespace Starcups
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstSiparisOzeti = new System.Windows.Forms.ListBox();
            this.gbSiparişVeme = new System.Windows.Forms.GroupBox();
            this.gb = new System.Windows.Forms.GroupBox();
            this.clbEkstra = new System.Windows.Forms.CheckedListBox();
            this.btnSiparisOnay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKahveSecim = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.LstKahve = new System.Windows.Forms.ListBox();
            this.btnIcecekEkle = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.gbSiparişVeme.SuspendLayout();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSiparisOzeti
            // 
            this.lstSiparisOzeti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lstSiparisOzeti.FormattingEnabled = true;
            this.lstSiparisOzeti.ItemHeight = 20;
            this.lstSiparisOzeti.Location = new System.Drawing.Point(305, 348);
            this.lstSiparisOzeti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstSiparisOzeti.Name = "lstSiparisOzeti";
            this.lstSiparisOzeti.Size = new System.Drawing.Size(416, 304);
            this.lstSiparisOzeti.TabIndex = 0;
            // 
            // gbSiparişVeme
            // 
            this.gbSiparişVeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbSiparişVeme.Controls.Add(this.gb);
            this.gbSiparişVeme.Controls.Add(this.btnSiparisOnay);
            this.gbSiparişVeme.Controls.Add(this.label3);
            this.gbSiparişVeme.Controls.Add(this.rbKucuk);
            this.gbSiparişVeme.Controls.Add(this.rbOrta);
            this.gbSiparişVeme.Controls.Add(this.rbBuyuk);
            this.gbSiparişVeme.Controls.Add(this.label2);
            this.gbSiparişVeme.Controls.Add(this.label1);
            this.gbSiparişVeme.Controls.Add(this.txtKahveSecim);
            this.gbSiparişVeme.Controls.Add(this.txtAd);
            this.gbSiparişVeme.Location = new System.Drawing.Point(14, 14);
            this.gbSiparişVeme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSiparişVeme.Name = "gbSiparişVeme";
            this.gbSiparişVeme.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSiparişVeme.Size = new System.Drawing.Size(283, 638);
            this.gbSiparişVeme.TabIndex = 1;
            this.gbSiparişVeme.TabStop = false;
            this.gbSiparişVeme.Text = "Sipariş Ekranı";
            // 
            // gb
            // 
            this.gb.Controls.Add(this.clbEkstra);
            this.gb.Location = new System.Drawing.Point(12, 271);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(253, 228);
            this.gb.TabIndex = 5;
            this.gb.TabStop = false;
            this.gb.Text = "Ekstralar";
            // 
            // clbEkstra
            // 
            this.clbEkstra.CheckOnClick = true;
            this.clbEkstra.FormattingEnabled = true;
            this.clbEkstra.Location = new System.Drawing.Point(6, 22);
            this.clbEkstra.Name = "clbEkstra";
            this.clbEkstra.Size = new System.Drawing.Size(232, 193);
            this.clbEkstra.TabIndex = 0;
            // 
            // btnSiparisOnay
            // 
            this.btnSiparisOnay.Location = new System.Drawing.Point(9, 505);
            this.btnSiparisOnay.Name = "btnSiparisOnay";
            this.btnSiparisOnay.Size = new System.Drawing.Size(256, 34);
            this.btnSiparisOnay.TabIndex = 4;
            this.btnSiparisOnay.Text = "Sipariş Onay";
            this.btnSiparisOnay.UseVisualStyleBackColor = true;
            this.btnSiparisOnay.Click += new System.EventHandler(this.btnSiparisOnay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Boy Seçimi";
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Location = new System.Drawing.Point(13, 181);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(76, 24);
            this.rbKucuk.TabIndex = 2;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(99, 181);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(62, 24);
            this.rbOrta.TabIndex = 2;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(170, 181);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(76, 24);
            this.rbBuyuk.TabIndex = 2;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kahve Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // txtKahveSecim
            // 
            this.txtKahveSecim.Location = new System.Drawing.Point(9, 127);
            this.txtKahveSecim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKahveSecim.Name = "txtKahveSecim";
            this.txtKahveSecim.Size = new System.Drawing.Size(241, 26);
            this.txtKahveSecim.TabIndex = 0;
            this.txtKahveSecim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKahveSecim_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(9, 71);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(241, 26);
            this.txtAd.TabIndex = 0;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // LstKahve
            // 
            this.LstKahve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LstKahve.FormattingEnabled = true;
            this.LstKahve.ItemHeight = 20;
            this.LstKahve.Location = new System.Drawing.Point(305, 14);
            this.LstKahve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LstKahve.Name = "LstKahve";
            this.LstKahve.Size = new System.Drawing.Size(416, 284);
            this.LstKahve.TabIndex = 2;
            // 
            // btnIcecekEkle
            // 
            this.btnIcecekEkle.Location = new System.Drawing.Point(305, 307);
            this.btnIcecekEkle.Name = "btnIcecekEkle";
            this.btnIcecekEkle.Size = new System.Drawing.Size(206, 31);
            this.btnIcecekEkle.TabIndex = 3;
            this.btnIcecekEkle.Text = "Listeye İçecek Ekle";
            this.btnIcecekEkle.UseVisualStyleBackColor = true;
            this.btnIcecekEkle.Click += new System.EventHandler(this.btnIcecekEkle_Click_1);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(517, 307);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(204, 31);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Ekleme Sonrası Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(734, 661);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnIcecekEkle);
            this.Controls.Add(this.LstKahve);
            this.Controls.Add(this.gbSiparişVeme);
            this.Controls.Add(this.lstSiparisOzeti);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Starcups";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSiparişVeme.ResumeLayout(false);
            this.gbSiparişVeme.PerformLayout();
            this.gb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSiparisOzeti;
        private System.Windows.Forms.GroupBox gbSiparişVeme;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ListBox LstKahve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKahveSecim;
        private System.Windows.Forms.Button btnSiparisOnay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Button btnIcecekEkle;
        private System.Windows.Forms.CheckedListBox clbEkstra;
        private System.Windows.Forms.Button btnYenile;
    }
}

