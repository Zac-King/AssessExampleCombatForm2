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
    public partial class BattleGround : Form
    {
        List<Combat.Classes.Unit> partisipants = new List<Combat.Classes.Unit>();
        List<Combat.Classes.Unit> partyA = new List<Combat.Classes.Unit>();
        List<Combat.Classes.Unit> partyB = new List<Combat.Classes.Unit>();

        public BattleGround()
        {
            InitializeComponent();
        }
    }
}
