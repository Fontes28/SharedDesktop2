using MySql.Data.MySqlClient;
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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            if (txtExcluir.Text != "")
            {
                Aluno aluno = new Aluno();
                aluno.excluirAluno(int.Parse(txtExcluir.Text));
                MessageBox.Show("Excluído com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtExcluir.Text = "";
            }
            else
            {
                MessageBox.Show("Digite um RA para excluir!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtExcluir.Text = "";
            }
            txtExcluir.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void txtExcluir_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (e.KeyChar == 13)
            {
                if (txtExcluir.Text == "")
                {
                    MessageBox.Show("Digite um RA para excluir!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int n;
                    bool ehUmNumero = int.TryParse(txtExcluir.Text, out n);
                    if (ehUmNumero)
                    {
                        Aluno con_a = new Aluno();

                        MySqlDataReader r = con_a.consultarAlunoRa(int.Parse(txtExcluir.Text));

                        if (r.Read())
                        {
                            dataGridView1.Rows.Add(r["nome"].ToString(), r["classe"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Aluno não cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        DAO_Conexao.con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Digite um número!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtExcluir.Text = "";
                    }
                }
            }
        }

        private void siticoneGroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluirMonitor_Click(object sender, EventArgs e)
        {
            if (txtExcluirMonitor.Text != "")
            {
                Monitor monitor = new Monitor();
                monitor.excluirMonitor(int.Parse(txtExcluirMonitor.Text));
                MessageBox.Show("Excluído com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Digite um RA para excluir!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtExcluirMonitor.Text = "";
            dataGridViewMonitor.Rows.Clear();
        }

        private void txtExcluirMonitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridViewMonitor.Rows.Clear();
            if (e.KeyChar == 13)
            {
                if (txtExcluirMonitor.Text == "")
                {
                    MessageBox.Show("Digite um RA para excluir!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int n;
                    bool ehUmNumero = int.TryParse(txtExcluirMonitor.Text, out n);
                    if (ehUmNumero)
                    {
                        Monitor con_m = new Monitor();

                        MySqlDataReader r = con_m.consultarMonitorRa(int.Parse(txtExcluirMonitor.Text));

                        if (r.Read())
                        {
                            dataGridViewMonitor.Rows.Add(r["nome"].ToString(), r["area"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Monitor não cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtExcluirMonitor.Text = "";
                        }

                        DAO_Conexao.con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Digite um número!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtExcluirMonitor.Text = "";
                    }
                }
            }
        }

        private void siticoneDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            if (txtExcluirProfessor.Text != "")
            {
                Professor prof = new Professor();
                prof.excluirProfessor(int.Parse(txtExcluirProfessor.Text));
                MessageBox.Show("Excluído com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Digite um NR para excluir!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtExcluirProfessor.Text = "";
            dataGridViewProfessor.Rows.Clear();
        }

        private void txtExcluirProfessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridViewProfessor.Rows.Clear();
            if (e.KeyChar == 13)
            {
                if (txtExcluirProfessor.Text == "")
                {
                    MessageBox.Show("Digite um NR para excluir!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int n;
                    bool ehUmNumero = int.TryParse(txtExcluirProfessor.Text, out n);
                    if (ehUmNumero)
                    {
                        Professor con_p = new Professor();

                        MySqlDataReader r = con_p.consultarProfessor(int.Parse(txtExcluirProfessor.Text));

                        if (r.Read())
                        {
                            dataGridViewProfessor.Rows.Add(r["nome"].ToString(), r["materia"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Professor não cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtExcluirProfessor.Text = "";
                        }

                        DAO_Conexao.con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Digite um número!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtExcluirProfessor.Text = "";
                    }
                }
            }
        }

        private void btnExcluirDir_Click(object sender, EventArgs e)
        {
            if (txtExcluirDir.Text != "")
            {
                Diretor diretor = new Diretor();
                diretor.excluirDiretor(int.Parse(txtExcluirDir.Text));
                MessageBox.Show("Excluído com sucesso! ", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Digite um NR para excluir!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtExcluirDir.Text = "";
            dataGridViewDir.Rows.Clear();
        }

        private void txtExcluirDir_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridViewDir.Rows.Clear();
            if (e.KeyChar == 13)
            {
                if (txtExcluirDir.Text == "")
                {
                    MessageBox.Show("Digite um NR para excluir!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int n;
                    bool ehUmNumero = int.TryParse(txtExcluirDir.Text, out n);
                    if (ehUmNumero)
                    {
                        Diretor con_d = new Diretor();

                        MySqlDataReader r = con_d.consultarDiretorNr(int.Parse(txtExcluirDir.Text));

                        if (r.Read())
                        {
                            dataGridViewDir.Rows.Add(r["nome"].ToString(), r["cargo"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Diretor não cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtExcluirDir.Text = "";
                        }

                        DAO_Conexao.con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Digite um número!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtExcluirDir.Text = "";
                    }
                }
            }
        }

        private void btnExcluirAdm_Click(object sender, EventArgs e)
        {
            if (txtExcluirAdm.Text != "")
            {
                Administrador admin = new Administrador();
                admin.excluirAdministrador(int.Parse(txtExcluirAdm.Text));
                MessageBox.Show("Excluído com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtExcluirAdm.Text = "";
            }
            else
            {
                MessageBox.Show("Digite um NR para excluir!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtExcluirAdm.Text = "";
            }
            txtExcluirAdm.Text = "";
            dataGridViewAdm.Rows.Clear();
        }

        private void txtExcluirAdm_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridViewAdm.Rows.Clear();

            if (e.KeyChar == 13)
            {
                if (txtExcluirAdm.Text == "")
                {
                    MessageBox.Show("Digite um NR para excluir!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int n;
                    bool ehUmNumero = int.TryParse(txtExcluirAdm.Text, out n);
                    if (ehUmNumero)
                    {
                        Administrador con_a = new Administrador();

                        MySqlDataReader r = con_a.consultarAdministradorNr(int.Parse(txtExcluirAdm.Text));

                        if (r.Read())
                        {
                            dataGridViewAdm.Rows.Add(r["nome"].ToString(), r["cargo"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Administrador não cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        DAO_Conexao.con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Digite um número!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtExcluirAdm.Text = "";
                    }
                }
            }
        }
    }
}
