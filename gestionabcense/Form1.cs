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

namespace absence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        gestionabsenceEntities2 gent = new gestionabsenceEntities2();
        Boolean just;



        private void button1_Click(object sender, EventArgs e)
        {
           



        }
        public fonction rechercher(string pprf)
        {
            fonction f = gent.fonction.FirstOrDefault(x => x.ppr == pprf);
            return f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            misdgv();
            
            
        }

        public void misdgv()
        {
            dgv.DataSource = null;
            dgv.DataSource = gent.absence.ToList();
            dgv.Columns.RemoveAt(dgv.Columns.Count - 1);

            guna2DataGridView2.DataSource = gent.absence.ToList();
            guna2DataGridView2.Columns.RemoveAt(dgv.Columns.Count - 1);






        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void infoabs(){
            textBox1.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            guna2DateTimePicker1.Value= (DateTime)dgv.CurrentRow.Cells[2].Value;
            if(dgv.CurrentRow.Cells[3].Value.ToString() == "True")
            {
                radioButton1.Checked = true;
            }
            if (dgv.CurrentRow.Cells[3].Value.ToString() == "False")
            {
                radioButton2.Checked = true;
            }


           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            infoabs();
        }

        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            infoabs();
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = (int)dgv.CurrentRow.Cells[0].Value;
           

            Form2 form = new Form2(id);
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            infoabs();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            
            
            
          int id = (int)dgv.CurrentRow.Cells[0].Value;


            Form2 form = new Form2(id);
            form.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string ppf = dgv.CurrentRow.Cells[1].Value.ToString();
                int idf = (int)dgv.CurrentRow.Cells[0].Value;

                absence ab = gent.absence.FirstOrDefault(a => a.id == idf);


                fonction ff = rechercher(ppf);
                string strms = "le ppr est " + ff.ppr.ToString() + " le nom complet est " + "\n" + ff.nom + " " + ff.prenom + "\n" + "ID est" + idf + " le service est " + ff.service;
                DialogResult res = MessageBox.Show(strms, "suppremer", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (res == DialogResult.OK)
                {
                    gent.absence.Remove(ab);
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



            if (radioButton1.Checked)
            {
                just = true;
            }
            if (radioButton2.Checked)
            {
                just = false;
            }
            ab.justifie = just;


            try
            {
                string msg;
                fonction f = rechercher(textBox1.Text);
                msg = "le person " + f.nom + " " + f.prenom + "\n" + "le ppr est " + f.ppr + "voulez vous ajouter";


                DialogResult rs = MessageBox.Show(msg, "ajouter", MessageBoxButtons.OKCancel);

                if (rs == DialogResult.OK)
                {
                    
                   siexisteab = virfabsenceexiste(textBox1.Text, guna2DateTimePicker1.Value);
                    if (siexisteab == true) {
                        gent.absence.Add(ab);

                        gent.SaveChanges();
                        MessageBox.Show("absenet is added seccssful");
                    }
                    else
                    {
                        MessageBox.Show("absenet does not added this is an absenct like that");
                    }
                  
                }
                else { MessageBox.Show("absenet is not  added you pressed cancel button "); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("this person is not exist in fonction table");
                MessageBox.Show(ex.Message);
            }



        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
           

        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            guna2DateTimePicker1.Value = (DateTime)dgv.CurrentRow.Cells[2].Value;
            if (dgv.CurrentRow.Cells[3].Value.ToString() == "True")
            {
                radioButton1.Checked = true;
            }
            if (dgv.CurrentRow.Cells[3].Value.ToString() == "False")
            {
                radioButton2.Checked = true;
            }



        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        
        public Boolean virfabsenceexiste(string ppra ,DateTime datab)
        {
            ObjectParameter nbaboutp = new ObjectParameter("nc", typeof(int));
            
            gent.virifiePROC(ppra, datab, nbaboutp);

          

            if (int.Parse(nbaboutp.Value.ToString()) == 0)
            { 
                MessageBox.Show("11");
                return true;
            }
            else
            {
                return false;
            }

            
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
