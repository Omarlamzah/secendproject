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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
          label1.Text= e.NewValue.ToString();
          label2.Text =e.OldValue.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'ds.ddsabsentDiag'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.ddsabsentDiagTableAdapter.Fill(this.ds.ddsabsentDiag,2014);

            this.reportViewer1.RefreshReport();
        }
    }
}
