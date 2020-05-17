using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace StalkerPDA.UserControls
{
    public partial class relationPanel : UserControl
    {
        public relationPanel()
        {
            InitializeComponent();
            fillCheckedListBox();
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

        }

        private void fillCheckedListBox()
        {
            using (var context = new StalkerP4Entities())
            {
                var factionList = context
                    .Frakcja.Where(x => x.Status == "Exists")
                    .Select(x => x.Nazwa_frakcji)
                    .OrderBy(x => x);

                foreach (var factionName in factionList)
                {
                    relationCheckedListBox.Items.Add(factionName);
                }
            }
        }

        private void relationCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Max 5 items checked
            if (e.NewValue == CheckState.Checked && relationCheckedListBox.CheckedItems.Count >= 5)
                e.NewValue = CheckState.Unchecked;
        }

        private void showRelationsButton_Click(object sender, EventArgs e)
        {
            int[] emptyRelation = new int[] { 0, 0, 0, 0, 0 };
            //Hide labels
            foreach (Label label in tableLayoutPanel1.Controls.OfType<Label>())
            {
                label.Visible = false;
            }

            foreach (var factions in relationCheckedListBox.CheckedItems)
            {
                for (int i = 0; i < emptyRelation.Length; i++)
                {
                    if (emptyRelation[i] == 0)
                    {
                        DataRowView row = factions as DataRowView;
                        switch (i)
                        {
                            case 0:
                                factionNameLabel1.Text = factions.ToString();
                                firstFactionNameLabel.Text = factions.ToString();
                                factionNameLabel1.Visible = firstFactionNameLabel.Visible = neutral1.Visible = true;
                                break;
                            case 1:
                                factionNameLabel2.Text = factions.ToString();
                                secondFactionNameLabel.Text = factions.ToString();
                                factionNameLabel2.Visible = secondFactionNameLabel.Visible = neutral2.Visible = true;
                                break;
                            case 2:
                                factionNameLabel3.Text = factions.ToString();
                                thirdFactionNameLabel.Text = factions.ToString();
                                factionNameLabel3.Visible = thirdFactionNameLabel.Visible = neutral3.Visible = true;
                                break;
                            case 3:
                                factionNameLabel4.Text = factions.ToString();
                                fourthFactionNameLabel.Text = factions.ToString();
                                factionNameLabel4.Visible = fourthFactionNameLabel.Visible = neutral4.Visible = true;
                                break;
                            case 4:
                                factionNameLabel5.Text = factions.ToString();
                                fifthFactionNameLabel.Text = factions.ToString();
                                factionNameLabel5.Visible = fifthFactionNameLabel.Visible = neutral5.Visible = true;
                                break;
                        }
                        emptyRelation[i] = 1;
                        break;
                    }
                }
            }

            changeRelation();

            //Uncheck all items
            for (int i = 0; i < relationCheckedListBox.Items.Count; i++)
            {
                relationCheckedListBox.SetItemChecked(i, false);
            }

            foreach (Label label in tableLayoutPanel1.Controls.OfType<Label>())
            {
                switch (label.Text)
                {
                    case "ALLIANCE":
                        label.ForeColor = Color.Green;
                        break;
                    case "CONFLICT":
                        label.ForeColor = Color.Red;
                        break;
                    case "NEUTRAL":
                        label.ForeColor = Color.Orange;
                        break;
                }
            }
        }

        private void changeRelation()
        {
            foreach (var factionName in tableLayoutPanel1.Controls)
            {
                //Sprawdzanie, czy kontrolka jest etykietą
                if (factionName.GetType() == factionNameLabel1.GetType())
                {
                    switch (relationCheckedListBox.CheckedItems.Count)
                    {
                        case 2:
                            relationLabel21.Text = relationLabel12.Text = getRelation(factionNameLabel1.Text, factionNameLabel2.Text);
                            relationLabel21.Visible = relationLabel12.Visible = true;
                            break;
                        case 3:
                            relationLabel31.Text = relationLabel13.Text = getRelation(factionNameLabel1.Text, factionNameLabel3.Text);
                            relationLabel32.Text = relationLabel23.Text = getRelation(factionNameLabel3.Text, factionNameLabel2.Text);
                            relationLabel31.Visible = relationLabel13.Visible = relationLabel32.Visible = relationLabel23.Visible = true;
                            goto case 2;
                        case 4:
                            relationLabel41.Text = relationLabel14.Text = getRelation(factionNameLabel1.Text, factionNameLabel4.Text);
                            relationLabel42.Text = relationLabel24.Text = getRelation(factionNameLabel4.Text, factionNameLabel2.Text);
                            relationLabel43.Text = relationLabel34.Text = getRelation(factionNameLabel4.Text, factionNameLabel3.Text);
                            relationLabel41.Visible = relationLabel14.Visible = relationLabel42.Visible = relationLabel24.Visible = true;
                            relationLabel43.Visible = relationLabel34.Visible = true;
                            goto case 3;
                        case 5:
                            relationLabel51.Text = relationLabel15.Text = getRelation(factionNameLabel1.Text, factionNameLabel5.Text);
                            relationLabel52.Text = relationLabel25.Text = getRelation(factionNameLabel5.Text, factionNameLabel2.Text);
                            relationLabel53.Text = relationLabel35.Text = getRelation(factionNameLabel5.Text, factionNameLabel3.Text);
                            relationLabel54.Text = relationLabel45.Text = getRelation(factionNameLabel4.Text, factionNameLabel5.Text);
                            relationLabel51.Visible = relationLabel15.Visible = relationLabel52.Visible = relationLabel25.Visible = true;
                            relationLabel53.Visible = relationLabel35.Visible = relationLabel54.Visible = relationLabel45.Visible = true;
                            goto case 4;
                    }
                }
            }
        }

        private string getRelation(string factionName1, string factionName2)
        {
            int fId1 = 0, fId2 = 0;
            string relation = "NEUTRAL";

            using (var context = new StalkerP4Entities())
            {
                var factionId1 = context
                    .Frakcja.Where(x => x.Nazwa_frakcji == factionName1)
                    .Select(x => x.Id_frakcji);

                foreach (var f in factionId1)
                {
                    fId1 = f;
                }

                var factionId2 = context
                    .Frakcja.Where(x => x.Nazwa_frakcji == factionName2)
                    .Select(x => x.Id_frakcji);

                foreach (var f in factionId2)
                {
                    fId2 = f;
                }

                var relationType = context
                    .Relacja.Where(x => x.Id_frakcji_p == fId1 & x.Id_frakcji_d == fId2)
                    .Select(x => x.Rodzaj_relacji);

                foreach (var rel in relationType)
                {
                    relation = rel.ToUpper();
                }
            }
            return relation;
        }
    }
}
