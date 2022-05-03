using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace TimeX
{
    public partial class MainWindow : Form
    {

        private bool mouseIsDown = false;
        private Point firstPoint;
        private double windowOpacityOnMouseDown = 0.70;
        private double windowOpacityOnMouseUp = 0.95;


        ToolTip toolTip = new ToolTip();

        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.alarm);
        
        private int timeInMinutes;
        private int defaultBreakTimeInMinutes = 1;
        private int defaultTimeInMinutes = 20;

        private bool breakTimeTimerIsOn = false;
        private bool alarmIsOn = false;
        private bool playInLoop = true;

        public MainWindow()
        {
            InitializeComponent();

            timeInMinutes = defaultTimeInMinutes;

            timer.Tick += new EventHandler(TimerCallback);
            timer.Enabled = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            TimeLabel.Text = MinutesToMaskedTextOfTime(timeInMinutes);

            toolTip.InitialDelay = 200;
            toolTip.AutoPopDelay = 10000;

            toolTip.SetToolTip(TimeXNameTextBox, "TimeX name");
            toolTip.SetToolTip(TimeTextBox, "Work time");
            toolTip.SetToolTip(BreakTimeTextBox, "Break time");
            toolTip.SetToolTip(PlayInLoopCheckBox, "Should TimeX run in work and break mode? If this option is disabled, TimeX will function as a normal timer");
            toolTip.SetToolTip(ApplyButton, "Apply settings");
        }

        private void MinimizeWindow()
        {
            Hide();
            SystemTray.Text = TimeXNameLabel.Text;
            SystemTray.Visible = true;
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizeWindow()
        {
            Show();
            SystemTray.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void MinimizeWindowButton_Click(object sender, EventArgs e)
        {
            MinimizeWindow();
        }

        private void SystemTray_MouseClick(object sender, MouseEventArgs e)
        {
            MaximizeWindow();
        }

        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                firstPoint = e.Location;
                mouseIsDown = true;
                Opacity = windowOpacityOnMouseDown;
            }
        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
            Opacity = windowOpacityOnMouseUp;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                // Get the difference between the two points
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        private void OpenCloseMenu()
        {
            if (Menu.Location.Y == 313)
            {
                OffAlarmButton.Visible = true;
                SliderMenuButton.Text = "▲";
                Menu.Location = new Point(Menu.Location.X, 530);
            }

            else if (Menu.Location.Y == 530)
            {
                OffAlarmButton.Visible = false;
                SliderMenuButton.Text = "▼";
                Menu.Location = new Point(Menu.Location.X, 313);
            }
        }

        private void SliderMenuButton_Click(object sender, EventArgs e)
        {
            OpenCloseMenu();
        }

        private int MaskedTextOfTimeToMinutes(string maskedTextOfTime)
        {
            int hours = int.Parse( maskedTextOfTime.Split(':')[0] );
            int minutes = int.Parse( maskedTextOfTime.Split(':')[1] );

            int timeInMinutes = (hours * 60) + minutes;

            return timeInMinutes;
        }
        
        private string MinutesToMaskedTextOfTime(int minutes)
        {
            int hours = minutes / 60;
            minutes = minutes % 60;

            string hoursString;
            string minutesString;

            if (hours > 9)
            {
                hoursString = hours.ToString();
            }
            else if (hours <= 9)
            {
                hoursString = '0' + hours.ToString();
            }
            else
            {
                hoursString = "00";
            }


            if (minutes > 9)
            {
                minutesString = minutes.ToString();
            }
            else if (minutes <= 9)
            {
                minutesString = '0' + minutes.ToString();
            }
            else
            {
                minutesString = "00";
            }

            string maskedTextOfTime = hoursString + ':' + minutesString;

            return maskedTextOfTime;
        }

        private void ChangeTimeInMinutesByXMinutes(int minutes)
        {
            if ( (timeInMinutes - minutes) >= 0)
            {
                timeInMinutes -= minutes;
            }
        }

        private void PlayAlarm()
        {
            player.PlayLooping();
            alarmIsOn = true;
        }

        private void OffAlarm()
        {
            player.Stop();
            alarmIsOn = false;
        }

        private void ResetTimer()
        {
            timer.Enabled = false;
            timer.Enabled = true;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            TimeXNameLabel.Text = TimeXNameTextBox.Text;
            playInLoop = PlayInLoopCheckBox.Checked;

            TimeLabel.Text = TimeTextBox.Text;
            defaultTimeInMinutes = MaskedTextOfTimeToMinutes(TimeTextBox.Text);
            timeInMinutes = defaultTimeInMinutes;

            defaultBreakTimeInMinutes = MaskedTextOfTimeToMinutes(BreakTimeTextBox.Text);

            // If the alarm is ON at this point, turn it off.
            OffAlarm();
            
            ResetTimer();

            OpenCloseMenu();
        }

        private void UpdateTimeLabel()
        {
            TimeLabel.Text = MinutesToMaskedTextOfTime(timeInMinutes);
        }

        private void TimeLabel_TextChanged(object sender, EventArgs e)
        {
            if (TimeLabel.Text == "00:00")
            {
                PlayAlarm();
            }
        }

        private void TimerCallback(object sender, EventArgs e)
        {
            ChangeTimeInMinutesByXMinutes(1);
            UpdateTimeLabel();
        }

        private void OffAlarmButton_Click(object sender, EventArgs e)
        {
            if (TimeLabel.Text == "00:00")
            {

                if (alarmIsOn == true)
                {
                    OffAlarm();
                }

                if (playInLoop == true)
                {
                    // Now is the time to count down the break time.
                    if (breakTimeTimerIsOn == false)
                    {
                        // If we work non-stop, then only reset the timer without switching to break time.
                        if (defaultBreakTimeInMinutes == 0)
                        {
                            timeInMinutes = defaultTimeInMinutes;

                            UpdateTimeLabel();

                            ResetTimer();

                            breakTimeTimerIsOn = false;
                        }
                        else
                        {
                            timeInMinutes = defaultBreakTimeInMinutes;

                            UpdateTimeLabel();

                            ResetTimer();

                            breakTimeTimerIsOn = true;
                        }

                    }
                    // Now is the time to count down the work time.
                    else
                    {
                        timeInMinutes = defaultTimeInMinutes;

                        UpdateTimeLabel();

                        ResetTimer();

                        breakTimeTimerIsOn = false;
                    }

                }
                else
                {
                   timer.Stop();
                }

            }
            // Press button twice to skip break time.
            else if ( (TimeLabel.Text == MinutesToMaskedTextOfTime(defaultBreakTimeInMinutes)) && (breakTimeTimerIsOn) )
            {
                timeInMinutes = defaultTimeInMinutes;

                UpdateTimeLabel();

                ResetTimer();

                breakTimeTimerIsOn = false;
            }
        }
    }
}
