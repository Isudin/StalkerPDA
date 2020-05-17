using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StalkerPDA.UserControls
{
    public partial class factionPanel : UserControl
    {
        public factionPanel()
        {
            InitializeComponent();
            fillListBox();
            factionListBox.SelectedIndex = 0;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void fillListBox()
        {
            using (var context = new StalkerP4Entities())
            {
                var factionList = context
                    .Frakcja.Select(x => x.Nazwa_frakcji)
                    .OrderBy(x => x);

                foreach (var factionName in factionList)
                {
                    factionListBox.Items.Add(factionName);
                }
            }
        }

        private void factionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fName = factionListBox.SelectedItem.ToString();
            factionNameLabel.Text = fName;
            factionLeaderLabel.Text = findLeader(fName);
            factionMembersLabel.Text = countMembers(fName).ToString();
            factionStatusLabel.Text = setStatus(fName);
            changeLogo(fName);
        }

        private string findLeader(string factionName)
        {
            string leaderName = "Unknown";
            using (var context = new StalkerP4Entities())
            {
                var factionID = context
                    .Frakcja.Where(x => x.Nazwa_frakcji == factionName)
                    .Select(x => x.Id_frakcji)
                    .First();
                try
                {
                    var stalkerID = context
                        .Czlonkostwo.Where(x => x.Id_frakcji == factionID && x.Stopien == "Leader")
                        .Select(x => x.Id_stalkera)
                        .First();

                    var leader = context
                        .Stalker.Where(x => x.Id_stalkera == stalkerID)
                        .Select(x => x.Pseudonim);

                    foreach (var lName in leader)
                    {
                        leaderName = lName.ToString();
                    }
                }
                catch (InvalidOperationException)
                {
                    return leaderName;
                }

            }
            return leaderName;
        }
        private void changeLogo(string factionName)
        {
            factionName = factionName.Replace(" ", "");
            factionName = char.ToUpper(factionName[0]) + factionName.Substring(1);
            pictureBox1.Image = Image.FromFile(@"Patches\" + factionName + ".png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private int countMembers(string factionName)
        {
            int members = 0;
            using (var context = new StalkerP4Entities())
            {
                var faction = context
                    .Frakcja.Where(x => x.Nazwa_frakcji == factionName)
                    .Select(x => x.Id_frakcji)
                    .First();

                var numOfMembers = context
                    .Czlonkostwo.Where(x => x.Id_frakcji == faction)
                    .Count();
                members = numOfMembers;
            }

            return members;
        }
        private string setStatus(string factionName)
        {
            string status = "Unknown";
            using (var context = new StalkerP4Entities())
            {
                var getStatus = context
                    .Frakcja.Where(x => x.Nazwa_frakcji == factionName)
                    .Select(x => x.Status)
                    .First();
                status = getStatus;
            }
            return status;
        }
    }
}
