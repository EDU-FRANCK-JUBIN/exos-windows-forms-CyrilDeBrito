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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void city_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = city.GetItemText(city.SelectedItem);
            MessageBox.Show(text);
        }
    }
}
