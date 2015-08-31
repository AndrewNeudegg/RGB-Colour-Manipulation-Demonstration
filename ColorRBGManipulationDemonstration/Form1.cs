using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorRBGManipulationDemonstration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int _r = 0;
        private int _b = 0;
        private int _g = 0;
        private Color ccColor = Color.White;
        private void button1_Click(object sender, EventArgs e)
        {
            var colorDialog1 = new ColorDialog();
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set the variable.
                ccColor = colorDialog1.Color;
            }

            InvalidateDataSet();
        }

        private void InvalidateDataSet()
        {
            button1.BackColor = ccColor;

            // Red v. Blue
            graph1.XAxisColor = Color.Red;
            graph1.YAxisColor = Color.Blue;
            graph1.PointColor = ccColor;
            //MessageBox.Show(String.Format("R:{0}, B:{1}", ccColor.R, ccColor.B));
            graph1.PointLocation = new Point(ccColor.R, ccColor.B);


            // Red v. Green
            graph2.XAxisColor = Color.Red;
            graph2.YAxisColor = Color.Green;
            graph2.PointColor = ccColor;
            //MessageBox.Show(String.Format("R:{0}, G:{1}", ccColor.R, ccColor.G));
            graph2.PointLocation = new Point(ccColor.R, ccColor.G);

            // Blue v. Green
            graph3.XAxisColor = Color.Blue;
            graph3.YAxisColor = Color.DarkGreen;
            graph3.PointColor = ccColor;
            //MessageBox.Show(String.Format("B:{0}, G:{1}", ccColor.B, ccColor.G));
            graph3.PointLocation = new Point(ccColor.B, ccColor.G);


            graph1.Invalidate();
            graph2.Invalidate();
            graph3.Invalidate();
            label1.Text = string.Format("RBG: ({0},{1},{2})", ccColor.R, ccColor.G, ccColor.B);
            _r = ccColor.R;
            _b = ccColor.B;
            _g = ccColor.G;


            lbl_Brightness.Text = String.Format("Brightness: {0}", ccColor.GetBrightness());
            lbl_Hue.Text = String.Format("Hue: {0}", ccColor.GetHue());
            lbl_Saturation.Text = String.Format("Saturation: {0}", ccColor.GetSaturation());

            REqualsB.BackColor = Color.FromArgb(_b, _g,_b);
            REqualsG.BackColor = Color.FromArgb(_g, _g, _b);
            BEqualsG.BackColor = Color.FromArgb(_r, _g, _g);
            BEqualsR.BackColor = Color.FromArgb(_r, _g, _r);
            GEqualsB.BackColor = Color.FromArgb(_r, _b, _b);
            GEqualsR.BackColor = Color.FromArgb(_r, _r, _b);


            trkBrR.Value = _r;
            trkBrG.Value = _g;
            trkBrB.Value = _b;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/andrewneudegg");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_Hue_Click(object sender, EventArgs e)
        {

        }

        private void REqualsB_Click(object sender, EventArgs e)
        {
            ccColor = REqualsB.BackColor;
            InvalidateDataSet();
        }

        private void BEqualsR_Click(object sender, EventArgs e)
        {
            ccColor = BEqualsR.BackColor;
            InvalidateDataSet();
        }

        private void GEqualsR_Click(object sender, EventArgs e)
        {
            ccColor = GEqualsR.BackColor;
            InvalidateDataSet();
        }

        private void REqualsG_Click(object sender, EventArgs e)
        {
            ccColor = REqualsG.BackColor;
            InvalidateDataSet();
        }

        private void BEqualsG_Click(object sender, EventArgs e)
        {
            ccColor = BEqualsG.BackColor;
            InvalidateDataSet();
        }

        private void GEqualsB_Click(object sender, EventArgs e)
        {
            ccColor = GEqualsB.BackColor;
            InvalidateDataSet();
        }

        private void trkBrR_Scroll(object sender, EventArgs e)
        {
            _r = trkBrR.Value;
            ccColor = Color.FromArgb(_r, _g, _b);
            InvalidateDataSet();
        }

        private void trkBrG_Scroll(object sender, EventArgs e)
        {
            _g = trkBrG.Value;
            ccColor = Color.FromArgb(_r, _g, _b);
            InvalidateDataSet();
        }

        private void trkBrB_Scroll(object sender, EventArgs e)
        {
            _b = trkBrB.Value;
            ccColor = Color.FromArgb(_r, _g, _b);
            InvalidateDataSet();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private int trkBrOverallValue = 0;
        private void trkBrOverall_Scroll(object sender, EventArgs e)
        {
            int tempVal = trkBrOverall.Value - trkBrOverallValue;
            trkBrOverallValue = trkBrOverall.Value;
            _r += tempVal;
            _g += tempVal;
            _b += tempVal;
            ccColor = Color.FromArgb(_r, _g, _b);
            InvalidateDataSet();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }

    }
}
