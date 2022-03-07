using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_alarm.Helpers
{
    public class SetTimeout
    {
        private readonly Timer timer;

        public SetTimeout(Action action, int timeout)
        {
            timer = new Timer
            {
                Interval = timeout
            };
            timer.Tick += delegate (object sender, EventArgs args)
            {
                timer.Stop();
                action();
            };
            timer.Start();
        }

    }
}
