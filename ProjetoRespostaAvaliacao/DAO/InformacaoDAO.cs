using FuncoesWinthor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRespostaAvaliacao.DAO
{
    public class InformacaoDAO
    {
        public static bool ExisteCPF(string cpf)
        {
            string sql = $"select * from fstpesqrh where REPLACE(REPLACE(CPF, '.', ''), '-','') = '{cpf}' ";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
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
