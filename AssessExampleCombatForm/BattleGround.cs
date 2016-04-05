using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Combat.Classes;

namespace AssessExampleCombatForm
{
    public partial class BattleGround : Form
    {
        public Form1 formParent;
        List<Combat.Classes.Unit> participants = new List<Combat.Classes.Unit>();
        List<Combat.Classes.Unit> partyA = new List<Combat.Classes.Unit>();
        List<Combat.Classes.Unit> partyB = new List<Combat.Classes.Unit>();
        List<Panel> UnitRepresentation = new List<Panel>();

        public BattleGround()
        {
            InitializeComponent();
        }

        public void RecieveUnits(List<Unit> Pa, List<Unit> Pb)
        {
            partyA = Pa;
            partyB = Pb;
            foreach(Unit u in partyA)
            {
                participants.Add(u);
            }
            foreach (Unit u in partyB)
            {
                participants.Add(u);
            }
            participants.OrderByDescending(x => x.Speed).ToList<Unit>();
        }

        private void Turn()
        {

        }

        

        public void SelectTarget(object sender, EventArgs e)
        {
            if( partyA.Contains(participants[0]) && participants[0].Alive)  // Player Controlled Unit
            {

            }

            if (partyB.Contains(participants[0]) && participants[0].Alive)  // Player Controlled Unit
            {

            }

        }
    }
}
