using System;
using System.Linq;

namespace Quick_alarm
{
    public class FormNotificationBuilder
    {
        public static NotificationForm CreateForm(string message)
        {
            NotificationForm form = Create(message);
            
            return form;
        }

        private static NotificationForm Create(string message)
        {
            NotificationForm form = new()
            {
                TopMost = true,
            };

            if (message != string.Empty)
            {
                form.Controls.Find("message", true).FirstOrDefault().Text = message;
            }
            form.Controls.Find("labelTimeNow", true).FirstOrDefault().Text = DateTime.Now.ToString("HH:mm");

            return form;
        }
    }
}
