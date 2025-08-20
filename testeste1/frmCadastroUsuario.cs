﻿using System;
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
    public partial class frmCadastroUsuario : Form
    {
        Conexao con = new Conexao();

        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCadUsuario.Text == "" && txtCadSenha.Text == "")
            {
                MessageBox.Show("Os campos não podem estar vazios");
                txtCadUsuario.Focus();
            }
            else
            {

            }
            try
            {
                string sql = "insert into tbLogin(usuario,senha)values(@user,@senha)";
                MySqlCommand cmd = new MySqlCommand (sql,con.ConnectarBD());
                cmd.Parameters.Add("@user",MySqlDbType.VarChar).Value = txtCadUsuario.Text;
                cmd.Parameters.Add("senha", MySqlDbType.VarChar).Value=txtCadSenha.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados cadastrados com sucesso");
/7                con.DesConnectarBD();
            }
                catch(Exception error)
            {
                    MessageBox.Show(error.Message);
            }
        }
    }
}