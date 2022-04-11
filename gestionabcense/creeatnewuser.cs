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
    public partial class creeatnewuser : Form
    {
        public creeatnewuser()
        {
            InitializeComponent();
        }
        gestionabsenceEntities gent = new gestionabsenceEntities();

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                // testuser
                string usert = guna2TextBox1.Text;
                int pass = Convert.ToInt32(guna2TextBox2.Text);


                ObjectParameter cexist = new ObjectParameter("existc", typeof(int));

                gent.testuser(usert, pass, cexist);


                if (int.Parse(cexist.Value.ToString()) == 1)
                {

                   
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog1.Show("infor", "this user elready existed");
                }

                else
                {

                    usere us = new usere();
                    us.username = guna2TextBox1.Text;
                    if (guna2TextBox2.Text == guna2TextBox2.Text)
                    {
                        us.password = int.Parse(guna2TextBox2.Text);

                    }

                    if (guna2CustomCheckBox1.Checked == true)
                    {
                        us.adminn = true;
                    }
                    if (guna2CustomCheckBox1.Checked == false)
                    {
                        us.adminn = false;
                    }
                    gent.useres.Add(us);
                    gent.SaveChanges();
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Show("user added with seccessfully");


                }
                // testuser

                

            }
            catch (Exception ex)
            {
                guna2MessageDialog1.Show(ex.Message);
            }


        }

        private void clos_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miseclass.windconfig(this, groupBox1);
        }

        private void minma_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
        public Boolean siexistthisuser()
        {
            string usert = guna2TextBox1.Text;
            int pass = Convert.ToInt32(guna2TextBox2.Text);


            System.Data.Entity.Core.Objects.ObjectParameter cexist = new ObjectParameter("existc", typeof(int));

            gent.testuser(usert, pass, cexist);


            if (int.Parse(cexist.Value.ToString()) == 1)
            {
                return true;

            }

            else
            {
                return false;


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button3_MouseHover(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;
            btn.BackColor = Color.FromArgb(100, 100, 100);
            
           
        }
    }
}
