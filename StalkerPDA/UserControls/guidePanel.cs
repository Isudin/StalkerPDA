using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using StalkerPDA.UserControls;

namespace StalkerPDA.UserControls
{
    public partial class guidePanel : UserControl
    {
        public guidePanel()
        {
            InitializeComponent();
            fillCategoryListBox();
            categoryListBox.SelectedIndex = 0;
            objectListBox.SelectedIndex = 0;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void fillCategoryListBox()
        {
            foreach (var category in categories)
            {
                categoryListBox.Items.Add(category);
            }
        }

        #region Reflections
        //private void fillObjectListBox(string categoryName)
        //{
        //    Type cats = categories.GetType();
        //    MethodInfo methodInfo = cats.GetMethod(categoryName);
        //    PropertyInfo propInfo = cats.GetProperty(categoryName);
        //    FieldInfo fieldInfo = cats.GetField(categoryName);
        //    ParameterInfo paramInfo = cats.
        //    //string name = info.Name.ToString();
        //    descriptionTextBox.Text = cats.Name.ToString();
        //}
        #endregion

        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cName = categoryListBox.SelectedItem.ToString();
            fillObjectListBox(cName);
        }

        private void fillObjectListBox(string categoryName)
        {
            objectListBox.Items.Clear();
            switch (categoryName)
            {
                case "Anomalies":
                    foreach (var anomaly in anomalies)
                    {
                        objectListBox.Items.Add(anomaly);
                    }
                    break;
                case "Artifacts":
                    foreach (var artifact in artifacts)
                    {
                        objectListBox.Items.Add(artifact);
                    }
                    break;
                case "Mutants":
                    foreach (var mutant in mutants)
                    {
                        objectListBox.Items.Add(mutant);
                    }
                    break;
            }
        }
        private void objectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string objectName = objectListBox.SelectedItem.ToString();
            objectName = objectName.Replace("-", "").Replace(" ", "").ToLower();
            objectName = char.ToUpper(objectName[0]) + objectName.Substring(1);
            fillTextBox(objectName);
            fillPictureBox(objectName);
        }
        private void fillTextBox(string objectName)
        {
            string path = @"Guide\" + categoryListBox.SelectedItem.ToString() + @"\" + objectName + @"\" + objectName + ".txt";
            descriptionTextBox.Text = File.ReadAllText(path);
        }

        private void fillPictureBox(string objectName)
        {
            int positionY = objectPictureBox.Location.Y;
            if (categoryListBox.SelectedItem.ToString() == "Mutants")
            {
                objectPictureBox.Width = descriptionTextBox.Width / 3 * 2;
                objectPictureBox.Location = new System.Drawing.Point(descriptionTextBox.Location.X + descriptionTextBox.Location.X / 6, positionY);
            }
            else
            {
                objectPictureBox.Width = descriptionTextBox.Width / 3;
                objectPictureBox.Location = new System.Drawing.Point(descriptionTextBox.Location.X + descriptionTextBox.Location.X / 3, positionY);
            }

            try
            {
                try
                {
                    string path = @"Guide\" + categoryListBox.SelectedItem.ToString() + @"\" + objectName + @"\" + objectName + ".jpg";
                    objectPictureBox.Image = Image.FromFile(path);
                }
                catch (FileNotFoundException)
                {
                    string path = @"Guide\" + categoryListBox.SelectedItem.ToString() + @"\" + objectName + @"\" + objectName + ".png";
                    objectPictureBox.Image = Image.FromFile(path);
                }
            }
            catch (FileNotFoundException)
            {
                string path = @"Guide\Nodata.jpg";
                objectPictureBox.Image = Image.FromFile(path);
            }
        }

        #region Lists

        List<string> categories = new List<string>
        {
            "Anomalies",
            "Artifacts",
            "Mutants"
        };

        List<string> anomalies = new List<string>
        {
            "Burner",
            "Comet",
            "Vortex",
            "Springboard",
            "Whirligig",
            "Fruit Punch",
            "Burnt Fuzz",
            "Gas",
            "Gas Cloud",
            "Electro",
            "Tesla",
            "Space Anomaly",
            "Teleport",
            "Emission",
            "Radiation",
            "Fault",
            "Symbiont"
        };

        List<string> mutants = new List<string>
        {
            "Flesh",
            "Boar",
            "Blind dog",
            "Pseudodog",
            "Psy-Dog",
            "Rodent",
            "Chimera",
            "Bloodsucker",
            "Poltergeist",
            "Pseudogiant",
            "Burer",
            "Snork",
            "Controller",
            "Pyrogeist"
        };

        List<string> artifacts = new List<string>
        {
            "Jellyfish",
            "Thorn",
            "Gravi",
            "Goldfish",
            "Droplet",
            "Eye",
            "Fireball",
            "Firefly",
            "Flame",
            "Flash",
            "Compass",
            "Night Star",
            "Moonlight"
        };


        #endregion
    }
}
