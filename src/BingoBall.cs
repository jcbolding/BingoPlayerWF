using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoPlayerWF
{
    public partial class BingoBall : UserControl
    {
        public BingoBall()
        {
            DoubleBuffered = true;
            // Ensure that the control is properly redrawn when it is resized. Also,
            // set the control styles to reduce flicker when repainting the control.
            SetStyle(ControlStyles.ResizeRedraw |
                ControlStyles.DoubleBuffer |
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.SupportsTransparentBackColor, true);

            InitializeComponent();
        }


        private Brush GetBrush()
        {
            if (string.IsNullOrEmpty(Text))
                return new SolidBrush(Color.LightGray);

            switch (Text[0])
            {
                case 'B':
                    return Brushes.Purple;
                case 'I':
                    return Brushes.Green;
                case 'N':
                    return Brushes.DarkRed;
                case 'G':
                    return Brushes.SaddleBrown;
                case 'O':
                    return Brushes.Blue;
            }

            return Brushes.BlueViolet;
        }

        private Brush GetBrus2h()
        {
            if (string.IsNullOrEmpty(Text))
                return new SolidBrush(Color.LightGray);

            switch (Text[0])
            {
                case 'B':
                    return new LinearGradientBrush(ClientRectangle, Color.LightBlue, Color.BlueViolet, LinearGradientMode.ForwardDiagonal);
                case 'I':
                    return new LinearGradientBrush(ClientRectangle, Color.LimeGreen, Color.DarkGreen, LinearGradientMode.ForwardDiagonal);
                case 'N':
                    return new LinearGradientBrush(ClientRectangle, Color.LightPink, Color.DarkRed, LinearGradientMode.ForwardDiagonal);
                case 'G':
                    return new LinearGradientBrush(ClientRectangle, Color.LightYellow, Color.SaddleBrown, LinearGradientMode.ForwardDiagonal);
                case 'O':
                    return new LinearGradientBrush(ClientRectangle, Color.Cyan, Color.Brown, LinearGradientMode.ForwardDiagonal);
            }

            return Brushes.BlueViolet;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var sf = new StringFormat())
            {
                var br = GetBrush();
                //using (var br = GetBrush())
                {

                    Rectangle rc = ClientRectangle;
                 //   e.Graphics.DrawRectangle(Pens.Black, rc.X, rc.Y, rc.Width -1, rc.Height -1);
                    rc.Inflate(-3, -2);

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Graphics.FillEllipse(br, rc);
                    e.Graphics.DrawString(Text, Font, Brushes.AntiqueWhite, rc, sf);
                }
            }
        }


        [DefaultValue(""),
         Browsable(true),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }
    }
}
