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
    public partial class fps : Form
    {
        public fps()
        {
            InitializeComponent();
        }
        int id;
        DateTime dt;
      
        public fps(int id,DateTime dt)
        {
            this.id = id;
            this.dt = dt;

            InitializeComponent();
        }
       
        int jt1, jt2;
        int jabs, moabs;

        private void fps_Load(object sender, EventArgs e)
        {
            int m1 = dt.Month;
            int m2 = DateTime.Today.Month;

            int j1 = dt.Day;
            int j2 = DateTime.Today.Day;

            if (m1 == 1 || m1 == 3 || m1 == 5 || m1 == 7 || m1 == 8 || m1 == 10 || m1 == 12) jt1 = 31;
            if (m2 == 1 || m2 == 3 || m2 == 5 || m2 == 7 || m2 == 8 || m2 == 10 || m2 == 12) jt1 = 31;

            
            if (m1 == m2)
            {
                jabs = j2 - j1;
            }



            if (m2 > m1) {
                if (m2 - m1 == 1)
                {
                    jabs = j2 + (jt1 - j1);
                }
                if (m2 - m1 > 1)
                {
                    jabs = j2 + (jt1 - j1);

                    moabs = (m2 - m1)-1;
                }
            }






            // TODO: cette ligne de code charge les données dans la table 'ds.infoabsent'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.infoabsentTableAdapter.Fill(this.ds.infoabsent,id, moabs+ "  moi et les jour sont  "+ jabs.ToString());

            this.reportViewer1.RefreshReport();
        }
        gestionabsenceEntities gent = new gestionabsenceEntities();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            detaille_abs dab = new detaille_abs();
            dab.dateirsalistifsar = guna2DateTimePicker1.Value;
            dab.irsalistifsar = "تم إرسال الإستفسار";
            reportViewer1.Enabled = true;
            gent.detaille_abs.Add(dab);

            gent.SaveChanges();
            MessageBox.Show("saved");
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
