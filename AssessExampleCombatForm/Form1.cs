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

namespace AssessExampleCombatForm
{
    public partial class Form1 : Form
    {
        List<Combat.Classes.Unit> CreatedUnits = new List<Combat.Classes.Unit>();
        ListBox CharactersOnFile = new ListBox();
        public Form1()
        {
            InitializeComponent();
            CharactersOnFile = this.Controls.Find("CreatedCharacters", true).FirstOrDefault() as ListBox;
            SyncCreatedCharacters();
        }

        private void CreateCharacterButton_Click(object sender, EventArgs e)
        {
            CreationWindow createWindow = new CreationWindow();
            createWindow.formParent = this;
            //createWindow.MdiParent = this;
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
                CharactersOnFile.Items.Add(c);
        }

        
    }
}
