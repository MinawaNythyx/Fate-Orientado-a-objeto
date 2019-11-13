using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;//NAO ESQUECE ESSA MERDA
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fate_Orientado_a_objeto
{
    class SqlDataDao
    {
        //Conexao com o banco de dados
        SQLiteConnection conexao;

        //Construtor
        public SqlDataDao()
        {
            conexao = new SQLiteConnection("Data Source=JogoBd.sqlite; Version = 3;");
        }

        public void CriarTabelas()
        {
            try
            {
                //Abre a conexao
                conexao.Open();
                //Cria comando
                var comando = conexao.CreateCommand();
                comando.CommandText = "CREATE TABLE IF NOT EXISTS Placar(Id Varchar(50), Jogador Varchar(50), Pontos int)";

                //Executa comando
                comando.ExecuteNonQuery();



            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }
        public bool IncluirPlayer(string jogador, int pontos)
        {
            try
            {
                using(var comando = conexao.CreateCommand())
                {
                    comando.CommandText = "INSERT INTO Placar(Id, Jogador, Pontos) values(@id, @jogador, @pontos)";
                    comando.Parameters.AddWithValue("@id", Guid.NewGuid());
                    comando.Parameters.AddWithValue("@jogador", jogador);
                    comando.Parameters.AddWithValue("@pontos", pontos);
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
        public DataTable ListarPlacar()
        {
            //Adaptador para gerar a tabela
            SQLiteDataAdapter adaptador = null;
            DataTable tabela = new DataTable();
            //tratamento de erro
            try
            {
                using(var comando = conexao.CreateCommand())
                {
                    comando.CommandText = "SELECT * FROM Placar";
                    adaptador = new SQLiteDataAdapter(comando.CommandText, conexao);
                    adaptador.Fill(tabela);
                    return tabela;
                }
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
    }
}
