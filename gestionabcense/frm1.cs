using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gestionabcense
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }
        gestionabsenceEntities gent = new gestionabsenceEntities();
        
        private void frm1_Load(object sender, EventArgs e)
        {
            
            misdgv();
            guna2Button1.Cursor = Cursors.Hand;
            btnajodesision.Cursor = Cursors.Hand;
            btnajouter.Cursor = Cursors.Hand;
            btnsuppremer.Cursor = Cursors.Hand;
            btnsuppremer.Cursor = Cursors.Hand;
            btnmodifie.Cursor = Cursors.Hand;
            btnmodifie.Cursor = Cursors.Hand;


            for (int i = 1999; i <= DateTime.Today.Year; i++) {
                comboBox1.Items.Add(i);
            }




        }
        public void infoabs()
        {
            textBox1.Text = dgvabs.CurrentRow.Cells[1].Value.ToString();
            guna2DateTimePicker1.Value = (DateTime)dgvabs.CurrentRow.Cells[2].Value;

            


        }

        public fonction rechercher(string pprf)
        {
            fonction f = gent.fonctions.FirstOrDefault(x => x.ppr == pprf);
            return f;
        }
        public void misdgv()
        {
            dgvabs.DataSource = null;
            dgvabs.DataSource = gent.absences.ToList(); 
            dgvabs.RightToLeft = RightToLeft.Yes;
            dgvabs.Columns.RemoveAt(dgvabs.Columns.Count - 1);
            dgvabs.Columns.RemoveAt(dgvabs.Columns.Count - 1);
            dgvabs.Columns.RemoveAt(dgvabs.Columns.Count - 1);
            dgvabs.Columns[2].HeaderText = "تريخ الغياب";

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string ppf = dgvabs.CurrentRow.Cells[1].Value.ToString();
                int idf = (int)dgvabs.CurrentRow.Cells[0].Value;

                absence ab = gent.absences.FirstOrDefault(a => a.id == idf);


                fonction ff = rechercher(ppf);
                string strms = "le ppr est " + ff.ppr.ToString() + " le nom complet est " + "\n" + ff.nom + " " + ff.prenom + "\n" + "ID est" + idf + " le service est " + ff.service;
                DialogResult res = MessageBox.Show(strms, "suppremer", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (res == DialogResult.OK)
                {
                    gent.absences.Remove(ab);
                    gent.SaveChanges();
                    MessageBox.Show("remove with seccsussfully");
                    misdgv();
                }
                else
                {
                    MessageBox.Show("does not remove try again");
                    misdgv();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Boolean siexisteab;
            absence ab = new absence();
            ab.ppr = textBox1.Text;
            ab.dateabsence = guna2DateTimePicker1.Value;



            try
            {
                string msg;
                if (virfExistTfon(textBox1.Text))
                {
                    fonction f = rechercher(textBox1.Text);
                    msg = "le person " + f.nom + " " + f.prenom + "\n" + "le ppr est " + f.ppr + "voulez vous ajouter";
                    DialogResult rs = MessageBox.Show(msg, "ajouter", MessageBoxButtons.OKCancel);
                    if (rs == DialogResult.OK)
                    {

                        siexisteab = virfabsenceexiste(textBox1.Text, guna2DateTimePicker1.Value);


                        if (siexisteab == true)
                        {
                            gent.absences.Add(ab);

                            gent.SaveChanges();
                            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                            guna2MessageDialog1.Show("إضافة","تمت الإضافة بنجاح");
                            misdgv();
                        }
                        else
                        {
                            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                            guna2MessageDialog1.Show("فشل الإضافة هناك متغيب يشبه هذا الشخص ");
                        }

                    }
                    else { MessageBox.Show("(cancel)لقد ضغطت على الزر إلغاء "); }
                }

                else
                {
                    guna2MessageDialog1.Show("(PPR) لا يوجد شخص يمتلك هذا رقم تعريف ", "messeage");
                }

               

               
            }
            catch (Exception ex)
            {
                guna2MessageDialog1.Show("this person is not exist in fonction table");
                guna2MessageDialog1.Show(ex.Message);
            }




        }
        public Boolean virfabsenceexiste(string ppra, DateTime datab)
        {
           
            Boolean ex;
           ObjectParameter nbaboutp = new ObjectParameter("nab", typeof(int));
           
           gent.virifiePROC(ppra, datab, nbaboutp);
          
            

            if (int.Parse(nbaboutp.Value.ToString()) == 0)
            {
               
                ex= true;
            }
            else
            {
                ex= false;
            }
            return ex;

        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            infoabs();
            infofon();

        }
        public void infofon()
        {
            string p = dgvabs.CurrentRow.Cells[1].Value.ToString();
            fonction f = gent.fonctions.FirstOrDefault(a => a.ppr == p);
            label13.Text = f.ppr;
            label14.Text = f.nom;
            label15.Text = f.prenom;
            label16.Text = f.ehelle;

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            try
            {
                int id = (int)dgvabs.CurrentRow.Cells[0].Value;


                Frm2 form = new Frm2(id);
                form.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                guna2MessageDialog1.Show(ex.Message);
            }
           
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        Boolean jus;
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            

            if (virfExistTfon(textBox1.Text))
            {
                int id = (int)(dgvabs.CurrentRow.Cells[0].Value);
                DateTime da = guna2DateTimePicker1.Value;
                absence ab = gent.absences.FirstOrDefault(s => s.id == id);



                string tpr = textBox1.Text;

                ab.ppr = tpr;
                ab.dateabsence = da;
                
                misdgv();
                gent.SaveChanges();
            }
            else {
                guna2MessageDialog1.Icon = (Guna.UI2.WinForms.MessageDialogIcon)MessageBoxIcon.Exclamation;
                guna2MessageDialog1.Show("there no person like this ppr", "message");
            }

        }
        List<absence> absglobal;
        List<absence> absppr = null;
       
        List<absence> abinyear=null;
        List<absence> abdedate =null;

        List<absence> abindate = null;

        
        public void guna2Button1_Click_1(object sender, EventArgs e)
        {
            recherche();
            
        }
        public void recherche()
        {





            absglobal = gent.absences.Where(id => id.id == 0).ToList();

            if (sheckbppr.Checked)
            {
                absppr = gent.absences.Where(a => a.ppr == textBox2.Text).ToList();
                absglobal.AddRange(absppr);
            }






            if (checkbdate1.Checked)
            {

                int dtyear = int.Parse(comboBox1.Text);
                abinyear = gent.absences.Where(d => d.dateabsence.Value.Year == dtyear).ToList();
                absglobal.AddRange(abinyear);
            }


            if (checkbdateenre.Checked)
            {
                DateTime d1 = dtmpdate1.Value;
                DateTime d2 = dtmpdat2.Value;
                abdedate = gent.absences.Where(ee => ee.dateabsence > d1 && ee.dateabsence < d2).ToList();
                absglobal.AddRange(abdedate);
            }



            if (indtckpx.Checked == true)
            {
                string dsform = dtpindate.Value.ToShortDateString();
                DateTime dt = Convert.ToDateTime(dsform);
                abindate = gent.absences.Where(q => q.dateabsence == dt).ToList();
                absglobal.AddRange(abindate);
            }

            if (indtckpx.Checked == false && checkbdateenre.Checked == false && checkbdate1.Checked == false && sheckbppr.Checked == false)
            {
                absglobal = gent.absences.ToList();
            }


            dgvabs.DataSource = absglobal;
            dgvabs.Columns.RemoveAt(dgvabs.ColumnCount - 1);
            dgvabs.Columns.RemoveAt(dgvabs.ColumnCount - 1);
            dgvabs.Columns.RemoveAt(dgvabs.ColumnCount - 1);
            label8.Text = dgvabs.RowCount.ToString();
        }

        public Boolean virfExistTfon(string p) {

            Boolean pe;
            ObjectParameter con = new ObjectParameter("nab", typeof(int));
            gent.virifieppr(p, con);

            if (int.Parse(con.Value.ToString()) == 1)
            {
                pe= true;
            }
            else
            {
                pe= false;
            }

            return pe;







        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            
           
            Application.Exit();
        }

        private void minma_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miseclass.windconfig(this, groupBox1);
            
            miseclass.controlslayout(dgvabs, this);
            miseclass.controlslayout(guna2GroupBox1, this);
        }
       
        private void frm1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void frm1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frm1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void frm1_MouseUp(object sender, MouseEventArgs e)
        {
            
    }
       
        private void mousedown(object sender, MouseEventArgs e)
        {
            

        }

        
        private void mousemove(object sender, MouseEventArgs e)
        {
           
        }

        private void frm1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void guna2Button2_Click_2(object sender, EventArgs e)
        {
            int id = (int)dgvabs.CurrentRow.Cells[0].Value;
            DateTime dt = (DateTime)dgvabs.CurrentRow.Cells[2].Value;
            fps f = new fps(id,dt);
            f.ShowDialog();
        }

        private void guna2Button1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
       
        private void frm1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
           
        }

        private void sheckbppr_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void checkbjustifie_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void guna2GroupBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
       
        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CmoveBforms.move1('c');

            CmoveBforms.hideforms(this);


        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CmoveBforms.move1('b');
            CmoveBforms.hideforms(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void checkbjustifie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            Guna.UI2.AnimatorNS.Animation an = new Guna.UI2.AnimatorNS.Animation();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
