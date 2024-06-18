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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblAreaProfessor_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRa.Text == "")
                {
                    MessageBox.Show("Digite um RA!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int ra = int.Parse(txtRa.Text);
                    Aluno aluno = new Aluno(txtName.Text, txtRg.Text, dateAluno.Text, txtTel.Text, txtEmail.Text, ra, 0);
                    if ((txtRa.Text == "") || (txtName.Text == "") || (txtRg.Text == "") || (txtTel.Text == "") || (txtEmail.Text == "") || (dateAluno.Text == ""))
                    {
                        MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        if (aluno.cadastrarAluno())
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtName.Text = "";
                            txtRg.Text = "";
                            dateAluno.Text = "";
                            txtTel.Text = "";
                            txtEmail.Text = "";
                            txtRa.Text = "";
                            txtName.Enabled = false;
                            txtRg.Enabled = false;
                            dateAluno.Enabled = false;
                            txtTel.Enabled = false;
                            txtEmail.Enabled = false;
                        }
                        else
                            MessageBox.Show("Erro no cadastro!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dateAluno_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarMonitor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRaMonitor.Text == "")
                {
                    MessageBox.Show("Digite um RA!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int ra = int.Parse(txtRaMonitor.Text);
                    Monitor monitor = new Monitor(txtNameMonitor.Text, txtRgMonitor.Text, txtDateMonitor.Text, txtTelMonitor.Text, txtEmailMonitor.Text, cbxArea.Text, ra, 0);
                    if ((txtRaMonitor.Text == "") || (cbxSerie.Text == "") || (txtNameMonitor.Text == "") || (txtRgMonitor.Text == "") || (txtTelMonitor.Text == "") || (txtEmailMonitor.Text == "") || (txtDateMonitor.Text == "") || (cbxArea.Text == ""))
                    {
                        MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        if (cbxSerie.Text.Equals("2° ano"))
                        {
                            monitor.Serie = 2;
                        }
                        else if (cbxSerie.Text.Equals("3° ano"))
                        {
                            monitor.Serie = 3;
                        }
                        else
                        {
                            monitor.Serie = 4;
                        }
                        if (monitor.cadastrarMonitor())
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNameMonitor.Text = "";
                            txtRgMonitor.Text = "";
                            cbxSerie.Text = "";
                            txtDateMonitor.Text = "";
                            txtTelMonitor.Text = "";
                            txtEmailMonitor.Text = "";
                            cbxArea.Text = "";
                            txtRaMonitor.Text = "";
                            txtNameMonitor.Enabled = false;
                            txtRgMonitor.Enabled = false;
                            cbxSerie.Enabled = false;
                            txtDateMonitor.Enabled = false;
                            txtTelMonitor.Enabled = false;
                            txtEmailMonitor.Enabled = false;
                            cbxSerie.Enabled = false;
                        }
                        else
                            MessageBox.Show("Erro no cadastro!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtRaMonitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtRaMonitor.Text == "")
                {
                    MessageBox.Show("Digite um RA!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int n;
                    bool ehUmNumero = int.TryParse(txtRaMonitor.Text, out n);
                    if (ehUmNumero)
                    {
                        Aluno a = new Aluno(int.Parse(txtRaMonitor.Text));
                        if (a.consultarAluno())
                        {
                            Monitor monitor = new Monitor(int.Parse(txtRaMonitor.Text));
                            bool existeAluno = monitor.consultarAlunoparaMonitor(int.Parse(txtRaMonitor.Text));
                            bool existeMonitor = monitor.consultarMonitor();
                            if (!monitor.consultarAlunoTurmaparaMonitor(int.Parse(txtRaMonitor.Text)))
                            {
                                MessageBox.Show("É necessário que o aluno esteja vinculado a uma turma!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtRaMonitor.Text = "";
                            }
                            else
                            {
                                if (existeAluno)
                                {
                                    if (!existeMonitor)
                                    {
                                        Aluno aluno = new Aluno(int.Parse(txtRaMonitor.Text));
                                        MySqlDataReader dr = aluno.consultarAluno02();
                                        if (dr.Read())
                                        {
                                            txtNameMonitor.Text = dr["nome"].ToString();
                                            txtRgMonitor.Text = dr["rg"].ToString();
                                            cbxSerie.Text = string.Concat(dr["classe"].ToString() + "° ano");
                                            txtDateMonitor.Text = dr["dataNascimento"].ToString();
                                            txtTelMonitor.Text = dr["celular"].ToString();
                                            txtEmailMonitor.Text = dr["emailInstitucional"].ToString();
                                            cbxArea.Enabled = true;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Esse monitor já foi cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        txtRaMonitor.Text = "";
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("É necessário que o aluno esteja cadastrado nas séries adequadas!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtRaMonitor.Text = "";
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("É necessário que o aluno esteja cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtRaMonitor.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite um número!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtRaMonitor.Text = "";
                    }
                }

                DAO_Conexao.con.Close();

            }
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }
    }
}
