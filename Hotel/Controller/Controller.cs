using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


using Hotel.Model;

namespace Hotel.Controller
{
    class Controller:Conexao
    {

       

        public void Gravar(Hospede H)
        {
            try
            {
                //abrir conexao

                AbrirConexao();

                Cmd = new SqlCommand("insert into Hospede(Codigo,Nome,Telefone,Endereco,Dias) values (@v1,@v2,@v3,@v4,@v5)", Con);

                Cmd.Parameters.AddWithValue("@v1", H.Codigo);
                Cmd.Parameters.AddWithValue("@v2",H.Nome);
                Cmd.Parameters.AddWithValue("@v3",H.Telefone);
                Cmd.Parameters.AddWithValue("@v4",H.Endereco);
                Cmd.Parameters.AddWithValue("@v5", H.Dias);
                Cmd.ExecuteNonQuery();//executa o metodo
                //grava dados no bd
            }
            catch (Exception ex)
            {

                throw new Exception(" - Erro ao gravar  Hospede - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }    //gravar dados : insert


        public void Atualizar(Hospede H) //update
        {
            try
            {
                AbrirConexao();


                Cmd = new SqlCommand("update Hospede set Nome=  @v1, Telefone= @v2, Endereco= @v3, Dias = @v4 where Codigo= @v5", Con);

                Cmd.Parameters.AddWithValue("@v1",H.Nome);
                Cmd.Parameters.AddWithValue("@v2",H.Telefone);
                Cmd.Parameters.AddWithValue("@v3",H.Endereco);
                Cmd.Parameters.AddWithValue("@v4",H.Dias);
                Cmd.Parameters.AddWithValue("@v5",H.Codigo);
                Cmd.ExecuteNonQuery();//atualiza daados do cliente
            }
            catch (Exception ex)
            {

                throw new Exception(" - Erro ao atualizar Hospede - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Excluir(int Codigo)//delete
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("delete  from Hospede where Codigo = @v1", Con);//exclui dados do hospede de acordo com o  codigo informado


                Cmd.Parameters.AddWithValue("@v1", Codigo);


                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception(" - Erro ao excluir o Hospede Cadastrado - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Hospede PesquisarPorCodigo(int Codigo)//obter pessoa por codigo - chave primaria
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("select * from Hospede where Codigo = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Dr = Cmd.ExecuteReader();//execuçao da leitura do bd

                Hospede H = null;//cria ponteiro

                if (Dr.Read())
                {
                    H = new Hospede();

                    H.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    H.Nome = Convert.ToString(Dr["Nome"]);
                    H.Telefone = Convert.ToInt32(Dr["Telefone"]);
                    H.Endereco = Convert.ToString(Dr["Endereco"]);
                    H.Dias = Convert.ToInt32(Dr["Dias"]);
                }

                return H;
                

            }
            catch (Exception ex)
            {

                throw new Exception(" - Código não encontrado - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Hospede> Listar()  //listar todos clientes cadastrados
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("select * from Hospede", Con);//seleciona todos no BD

                Dr = Cmd.ExecuteReader();

                List<Hospede> lista = new List<Hospede>();//lista vazia

                while (Dr.Read())
                {
                    

                    Hospede H = new Hospede();

                    H.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    H.Nome = Convert.ToString(Dr["Nome"]);
                    H.Telefone = Convert.ToInt32(Dr["Telefone"]);
                    H.Endereco = Convert.ToString(Dr["Endereco"]);
                    H.Dias = Convert.ToInt32(Dr["Dias"]);

                    lista.Add(H);// RETORNA DADOS DO BD
                }
                return lista;


            }
            catch (Exception ex)
            {

                throw new Exception(" - Não foi possivel Listar os clientes cadastrados -- verifique o armazenamento do banco! - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }


    }
}
