using FuncoesWinthor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRespostaAvaliacao.DAO
{
    public class RespostaDAO
    {
        public static DataTable Perguntas(int idpergunta)
        {
            string sql = $"select id, pergunta, tipoperg from fstperguntarh where id = {idpergunta}";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
    }
}
