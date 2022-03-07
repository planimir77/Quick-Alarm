using System.Windows.Forms;

namespace Quick_alarm.Helpers
{
    public class FormOnScreen
    {
        public static void Right(Form form)
        {
            Screen rightmost = Screen.AllScreens[0];
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Right > rightmost.WorkingArea.Right)
                {
                    rightmost = screen;
                }
            }

            form.Left = rightmost.WorkingArea.Right - form.Width;
            form.Top = rightmost.WorkingArea.Bottom - form.Height;
        }
    }
}
