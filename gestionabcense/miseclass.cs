using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna;
using System.Drawing;


namespace gestionabcense
{
   public class miseclass
    {

        public static gestionabsenceEntities gent = new gestionabsenceEntities();

        public static void controlslayout(Control c,Form f)
        { 
            
            if (f.WindowState == FormWindowState.Normal) c.Width =600;
           if (f.WindowState==FormWindowState.Maximized) { c.Width = (f.Width) - 500; }
            if (c.Name == "dgva") c.Width = f.Width - 30;




        }


        public static void windconfig(Form f,Control b)
        {
            if (f.WindowState == FormWindowState.Normal)
            {
                f.WindowState = FormWindowState.Maximized;
                b.Left = f.Width - 120;
                b.Cursor = Cursors.Hand;
            
            }
            else
            { 
                f.WindowState = FormWindowState.Normal;
                b.Left = f.Width - 120;
                b.Cursor = Cursors.Hand;

            }
        }
    }
}
