using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel.Controller
{
    class Conexao
    {

        protected SqlConnection Con;//estabelece conexao
        protected SqlCommand Cmd; // comandos sql
        protected SqlDataReader Dr; // ler do banco


        protected void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True");//conection string
                //string de conexão com o banco de Dados

                Con.Open();
                //abre conexão com o bd

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        //abrir conexao


        protected void FecharConexao()
        {
            try
            {
                Con.Close();
                //fecha conexao com o banco
            }
            catch (Exception ex)
            {

                throw new Exception (ex.Message);
            }
        }
        
    }
}
