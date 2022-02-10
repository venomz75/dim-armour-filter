using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIM_Armour_Filter
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void GenerateQueryString()
        {
            string output = "";

            //Class
            if (radTitan.Checked) output += "is:titan ";
            if (radHunter.Checked) output += "is:hunter ";
            if (radWarlock.Checked) output += "is:warlock ";

            //Exotic
            if (radExoticYes.Checked) output += "is:exotic ";
            if (radExoticNo.Checked) output += "not:exotic ";

            //Masterwork
            if (radMasterworkYes.Checked) output += "is:masterwork ";
            if (radMasterworkNo.Checked) output += "not:masterwork ";

            //Base stats
            if (nudMobility.Value > 0) output += "basestat:mobility:>" + nudMobility.Value.ToString() + " ";
            if (nudResilience.Value > 0) output += "basestat:resilience:>" + nudResilience.Value.ToString() + " ";
            if (nudRecovery.Value > 0) output += "basestat:recovery:>" + nudRecovery.Value.ToString() + " ";
            if (nudDiscipline.Value > 0) output += "basestat:discipline:>" + nudDiscipline.Value.ToString() + " ";
            if (nudIntellect.Value > 0) output += "basestat:intellect:>" + nudIntellect.Value.ToString() + " ";
            if (nudStrength.Value > 0) output += "basestat:strength:>" + nudStrength.Value.ToString() + " ";
            if (nudTotal.Value > 0) output += "basestat:total:>" + nudTotal.Value.ToString() + " ";

            //Piece
            if (radPieceHelmet.Checked) output += "is:helmet ";
            if (radPieceGauntlets.Checked) output += "is:gauntlets ";
            if (radPieceChest.Checked) output += "is:chest ";
            if (radPieceLegs.Checked) output += "is:leg ";

            System.Windows.Forms.Clipboard.SetText(output);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            GenerateQueryString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nudMobility.Value = 0;
            nudResilience.Value = 0;
            nudRecovery.Value = 0;
            nudDiscipline.Value = 0;
            nudIntellect.Value = 0;
            nudStrength.Value = 0;
            nudTotal.Value = 0;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
