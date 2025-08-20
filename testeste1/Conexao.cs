using System;
using MySql.Data.MySqlClient;

namespace testeste1
{
    class Conexao
    {
        // instância é o ato de apelidar algo
        MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=BDProjeto1;user=root;pwd=12345678");

        // a palavra static declara que é uma variável estática, ou seja, ela permanece mesmo mudando a situação, só muda o valor dela.
        public static string msg;
        public MySqlConnection ConnectarBD()
        {
            // try e catch são tratamento de erros
            try
            {
                con.Open();

            }
            catch (Exception error)
            {

                msg = "Ocorreu um erro ao se conectar" + error.Message;
            }
            return con;
        }

        public MySqlConnection DesConnectarBD()
        {
            try
            {
                con.Close();

            }
            catch (Exception error)
            {

                msg = "Ocorreu um erro ao se desconectar" + error.Message;
            }
            return con;
        }
    }
}
