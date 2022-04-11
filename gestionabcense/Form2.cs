using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace absence
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int idab;
        public Form2(int ida)
        {
            this.idab = ida;
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        gestionabsenceEntities2 gent = new gestionabsenceEntities2();
        private void Form2_Load(object sender, EventArgs e)
        {
            absence ab = gent.absence.FirstOrDefault(b => b.id == idab);
            string pprr = ab.ppr;
            fonction f = gent.fonction.FirstOrDefault(ff=> ff.ppr == pprr);

            label2.Text = f.ppr;
            label4.Text = f.prenom;
            label5.Text = f.echlant;
            label7.Text = f.service;

            




           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decision1 d = new Decision1();
            d.iddes = idab;
            d.datekarara = dateTimePicker1.Value;
            d.jours_retr = int.Parse(comboBox2.Text);
            d.nomre_karar = textBox2.Text;
            d.nombre_stifsar = int.Parse(textBox1.Text);

            gent.Decision1.Add(d);

            gent.SaveChanges();
            MessageBox.Show("le decision est ajouter");




        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nstf = int.Parse(textBox3.Text);
            Decision1 d= gent.Decision1.FirstOrDefault(a=>a.nombre_stifsar==nstf);
          
              dateTimePicker1.Value=(DateTime)d.datekarara;
         comboBox2.Text=d.jours_retr.ToString()  ;
            textBox2.Text=d.nomre_karar  ;
              textBox1.Text =d.nombre_stifsar.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nstf =int.Parse( textBox1.Text);
            fprint fp = new fprint(nstf);
            fp.Show();
        }
    }
}
