using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace testeste1
{
    public partial class frmLogin : Form
    {
        // Instanciando a string de conexão
        Conexao con = new Conexao();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuário_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuário.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Usuário e senha inválido");
            }
            try
            {
                string sql = "select * from tbLogin where usuario = @user and senha = @senha";
                MySqlCommand cmd = new MySqlCommand(sql,con.ConnectarBD());

                // As linhas abaixo representa a criação de um user e senha
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUsuário.Text;
                cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value=txtSenha.Text;

                MySqlDataReader dados;
                dados = cmd.ExecuteReader();

                if (dados.HasRows) 
                {
                    MessageBox.Show("Seja bem-vindo ao sistema");
                    frmMenu menu = new frmMenu();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    txtUsuário.Clear();
                    txtSenha.Clear();
                    txtUsuário.Focus();
                }
            } 
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                con.DesConnectarBD();
            }
        }

        private void btnMostrarSenha_Click(object sender, EventArgs e)
        {
        
        }
    }
}
