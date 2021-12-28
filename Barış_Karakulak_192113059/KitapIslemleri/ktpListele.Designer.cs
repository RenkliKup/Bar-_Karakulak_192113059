
namespace Barış_Karakulak_192113059.KitapIslemleri
{
    partial class ktpListele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closelabel = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ara = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.radio_yazar_gore = new MetroFramework.Controls.MetroRadioButton();
            this.radio_ad_gore = new MetroFramework.Controls.MetroRadioButton();
            this.txt_aranan_deger = new MetroFramework.Controls.MetroTextBox();
            this.grid_listele = new MetroFramework.Controls.MetroGrid();
            this.btn_listele = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radio_alinmamis_ktp = new MetroFramework.Controls.MetroRadioButton();
            this.radio_alinmis_ktp = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton4 = new MetroFramework.Controls.MetroRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            this.groupBox24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_listele)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(8, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 10);
            this.panel1.TabIndex = 38;
            // 
            // closelabel
            // 
            this.closelabel.BackColor = System.Drawing.Color.Teal;
            this.closelabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.closelabel.ForeColor = System.Drawing.Color.Crimson;
            this.closelabel.Location = new System.Drawing.Point(1054, 4);
            this.closelabel.Name = "closelabel";
            this.closelabel.Size = new System.Drawing.Size(19, 23);
            this.closelabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.closelabel.TabIndex = 37;
            this.closelabel.Text = "X";
            this.closelabel.UseCustomBackColor = true;
            this.closelabel.UseCustomForeColor = true;
            this.closelabel.Click += new System.EventHandler(this.closelabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ara);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.groupBox24);
            this.groupBox1.Controls.Add(this.txt_aranan_deger);
            this.groupBox1.Location = new System.Drawing.Point(7, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 119);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ara";
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(6, 81);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(175, 23);
            this.btn_ara.TabIndex = 4;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseSelectable = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Aranan Değer";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.radio_yazar_gore);
            this.groupBox24.Controls.Add(this.radio_ad_gore);
            this.groupBox24.Location = new System.Drawing.Point(187, 10);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(146, 99);
            this.groupBox24.TabIndex = 3;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Göre Ara";
            // 
            // radio_yazar_gore
            // 
            this.radio_yazar_gore.AutoSize = true;
            this.radio_yazar_gore.Location = new System.Drawing.Point(3, 44);
            this.radio_yazar_gore.Name = "radio_yazar_gore";
            this.radio_yazar_gore.Size = new System.Drawing.Size(98, 17);
            this.radio_yazar_gore.TabIndex = 1;
            this.radio_yazar_gore.Text = "Yazar\'a Göre";
            this.radio_yazar_gore.UseCustomBackColor = true;
            this.radio_yazar_gore.UseSelectable = true;
            // 
            // radio_ad_gore
            // 
            this.radio_ad_gore.AutoSize = true;
            this.radio_ad_gore.Location = new System.Drawing.Point(3, 21);
            this.radio_ad_gore.Name = "radio_ad_gore";
            this.radio_ad_gore.Size = new System.Drawing.Size(83, 17);
            this.radio_ad_gore.TabIndex = 0;
            this.radio_ad_gore.Text = "Ad\'a Göre";
            this.radio_ad_gore.UseCustomBackColor = true;
            this.radio_ad_gore.UseSelectable = true;
            // 
            // txt_aranan_deger
            // 
            // 
            // 
            // 
            this.txt_aranan_deger.CustomButton.Image = null;
            this.txt_aranan_deger.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txt_aranan_deger.CustomButton.Name = "";
            this.txt_aranan_deger.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_aranan_deger.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_aranan_deger.CustomButton.TabIndex = 1;
            this.txt_aranan_deger.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_aranan_deger.CustomButton.UseSelectable = true;
            this.txt_aranan_deger.CustomButton.Visible = false;
            this.txt_aranan_deger.Lines = new string[0];
            this.txt_aranan_deger.Location = new System.Drawing.Point(6, 52);
            this.txt_aranan_deger.MaxLength = 32767;
            this.txt_aranan_deger.Name = "txt_aranan_deger";
            this.txt_aranan_deger.PasswordChar = '\0';
            this.txt_aranan_deger.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_aranan_deger.SelectedText = "";
            this.txt_aranan_deger.SelectionLength = 0;
            this.txt_aranan_deger.SelectionStart = 0;
            this.txt_aranan_deger.ShortcutsEnabled = true;
            this.txt_aranan_deger.Size = new System.Drawing.Size(175, 23);
            this.txt_aranan_deger.TabIndex = 2;
            this.txt_aranan_deger.UseSelectable = true;
            this.txt_aranan_deger.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_aranan_deger.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // grid_listele
            // 
            this.grid_listele.AllowUserToResizeRows = false;
            this.grid_listele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_listele.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_listele.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_listele.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_listele.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_listele.DefaultCellStyle = dataGridViewCellStyle8;
            this.grid_listele.EnableHeadersVisualStyles = false;
            this.grid_listele.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_listele.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_listele.Location = new System.Drawing.Point(9, 174);
            this.grid_listele.Name = "grid_listele";
            this.grid_listele.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_listele.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grid_listele.RowHeadersWidth = 51;
            this.grid_listele.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_listele.RowTemplate.Height = 24;
            this.grid_listele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_listele.Size = new System.Drawing.Size(576, 170);
            this.grid_listele.TabIndex = 35;
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(12, 350);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(129, 23);
            this.btn_listele.TabIndex = 34;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radio_alinmamis_ktp);
            this.groupBox3.Controls.Add(this.radio_alinmis_ktp);
            this.groupBox3.Controls.Add(this.metroRadioButton4);
            this.groupBox3.Location = new System.Drawing.Point(355, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 119);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Göre Listele";
            // 
            // radio_alinmamis_ktp
            // 
            this.radio_alinmamis_ktp.Location = new System.Drawing.Point(6, 47);
            this.radio_alinmamis_ktp.Name = "radio_alinmamis_ktp";
            this.radio_alinmamis_ktp.Size = new System.Drawing.Size(149, 17);
            this.radio_alinmamis_ktp.TabIndex = 2;
            this.radio_alinmamis_ktp.Text = "Alınmamış Kitaplar";
            this.radio_alinmamis_ktp.UseCustomBackColor = true;
            this.radio_alinmamis_ktp.UseSelectable = true;
            // 
            // radio_alinmis_ktp
            // 
            this.radio_alinmis_ktp.Location = new System.Drawing.Point(6, 24);
            this.radio_alinmis_ktp.Name = "radio_alinmis_ktp";
            this.radio_alinmis_ktp.Size = new System.Drawing.Size(149, 17);
            this.radio_alinmis_ktp.TabIndex = 1;
            this.radio_alinmis_ktp.Text = "Alınmış Kitaplar";
            this.radio_alinmis_ktp.UseCustomBackColor = true;
            this.radio_alinmis_ktp.UseSelectable = true;
            // 
            // metroRadioButton4
            // 
            this.metroRadioButton4.AutoSize = true;
            this.metroRadioButton4.Location = new System.Drawing.Point(6, 21);
            this.metroRadioButton4.Name = "metroRadioButton4";
            this.metroRadioButton4.Size = new System.Drawing.Size(16, 0);
            this.metroRadioButton4.TabIndex = 0;
            this.metroRadioButton4.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ödünç Aldığı Öğrenciler ";
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(591, 173);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid2.RowHeadersWidth = 51;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.RowTemplate.Height = 24;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(485, 170);
            this.metroGrid2.TabIndex = 40;
            // 
            // ktpListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1088, 382);
            this.Controls.Add(this.metroGrid2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closelabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid_listele);
            this.Controls.Add(this.btn_listele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ktpListele";
            this.Text = "ktpListele";
            this.Load += new System.EventHandler(this.ktpListele_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_listele)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel closelabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btn_ara;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox24;
        private MetroFramework.Controls.MetroRadioButton radio_yazar_gore;
        private MetroFramework.Controls.MetroRadioButton radio_ad_gore;
        private MetroFramework.Controls.MetroTextBox txt_aranan_deger;
        private MetroFramework.Controls.MetroGrid grid_listele;
        private MetroFramework.Controls.MetroButton btn_listele;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroRadioButton radio_alinmamis_ktp;
        private MetroFramework.Controls.MetroRadioButton radio_alinmis_ktp;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton4;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroGrid metroGrid2;
    }
}