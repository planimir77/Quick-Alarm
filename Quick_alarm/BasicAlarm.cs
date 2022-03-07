using System;
using System.Media;
using Quick_alarm.Helpers;

namespace Quick_alarm
{
    public class BasicAlarm
    {
        private readonly string message;
        private SoundPlayer player;
        private NotificationForm form;

        public BasicAlarm(string message)
        {
            this.message = message;
            InitializePlayer();
            InitializeForm();
        }

        private void InitializeForm()
        {
            form = FormNotificationBuilder.CreateForm(message);
        }

        private void InitializePlayer()
        {
            var sound = Properties.Resources.Cool_alarm_tone_notification_sound;
            player = new SoundPlayer(sound);
        }

        internal void Start_Alarm()
        {
            PlaySound();

            form.Focus();
            form.ShowDialog();

            StopSound();
            form.Dispose();
        }

        internal DateTime Create(DateTime scheduledTime)
        {
            if (scheduledTime < DateTime.Now)
            {
                scheduledTime = scheduledTime.AddDays(1);
            }

            int tickTime = (int)(scheduledTime - DateTime.Now).TotalMilliseconds;
            
            _ = new SetTimeout(Start_Alarm, tickTime);

            return scheduledTime;


        }
        private void StopSound()
        {
            player.Stop();
            player.Dispose();
        }
        private void PlaySound()
        {
            player.PlayLooping();
        }
    }
}
