namespace Quick_alarm
{
    using System;
    using System.Windows.Forms;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.ComponentModel;
    public class RoundedButton : Button
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.BlueViolet;

        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }


        //Properties
        [Category("Rounded Button")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                this.borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Rounded Button")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                this.borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("Rounded Button")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                this.borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Rounded Button")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set
            {
                this.BackColor = value;
            }
        }
        [Category("Rounded Button")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set
            {
                this.ForeColor = value;
            }
        }

        //Methods
        private static GraphicsPath GetFigurePath(RectangleF rect, float radius, int borderSize)
        {
            float m = borderSize == 0 ? 1F : ((float)borderSize) / 1.5f;

            var path = new GraphicsPath();

            path.AddArc(rect.X + m, rect.Y + m, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius - m, rect.Y + m, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius - m,
                           rect.Y + rect.Height - radius - m, radius, radius, 0, 90);
            path.AddArc(rect.X + m, rect.Y + rect.Height - radius - m, radius, radius, 90, 90);

            path.CloseFigure();
            return path;
        }

        private static GraphicsPath GetFigureBorderPath(RectangleF rect, float radius)
        {
            var path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius,
                           rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            //if (borderSize > 0)
            //    smoothSize = borderSize;

            //Rounded button
            if (borderRadius > 2)
            {
                using GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius, borderSize);


                using Pen penSurface = new Pen(this.Parent.BackColor, smoothSize);


                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                //Button surface
                this.Region = new Region(pathSurface);
                //Draw surface border for HD result
                pevent.Graphics.DrawPath(penSurface, pathSurface);

                // Button bordered                    
                if (borderSize >= 1)
                {
                    using GraphicsPath pathBorder = GetFigureBorderPath(rectBorder, borderRadius - borderSize);
                    using Pen penBorder = new Pen(borderColor, borderSize);

                    //Draw control border
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else // Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button bordered
                if (borderSize >= 1)
                {
                    using var penBorder = new Pen(borderColor, borderSize);
                    penBorder.Alignment = PenAlignment.Inset;
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode) this.Invalidate();
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (this.borderRadius > this.Height)
                this.borderRadius = this.Height;
        }
    }
}
