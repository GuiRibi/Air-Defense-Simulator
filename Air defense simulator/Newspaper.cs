using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Air_defense_simulator;

namespace Air_defense_simulator
{
    public partial class Newspaper : Form
    {
        NotifyEvent close;

        int loaded = 0;
        public bool isPassenger { get; set; }
        public Newspaper(NotifyEvent closeform, bool passenger)
        {
            InitializeComponent();
            this.Opacity = 0;
            close = closeform;
            isPassenger = passenger;
        }

        private void timerOpacity_Tick(object sender, EventArgs e)
        {
            ChangeOpacity();
        }
        private void ChangeOpacity()
        {
            if(timerOpacity.Tag == null)
            {
                this.Opacity += .01;
                if (this.Opacity == 1)
                {
                    timerOpacity.Stop();
                    Cursor.Show();
                    pictureBox2.Visible = true;
                }
            }
            else
            {
                this.Opacity -= .1;
                if (this.Opacity == 0)
                {
                    timerOpacity.Stop();
                    Cursor.Show();
                    close.Invoke();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.TopMost = true;

            Cursor.Hide();

            labelLoading.Visible = true;
            if (isPassenger)
                labelInfo.Text = "Tip: Some passenger planes might have faulty transponders.\r\nDon't forget to use IFF Identifier.";
            else
                labelInfo.Text = "Tip: Not all missiles fired against you will hit the Air Base.\r\nDon't forget to use GIP to your advantage.";
            labelInfo.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            timerLoading.Start();
        }

        private void Newspaper_Load(object sender, EventArgs e)
        {
            if(isPassenger)
            {
                pictureBox1.Image = Properties.Resources.Newspaper;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.newspaper_airbase;
            }
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            switch (timerLoading.Tag)
            {
                case "1":
                    labelLoading.Text = "Loading.";
                    timerLoading.Tag = "2";
                    break;
                case "2":
                    labelLoading.Text = "Loading..";
                    timerLoading.Tag = "3";
                    break;
                case "3":
                    labelLoading.Text = "Loading...";
                    timerLoading.Tag = "1";
                    if (loaded == 4)
                    {
                        string currentDirectory = Directory.GetCurrentDirectory();

                        string fileName = currentDirectory + "\\Menu.exe";

                        Process process = new Process();
                        process.StartInfo.FileName = fileName;
                        process.Start();
                    }
                    if (loaded == 5)
                    {
                        timerOpacity.Tag = "bye";
                        timerOpacity.Start();
                    }
                    else
                        loaded++;
                    break;
            }
        }
    }
}
