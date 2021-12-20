
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_ogr_ad = new MetroFramework.Controls.MetroTextBox();
            this.txt_ogr_soyad = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closelabel = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(12, 396);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(85, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Ekle";
            this.metroButton1.UseSelectable = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Erkek";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 67);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kadın";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
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
            // txt_ogr_ad
            // 
            // 
            // 
            // 
            this.txt_ogr_ad.CustomButton.Image = null;
            this.txt_ogr_ad.CustomButton.Location = new System.Drawing.Point(117, 1);
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
            // txt_ogr_soyad
            // 
            // 
            // 
            // 
            this.txt_ogr_soyad.CustomButton.Image = null;
            this.txt_ogr_soyad.CustomButton.Location = new System.Drawing.Point(117, 1);
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
            this.Controls.Add(this.metroButton1);
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

        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
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