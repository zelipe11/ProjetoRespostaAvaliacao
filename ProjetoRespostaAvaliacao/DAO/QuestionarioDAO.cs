using FuncoesWinthor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRespostaAvaliacao.DAO
{
    public class QuestionarioDAO
    {
        public static DataTable Questionarios(int codsetor)
        {
            string sql = $@"select codpesq, descricaopesq, dtinicio, dtfim, CASE WHEN formato = 'I' then 'IDENTIFICADA' WHEN formato = 'A' then 'ANONIMA' END AS formatopesq, 
                            tipoavalia, idpergunta from fstpesquisarh where (codsetor = {codsetor} or codsetor is null) and formato = 'I'";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
    }
}
