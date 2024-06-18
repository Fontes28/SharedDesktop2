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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            if (DAO_Conexao.getConexao("143.106.241.3", "cl202239", "cl202239", "@marip.864_frozen0905"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de conexão");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home homeScreen = new Home();
            homeScreen.Show();
        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.verLogin(txtUser.Text, txtPass.Text);
            if (tipo == 0)
                MessageBox.Show("Usuário/Senha inválidos", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Home homeScreen = new Home();
                homeScreen.Show();
                this.Hide();

            }
        }
    }
}
