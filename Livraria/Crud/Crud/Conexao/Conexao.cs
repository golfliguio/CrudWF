using System;
using System.Collections.Generic;
using System.Text;


using System.Data;
using System.Data.SqlClient;

namespace Crud
{
    public class Conexao
    {
        protected SqlConnection Con;//estabelecer conexao
        protected SqlCommand Cmd;//comandos sql
        protected SqlDataReader Dr;// ler registros query

        //abrir conexao
        protected void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True");//conection string



                Con.Open();//abre o bd
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        protected void FecharConexao()
        {
            try
            {
                Con.Close();//fecha bd
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}