using Menu;
using Microsoft.VisualBasic.Devices;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing.Text;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Air_defense_simulator
{
    public delegate void NotifyEvent();

    public partial class ADS : Form
    {
        public List<Target> enemies = new List<Target>();

        public List<Target> selection = new List<Target>();
        public Target destroyed = null;

        Stack<Target> friends = new Stack<Target>();

        public List<Missile> missiles = new List<Missile>();

        public List<ADS> launchers = new List<ADS>();
        public ADS launcher = null;

        public List<Passenger> passengers = new List<Passenger>();

        public List<Passenger> selectionPassenger = new List<Passenger>();
        public Passenger destroyedPassenger = null;

        Stack<Target> fired = new Stack<Target>();
        Stack<Passenger> Passengerfired = new Stack<Passenger>();

        Corridor corridor = new Corridor();

        public NotifyEvent notifyDelegate;

        public NotifyEvent close;

        public NotifyEvent show;

        int Number = 0;
        int t;
        int z;
        int trackNumber;
        bool reloading;
        int time = 0;
        int value = 8;
        int NumberOfTargets = 0;
        int X;
        int pause = 0;
        int passenger = 0;

        public void Wait(int seconds)
        {
            if(seconds <= 0) 
                return;

            int wait = pause + seconds;

            while (pause != wait)
            {
                Application.DoEvents();
            }
        }

        public ADS()
        {
            InitializeComponent();

            richTextBoxReport.SelectionAlignment = HorizontalAlignment.Center;

            trackNumber++;
            Passenger passenger1 = new Passenger(0.55, 21.5 * Math.PI / 12, Color.Yellow, 189, 250, trackNumber, 0);
            passengers.Add(passenger1);
            Report("0", trackNumber);

            trackNumber++;
            Passenger passenger2 = new Passenger(0.55, Math.PI, Color.Yellow, 519, 178, trackNumber, 0);
            passengers.Add(passenger2);
            Report("0", trackNumber);

            notifyDelegate = new NotifyEvent(TimerStart);

            close = new NotifyEvent(CloseForm);

            show = new NotifyEvent(ShowForm);
        }

        private void pictureBoxFlipSwitch1_Click(object sender, EventArgs e)
        {
            //Flip Switch
            if ((string)pictureBoxFlipSwitch1.Tag == "up")
            {
                pictureBoxFlipSwitch1.Image = Properties.Resources.switch_down;
                pictureBoxFlipSwitch1.Tag = "down";
                pictureBoxLight1.Image = Properties.Resources.light_off;
                Report("7", 0);
            }
            else
            {
                pictureBoxFlipSwitch1.Image = Properties.Resources.switch_up;
                pictureBoxFlipSwitch1.Tag = "up";
                pictureBoxLight1.Image = Properties.Resources.light_on;
                Report("6", 0);
            }
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            if (buttonSimulation.Enabled== false)
            {
                time++;
                if (time == value)
                {
                    time = 0;
                    NewTarget();
                }
            }

            passenger++;
            if (passenger == 120)
            {
                passenger = 0;
                NewPassenger();
            }

            z++;
            if(t == z)
            {
                Launchers(true);
                Number = 0;
                launchers.Clear();
                reloading = false;
            }

            pause++;

            int seconds = int.Parse(labelClockSeconds.Text);
            int minutes = int.Parse(labelClockMinutes.Text);
            int hours = int.Parse(labelClockHours.Text);
            seconds++;

            if (seconds == 60)
            {
                seconds = 0;
                minutes++;

                if (minutes == 60)
                {
                    minutes = 0;
                    hours++;

                    if (hours == 24)
                    {
                        hours = 0;
                    }
                }
            }

            // Update the labels with the new values
            labelClockSeconds.Text = seconds.ToString().PadLeft(2, '0');
            labelClockMinutes.Text = minutes.ToString().PadLeft(2, '0');
            labelClockHours.Text = hours.ToString().PadLeft(2, '0');
        }

        private void buttonEngage_Click(object sender, EventArgs e)
        {
            //Shooting down a target
            if ((string)pictureBoxFlipSwitch1.Tag == "up" & reloading == false)
            {
                //Target
                foreach (Target selected in selection)
                {
                    fired.Push(selected);
                }
                while (fired.Count > 0)
                {
                    Target selected = fired.Pop();
                    Passenger selectedPassenger = null;

                    //Single
                    if (Number < 24 && buttonSingle.Enabled == false)
                    {


                        Wait(3);

                        trackNumber++;
                        Missile missile = new Missile(316, 355, selected, selectedPassenger, trackNumber);
                        missiles.Add(missile);
                        launchers.Add(launcher);
                        Number = launchers.Count;
                        Report("1", selected.TrackNumber);
                        for (int i = 1; i <= 24; i++)
                        {
                            if (i <= Number)
                            {
                                this.Controls["Launcher" + i].BackColor = Color.Red;
                            }
                        }
                    }
                    //Salvo
                    if (Number < 23 && buttonSalvo.Enabled == false)
                    {
                        Wait(3);

                        trackNumber++;
                        Missile missile1 = new Missile(316, 355, selected, selectedPassenger, trackNumber);
                        missiles.Add(missile1);
                        launchers.Add(launcher);
                        Number = launchers.Count;
                        Report("1", selected.TrackNumber);

                        Wait(3);

                        trackNumber++;
                        Missile missile2 = new Missile(316, 355, selected, selectedPassenger, trackNumber);
                        missiles.Add(missile2);
                        launchers.Add(launcher);
                        Number = launchers.Count;
                        Report("1", selected.TrackNumber);

                        for (int i = 1; i <= 24; i++)
                        {
                            if (i <= Number)
                            {
                                this.Controls["Launcher" + i].BackColor = Color.Red;
                            }
                        }
                    }
                }

                //Passenger
                foreach (Passenger selectedPassenger in selectionPassenger)
                {
                    Passengerfired.Push(selectedPassenger);
                }
                while (Passengerfired.Count > 0)
                {
                    Passenger selectedPassenger = Passengerfired.Pop();
                    Target selected = null;

                    //Single
                    if (Number < 24 && buttonSingle.Enabled == false && (string)buttonIgnoreWarning.Tag == "true")
                    {
                        Wait(3);

                        trackNumber++;
                        Missile missile = new Missile(316, 355, selected, selectedPassenger, trackNumber);
                        missiles.Add(missile);
                        launchers.Add(launcher);
                        Number = launchers.Count;
                        Report("1", selectedPassenger.TrackNumber);
                        for (int i = 1; i <= 24; i++)
                        {
                            if (i <= Number)
                            {
                                this.Controls["Launcher" + i].BackColor = Color.Red;
                            }
                        }
                    }
                    //Salvo
                    if (Number < 23 && buttonSalvo.Enabled == false && (string)buttonIgnoreWarning.Tag == "true")
                    {
                        Wait(3);

                        trackNumber++;
                        Missile missile1 = new Missile(316, 355, selected, selectedPassenger, trackNumber);
                        missiles.Add(missile1);
                        launchers.Add(launcher);
                        Number = launchers.Count;
                        Report("1", selectedPassenger.TrackNumber);

                        Wait(3);

                        trackNumber++;
                        Missile missile2 = new Missile(316, 355, selected, selectedPassenger, trackNumber);
                        missiles.Add(missile2);
                        launchers.Add(launcher);
                        Number = launchers.Count;
                        Report("1", selectedPassenger.TrackNumber);

                        for (int i = 1; i <= 24; i++)
                        {
                            if (i <= Number)
                            {
                                this.Controls["Launcher" + i].BackColor = Color.Red;
                            }
                        }
                    }
                    if ((string)buttonIgnoreWarning.Tag == "false")
                    {
                        Report("13", selectedPassenger.TrackNumber);
                    }
                }
            }
        }
        private void timerTargetUpdate_Tick(object sender, EventArgs e)
        {
            Bitmap Graphbmp = new Bitmap(pictureBoxRadar.Width, pictureBoxRadar.Height);
            Graphics Graph = Graphics.FromImage(Graphbmp);

            //Targets
            Random random = new Random();
            int targetfriend = random.Next(0, 150);
            

            if (targetfriend == 69 && buttonSimulation.Enabled == false)
            {
                int X = random.Next(100, 450);
                double Y1 = 1;
                double Y2 = -756;
                double Y3 = 142884 + (315 - X) * (315 - X) - (325 * 325);

                double Y = (-Y2 - Math.Sqrt(Y2 * Y2 - 4 * Y1 * Y3)) / (2 * Y1);
                int RandX = random.Next(296, 343);
                int RandY = random.Next(320, 365);
                double m = (Y - RandY) / (X - RandX);

                double A = Math.Atan(m);

                if (RandX < X)
                    A = A + Math.PI;

                trackNumber++;
                Target enemy = new Target(0.674, A, Color.Red, X, (int)Y, trackNumber, 0, RandX, RandY, false);
                enemies.Add(enemy);
                Report("0", enemy.TrackNumber);
            }

            Target targetGone = null;

            foreach (Target enemy in enemies)
            {
                enemy.MoveTarget();
                enemy.DrawTarget(Graph);

                //Target leaves Radar
                if (enemy.Y > 0.947 * enemy.X + 70 || enemy.Y > -0.935 * enemy.X + 662 || 330 < Math.Sqrt((315 - enemy.X) * (315 - enemy.X) + (378 - enemy.Y) * (378 - enemy.Y)))
                {
                    targetGone = enemy;
                }
                //Drawing GIP
                if (enemy.GIP)
                    enemy.DrawGIP(Graph);
                //Target reaches GIP
                if (enemy.GIPReached)
                {
                    if (enemy.Y >= -1.75 * enemy.X + 875 && enemy.Y >= 334 && enemy.Y <= -1.75 * enemy.X + 934 && enemy.Y <= 355)
                    {
                        timerClock.Stop();
                        timerTargetUpdate.Stop();

                        BSOD bsod = new BSOD(show);
                        bsod.Show();
                    }
                    else
                        targetGone = enemy;
                }
            }
            foreach (Target selected in selection)
            {
                selected.MoveTarget();
                selected.DrawTarget(Graph);

                //selectedTarget leaves Radar
                if (selected.Y > 0.947 * selected.X + 70 || selected.Y > -0.935 * selected.X + 662 || 330 < Math.Sqrt((315 - selected.X) * (315 - selected.X) + (378 - selected.Y) * (378 - selected.Y)))
                {
                    targetGone = selected;
                }
                //Drawing GIP
                if (selected.GIP)
                    selected.DrawGIP(Graph);
                //selectedTarget reaches GIP
                if (selected.GIPReached)
                {
                    if (selected.Y >= -1.75 * selected.X + 875 && selected.Y >= 334 && selected.Y <= -1.75 * selected.X + 934 && selected.Y <= 355)
                    {
                        timerClock.Stop();
                        timerTargetUpdate.Stop();

                        BSOD bsod = new BSOD(show);
                        bsod.Show();
                    }
                    else
                        targetGone = selected;
                }
            }

            selection.Remove(targetGone);
            enemies.Remove(targetGone);

            //Missiles

            Missile missileGone = null;
            List<Missile> expired = new List<Missile>();

            foreach (Missile missile in missiles)
            {
                missile.MoveMissile();
                missile.MoveMissilePassenger();
                missile.DrawMissile(Graph);
                missile.DrawDashedLine(Graph);

                if (missile.TargetReached)
                {
                    expired.Add(missile);
                    Report("5", missile.Target.TrackNumber);
                }
                if (missile.PassengerReached)
                {
                    expired.Add(missile);
                    Report("5", missile.Passenger.TrackNumber);
                }

                //Missile leaves Radar
                if (missile.Y > 0.947 * missile.X + 70 || missile.Y > -0.935 * missile.X + 662 || 330 < Math.Sqrt((315 - missile.X) * (315 - missile.X) + (378 - missile.Y) * (378 - missile.Y)))
                {
                    missileGone = missile;
                }
            }
            foreach (Missile missile in expired)
            {
                if (missile.Target != null && missile.Target.IFF == 0)
                {
                    selection.Remove(missile.Target);
                    enemies.Remove(missile.Target);
                    missiles.Remove(missile);

                    timerClock.Interval = 1000;
                    timerTargetUpdate.Interval = 3000;

                    Wait(6);

                    Newspaper newspaper= new Newspaper(close, true);
                    newspaper.Show();
                }
                if (missile.Passenger != null)
                {
                    selectionPassenger.Remove(missile.Passenger);
                    passengers.Remove(missile.Passenger);
                    missiles.Remove(missile);

                    timerClock.Interval = 1000;
                    timerTargetUpdate.Interval = 3000;

                    Wait(6);

                    Newspaper newspaper = new Newspaper(close, true);
                    newspaper.Show();
                }
                else
                {
                    selection.Remove(missile.Target);
                    enemies.Remove(missile.Target);
                    missiles.Remove(missile);
                }
            }

            missiles.Remove(missileGone);

            //Passenger
            Passenger passengerGone = null;

            foreach (Passenger passenger in passengers)
            {
                passenger.MovementPassenger();
                passenger.DrawPassenger(Graph);

                //Passenger turning
                if (passenger.X < 274)
                {
                    //coming from the right
                    if (passenger.A == 17 * Math.PI / 18)
                    {
                        passenger.A = 9.5 * Math.PI / 12;
                    }
                }

                //Passenger turning
                if (passenger.X > 274 && passenger.X < 400)
                {
                    //coming from the right
                    if (passenger.A == Math.PI)
                    {
                        passenger.A = 17 * Math.PI / 18;
                    }
                    //coming from the left
                    if (passenger.A == 21.5 * Math.PI / 12)
                    {
                        passenger.A = 23.2 * Math.PI / 12;
                    }
                }

                //Passenger turning
                if (passenger.X > 400)
                {
                    //coming from the left
                    if (passenger.A == 23.2 * Math.PI / 12)
                    {
                        passenger.A = 0.3 * Math.PI / 12;
                    }
                }

                //Passenger leaves Radar
                if (passenger.Y > 0.947 * passenger.X + 70 || passenger.Y > -0.935 * passenger.X + 662 || 330 < Math.Sqrt((315 - passenger.X) * (315 - passenger.X) + (378 - passenger.Y) * (378 - passenger.Y)))
                {
                    passengerGone = passenger;
                }
            }
            foreach (Passenger selectedPassenger in selectionPassenger)
            {
                selectedPassenger.MovementPassenger();
                selectedPassenger.DrawPassenger(Graph);

                //Passenger turning
                if (selectedPassenger.X < 274)
                {
                    //coming from the right
                    if (selectedPassenger.A == 17 * Math.PI / 18)
                    {
                        selectedPassenger.A = 9.5 * Math.PI / 12;
                    }
                }

                //Passenger turning
                if (selectedPassenger.X > 274 && selectedPassenger.X < 400)
                {
                    //coming from the right
                    if (selectedPassenger.A == Math.PI)
                    {
                        selectedPassenger.A = 17 * Math.PI / 18;
                    }
                    //coming from the left
                    if (selectedPassenger.A == 21.5 * Math.PI / 12)
                    {
                        selectedPassenger.A = 23.2 * Math.PI / 12;
                    }
                }

                //Passenger turning
                if (selectedPassenger.X > 400)
                {
                    //coming from the left
                    if (selectedPassenger.A == 23.2 * Math.PI / 12)
                    {
                        selectedPassenger.A = 0.3 * Math.PI / 12;
                    }
                }

                //selectedPassenger leaves Radar
                if (selectedPassenger.Y > 0.947 * selectedPassenger.X + 70 || selectedPassenger.Y > -0.935 * selectedPassenger.X + 662 || 330 < Math.Sqrt((315 - selectedPassenger.X) * (315 - selectedPassenger.X) + (378 - selectedPassenger.Y) * (378 - selectedPassenger.Y)))
                {
                    passengerGone = selectedPassenger;
                }
            }

            passengers.Remove(passengerGone);
            selectionPassenger.Remove(passengerGone);

            //Corridor
            if (buttonShowAirway.Enabled == false)
            {
                corridor.corridor(Graph);
            }
            pictureBoxRadar.Image = Graphbmp;
        }
        
        private void buttonReload_MouseEnter(object sender, EventArgs e)
        {
            buttonReload.BackColor = Color.FromArgb(245, 41, 41);
        }

        private void buttonReload_MouseLeave(object sender, EventArgs e)
        {
            buttonReload.BackColor = Color.Gainsboro;
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            if (Number > 0)
            {
                z = 0;
                t = Number * 15 + 60;
                reloading = true;
                buttonReload.Enabled = false;
                buttonReload.BackColor = Color.Red;
                Report("3", 0);
                for (int i = 1; i <= 24; i++)
                {
                    if (this.Controls["Launcher" + i].BackColor == Color.Lime)
                    {
                        this.Controls["Launcher" + i].BackColor = Color.DarkGreen;
                    }
                }
            }
        }

        public void Launchers(bool reload)
        {
            //Reload Complete
            if (reload == true)
            {
                buttonReload.Enabled = true;
                buttonReload.BackColor = Color.Gainsboro;
                for (int i = 1; i <= 24; i++)
                {
                    this.Controls["Launcher" + i].BackColor = Color.Lime;
                }
                Report("4", 0);
            }
        }

        private void pictureBoxRadar_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            //Selecting Tracks
            if ((string)pictureBoxRadar.Tag == "select")
            {
                Target selected = null;
                Passenger selectedPassenger = null;

                foreach (Target enemy in enemies)
                {
                    if (mouse.X < enemy.X + 6 && mouse.X > enemy.X - 6 && mouse.Y < enemy.Y + 6 && mouse.Y > enemy.Y - 6)
                    {
                        Report("8", enemy.TrackNumber);
                        selected = enemy;
                        break;
                    }
                }
                if (selected != null)
                {
                    selected.Color = Color.Green;
                    selection.Add(selected);
                    enemies.Remove(selected);
                }

                foreach (Passenger passenger in passengers)
                {
                    if (mouse.X < passenger.X + 6 && mouse.X > passenger.X - 6 && mouse.Y < passenger.Y + 6 && mouse.Y > passenger.Y - 6)
                    {
                        if((string)buttonIgnoreWarning.Tag == "false")
                            Report("9", passenger.TrackNumber);
                        else
                            Report("8", passenger.TrackNumber);

                        selectedPassenger = passenger;
                        break;
                    }
                }
                if (selectedPassenger != null)
                {
                    selectedPassenger.Color = Color.Green;
                    selectionPassenger.Add(selectedPassenger);
                    passengers.Remove(selectedPassenger);
                }
            }

            //Unselecting Tracks
            if ((string)pictureBoxRadar.Tag == "unselect")
            {
                Target enemy = null;
                Passenger passenger = null;

                foreach (Target selected in selection)
                {
                    if (mouse.X < selected.X + 6 && mouse.X > selected.X - 6 && mouse.Y < selected.Y + 6 && mouse.Y > selected.Y - 6)
                    {
                        Report("10", selected.TrackNumber);
                        enemy = selected;
                        break;
                    }
                }
                if (enemy != null)
                {
                    enemy.Color = Color.Red;
                    enemies.Add(enemy);
                    selection.Remove(enemy);
                }

                foreach (Passenger selectedPassenger in selectionPassenger)
                {
                    if (mouse.X < selectedPassenger.X + 6 && mouse.X > selectedPassenger.X - 6 && mouse.Y < selectedPassenger.Y + 6 && mouse.Y > selectedPassenger.Y - 6)
                    {
                        Report("10", selectedPassenger.TrackNumber);
                        passenger = selectedPassenger;
                        break;
                    }
                }
                if (passenger != null)
                {
                    passenger.Color = Color.Yellow;
                    passengers.Add(passenger);
                    selectionPassenger.Remove(passenger);
                }
            }

            //No options selected
            if(pictureBoxRadar.Tag == null)
            {
                richTextBoxReport.Text = richTextBoxReport.Text;
                richTextBoxReport.AppendText(Environment.NewLine);
                richTextBoxReport.AppendText("No options were selected for this specific intput.");

                richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                richTextBoxReport.ScrollToCaret();
            }
        }

        //1X speed
        private void button1X_Click(object sender, EventArgs e)
        {
            button1X.BackColor = Color.FromArgb(210, 0, 0);
            button1X.Enabled = false;
            button10X.BackColor = Color.Gainsboro;
            button10X.Enabled = true;
            button50X.BackColor = Color.Gainsboro;
            button50X.Enabled = true;

            timerClock.Interval = 1000;
            timerTargetUpdate.Interval = 3000;
            timerNewTarget.Interval = 3000;
        }

        //10X speed
        private void button10X_Click(object sender, EventArgs e)
        {
            button1X.BackColor = Color.Gainsboro;
            button1X.Enabled = true;
            button10X.BackColor = Color.FromArgb(210, 0, 0);
            button10X.Enabled = false;
            button50X.BackColor = Color.Gainsboro;
            button50X.Enabled = true;

            timerClock.Interval = 100;
            timerTargetUpdate.Interval = 300;
            timerNewTarget.Interval = 300;
        }

        //50X speed
        private void button50X_Click(object sender, EventArgs e)
        {
            button1X.BackColor = Color.Gainsboro;
            button1X.Enabled = true;
            button10X.BackColor = Color.Gainsboro;
            button10X.Enabled = true;
            button50X.BackColor = Color.FromArgb(210, 0, 0);
            button50X.Enabled = false;

            timerClock.Interval = 20;
            timerTargetUpdate.Interval = 60;
            timerNewTarget.Interval = 60;
        }

        private void Report(string report, int enemyTrackNumber)
        {
            //report
            switch(report)
            {
                //New Track
                case "0":
                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Track " + enemyTrackNumber);

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();
                    break;

                //New Track Missile
                case "1":
                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Track " + trackNumber + " - Bird Away - Track " + enemyTrackNumber);

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();
                    break;

                //New GIP (Ground Impact Point)
                case "2":
                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Warning! - Track " + enemyTrackNumber + " GIP is inside the Air Base.");

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();
                    break;

                //New Reload
                case "3":
                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Reloading... Launchers will be offline for the next " + t + " seconds.");

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();
                    break;

                //Finished Reload
                case "4":
                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Reload Complete.");

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();
                    break;

                //New fireball (Interception)
                case "5":
                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Track " + enemyTrackNumber + " intercepted.");

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();
                    break;

                //Weapons free
                case "6":
                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Weapons unlocked.");

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();
                    break;

                //Weapons locked
                case "7":
                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Weapons locked.");

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();
                    break;

                //New selection
                case "8":
                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Track " + enemyTrackNumber + " selected.");

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();
                    break;

                //New selection Friend
                case "9":
                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Track " + enemyTrackNumber + " selected.");

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();

                    Wait(2);

                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Warning! Track " + enemyTrackNumber + " selected." + Environment.NewLine + "Track " + enemyTrackNumber + " may be Friendly." + Environment.NewLine + "Track " + enemyTrackNumber + " will be skipped.");

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();
                    break;

                //New unselect
                case "10":
                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Track " + enemyTrackNumber + " unselected.");

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();
                    break;

                //IFF Friend
                case "11":
                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Interrogating Track " + enemyTrackNumber + " ...");

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();

                    Wait(3);

                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Interrogation Complete." + Environment.NewLine + "Track " + enemyTrackNumber + " - IFF Friend." + Environment.NewLine + "Track " + enemyTrackNumber + " automatically unselected.");

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();
                    break;

                //IFF Foe
                case "12":
                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Interrogating Track " + enemyTrackNumber + " ...");

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();

                    Wait(3);

                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Interrogation Complete." + Environment.NewLine + "Track " + enemyTrackNumber + " - IFF no response.");

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();
                    break;

                //Report Warning - Track Passenger Selected
                case "13":
                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Warning! Track " + enemyTrackNumber + " may be friendly and will be skipped." + Environment.NewLine + "Press 'Ignore Warning' button (IW) to unlock weapons or unselect Track.");

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();
                    break;

                //Warnings ignored
                case "14":
                    richTextBoxReport.AppendText(Environment.NewLine);
                    richTextBoxReport.AppendText("Warnings ignored. Weapons are now unlocked for every Track.");

                    richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                    richTextBoxReport.ScrollToCaret();
                    break;
            }
        }

        private void buttonIFF_Click(object sender, EventArgs e)
        {
            foreach (Target selected in selection)
            {
                //IFF Friend
                if (selected.IFF == 0)
                {
                    Report("11", selected.TrackNumber);

                    friends.Push(selected);
                }
                //IFF Foe
                else
                {
                    Report("12", selected.TrackNumber);
                }
            }
            //Converting Target to Passanger
            while (friends.Count > 0)
            {
                Target friend = friends.Pop();

                double m;
                double A;

                //Heading to the left side of the Radar
                if (friend.A > Math.PI / 2)
                {
                    m = (friend.Y - 270) / (friend.X - 160);
                    A = Math.Atan(m);

                    if (friend.X > 160)
                        A = A + Math.PI;

                    Passenger passenger = new Passenger(friend.V, A, Color.Yellow, friend.X, friend.Y, friend.TrackNumber, 0);
                    passengers.Add(passenger);
                    selection.Remove(friend);
                }
                //Heading to the right side of the Radar
                if (friend.A < Math.PI / 2)
                {
                    m = (friend.Y - 180) / (friend.X - 500);
                    A = Math.Atan(m);

                    if (friend.X > 500)
                        A = A + Math.PI;

                    Passenger passenger = new Passenger(friend.V, A, Color.Yellow, friend.X, friend.Y, friend.TrackNumber, 0);
                    passengers.Add(passenger);
                    selection.Remove(friend);
                }
            }
        }

        private void buttonSingle_Click(object sender, EventArgs e)
        {
            buttonSingle.BackColor = Color.FromArgb(210, 0, 0);
            buttonSingle.Enabled = false;
            buttonSalvo.BackColor = Color.Gainsboro;
            buttonSalvo.Enabled = true;
        }

        private void buttonSalvo_Click(object sender, EventArgs e)
        {
            buttonSingle.BackColor = Color.Gainsboro;
            buttonSingle.Enabled = true;
            buttonSalvo.BackColor = Color.FromArgb(210, 0, 0);
            buttonSalvo.Enabled = false;
        }

        private void buttonIgnoreWarning_Click(object sender, EventArgs e)
        {
            if ((string)buttonIgnoreWarning.Tag == "false")
            {
                buttonIgnoreWarning.Tag = "true";
                buttonIgnoreWarning.BackColor = Color.Khaki;
                Report("14", 0);
            }
            else
            {
                buttonIgnoreWarning.Tag = "false";
                buttonIgnoreWarning.BackColor = Color.Gainsboro;
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            pictureBoxRadar.Tag = "select";

            buttonSelect.BackColor = Color.Khaki;
            buttonSelect.Enabled = false;
            buttonUnselect.BackColor = Color.Gainsboro;
            buttonUnselect.Enabled = true;
        }

        private void buttonUnselect_Click(object sender, EventArgs e)
        {
            pictureBoxRadar.Tag = "unselect";

            buttonSelect.BackColor = Color.Gainsboro;
            buttonSelect.Enabled = true;
            buttonUnselect.BackColor = Color.Khaki;
            buttonUnselect.Enabled = false;
        }

        private void buttonShowAirway_Click(object sender, EventArgs e)
        {
            buttonHideAirway.BackColor = Color.Gainsboro;
            buttonHideAirway.Enabled = true;
            buttonShowAirway.BackColor = Color.Khaki;
            buttonShowAirway.Enabled = false;
        }

        private void buttonHideAirway_Click(object sender, EventArgs e)
        {
            buttonHideAirway.BackColor = Color.Khaki;
            buttonHideAirway.Enabled = false;
            buttonShowAirway.BackColor = Color.Gainsboro;
            buttonShowAirway.Enabled = true;
        }

        private void NewTarget()
        {
            Random random = new Random();
            value = random.Next(180, 360);

            NumberOfTargets = random.Next(3, 10);
            X = random.Next(100, 450);
        }

        private void timerNewTarget_Tick(object sender, EventArgs e)
        {
            if(NumberOfTargets != 0)
            {
                Random random = new Random();
                X = X + random.Next(-10, 10);

                double Y1 = 1;
                double Y2 = -756;
                double Y3 = 142884 + (315 - X) * (315 - X) - (325 * 325);

                double Y = (-Y2 - Math.Sqrt(Y2 * Y2 - 4 * Y1 * Y3)) / (2 * Y1);
                int RandX = random.Next(296, 343);
                int RandY = random.Next(320, 365);
                double m = (Y - RandY) / (X - RandX);

                double A = Math.Atan(m);

                if (RandX < X)
                    A = A + Math.PI;

                trackNumber++;
                NumberOfTargets--;
                Target enemy = new Target(0.674, A, Color.Red, X, (int)Y, trackNumber, 1, RandX, RandY, false);
                enemies.Add(enemy);
                Report("0", enemy.TrackNumber);
            }
        }

        //New Passenger each Tick
        private void NewPassenger()
        {
            double P = Target.RNG(0, 2);
            if (P < 1)
            {
                trackNumber++;
                Passenger passenger = new Passenger(0.55, 21.5 * Math.PI / 12, Color.Yellow, 189, 250, trackNumber, 0);
                passengers.Add(passenger);
                Report("0", trackNumber);
            }
            if (P > 1)
            {
                trackNumber++;
                Passenger passenger = new Passenger(0.55, Math.PI, Color.Yellow, 519, 178, trackNumber, 0);
                passengers.Add(passenger);
                Report("0", trackNumber);
            }
        }

        //Close Program
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Program settings
        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            timerClock.Stop();
            if (buttonSimulation.Enabled == false)
            timerTargetUpdate.Stop();

            Controls control;
            control = new Controls(notifyDelegate);
            control.Show();
        }

        //UnPause timers
        private void TimerStart()
        {
            timerClock.Start();
            timerTargetUpdate.Start();
        }

        private void buttonGIP_Click(object sender, EventArgs e)
        {
            Target HasGIP = null;
            richTextBoxReport.AppendText(Environment.NewLine);
            richTextBoxReport.AppendText("Calculating GIP...");

            richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
            richTextBoxReport.ScrollToCaret();
            Wait(3);

            foreach(Target enemy in enemies)
            {
                enemy.GIP = true;
                if (enemy.GIPY >= -1.75 * enemy.GIPX + 875 && enemy.GIPY >= 334 && enemy.GIPY <= -1.75 * enemy.GIPX + 934 && enemy.GIPY <= 355)
                {
                    Report("2", enemy.TrackNumber);

                    HasGIP = enemy;
                }
            }
            foreach(Target selected in selection)
            {
                selected.GIP = true;

                if (selected.GIPY >= -1.75 * selected.GIPX + 875 && selected.GIPY >= 334 && selected.GIPY <= -1.75 * selected.GIPX + 934 && selected.GIPY <= 355)
                {
                    Report("2", selected.TrackNumber);

                    HasGIP = selected;
                }
            }

            if (HasGIP == null)
            {
                richTextBoxReport.AppendText(Environment.NewLine);
                richTextBoxReport.AppendText("No Track has a GIP inside the Air Base");

                richTextBoxReport.SelectionStart = richTextBoxReport.Text.Length;
                richTextBoxReport.ScrollToCaret();
            }
        }

        private void buttonSimulation_Click(object sender, EventArgs e)
        {
            buttonSimulation.Enabled = false;
            buttonSingle.Enabled = true;
            buttonSalvo.Enabled = true;
            pictureBoxFlipSwitch1.Enabled = true;
            pictureBoxRadar.Enabled = true;
            buttonReload.Enabled = true;
            buttonEngage.Enabled = true;
            buttonSelect.Enabled = true;
            buttonUnselect.Enabled = true;
            buttonIgnoreWarning.Enabled = true;
            buttonGIP.Enabled = true;
            buttonIFF.Enabled = true;

            time = 0;
        }

        private void buttonSimulation_MouseEnter(object sender, EventArgs e)
        {
            buttonSimulation.BackColor = Color.Red;
        }

        private void buttonSimulation_MouseLeave(object sender, EventArgs e)
        {
            buttonSimulation.BackColor = Color.Gainsboro;
        }
        private void CloseForm()
        {
            Close();
        }

        private void ShowForm()
        {
            Newspaper newspaper = new Newspaper(close, false);
            newspaper.Show();
        }
    }
}