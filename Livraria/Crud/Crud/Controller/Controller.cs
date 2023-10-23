using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Crud
{
    class Controller : Conexao
    {
        public void Gravar(Livro l)
        {
            try
            {
                //abrir conexao

                AbrirConexao();

                Cmd = new SqlCommand("insert into Livro(Titulo,Autor,Lancamento) values (@v1,@v2,@v3)", Con);

                Cmd.Parameters.AddWithValue("@v1", l.Titulo );
                Cmd.Parameters.AddWithValue("@v2", l.Autor );
                Cmd.Parameters.AddWithValue("@v3", l.Lancamento);

                Cmd.ExecuteNonQuery();//executa o metodo
                //grava dados no bd
            }
            catch (Exception ex)
            {

                throw new Exception(" - Erro ao gravar  Livro - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }    //gravar dados : insert

        public void Atualizar(Livro l) //update
        {
            try
            {
                AbrirConexao();


                Cmd = new SqlCommand("update Livro set Titulo=  @v1, Autor= @v2, Lancamento= @v3 where Codigo= @v4", Con);

                Cmd.Parameters.AddWithValue("@v1", l.Titulo);
                Cmd.Parameters.AddWithValue("@v2", l.Autor);
                Cmd.Parameters.AddWithValue("@v3", l.Lancamento);
                Cmd.Parameters.AddWithValue("@v4", l.Codigo);
                Cmd.ExecuteNonQuery();//atualiza daados do cliente
            }
            catch (Exception ex)
            {

                throw new Exception(" - Erro ao atualizar Livro - " + ex.Message);
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

                Cmd = new SqlCommand("delete  from Livro where Codigo = @v1", Con);//exclui dados do livro de acordo com o  codigo informado


                Cmd.Parameters.AddWithValue("@v1", Codigo);


                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception(" - Erro ao excluir o Livro - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Livro PesquisarPorCodigo(int Codigo)//obter pessoa por codigo - chave primaria
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("select * from Livro where Codigo = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Dr = Cmd.ExecuteReader();//execuçao da leitura do bd

                Livro l = null;//cria ponteiro

                if (Dr.Read())
                {
                    l = new Livro();

                    l.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    l.Titulo  = Convert.ToString(Dr["Titulo"]);
                    l.Autor  = Convert.ToString(Dr["Autor"]);
                    l.Lancamento = Convert.ToString(Dr["Lancamento"]);
                }

                return l;
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

        public List<Livro> Listar()  //listar todos clientes cadastrados
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("select * from Livro", Con);//seleciona todos no BD

                Dr = Cmd.ExecuteReader();

                List<Livro> lista = new List<Livro>();//lista vazia

                while (Dr.Read())
                {
                    Livro l  = new  Livro();

                    l.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    l.Titulo = Convert.ToString(Dr["Titulo"]);
                    l.Autor = Convert.ToString(Dr["Autor"]);
                    l.Lancamento = Convert.ToString(Dr["Lancamento"]);

                    lista.Add(l);// RETORNA DADOS DO BD
                }
                return lista;


            }
            catch (Exception ex)
            {

                throw new Exception(" - Não foi possivel Listar o acervo! - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

    }
    
}
