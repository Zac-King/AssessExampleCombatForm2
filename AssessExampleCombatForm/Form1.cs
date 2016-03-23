using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AssessExampleCombatForm
{
    public partial class Form1 : Form
    {
        List<Combat.Classes.Unit> CreatedUnits = new List<Combat.Classes.Unit>();
        List<Combat.Classes.Unit> PartyA = new List<Combat.Classes.Unit>();
        List<Combat.Classes.Unit> PartyB = new List<Combat.Classes.Unit>();
        ListBox CharactersOnFile = new ListBox();
        RichTextBox statBox = new RichTextBox();
        RichTextBox partyATestBox = new RichTextBox();
        RichTextBox partyBTestBox = new RichTextBox();
        bool partyAReady = false, partyBReady = false;
        Button PlayButton;
        Combat.Classes.Unit SelectedUnit;

        public Form1()
        {
            InitializeComponent();

            CharactersOnFile = this.Controls.Find("CreatedCharacters", true).FirstOrDefault() as ListBox;
            statBox = this.Controls.Find("StatTextBox", true).FirstOrDefault() as RichTextBox;
            partyATestBox = this.Controls.Find("PartyATestBox", true).FirstOrDefault() as RichTextBox;
            partyBTestBox = this.Controls.Find("PartyBTestBox", true).FirstOrDefault() as RichTextBox;
            PlayButton = this.Controls.Find("StartGame", true).FirstOrDefault() as Button;
            SyncCreatedCharacters();
        }

        private void CreateCharacterButton_Click(object sender, EventArgs e)
        {
            CreationWindow createWindow = new CreationWindow();
            createWindow.formParent = this;
            createWindow.Show();
        }

        public void SyncCreatedCharacters()
        {
            CreatedUnits.Clear();
            string path = @"..\..\SavedFiles";      // File Path to our saved Units
            var relay = Directory.GetFiles(path);
            
            foreach (var v in relay)
            {
                Combat.Classes.Unit t = Combat.Utilities.Serializer.DeserializeXML<Combat.Classes.Unit>((string)v);
                CreatedUnits.Add(t);
            }

            UpdateCharacterListBox();
        }

        private void UpdateCharacterListBox()
        {

            CharactersOnFile.Items.Clear();
            foreach (Combat.Classes.Unit c in CreatedUnits)
            {
                CharactersOnFile.Items.Add(c.name);
            }

        }

        private void UpdateSelected(object sender, EventArgs e)
        {
            string s = (string)CharactersOnFile.SelectedItem;
            foreach (Combat.Classes.Unit u in CreatedUnits)
            {
                if (u.Name == s)
                {
                    SelectedUnit = u;
                    statBox.Text = "Name: \t" + u.Name
                                + "\nClass: \t" + u.ClassName
                                + "\nHealth: \t\t" + u.Health
                                + "\nSpeed: \t\t" + u.Speed
                                + "\nDexterity: \t\t" + u.Dexerity
                                + "\nStrength: \t\t" + u.Strength
                                + "\nIntelligence: \t" + u.Intelligence;
                }
            }

        }

        private void AddToParty(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (SelectedUnit != null)
            {
                if (b.Name == "AddSelectedToA") // Team A
                {
                    partyATestBox.Text += SelectedUnit.Name + "\n";
                    PartyA.Add(SelectedUnit);
                }
                if (b.Name == "AddSelectedToB") // Team B
                {
                    partyBTestBox.Text += SelectedUnit.Name + "\n";
                    PartyB.Add(SelectedUnit);
                }
            }
            TeamReadyCheck();
            if (b.Name == "AddSelectedToA" && partyAReady)
            {
                b.Visible = false;
            }
            if (b.Name == "AddSelectedToB" && partyBReady)
            {
                b.Visible = false;
            }
        }

        private void TeamReadyCheck()
        {
            if (PartyA.Count == 3)
            {
                partyAReady = true;
            }
            if (PartyB.Count == 3)
            {
                partyBReady = true;

            }

            if (partyAReady && partyBReady)
            {
                PlayButton.Visible = true;
            }
        }

        private void StartFight(object sender, EventArgs e)
        {
            BattleGround bg = new BattleGround();
            bg.formParent = this;
            bg.RecieveUnits(PartyA, PartyB);
            bg.Show();
        }

        public void MyReset()
        {
            PartyA = new List<Combat.Classes.Unit>();
            PartyB = new List<Combat.Classes.Unit>();
            partyAReady = false;
            partyBReady = false;


        }
    }
}
