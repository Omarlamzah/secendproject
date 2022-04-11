using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionabcense
{
    class CmoveBforms
    {
    
        public static void  hideforms(Form f1)
        {
            f1.Hide();
           
        }
    public static void move1(char c)
        {
            
            switch (c)
            {
                case 'a':
                    frm1 f = new frm1();
                    f.Show();
                   
                   
                    break;

                case 'b':
                    Frm2 ff = new Frm2();
                    ff.Show();
                   
                    break;

                case 'c':
                    fistifsar fff = new fistifsar();
                   
                    fff.Show();
                    
                    break;
            }

        }
    }
}
