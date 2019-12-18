using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Databinding : Form
    {
        public Databinding(string Artiste, string Chanson)
        {
            InitializeComponent();
            this._nomArtiste = Artiste;
            this._titreChanson = Chanson;
        }

        private string _nomArtiste { get; set; }
        private string _titreChanson { get; set; }

        
    }

    private void BindingToObservableCollection_Load(object sender, EventArgs e)
    {
        initializeCollection();
        this.radGridView1.DataSource = chanson;
        }
}
