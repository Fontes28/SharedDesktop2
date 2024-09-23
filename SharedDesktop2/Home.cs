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
        
        Delete del = new Delete();


        public Home()
        {
            InitializeComponent();
            this.CenterToScreen();
            
            

        }

        

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Add add = new Add(0);

            if ((Application.OpenForms.OfType<Add>().Count() == 0) && (Application.OpenForms.OfType<Delete>().Count() == 0))
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
          
                
                del.MdiParent = this;
                del.Show();
                isOpen = true;
            
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Add upd = new Add(1);

            if ((Application.OpenForms.OfType<Add>().Count() == 0) && (Application.OpenForms.OfType<Delete>().Count() == 0))
            {
                upd.MdiParent = this;
                upd.Show();
                isOpen = true;
            }
            else
            {
                upd.Close();
                isOpen = false;
            }

        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
           
            LoginForm lgn = new LoginForm();
            lgn.Show();
            this.Close();
        }
    }
}
