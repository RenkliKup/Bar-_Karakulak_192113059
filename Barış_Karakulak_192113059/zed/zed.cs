using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using DataTransactionLayer;
namespace Barış_Karakulak_192113059.zed
{
    public partial class zed : Form
    {
        public zed()
        {
            InitializeComponent();
        }
          protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        //BookContext olusturdum
        BookContext BookContext = new BookContext();
        private void closelabel_Click(object sender, EventArgs e)
        {
            //formu kapat
            this.Close();
        }

        private void zed_Load(object sender, EventArgs e)
        {
            // get a reference to the GraphPane
            GraphPane myPane = zedGraphControl1.GraphPane;

            // Set the Titles
            myPane.Title.Text = "My Test Bar Graph";
            myPane.XAxis.Title.Text = "Label";
            myPane.YAxis.Title.Text = "My Y Axis";

            // Make up some random data points
            string[] labels = { "Verilmeye Hazır Kitaplar", "Verilmiş Kitaplar"  };
            int alinmamisKitaplar = BookContext.AlinmamisKitaplar().Count;
            int alinmisKitaplar = BookContext.AlinmisKitaplar().Count;
            double[] y = { alinmamisKitaplar, alinmisKitaplar };
            
            

            // Generate a red bar with "Curve 1" in the legend
            BarItem myBar = myPane.AddBar("Curve 1", null, y,
                                                        Color.Red);
            myBar.Bar.Fill = new Fill(Color.Red, Color.White,
                                                        Color.Red);

            
            // Draw the X tics between the labels instead of 
            // at the labels
            myPane.XAxis.MajorTic.IsBetweenLabels = true;

            // Set the XAxis labels
            myPane.XAxis.Scale.TextLabels = labels;
            // Set the XAxis to Text type
            myPane.XAxis.Type = AxisType.Text;

            // Fill the Axis and Pane backgrounds
            myPane.Chart.Fill = new Fill(Color.White,
                  Color.FromArgb(255, 255, 166), 90F);
            myPane.Fill = new Fill(Color.FromArgb(250, 250, 255));

            // Tell ZedGraph to refigure the
            // axes since the data have changed
            zedGraphControl1.AxisChange();
        }
    }
      

       
    }

