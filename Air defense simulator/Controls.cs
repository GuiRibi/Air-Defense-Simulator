using Air_defense_simulator;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Controls : Form
    {
        NotifyEvent notifyDelegate;

        Font font = new Font("Segoe UI", 11);
        public Controls(NotifyEvent notify)
        {
            InitializeComponent();

            notifyDelegate = notify;
        }

        private void labelUnderstanding_Click(object sender, EventArgs e)
        {
            labelUnderstanding.Font = new Font(font, FontStyle.Bold);
            labelSelecting.Font = new Font(font, FontStyle.Regular);
            labelIFF.Font = new Font(font, FontStyle.Regular);
            labelFiring.Font = new Font(font, FontStyle.Regular);
            labelUnselecting.Font = new Font(font, FontStyle.Regular);
            labelReloading.Font = new Font(font, FontStyle.Regular);
            labelGIP.Font = new Font(font, FontStyle.Regular);

            pictureBox1.Image = Air_defense_simulator.Properties.Resources.Understanding;
            pictureBox1.Tag = "1";

            labelText1.Text = "This is the Control Panel of the Air Defense System you will be operating.";
            richTextBoxText1.Text = "The left side of the screen contains the 'Launchers' and 'Speed' control panels.\r\n\r\nThe right side of the screen contains the 'Controls' panel.\r\n\r\nThe middle contains the Engagement panel and the Radar Screen, which shows you possible targets and friendly aircraft.\r\nIt also contains a Report panel that will report every action that takes place.";
        }

        private void labelSelecting_Click(object sender, EventArgs e)
        {
            labelUnderstanding.Font = new Font(font, FontStyle.Regular);
            labelSelecting.Font = new Font(font, FontStyle.Bold);
            labelIFF.Font = new Font(font, FontStyle.Regular);
            labelFiring.Font = new Font(font, FontStyle.Regular);
            labelUnselecting.Font = new Font(font, FontStyle.Regular);
            labelReloading.Font = new Font(font, FontStyle.Regular);
            labelGIP.Font = new Font(font, FontStyle.Regular);

            pictureBox1.Image = Air_defense_simulator.Properties.Resources.Selecting;
            pictureBox1.Tag = "2";

            labelText1.Text = "To select a target you must follow these steps:";
            richTextBoxText1.Text = "1.\r\nOn the Controls tab, click on the Select button.\r\n\r\n2.\r\nOn the Radar screen, click on the target you wish to select.";
        }

        private void labelIFF_Click(object sender, EventArgs e)
        {
            labelUnderstanding.Font = new Font(font, FontStyle.Regular);
            labelSelecting.Font = new Font(font, FontStyle.Regular);
            labelIFF.Font = new Font(font, FontStyle.Bold);
            labelFiring.Font = new Font(font, FontStyle.Regular);
            labelUnselecting.Font = new Font(font, FontStyle.Regular);
            labelReloading.Font = new Font(font, FontStyle.Regular);
            labelGIP.Font = new Font(font, FontStyle.Regular);

            pictureBox1.Image = Air_defense_simulator.Properties.Resources.IFF;
            pictureBox1.Tag = "3";

            labelText1.Text = "When using IFF, selected targets will be interrogated.\r\nTo use IFF you must follow these steps:";
            richTextBoxText1.Text = "1.\r\nSelect the target/targets you want to interrogate.\r\n\r\n2.\r\nOn the Controls tab, click on the IFF button.\r\n\r\n3.\r\nOn the Radar screen, you will see a report.\r\n>'IFF no response' means that the selected target is enemy.\r\n>'IFF Friend' means that the selected target is friendly.";
        }

        private void labelFiring_Click(object sender, EventArgs e)
        {
            labelUnderstanding.Font = new Font(font, FontStyle.Regular);
            labelSelecting.Font = new Font(font, FontStyle.Regular);
            labelIFF.Font = new Font(font, FontStyle.Regular);
            labelFiring.Font = new Font(font, FontStyle.Bold);
            labelUnselecting.Font = new Font(font, FontStyle.Regular);
            labelReloading.Font = new Font(font, FontStyle.Regular);
            labelGIP.Font = new Font(font, FontStyle.Regular);

            pictureBox1.Image = Air_defense_simulator.Properties.Resources.Firing;
            pictureBox1.Tag = "4";

            labelText1.Text = "To Fire a missile you must follow these steps:";
            richTextBoxText1.Text = "1.\r\nSelect the target/targets you want to interrogate.\r\n\r\n2.\r\nOn the Engagement Method tab, unlock weapons by clicking on the flip switch.\r\n>A light will light up confirming the action.\r\n\r\n3.\r\nOn the Engagement methods tab, select your prefered engagement method.\r\n>Single will fire a single missile for each selected target.\r\n>Salvo will fire 2 missiles for each selected target.\r\n\r\n4.\r\nOn the Engagement methods tab, click on the Fire button.";
        }

        private void labelUnselecting_Click(object sender, EventArgs e)
        {
            labelUnderstanding.Font = new Font(font, FontStyle.Regular);
            labelSelecting.Font = new Font(font, FontStyle.Regular);
            labelIFF.Font = new Font(font, FontStyle.Regular);
            labelFiring.Font = new Font(font, FontStyle.Regular);
            labelUnselecting.Font = new Font(font, FontStyle.Bold);
            labelReloading.Font = new Font(font, FontStyle.Regular);
            labelGIP.Font = new Font(font, FontStyle.Regular);

            pictureBox1.Image = Air_defense_simulator.Properties.Resources.Unselect;
            pictureBox1.Tag = "5";

            labelText1.Text = "To unselect a target you must follow these steps:";
            richTextBoxText1.Text = "1.\r\nOn the Controls tab, click on the Unselect button.\r\n\r\n2.\r\nOn the Radar screen, click on the target you wish to unselect.";
        }

        private void labelReloading_Click(object sender, EventArgs e)
        {
            labelUnderstanding.Font = new Font(font, FontStyle.Regular);
            labelSelecting.Font = new Font(font, FontStyle.Regular);
            labelIFF.Font = new Font(font, FontStyle.Regular);
            labelFiring.Font = new Font(font, FontStyle.Regular);
            labelUnselecting.Font = new Font(font, FontStyle.Regular);
            labelReloading.Font = new Font(font, FontStyle.Bold);
            labelGIP.Font = new Font(font, FontStyle.Regular);

            pictureBox1.Image = Air_defense_simulator.Properties.Resources.Reload;
            pictureBox1.Tag = "6";

            labelText1.Text = "To reload the launchers you must follow these steps:";
            richTextBoxText1.Text = "1.\r\nOn the Launchers tab, click on the Reload button.\r\n\r\n2.\r\nOn the Radar screen, you will see a report stating the reloading time.";
        }

        private void labelGIP_Click(object sender, EventArgs e)
        {
            labelUnderstanding.Font = new Font(font, FontStyle.Regular);
            labelSelecting.Font = new Font(font, FontStyle.Regular);
            labelIFF.Font = new Font(font, FontStyle.Regular);
            labelFiring.Font = new Font(font, FontStyle.Regular);
            labelUnselecting.Font = new Font(font, FontStyle.Regular);
            labelReloading.Font = new Font(font, FontStyle.Regular);
            labelGIP.Font = new Font(font, FontStyle.Bold);

            pictureBox1.Image = Air_defense_simulator.Properties.Resources.GIP;
            pictureBox1.Tag = "7";

            labelText1.Text = "GIP or Ground Impact Point is a tool that calculates where targets will hit.\r\nTo use GIP you must follow these steps:";
            richTextBoxText1.Text = "When you see a target or various targets on the Radar screen\r\n\r\n1.\r\nOn the Controls tab, click on the GIP button.\r\n\r\n2.\r\nOn the Radar screen, you will see the trajectory of the targets along their GIP\r\n\r\n3.\r\nOn the radar screen, you will see a report.\r\n>'Warning! - Track # GIP is inside the Air Base.' means that target will hit the area.";
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            notifyDelegate.Invoke();

            Close();
        }

        private void labelUnderstanding_MouseEnter(object sender, EventArgs e)
        {
            labelUnderstanding.Font = new Font(font, FontStyle.Bold);
        }

        private void labelUnderstanding_MouseLeave(object sender, EventArgs e)
        {
            if ((string)pictureBox1.Tag != "1")
            {
                labelUnderstanding.Font = new Font(font, FontStyle.Regular);
            }
        }

        private void labelSelecting_MouseEnter(object sender, EventArgs e)
        {
            labelSelecting.Font = new Font(font, FontStyle.Bold);
        }

        private void labelSelecting_MouseLeave(object sender, EventArgs e)
        {
            if ((string)pictureBox1.Tag != "2")
            {
                labelSelecting.Font = new Font(font, FontStyle.Regular);
            }
        }

        private void labelIFF_MouseEnter(object sender, EventArgs e)
        {
            labelIFF.Font = new Font(font, FontStyle.Bold);
        }

        private void labelIFF_MouseLeave(object sender, EventArgs e)
        {
            if ((string)pictureBox1.Tag != "3")
            {
                labelIFF.Font = new Font(font, FontStyle.Regular);
            }
        }

        private void labelFiring_MouseEnter(object sender, EventArgs e)
        {
            labelFiring.Font = new Font(font, FontStyle.Bold);
        }

        private void labelFiring_MouseLeave(object sender, EventArgs e)
        {
            if ((string)pictureBox1.Tag != "4")
            {
                labelFiring.Font = new Font(font, FontStyle.Regular);
            }
        }

        private void labelUnselecting_MouseEnter(object sender, EventArgs e)
        {
            labelUnselecting.Font = new Font(font, FontStyle.Bold);
        }

        private void labelUnselecting_MouseLeave(object sender, EventArgs e)
        {
            if ((string)pictureBox1.Tag != "5")
            {
                labelUnselecting.Font = new Font(font, FontStyle.Regular);
            }
        }

        private void labelReloading_MouseEnter(object sender, EventArgs e)
        {
            labelReloading.Font = new Font(font, FontStyle.Bold);
        }

        private void labelReloading_MouseLeave(object sender, EventArgs e)
        {
            if ((string)pictureBox1.Tag != "6")
            {
                labelReloading.Font = new Font(font, FontStyle.Regular);
            }
        }

        private void labelGIP_MouseEnter(object sender, EventArgs e)
        {
            labelGIP.Font = new Font(font, FontStyle.Bold);
        }

        private void labelGIP_MouseLeave(object sender, EventArgs e)
        {
            if ((string)pictureBox1.Tag != "7")
            {
                labelGIP.Font = new Font(font, FontStyle.Regular);
            }
        }
    }
}
