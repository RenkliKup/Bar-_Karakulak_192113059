
namespace Barış_Karakulak_192113059.KitapIslemleri
{
    partial class ktpAnasayfa
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
            this.btn_listele = new MetroFramework.Controls.MetroButton();
            this.btn_guncelle = new MetroFramework.Controls.MetroButton();
            this.btn_sil = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closelabel = new MetroFramework.Controls.MetroLabel();
            this.btn_ekle = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.Wheat;
            this.btn_listele.Location = new System.Drawing.Point(221, 275);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(204, 224);
            this.btn_listele.TabIndex = 14;
            this.btn_listele.Text = "Kitap Listele/Ara";
            this.btn_listele.UseCustomBackColor = true;
            this.btn_listele.UseSelectable = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.Turquoise;
            this.btn_guncelle.Location = new System.Drawing.Point(11, 275);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(204, 224);
            this.btn_guncelle.TabIndex = 13;
            this.btn_guncelle.Text = "Kitap Güncelle";
            this.btn_guncelle.UseCustomBackColor = true;
            this.btn_guncelle.UseSelectable = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Tomato;
            this.btn_sil.Location = new System.Drawing.Point(221, 45);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(204, 224);
            this.btn_sil.TabIndex = 12;
            this.btn_sil.Text = "Kitap Sil";
            this.btn_sil.UseCustomBackColor = true;
            this.btn_sil.UseSelectable = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(10, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 10);
            this.panel1.TabIndex = 11;
            // 
            // closelabel
            // 
            this.closelabel.BackColor = System.Drawing.Color.Teal;
            this.closelabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.closelabel.ForeColor = System.Drawing.Color.Crimson;
            this.closelabel.Location = new System.Drawing.Point(406, 4);
            this.closelabel.Name = "closelabel";
            this.closelabel.Size = new System.Drawing.Size(19, 22);
            this.closelabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.closelabel.TabIndex = 10;
            this.closelabel.Text = "X";
            this.closelabel.UseCustomBackColor = true;
            this.closelabel.UseCustomForeColor = true;
            this.closelabel.Click += new System.EventHandler(this.closelabel_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Thistle;
            this.btn_ekle.Location = new System.Drawing.Point(11, 45);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(204, 224);
            this.btn_ekle.TabIndex = 9;
            this.btn_ekle.Text = "Kitap Ekle";
            this.btn_ekle.UseCustomBackColor = true;
            this.btn_ekle.UseSelectable = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // ktpAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(437, 509);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closelabel);
            this.Controls.Add(this.btn_ekle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ktpAnasayfa";
            this.Text = "ktpAnasayfa";
            this.Load += new System.EventHandler(this.ktpAnasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_listele;
        private MetroFramework.Controls.MetroButton btn_guncelle;
        private MetroFramework.Controls.MetroButton btn_sil;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel closelabel;
        private MetroFramework.Controls.MetroButton btn_ekle;
    }
}