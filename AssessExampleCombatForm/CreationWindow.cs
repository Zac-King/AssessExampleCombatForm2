using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessExampleCombatForm
{
    public partial class CreationWindow : Form
    {
        public Form1 formParent;
        List<Combat.Classes.Unit> savedUnits = new List<Combat.Classes.Unit>();

        public CreationWindow()
        {
            InitializeComponent();
        }

        private void ChangeAttribute(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Control parent = b.Parent;
            Panel p = parent as Panel;
            Label attValue = new Label();
            Label points = new Label();

            foreach (Control c in parent.Parent.Controls)
            {
                if (c.Name == "RemainingPoints" && c is Label)
                    points = c as Label;
                //
            }

            foreach (Control ch in p.Controls)
            {
                if (ch is Label)
                {
                    attValue = ch as Label;
                    break;
                }
            }

            int val = int.Parse(attValue.Text);
            int pointValue = int.Parse(points.Text);

            if ((b.Text == "<") && (val > 0) && (pointValue <= 15))
            {
                val--;
                pointValue++;
            }

            if ((b.Text == ">") && (val >= 0) && (pointValue > 0))
            {
                val++;
                pointValue--;
            }
            attValue.Text = val.ToString();
            points.Text = pointValue.ToString();
        }

        private void SaveAttributes(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Control parent = b.Parent;
            Panel panelGroup = parent as Panel;

            float str = 0f, dex = 0f, intel = 0f, spd = 0f;
            string name = "John", className = "Squire";

            foreach (Control c in parent.Controls)
            {
                if (c is Panel)
                    foreach (Control c2 in c.Controls)
                        if (c2 is Label)
                        {
                            int val = int.Parse(c2.Text);

                            if (c2.Name == "StrengthValue")
                                str = val;
                            if (c2.Name == "DexterityValue")
                                dex = val;
                            if (c2.Name == "IntelligenceValue")
                                intel = val;
                            if (c2.Name == "SpeedValue")
                                spd = val;
                        }
                if (c is TextBox)
                {
                    if(c.Name == "UnitName")
                        name = c.Text;
                    if (c.Name == "UnitClass")
                        className = c.Text;
                }
            }
            /// out of all those checks

            Combat.Classes.Unit temp = new Combat.Classes.Unit(name, className, 20, spd, dex, str, intel);
            Combat.Utilities.Serializer.SerializeXML("SavedFiles", name, temp);
            formParent.SyncCreatedCharacters();
            this.Close();
        }
    }
}
