
namespace Barış_Karakulak_192113059.iadeEt
{
    partial class ogrSec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ara = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.radio_soyad_gore = new MetroFramework.Controls.MetroRadioButton();
            this.radio_ad_gore = new MetroFramework.Controls.MetroRadioButton();
            this.txt_aranan_deger = new MetroFramework.Controls.MetroTextBox();
            this.data_grid_listele = new MetroFramework.Controls.MetroGrid();
            this.btn_sec = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closelabel = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ara);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.groupBox24);
            this.groupBox1.Controls.Add(this.txt_aranan_deger);
            this.groupBox1.Location = new System.Drawing.Point(11, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 119);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ara";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.groupBox24.Controls.Add(this.radio_soyad_gore);
            this.groupBox24.Controls.Add(this.radio_ad_gore);
            this.groupBox24.Location = new System.Drawing.Point(187, 10);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(146, 99);
            this.groupBox24.TabIndex = 3;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Göre Ara";
            // 
            // radio_soyad_gore
            // 
            this.radio_soyad_gore.AutoSize = true;
            this.radio_soyad_gore.Location = new System.Drawing.Point(3, 44);
            this.radio_soyad_gore.Name = "radio_soyad_gore";
            this.radio_soyad_gore.Size = new System.Drawing.Size(103, 17);
            this.radio_soyad_gore.TabIndex = 1;
            this.radio_soyad_gore.Text = "Soyad\'a Göre";
            this.radio_soyad_gore.UseCustomBackColor = true;
            this.radio_soyad_gore.UseSelectable = true;
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
            // data_grid_listele
            // 
            this.data_grid_listele.AllowUserToResizeRows = false;
            this.data_grid_listele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data_grid_listele.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_grid_listele.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_grid_listele.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_listele.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_grid_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_grid_listele.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_grid_listele.EnableHeadersVisualStyles = false;
            this.data_grid_listele.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.data_grid_listele.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data_grid_listele.Location = new System.Drawing.Point(12, 177);
            this.data_grid_listele.Name = "data_grid_listele";
            this.data_grid_listele.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_listele.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data_grid_listele.RowHeadersWidth = 51;
            this.data_grid_listele.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data_grid_listele.RowTemplate.Height = 24;
            this.data_grid_listele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_grid_listele.Size = new System.Drawing.Size(576, 170);
            this.data_grid_listele.TabIndex = 35;
            this.data_grid_listele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_listele_CellClick);
            // 
            // btn_sec
            // 
            this.btn_sec.Location = new System.Drawing.Point(12, 354);
            this.btn_sec.Name = "btn_sec";
            this.btn_sec.Size = new System.Drawing.Size(129, 23);
            this.btn_sec.TabIndex = 34;
            this.btn_sec.Text = "Öğrenci Seç";
            this.btn_sec.UseSelectable = true;
            this.btn_sec.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(11, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 10);
            this.panel1.TabIndex = 39;
            // 
            // closelabel
            // 
            this.closelabel.BackColor = System.Drawing.Color.Teal;
            this.closelabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.closelabel.ForeColor = System.Drawing.Color.Crimson;
            this.closelabel.Location = new System.Drawing.Point(572, 6);
            this.closelabel.Name = "closelabel";
            this.closelabel.Size = new System.Drawing.Size(19, 22);
            this.closelabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.closelabel.TabIndex = 38;
            this.closelabel.Text = "X";
            this.closelabel.UseCustomBackColor = true;
            this.closelabel.UseCustomForeColor = true;
            this.closelabel.Click += new System.EventHandler(this.closelabel_Click);
            // 
            // ogrSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(601, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closelabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.data_grid_listele);
            this.Controls.Add(this.btn_sec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ogrSec";
            this.Text = "ogrSec";
            this.Load += new System.EventHandler(this.ogrSec_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_listele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btn_ara;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox24;
        private MetroFramework.Controls.MetroRadioButton radio_ad_gore;
        private MetroFramework.Controls.MetroTextBox txt_aranan_deger;
        private MetroFramework.Controls.MetroGrid data_grid_listele;
        private MetroFramework.Controls.MetroButton btn_sec;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel closelabel;
        private MetroFramework.Controls.MetroRadioButton radio_soyad_gore;
    }
}