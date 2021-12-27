
namespace Barış_Karakulak_192113059.OgrenciIslemleri
{
    partial class ogrEkle
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
            this.btn_ogr_ekle = new MetroFramework.Controls.MetroButton();
            this.radio_erkek = new System.Windows.Forms.RadioButton();
            this.radio_kadın = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ogr_soyad = new MetroFramework.Controls.MetroTextBox();
            this.txt_ogr_ad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closelabel = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ogr_ekle
            // 
            this.btn_ogr_ekle.Location = new System.Drawing.Point(12, 396);
            this.btn_ogr_ekle.Name = "btn_ogr_ekle";
            this.btn_ogr_ekle.Size = new System.Drawing.Size(85, 23);
            this.btn_ogr_ekle.TabIndex = 0;
            this.btn_ogr_ekle.Text = "Ekle";
            this.btn_ogr_ekle.UseSelectable = true;
            this.btn_ogr_ekle.Click += new System.EventHandler(this.btn_ogr_ekle_Click);
            // 
            // radio_erkek
            // 
            this.radio_erkek.AutoSize = true;
            this.radio_erkek.Location = new System.Drawing.Point(21, 21);
            this.radio_erkek.Name = "radio_erkek";
            this.radio_erkek.Size = new System.Drawing.Size(65, 21);
            this.radio_erkek.TabIndex = 1;
            this.radio_erkek.TabStop = true;
            this.radio_erkek.Text = "Erkek";
            this.radio_erkek.UseVisualStyleBackColor = true;
            // 
            // radio_kadın
            // 
            this.radio_kadın.AutoSize = true;
            this.radio_kadın.Location = new System.Drawing.Point(21, 67);
            this.radio_kadın.Name = "radio_kadın";
            this.radio_kadın.Size = new System.Drawing.Size(65, 21);
            this.radio_kadın.TabIndex = 2;
            this.radio_kadın.TabStop = true;
            this.radio_kadın.Text = "Kadın";
            this.radio_kadın.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_kadın);
            this.groupBox1.Controls.Add(this.radio_erkek);
            this.groupBox1.Location = new System.Drawing.Point(12, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ogr_soyad);
            this.groupBox2.Controls.Add(this.txt_ogr_ad);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 155);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ad/Soyad";
            // 
            // txt_ogr_soyad
            // 
            // 
            // 
            // 
            this.txt_ogr_soyad.CustomButton.Image = null;
            this.txt_ogr_soyad.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txt_ogr_soyad.CustomButton.Name = "";
            this.txt_ogr_soyad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ogr_soyad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ogr_soyad.CustomButton.TabIndex = 1;
            this.txt_ogr_soyad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ogr_soyad.CustomButton.UseSelectable = true;
            this.txt_ogr_soyad.CustomButton.Visible = false;
            this.txt_ogr_soyad.Lines = new string[0];
            this.txt_ogr_soyad.Location = new System.Drawing.Point(6, 106);
            this.txt_ogr_soyad.MaxLength = 32767;
            this.txt_ogr_soyad.Name = "txt_ogr_soyad";
            this.txt_ogr_soyad.PasswordChar = '\0';
            this.txt_ogr_soyad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ogr_soyad.SelectedText = "";
            this.txt_ogr_soyad.SelectionLength = 0;
            this.txt_ogr_soyad.SelectionStart = 0;
            this.txt_ogr_soyad.ShortcutsEnabled = true;
            this.txt_ogr_soyad.Size = new System.Drawing.Size(133, 23);
            this.txt_ogr_soyad.TabIndex = 3;
            this.txt_ogr_soyad.UseSelectable = true;
            this.txt_ogr_soyad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ogr_soyad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_ogr_ad
            // 
            // 
            // 
            // 
            this.txt_ogr_ad.CustomButton.Image = null;
            this.txt_ogr_ad.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txt_ogr_ad.CustomButton.Name = "";
            this.txt_ogr_ad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ogr_ad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ogr_ad.CustomButton.TabIndex = 1;
            this.txt_ogr_ad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ogr_ad.CustomButton.UseSelectable = true;
            this.txt_ogr_ad.CustomButton.Visible = false;
            this.txt_ogr_ad.Lines = new string[0];
            this.txt_ogr_ad.Location = new System.Drawing.Point(6, 49);
            this.txt_ogr_ad.MaxLength = 32767;
            this.txt_ogr_ad.Name = "txt_ogr_ad";
            this.txt_ogr_ad.PasswordChar = '\0';
            this.txt_ogr_ad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ogr_ad.SelectedText = "";
            this.txt_ogr_ad.SelectionLength = 0;
            this.txt_ogr_ad.SelectionStart = 0;
            this.txt_ogr_ad.ShortcutsEnabled = true;
            this.txt_ogr_ad.Size = new System.Drawing.Size(133, 23);
            this.txt_ogr_ad.TabIndex = 2;
            this.txt_ogr_ad.UseSelectable = true;
            this.txt_ogr_ad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ogr_ad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Soyad";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(29, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Ad:";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 13);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // closelabel
            // 
            this.closelabel.BackColor = System.Drawing.Color.Teal;
            this.closelabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.closelabel.ForeColor = System.Drawing.Color.Crimson;
            this.closelabel.Location = new System.Drawing.Point(143, 30);
            this.closelabel.Name = "closelabel";
            this.closelabel.Size = new System.Drawing.Size(19, 23);
            this.closelabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.closelabel.TabIndex = 6;
            this.closelabel.Text = "X";
            this.closelabel.UseCustomBackColor = true;
            this.closelabel.UseCustomForeColor = true;
            this.closelabel.Click += new System.EventHandler(this.closelabel_Click);
            // 
            // ogrEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(174, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closelabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ogr_ekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ogrEkle";
            this.Text = "ogrEkle";
            this.Load += new System.EventHandler(this.ogrEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_ogr_ekle;
        private System.Windows.Forms.RadioButton radio_erkek;
        private System.Windows.Forms.RadioButton radio_kadın;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txt_ogr_soyad;
        private MetroFramework.Controls.MetroTextBox txt_ogr_ad;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel closelabel;
    }
}