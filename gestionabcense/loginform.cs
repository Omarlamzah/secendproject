using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionabcense
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
            
            guna2TextBox2.UseSystemPasswordChar = true;
            progressBar1.Style = ProgressBarStyle.Marquee;
           
        }

        private void guna2HtmlToolTip1_Popup(object sender, PopupEventArgs e)
        {
           
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        gestionabsenceEntities gent = new gestionabsenceEntities();
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
            loginfunc();
            


        }
        public void userlogin()
        {
            frm1 f = new frm1();


            f.Show();

            this.Hide();
        }

        public void progressbartest()
        {
            for (int i = 0; i < 100; i = i + 10)
            {
                Thread.Sleep(200);
                progressBar1.Value = i;
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string user = guna2TextBox1.Text;
                int ps = int.Parse(guna2TextBox2.Text);
                ObjectParameter siadmin = new ObjectParameter("existc", typeof(int));//somthing happend here

                gent.ifuserisADMIN(user, ps, siadmin);

                if (int.Parse(siadmin.Value.ToString()) == 1)
                {
                    creeatnewuser f = new creeatnewuser();
                    f.Show();
                    this.Hide();
                }

                else if (int.Parse(siadmin.Value.ToString()) != 1)
                {

                    string usert = guna2TextBox1.Text;
                    int pass = Convert.ToInt32(guna2TextBox2.Text);


                    ObjectParameter cexist = new ObjectParameter("existc", typeof(int));

                    gent.testuser(usert, pass, cexist);


                    if (int.Parse(cexist.Value.ToString()) == 1)
                    {

                        guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                        guna2MessageDialog1.Show("do not have permission to add user ar login error");


                    }





                }

                else
                {
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog1.Show("error", "incorect forma in input text");

                }



                // si user name not exist

                // si user name not exist



            }
            catch (Exception ex)
            {
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("error", "incorect passeword or username or both");


            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       public  void loginfunc()
        {
            try
            {
                string usert = guna2TextBox1.Text;
                int pass = Convert.ToInt32(guna2TextBox2.Text);


                ObjectParameter cexist = new ObjectParameter("existc", typeof(int));

                gent.testuser(usert, pass, cexist);


                if (int.Parse(cexist.Value.ToString()) == 1)
                {
                    this.Cursor = Cursors.AppStarting;
                    progressbartest();
                    userlogin();


                }

                else
                {
                    label3.Visible = true;
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog1.Show("error", "incorect passeword or username or both");



                }
            }
            catch (Exception ex)
            {
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog1.Show("error systeme", ex.Message);

            }
            finally
            {
                guna2TextBox1.Focus();
            }




        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
           

           
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            guna2TextBox2.UseSystemPasswordChar = false;

            Thread.Sleep(1000);
           
            guna2TextBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressbartest();
          
        }

        private void loginform_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void guna2GradientButton1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
           
        }

        private void loginform_KeyDown(object sender, KeyEventArgs e)
        {
            
            
        }

        private void loginform_MouseLeave(object sender, EventArgs e)
        {
          

        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void guna2TextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginfunc();
            }
        }

        private void guna2TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginfunc();
            }
        }
    }
}
