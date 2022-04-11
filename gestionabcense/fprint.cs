using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionabcense
{
    public partial class fprint : Form
    {
        public fprint()
        {
            InitializeComponent();
        }
        int ns;
        public fprint(int ns)
        {
            this.ns = ns;
            InitializeComponent();

        }

        private void fprint_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'ds.DataTable1'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.DataTable1TableAdapter.Fill(this.ds.DataTable1,ns);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
