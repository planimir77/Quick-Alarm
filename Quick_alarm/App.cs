namespace Quick_alarm
{
    using Quick_alarm.Helpers;
    using System;
    using System.Linq;
    using System.Windows.Forms;
    public partial class App : Form
    {
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        public App()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            timer1.Start();
            UpdateTimePickerValue();
            
            FormOnScreen.Right(this);
        }

        private void Timer_Tick (object sender, EventArgs e)
        {
            if (DateTime.Now.Second == 0)
            {
                UpdateTimePickerValue();
            }
        }

        private void DropDoun_Click(object sender, EventArgs e)
        {
            ;
            throw new NotImplementedException();
        }

        protected override void OnResize(EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
            }
            else
            {
                //Hide();
                notifyIcon1.Visible = false;
            }
        }


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            // get minutes from button text
            var minutesToAdd =
                Double.Parse(((Button)sender)
                .Text
                .Split()
                .ElementAt(0));
            // ================== TODO AddMinutes ===================
            var scheduledTime = DateTime.Now.AddSeconds(minutesToAdd);

            CreateAlarm(scheduledTime);
        }

        private void ButtonSet_Click(object sender, EventArgs e)
        {
            var scheduledTime = RoundTime(dateTimePicker1.Value);
            
            UpdateTimePickerValue();

            CreateAlarm(scheduledTime);
        }

        private void CreateAlarm(DateTime scheduledTime)
        {
            var message = this.textBoxMessage.TextMessage;
            this.textBoxMessage.TextMessage = String.Empty;

            var alarm = new BasicAlarm(message);


            var alarmTime = alarm.Create(scheduledTime);

            ShowPopupMessage(alarmTime);
        }

        private void ShowPopupMessage(DateTime dateTime)
        {
            this.popupMessage.Text = $"Alarm in {dateTime.ToShortTimeString()}";
            this.popupMessage.Visible = true;
            _ = new SetTimeout(HidePopupMessage, 5000);
        }
        private void HidePopupMessage()
        {
            this.popupMessage.Visible = false;
            this.popupMessage.Text = "";
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void NotifyIcon1_MouseUp(object sender, EventArgs e)
        {
            this.notifyIcon1.BalloonTipTitle = "BalloonTipTitle";
            this.notifyIcon1.BalloonTipText = "BalloonTip Text";
            this.notifyIcon1.ShowBalloonTip(3000);
        }

        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            // Left Click
            if (e.Button == MouseButtons.Left)
            {
                Show();
                this.WindowState = FormWindowState.Normal;
                this.notifyIcon1.Visible = false;
                this.TopMost = true;
            }
        }

        private void About_Click(object sender, EventArgs e)
        {
            ;
        }

        private static DateTime RoundTime(DateTime dateTime)
        {
            // Date and time to short date and time format.
            var dateTimeString = dateTime.ToString("g");
            return DateTime.Parse(dateTimeString);
        }

        private void UpdateTimePickerValue()
        {
            dateTimePicker1.Value = GetDateTimeValue();
        }

        private static DateTime GetDateTimeValue()
        {
            return DateTime.Now.AddMinutes(1);
        }
    }
}
