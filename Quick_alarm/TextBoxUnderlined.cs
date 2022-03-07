using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Quick_alarm
{
    public partial class TextBoxUnderlined : UserControl
    {
        private Color borderColor = Color.FromArgb(171, 109, 35);
        private int borderSize = 2;
        private bool underlinedStyle = false;

        public TextBoxUnderlined()
        {
            InitializeComponent();
        }

        [Category("TextBox Underlined")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("TextBox Underlined")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("TextBox Underlined")]
        public bool UnderlinedStyle
        {
            get
            {
                return underlinedStyle;
            }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("TextBox Underlined")]
        public string PlaceholderText
        {
            get
            {
                return this.textBox1.PlaceholderText;
            }
            set
            {
                this.textBox1.PlaceholderText = value;
                this.Invalidate();
            }
        }

        [Category("TextBox Underlined")]
        public string TextMessage
        {
            get
            {
                return this.textBox1.Text;
            }
            set
            {
                this.textBox1.Text = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;

            // Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (underlinedStyle) // Underlined Style
                {
                    graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                }
                else // Normal Style
                {
                    graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                this.UpdateControlHeight();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (this.textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                this.textBox1.Multiline = true;
                this.textBox1.MinimumSize = new Size(0, txtHeight);
                this.textBox1.Multiline = false;

                this.Height = this.textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
    }
}
