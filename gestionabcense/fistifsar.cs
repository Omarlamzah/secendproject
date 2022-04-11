using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionabcense
{
    public partial class fistifsar : Form
    {
        public fistifsar()
        {
            InitializeComponent();
        }
        
        private void fistifsar_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        public void fillgrid()
        {
            dgva.DataSource = null;
           dgva.DataSource = miseclass.gent.detaille_abs.ToArray();  
             


            //shape gride
            dgva.Columns[0].HeaderText = "idd";
            dgva.Columns[1].HeaderText = "إرسال إستفسار";
            dgva.Columns[2].HeaderText = "تريخ إرسال إستفسار";
            dgva.Columns[3].HeaderText = "جواب عن إستفسار";
            dgva.Columns[4].HeaderText = "وصول إستفسار";
            dgva.Columns[5].HeaderText = "تريخ جواب عن إستفسار";
            dgva.Columns[6].HeaderText = "نوع جواب عن إستفسار";

            dgva.Columns[0].Width = 105;
            dgva.Columns[1].Width = 200;
            dgva.Columns[2].Width = 120;
            dgva.Columns[3].Width = 150;
            dgva.Columns[4].Width = 150;
           

            dgva.Columns.RemoveAt(dgva.Columns.Count - 1);
            dgva.Columns.RemoveAt(dgva.Columns.Count - 1);
            dgva.Columns.RemoveAt(dgva.Columns.Count - 1); 
            dgva.Columns.RemoveAt(dgva.Columns.Count - 1);
            dgva.Columns.RemoveAt(dgva.Columns.Count - 1);



            //shappe gride
        }
        private void button1_Click(object sender, EventArgs e)
        {
            miseclass.windconfig(this,groupBox1);
            miseclass.controlslayout(dgva, this);
        }

        private void minma_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void clos_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CmoveBforms.move1('a');
            CmoveBforms.hideforms(this);
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CmoveBforms.move1('b');
            CmoveBforms.hideforms(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
           infoemploye();
           attributabse(); 
        }
        public void infoemploye()
        {
            try
            { 
                if(dgva.CurrentRow.Cells[dgva.ColumnCount - 1].Value != null) {
                    int idg = (int)dgva.CurrentRow.Cells[dgva.ColumnCount - 1].Value;
                    detaille_abs dd = miseclass.gent.detaille_abs.FirstOrDefault(d => d.idabs == idg);
                    absence abs = dd.absence;
                    fonction fon = abs.fonction;
                    label1.Text = fon.ppr.Trim();
                    label3.Text = fon.nom.Trim() + " " + fon.prenom.Trim();
                    label6.Text = fon.ehelle.Trim();
                
                }
                else
                {
                   
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString());
            }
        }
        string s1;
        string s3;
        string s4;
        DateTime d1;
        DateTime d5;
        string s6;
        public void attributabse()
        {
           
            if ((dgva.CurrentRow.Cells[1].Value)!=null)
            {
                 s1 = dgva.CurrentRow.Cells[1].Value.ToString().Trim();
                radioButton1.Checked = (s1 == "تم إرسال الإستفسار" ? true : false);
                radioButton2.Checked = (s1 == "لم يتم إرسال الإستفسار" ? true : false);
                radioButton1.Enabled = radioButton2.Enabled = false;
            }
            else
            {
                radioButton1.Checked = radioButton2.Checked = false;
                radioButton1.Enabled = radioButton2.Enabled = true;
            }
           

            if (dgva.CurrentRow.Cells[3].Value!=null)
            {
                s3 = dgva.CurrentRow.Cells[3].Value.ToString().Trim();
                radioButton6.Checked = (s3 == "لا يوجد جواب" ? true : false);
                radioButton5.Checked = (s3 == "يوجد جواب" ? true : false);
                radioButton6.Enabled = radioButton5.Enabled = false;
            }
            else
            {
                radioButton6.Checked = radioButton5.Checked = false;
                radioButton6.Enabled = radioButton5.Enabled = true;

            }
            
            if (dgva.CurrentRow.Cells[4].Value!=null)
            {
                 s4 = dgva.CurrentRow.Cells[4].Value.ToString().Trim();
                radioButton3.Checked = (s4 == "وصل" ? true : false);
                radioButton4.Checked = (s4 == "تعذر" ? true : false);
                radioButton3.Enabled= radioButton4.Enabled = false;
            }
            else
            {
                s4 = null;
                radioButton3.Enabled = radioButton4.Enabled = true;
            }
            
            if (dgva.CurrentRow.Cells[2].Value!=null)
            {
                 d1 = (DateTime)dgva.CurrentRow.Cells[2].Value;
                guna2DateTimePicker1.Value = d1;
                guna2DateTimePicker1.Enabled = false;
            }
            else
            {
                d1 = DateTime.Today;
                guna2DateTimePicker1.Enabled = true;
            }


           
            if (dgva.CurrentRow.Cells[5].Value != null)
            {

                 d5 = (DateTime)dgva.CurrentRow.Cells[5].Value;
                guna2DateTimePicker2.Value = d5;
                guna2DateTimePicker2.Enabled = false;
            }
            else
            {
                d5 = DateTime.Today;
                guna2DateTimePicker2.Enabled = true;
            }



            
            if (dgva.CurrentRow.Cells[6].Value!=null)
            {
                 s6 = dgva.CurrentRow.Cells[6].Value.ToString().Trim();
                comboBox1.Text = s6;
               comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
            }
            

        }

        private void dgva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dgva.CurrentRow.Cells[3].Value.ToString().Trim() is null)
            MessageBox.Show(dgva.CurrentRow.Cells[3].Value.ToString().Trim());
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
           



            int iddt = (int)dgva.CurrentRow.Cells[0].Value;
            detaille_abs da = miseclass.gent.detaille_abs.FirstOrDefault(d=>d.iddetaile==iddt);
          
            if(radioButton1.Checked) da.irsalistifsar = "تم إرسال الإستفسار";
            if (radioButton2.Checked) da.irsalistifsar = "لم يتم إرسال الإستفسار";

            da.dateirsalistifsar = guna2DateTimePicker1.Value;
           
           if(radioButton5.Checked) da.reponsestifsar = "لا يوجد جواب";
            if (radioButton6.Checked) da.reponsestifsar = "يوجد جواب";


            if (radioButton3.Checked) da.wosolistifsar = "وصل";
            if (radioButton4.Checked) da.wosolistifsar = "تعذر";
            da.datereponsestifsar = guna2DateTimePicker2.Value;
            da.typedereponse = comboBox1.Text;     
            miseclass.gent.SaveChanges();

            fillgrid();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_MouseHover(object sender, EventArgs e)
        {

            
           

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
            if (radioButton4.Checked)
            {
                comboBox1.Visible = guna2DateTimePicker2.Visible = false;
                comboBox1.Text = "";
                guna2DateTimePicker2.Value =new DateTime(1888,8,8);

            }
            else
            {
                comboBox1.Visible = guna2DateTimePicker2.Visible = true;

            }
        }
    }
}
