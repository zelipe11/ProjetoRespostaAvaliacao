using FuncoesWinthor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRespostaAvaliacao.DAO
{
    public class ResultadosDAO
    {
        public static DataTable RespostasUsuario(int codfunc, int codsetor)
        {
            string sql = $@"select p.codpesq, p.descricaopesq, r.codgrupo, g.descricao descgrupo,
                            TO_DATE(r.dtfinaliza, 'DD/MM/YYYY') dtresposta,
                            p.idpergunta

                            from fstpesquisarh p, fstperguntarh pp, 
                            fstrespostasrh r , fstgruporh g

                            where p.codsetor = {codsetor}
                            and r.codfunc = {codfunc}
                            and p.idpergunta = pp.id 
                            and pp.idpergunta = r.idpergunta 
                            and r.codgrupo = g.codgrupo
                            and r.dtfinaliza is not null
                            and r.AVALEXP is null
                            group by p.codpesq, p.descricaopesq, r.dtfinaliza, p.idpergunta, r.codgrupo, g.descricao";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static DataTable RespostaPergUsuario(int codfunc, int codperg, int codgrupo)
        {
            string sql = $@"select r.idpergunta, (select pergunta from fstperguntarh where r.idpergunta = idpergunta) pergunta,r.respostafunc, r.comentariofunc, r.dtfinaliza  
                                from fstrespostasrh r where r.codfunc = {codfunc} and r.codperg = {codperg} and r.codgrupo = {codgrupo}";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
    }
}
