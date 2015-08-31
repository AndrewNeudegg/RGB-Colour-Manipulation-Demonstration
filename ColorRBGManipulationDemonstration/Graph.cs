using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ColorRBGDemonstration
{
    public class Graph : Control
    {
        public Color XAxisColor { get; set; }
        public Color YAxisColor { get; set; }
        public Color PointColor { get; set; }
        public Point PointLocation { get; set; }

        /// <summary>
        ///     Initialises the graph.
        /// </summary>
        public Graph()
        {
            DoubleBuffered = true;
            XAxisColor = Color.Red;
            YAxisColor = Color.Green;
            PointColor = Color.Black;
            PointLocation = new Point(50, 50);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Calling the base class OnPaint
            base.OnPaint(pe);

            float LogicalY = Height;
                // Otherwise (0,0) equals the top left, which isn't the logical way to create a graph.

            float DivSize = 255f;
            float LogicalSubDivisionX = Width/DivSize;
            float LogicalSubDivisionY = Height/DivSize;

            float pointX = (Width/255f)*PointLocation.X;
            float pointY = LogicalY - (Height/255f)*PointLocation.Y;


            pe.Graphics.DrawLine(new Pen(XAxisColor, 5), 0, Height, Width, Height); // X Axis
            pe.Graphics.DrawLine(new Pen(YAxisColor, 5), 0, 0, 0, Width); // Y Axis

            pe.Graphics.DrawLine(new Pen(new HatchBrush(HatchStyle.Cross, Color.OrangeRed, Color.Transparent), 3), 0,
                Height, Width, 0); // Line of aproximate greyness.

            for (int i = 0; i < 255; i = i + 15)
            {
                pe.Graphics.DrawLine(new Pen(Color.FromArgb(128, 128, 128, 128)), //Set the pen
                    LogicalSubDivisionX*i, // Start at X=0,X=10, X=20 etc
                    0, // Y=0, cross the x axis
                    LogicalSubDivisionX*i, // Finish at X=0,X=10,X=20
                    Height // Y = Height
                    );
            }

            for (int i = 0; i < 255; i = i + 15)
            {
                pe.Graphics.DrawLine(new Pen(Brushes.LightSlateGray), //Set the pen
                    0, // X=0, cross Y axis.
                    LogicalSubDivisionY*i, // Y=0,Y=10,Y=20 etc.
                    Width, // X=Width
                    LogicalSubDivisionY*i // Finish at Y=0,Y=10,Y=20 etc.
                    );
            }

            pe.Graphics.FillEllipse(new SolidBrush(PointColor), pointX - 5, pointY - 5, 15, 15); // Draw Point.
            pe.Graphics.DrawString(String.Format("({0},{1})", PointLocation.X, PointLocation.Y), new Font("Arial", 20),
                new SolidBrush(Color.Black), new PointF(Width/2f, Height/2f));
        }
    }
}
