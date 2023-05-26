using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Air_defense_simulator;

namespace Air_defense_simulator
{
    
    public partial class BSOD : Form
    {
        NotifyEvent show;
        public BSOD(NotifyEvent showform)
        {
            InitializeComponent();

            Cursor.Hide();
            show = showform;

            pictureBox1.Image = Properties.Resources._0;
        }

        private void timerBSOD_Tick(object sender, EventArgs e)
        {
            switch (pictureBox1.Tag)
            {
                case "0":
                    ChangeImage("1");
                    break;
                case "1":
                    ChangeImage("2");
                    break;
                case "2":
                        ChangeImage("3");
                    break;
                case "3":
                        ChangeImage("4");
                    break;
                case "4":
                        ChangeImage("5");
                    break;
                case "5":
                        ChangeImage("6");
                    break;
                case "6":
                    ChangeImage("7");
                    break;
                case "7":
                    ChangeImage("8");
                    break;
                case "8":
                    ChangeImage("9");
                    break;
                case "9":
                    ChangeImage("10");
                    break;
            }
        }

        private void ChangeImage(string imageTag)
        {
            pictureBox1.Tag = imageTag;
            switch (imageTag)
            {
                case "1":
                    pictureBox1.Image = Properties.Resources._5;
                    timerBSOD.Interval = 5000;
                    break;
                case "2":
                    pictureBox1.Image = Properties.Resources._21;
                    timerBSOD.Interval = 3000;
                    break;
                case "3":
                    pictureBox1.Image = Properties.Resources._34;
                    timerBSOD.Interval = 4000;
                    break;
                case "4":
                    pictureBox1.Image = Properties.Resources._49;
                    timerBSOD.Interval = 5000;
                    break;
                case "5":
                    pictureBox1.Image = Properties.Resources._63;
                    timerBSOD.Interval = 3000;
                    break;
                case "6":
                    pictureBox1.Image = Properties.Resources._78;
                    timerBSOD.Interval = 5000;
                    break;
                case "7":
                    pictureBox1.Image = Properties.Resources._97;
                    timerBSOD.Interval = 1000;
                    break;
                case "8":
                    pictureBox1.Image = Properties.Resources._100;
                    timerBSOD.Interval = 5000;
                    break;
                case "9":
                    timerBSOD.Interval = 2000;
                    pictureBox1.Image = null;
                    break;
                case "10":
                    show.Invoke();
                    break;
            }
        }
    }
}
