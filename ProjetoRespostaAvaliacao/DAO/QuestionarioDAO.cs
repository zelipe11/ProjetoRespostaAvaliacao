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
                            tipoavalia, idpergunta,(select count(codperg) from fstrespostasrh where codperg=a.idpergunta )qtrespo,(select count(id) 
                            from fstperguntarh where id=a.idpergunta)qtperg, a.codsetor from fstpesquisarh a where (codsetor = {codsetor} or codsetor is null) and formato = 'I'
                            and (select count(codperg) from fstrespostasrh where codperg=a.idpergunta ) < (select count(id) from fstperguntarh where id=a.idpergunta)
                            and a.dtexclusao is null
                            and trunc(sysdate) between trunc(dtinicio) and trunc(dtfim)";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
        
        public static DataTable Questionarios()
        {
            string sql = $@"select codpesq, descricaopesq, dtinicio, dtfim, CASE WHEN formato = 'I' then 'IDENTIFICADA' WHEN formato = 'A' then 'ANONIMA' END AS formatopesq, 
                            tipoavalia, idpergunta from fstpesquisarh where codsetor is null and formato = 'A'
                            and dtexclusao is null
                            and trunc(sysdate) between trunc(dtinicio) and trunc(dtfim)";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
    }
}
