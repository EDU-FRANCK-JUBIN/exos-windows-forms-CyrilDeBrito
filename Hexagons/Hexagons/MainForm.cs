using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hexagons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            textBoxRed.Text = trackBarR.Value.ToString();
            setColor();
        }

        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            textBoxGreen.Text = trackBarG.Value.ToString();
            setColor();
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            textBoxBlue.Text = trackBarB.Value.ToString();
            setColor();
        }

        private void setColor()
        {
            Color color = Color.FromArgb(trackBarR.Value, trackBarG.Value, trackBarB.Value);
            lbColor.BackColor = color;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Vient de la chasse : " + Hexagon.HexagonNumber.ToString());
            
            var appSettings = ConfigurationManager.AppSettings;
            string result = appSettings["HexagonNumberFromApp"] ?? "Not found";
            MessageBox.Show("Vient de app.config : " + result);        }
    }
}
