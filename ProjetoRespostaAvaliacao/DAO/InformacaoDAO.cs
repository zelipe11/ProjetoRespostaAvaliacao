using FuncoesWinthor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRespostaAvaliacao.DAO
{
    public class InformacaoDAO
    {
        public static bool ExisteCPF(string cpf, string senha)
        {
            string sql = $"select * from fstpesqrh where REPLACE(REPLACE(CPF, '.', ''), '-','') = '{cpf}' and senha = '{senha}'";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static bool TemCpf(string cpf)
        {
            string sql = $@"select case when exists (select cpf from fstpesqrh where REPLACE(REPLACE(CPF, '.', ''), '-','') = '{cpf}')
                            then 1 else 0 end as cpfuser from dual";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            if (Convert.ToInt32(dt.Rows[0][0].ToString()) == 1)
                return true;
            else
                return false;
        }

        public static bool TemSenha(string cpf)
        {
            string sql = $@"select case when (select senha from fstpesqrh where REPLACE(REPLACE(CPF, '.', ''), '-','') = '{cpf}') is not null
                            then 1 else 0 end as senhauser from dual";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            if (Convert.ToInt32(dt.Rows[0][0].ToString()) == 1)
                return true;
            else
                return false;
        }

        public static void CriarSenha(string cpf, string senha)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdSenha = conexao.CreateCommand();
                cmdSenha.Transaction = transacao;

                cmdSenha.CommandText = @"UPDATE fstpesqrh set
                                            senha = :senha
                                            where REPLACE(REPLACE(CPF, '.', ''), '-','') = :cpf";


                cmdSenha.Parameters.AddWithValue(":cpf", cpf);
                cmdSenha.Parameters.AddWithValue(":senha", senha);

                cmdSenha.ExecuteNonQuery();

                transacao.Commit();
            }
            catch (Exception erro)
            {
                transacao.Rollback();
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static int SetorDoUsuario(string cpf)
        {
            string sql = $"select setor from fstpesqrh where REPLACE(REPLACE(CPF, '.', ''), '-','') = '{cpf}'";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public static int CodigoUsuario(string cpf)
        {
            string sql = $"select codigo from fstpesqrh where REPLACE(REPLACE(CPF, '.', ''), '-','') = '{cpf}'";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public static DataTable InfoUsuario(string cpf)
        {
            string sql = $"select nome, funcao from fstpesqrh where REPLACE(REPLACE(CPF, '.', ''), '-','') = '{cpf}'";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
    }
}
