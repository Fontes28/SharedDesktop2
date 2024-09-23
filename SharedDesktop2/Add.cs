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
        int ident = -1;
        public Add()
        {
            InitializeComponent();

        }
        public Add(int i)
        {
            ident = i;
            InitializeComponent();
            this.CenterToParent();
            if(i==0)
            {
                btnAtualizarAluno.Visible = false;
                lblAttAluno.Visible = false;
                switchAtivoAluno.Visible = false;
                btnAtualizarMonitor.Visible = false;
                lblAttMonitor.Visible = false;
                switchAtualizarMonitor.Visible = false;
                btnAtualizarProfessor.Visible = false;
                lblAttProf.Visible = false;
                switchAtualizarProfessor.Visible = false;
                btnAtualizarDir.Visible = false;
                lblAtualizarDir.Visible = false;
                switchAtualizarDir.Visible = false;
                btnAtualizarAdm.Visible = false;
                lblAttAdm.Visible = false;
                switchAtualizarAdm.Visible = false;
            }
            else if(i==1)
            {
                btnRegister.Visible = false;
                btnCadastrarMonitor.Visible = false;
                btnCadastrarProfessor.Visible = false;
                btnCadastrarDir.Visible = false;
                btnCadastrarAdm.Visible = false;
                tabAluno.Text = "Atualizar Aluno";
                tabMonitor.Text = "Atualizar Monitor";
                tabProfessor.Text = "Aatualizar Professor";
                tabDiretor.Text = "Atualizar Diretor";
                tabAdmin.Text = "Atualizar Administrador";
                
            }

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

        private void siticoneGroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizarAluno_Click(object sender, EventArgs e)
        {

        }

        private void txtRa_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnCadastrarAdm_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNrProfessor.Text == "")
                {
                    MessageBox.Show("Digite um NR!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int nr = int.Parse(txtNrProfessor.Text);
                    Professor prof = new Professor(txtNameProfessor.Text, txtRg.Text, cbxAreaProfessor.Text, txtTelProfessor.Text, txtEmail.Text, nr);
                    if ((txtNrProfessor.Text == "") || (cbxAreaProfessor.Text == "") || (txtNameProfessor.Text == "") || (txtRg.Text == "") || (txtTelProfessor.Text == "") || (txtEmail.Text == ""))
                    {
                        MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (prof.cadastrarProfessor())
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNameProfessor.Text = "";
                            txtRg.Text = "";
                            txtTelProfessor.Text = "";
                            txtEmail.Text = "";
                            txtRg.Text = "";
                            txtNrProfessor.Text = "";
                            cbxAreaProfessor.Text = "";
                            txtNameProfessor.Enabled = false;
                            txtRg.Enabled = false;
                            txtTelProfessor.Enabled = false;
                            txtEmail.Enabled = false;
                            txtRg.Enabled = false;
                            cbxAreaProfessor.Enabled = false;
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

        private void btnCadastrarDir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNrDiretor.Text == "")
                {
                    MessageBox.Show("Digite um NR!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int ra = int.Parse(txtNrDiretor.Text);
                    Diretor diretor = new Diretor(txtNomeDiretor.Text, txtRgDir.Text, txtEmail.Text, cbxCargoDiretor.Text, txtTelDiretor.Text, ra);
                    if ((txtNrDiretor.Text == "") || (cbxCargoDiretor.Text == "") || (txtNomeDiretor.Text == "") || (txtRgDir.Text == "") || (txtTelDiretor.Text == "") || (txtEmail.Text == "") || (txtSenhaDir.Text == ""))
                    {
                        MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (diretor.cadastrarDiretor())
                        {
                            int tipo = 2;
                            DAO_Conexao.CadLogin(txtNomeDiretor.Text, txtSenhaDir.Text, tipo);
                            MessageBox.Show("Cadastro realizado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNomeDiretor.Text = "";
                            txtRgDir.Text = "";
                            cbxCargoDiretor.Text = "";
                            txtTelDiretor.Text = "";
                            txtEmail.Text = "";
                            txtRgDir.Text = "";
                            txtNrDiretor.Text = "";
                            txtSenhaDir.Text = "";
                            txtNomeDiretor.Enabled = false;
                            txtRgDir.Enabled = false;
                            cbxCargoDiretor.Enabled = false;
                            txtTelDiretor.Enabled = false;
                            txtEmail.Enabled = false;
                            txtRgDir.Enabled = false;
                            txtSenhaDir.Enabled = false;
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
    }
}
