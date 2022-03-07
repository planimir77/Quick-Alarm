using System;
using System.Windows.Forms;
using Quick_alarm.Helpers;

namespace Quick_alarm
{
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            FormOnScreen.Right(this);
            base.OnLoad(e);
        }
 

        private void ButtonOkClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
