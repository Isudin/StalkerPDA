using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StalkerPDA
{
    public partial class MainForm : Form
    {
        private int panelNumber = 1;
        public MainForm()
        {
            InitializeComponent();
            hidePanels();
            changePanel();
            foreach (var panel in this.Controls.OfType<Panel>())
            {
                panel.Parent = this;
            }
            timeLabelTimer.Enabled = true;
        }


        private void changePanel()
        {
            switch (panelNumber)
            {
                case 1:
                    hidePanels();
                    factionPanel1.Visible = true;
                    break;
                case 2:
                    hidePanels();
                    relationPanel1.Visible = true;
                    break;
                case 3:
                    hidePanels();
                    guidePanel1.Visible = true;
                    break;
            }
        }



        private void hidePanels()
        {
            foreach (var userPanel in this.Controls.OfType<UserControl>())
            {
                userPanel.Visible = false;
                userPanel.Hide();
            }
        }

        private void factionTabButton_Click(object sender, EventArgs e)
        {
            panelNumber = 1;
            changePanel();
        }

        private void relationTabButton_Click(object sender, EventArgs e)
        {
            panelNumber = 2;
            changePanel();
        }

        private void guideTabButton_Click(object sender, EventArgs e)
        {
            panelNumber = 3;
            changePanel();
        }

        private void timeLabelTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
