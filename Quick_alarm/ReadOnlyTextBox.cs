namespace Quick_alarm
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    public partial class ReadOnlyTextBox : TextBox
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public ReadOnlyTextBox()
        {

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.ReadOnly = true;
            this.Multiline = true;
            this.GotFocus += TextBoxGotFocus;
            this.Cursor = Cursors.Arrow;

        }
        private void TextBoxGotFocus(object sender, EventArgs args)
        {
            HideCaret(this.Handle);
        }
    }
}
