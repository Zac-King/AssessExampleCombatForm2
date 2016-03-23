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

        //private void ResetParent(object sender, EventArgs e)
        //{
            
        //}
    }
}
