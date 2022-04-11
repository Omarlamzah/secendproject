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
    public partial class Frm2 : Form
    {
        public Frm2()
        {
            InitializeComponent();
        }
        int ida;
        public Frm2(int ida)
        {
          
                this.ida = ida;
                InitializeComponent();
            

        }
        

        gestionabsenceEntities gent = new gestionabsenceEntities();

        private void Frm3_Load(object sender, EventArgs e)
        {
            try
            {
                absence ab = gent.absences.FirstOrDefault(b => b.id == ida);
                if (ab != null)
                {
                    string pprr = ab.ppr;
                    fonction f = gent.fonctions.FirstOrDefault(ff => ff.ppr == pprr);

                    label2.Text = f.ppr;
                    label4.Text = f.prenom;
                    label5.Text = f.echlant;
                    label7.Text = f.service;
                }
                
            }
            catch (Exception ex)
            {
                guna2MessageDialog1.Icon = (Guna.UI2.WinForms.MessageDialogIcon)MessageBoxIcon.Information;
                guna2MessageDialog1.Show(ex.Message);
                

            }

            //fill dgv

            fillgv();

            //fill dgv


        }
        public void fillgv()
        {

            guna2DataGridView1.DataSource = null;
           guna2DataGridView1.DataSource = gent.Decisions.ToList();
            guna2DataGridView1.Columns.RemoveAt(guna2DataGridView1.ColumnCount - 1);
            guna2DataGridView1.Columns[0].Width = 40;
            guna2DataGridView1.Columns[1].Width = 110;
            guna2DataGridView1.Columns[2].Width = 110;
            guna2DataGridView1.Columns[3].Width = 40;
            guna2DataGridView1.Columns[4].Width = 110;
            guna2DataGridView1.Columns[5].Width = 40;
            guna2DataGridView1.Columns[6].Width = 110;

            ////shape gride
            guna2DataGridView1.Columns[0].HeaderText = "رقم الإستفسار";
            guna2DataGridView1.Columns[1].HeaderText = "بتاريخ";
            guna2DataGridView1.Columns[2].HeaderText = "مصلحة";
            guna2DataGridView1.Columns[3].HeaderText = "أيام إقتطاعات";
            guna2DataGridView1.Columns[4].HeaderText = "بتاريخ";


            guna2DataGridView1.Columns[0].Width = 45;
            guna2DataGridView1.Columns[1].Width = 200;
            guna2DataGridView1.Columns[2].Width = 120;
            guna2DataGridView1.Columns[3].Width = 150;
            guna2DataGridView1.Columns[4].Width = 150;
           
            ///sssss

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Decision d = new Decision();
                d.datestifdsar = guna2DateTimePicker1.Value;
                d.datededure = guna2DateTimePicker2.Value;
                d.iddes = ida;
                d.jourdeduirr = int.Parse(txtjour9t.Text);
                d.numrestifsar = int.Parse(txtstf.Text);
                d.service = comboBox1.Text;
                d.numdesisionktita3 =int.Parse( txtnumbre9tia3.Text);
                d.typedecision = comboBox2.Text;
                
                gent.Decisions.Add(d);

                gent.SaveChanges();

                guna2MessageDialog1.Show("le decision est ajouter");
                fillgv();
            }
            catch (Exception ex)
            {
                ex = new Exception("my mes", ex.InnerException);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int nstf = int.Parse(txtstf.Text);
                fprint fp = new fprint(nstf);
                fp.Show();
            }
            catch (Exception ex)
            {
                guna2MessageDialog1.Show("something was wrong");
                guna2MessageDialog1.Show(ex.Message);
            }
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm1 f = new frm1();
            f.Show();
            this.Hide();
        }

        private void clos_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maxima_Click(object sender, EventArgs e)
        {
            //windoconfiguration.windconfig(this,maxima);
            
        }

        private void minma_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            miseclass.windconfig(this,groupBox1);
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm2_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show(e.Data.ToString());
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           txtstf.Text= guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            guna2DateTimePicker1.Value= (DateTime)guna2DataGridView1.CurrentRow.Cells[1].Value;
            comboBox1.Text= guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtjour9t.Text= guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            guna2DateTimePicker2.Value= (DateTime)guna2DataGridView1.CurrentRow.Cells[4].Value;
            txtnumbre9tia3.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox2.Text = guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
