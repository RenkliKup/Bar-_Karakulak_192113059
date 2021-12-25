
namespace Barış_Karakulak_192113059.OgrenciIslemleri
{
    partial class ogrAnasayfa
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
            this.btn_ekle = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closelabel = new MetroFramework.Controls.MetroLabel();
            this.btn_sil = new MetroFramework.Controls.MetroButton();
            this.btn_Guncelle = new MetroFramework.Controls.MetroButton();
            this.btn_Listele = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Thistle;
            this.btn_ekle.Location = new System.Drawing.Point(12, 46);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(204, 224);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "Öğrenci Ekle";
            this.btn_ekle.UseCustomBackColor = true;
            this.btn_ekle.UseSelectable = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(11, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 10);
            this.panel1.TabIndex = 5;
            // 
            // closelabel
            // 
            this.closelabel.BackColor = System.Drawing.Color.Teal;
            this.closelabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.closelabel.ForeColor = System.Drawing.Color.Crimson;
            this.closelabel.Location = new System.Drawing.Point(407, 5);
            this.closelabel.Name = "closelabel";
            this.closelabel.Size = new System.Drawing.Size(19, 22);
            this.closelabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.closelabel.TabIndex = 4;
            this.closelabel.Text = "X";
            this.closelabel.UseCustomBackColor = true;
            this.closelabel.UseCustomForeColor = true;
            this.closelabel.Click += new System.EventHandler(this.closelabel_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Tomato;
            this.btn_sil.Location = new System.Drawing.Point(222, 46);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(204, 224);
            this.btn_sil.TabIndex = 6;
            this.btn_sil.Text = "Öğrenci Sil";
            this.btn_sil.UseCustomBackColor = true;
            this.btn_sil.UseSelectable = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Guncelle.Location = new System.Drawing.Point(12, 276);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(204, 224);
            this.btn_Guncelle.TabIndex = 7;
            this.btn_Guncelle.Text = "Öğrenci Güncelle";
            this.btn_Guncelle.UseCustomBackColor = true;
            this.btn_Guncelle.UseSelectable = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Listele
            // 
            this.btn_Listele.BackColor = System.Drawing.Color.Wheat;
            this.btn_Listele.Location = new System.Drawing.Point(222, 276);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(204, 224);
            this.btn_Listele.TabIndex = 8;
            this.btn_Listele.Text = "Öğrenci Listele/Ara";
            this.btn_Listele.UseCustomBackColor = true;
            this.btn_Listele.UseSelectable = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // ogrAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(437, 509);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closelabel);
            this.Controls.Add(this.btn_ekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ogrAnasayfa";
            this.Text = "OgrenciIslemleri";
            this.Load += new System.EventHandler(this.OgrenciIslemleri_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_ekle;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel closelabel;
        private MetroFramework.Controls.MetroButton btn_sil;
        private MetroFramework.Controls.MetroButton btn_Guncelle;
        private MetroFramework.Controls.MetroButton btn_Listele;
    }
}