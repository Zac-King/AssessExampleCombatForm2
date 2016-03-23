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
        ListBox CharactersOnFile = new ListBox();
        Chart StatChart = new Chart();
        Combat.Classes.Unit SelectedUnit;
    
        public Form1()
        {
            InitializeComponent();
            CharactersOnFile = this.Controls.Find("CreatedCharacters", true).FirstOrDefault() as ListBox;
            StatChart = this.Controls.Find("CharacterStatChart", true).FirstOrDefault() as Chart;
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
            string path = @"..\..\SavedFiles";      // File Path to our saved Units
            var relay = Directory.GetFiles(path);
            
            foreach(var v in relay)
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
                CharactersOnFile.Items.Add(c.Name);
            }
                
        }

       private void UpdateSelected(object sender, EventArgs e)
        {
           // SelectedUnit = CharactersOnFile.GetSelected();
        } 
    }
}
