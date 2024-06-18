using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharedDesktop2
{
    public partial class Home : Form
    {
        bool isOpen = false;
        Add add = new Add();
        Delete del = new Delete();


        public Home()
        {
            InitializeComponent();
            this.CenterToScreen();
            
            

        }

        

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            
            if (!isOpen)
            {
                add.MdiParent = this;
                add.Show();
                isOpen = true;
            }
            else
            {
                add.Close();
                isOpen = false;
            }
            

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!isOpen)
            {
                
                del.MdiParent = this;
                del.Show();
                isOpen = true;
            }
            else
            {
                del.Close();
                isOpen = false;
            }
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {

        }
    }
}
