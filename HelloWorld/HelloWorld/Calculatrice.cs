using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }

        private void buttonCalcEquals_Click(object sender, EventArgs e);
        string tdDemande = "";

        {
            DataTable dt = new DataTable();
            var v = dt.Compute(tdDemande.Text, "");
            tbRessultat.Text = v.ToString();
        }

        private void Calculatrice_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox_Calc(object sender, EventArgs e)
        {

        }

        private void groupBox_Calc_Enter(object sender, EventArgs e)
        {

        }

        private void button_CalcCE(object sender, EventArgs e)
        {

        }

        private void buttonCalcCE_Click(object sender, EventArgs e)
        {

        }

        private void buttonC_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }

        private void buttonDevide_Click(object sender, EventArgs e)
        {

        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {

        }

        private void buttonheight_Click(object sender, EventArgs e)
        {

        }

        private void buttonNine_Click(object sender, EventArgs e)
        {

        }

        private void buttonMult_Click(object sender, EventArgs e)
        {

        }

        private void buttonFour_Click(object sender, EventArgs e)
        {

        }

        private void buttonFive_Click(object sender, EventArgs e)
        {

        }

        private void buttonSix_Click(object sender, EventArgs e)
        {

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

        }

        private void buttonOne_Click(object sender, EventArgs e)
        {

        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {

        }

        private void buttonThree_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoreLess_Click(object sender, EventArgs e)
        {

        }

        private void buttonZero_Click(object sender, EventArgs e)
        {

        }

        private void buttonComma_Click(object sender, EventArgs e)
        {

        }
    }
}
