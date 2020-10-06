using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roosevelt_Solutions
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_logomenu_Click(object sender, EventArgs e)
        {
            if (panelmenu.Width == 320)
            {
                panelmenu.Width = 107;
            }
            else
                panelmenu.Width = 320; 
        }
    }
}
