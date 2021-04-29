using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PersonalAccounting.UI.UserControl
{
    public class TabControlZ : TabControl
    {
        private Color _nonactiveColor1 = Color.LightGreen;
        private Color _nonactiveColor2 = Color.DarkBlue;
        private Color _activeColor1 = Color.FromArgb(255, 210, 250, 220);
        private Color _activeColor2 = Color.FromArgb(255, 140, 160, 200);
        public Color foreColor = Color.Navy;
        private int _color1Transparent = 150;
        private int _color2Transparent = 150;
        private System.ComponentModel.IContainer components;
        private int _angle = 90;

        public Color ActiveTabStartColor
        {
            get => _activeColor1;
            set { _activeColor1 = value; Invalidate(); }
        }
        public Color ActiveTabEndColor
        {
            get => _activeColor2;
            set { _activeColor2 = value; Invalidate(); }
        }
        public Color NonActiveTabStartColor
        {
            get => _nonactiveColor1;
            set { _nonactiveColor1 = value; Invalidate(); }
        }
        public Color NonActiveTabEndColor
        {
            get => _nonactiveColor2;
            set { _nonactiveColor2 = value; Invalidate(); }
        }
        public int Transparent1
        {
            get => _color1Transparent;
            set
            {
                _color1Transparent = value;
                if (_color1Transparent > 255)
                {
                    _color1Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }

        public int Transparent2
        {
            get => _color2Transparent;
            set
            {
                _color2Transparent = value;
                if (_color2Transparent > 255)
                {
                    _color2Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }
        public int GradientAngle
        {
            get => _angle;
            set { _angle = value; Invalidate(); }
        }
        public Color TextColor
        {
            get => foreColor;
            set { foreColor = value; Invalidate(); }
        }

        public TabControlZ()
        {
            DrawMode = TabDrawMode.OwnerDrawFixed;
            Padding = new Point(30, 4);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        //method for drawing tab items 
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            var rc = GetTabRect(e.Index);
            var rc2 = GetTabRect(e.Index);

            if (SelectedTab == TabPages[e.Index])
            {
                var c1 = Color.FromArgb(_color1Transparent, _activeColor1);
                var c2 = Color.FromArgb(_color2Transparent, _activeColor2);
                using (var br = new LinearGradientBrush(rc, c1, c2, _angle))
                {
                    e.Graphics.FillRectangle(br, rc);
                }
            }
            else
            {
                var c1 = Color.FromArgb(_color1Transparent, _nonactiveColor1);
                var c2 = Color.FromArgb(_color2Transparent, _nonactiveColor2);
                using (var br = new LinearGradientBrush(rc, c1, c2, _angle))
                {
                    e.Graphics.FillRectangle(br, rc);
                }
            }

            TabPages[e.Index].BorderStyle = BorderStyle.FixedSingle;
            TabPages[e.Index].ForeColor = SystemColors.ControlText;

            var paddedBounds = e.Bounds;
            paddedBounds.Inflate(-12, -4);

            e.Graphics.DrawString(TabPages[e.Index].Text, Font, new SolidBrush(foreColor), paddedBounds);
        }


        private void InitializeComponent()
        {
            SuspendLayout();
            ResumeLayout(false);

        }
    }
}
