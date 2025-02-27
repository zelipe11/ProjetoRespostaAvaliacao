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
    public class RespostaDAO
    {
        public static DataTable Perguntas(int idpergunta, int codgrupo)
        {
            string sql = $"select idpergunta ,id, pergunta, tipoperg from fstperguntarh where id = {idpergunta} and codgrupo = {codgrupo}";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static DataTable RespostasSalvas(int codPerg, int codGrupo, int codFunc, int idPesq)
        {
            string sql = $"select respostafunc, comentariofunc from fstrespostasrh where codperg = {codPerg} and codgrupo = {codGrupo} and codfunc = {codFunc} and idpergunta = {idPesq} and AVALEXP is null";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static DataTable Grupos(int idpergunta)
        {
            string sql = $"select p.codgrupo, g.descricao from fstperguntarh p, fstgruporh g where p.codgrupo = g.codgrupo and id = {idpergunta} group by p.codgrupo, g.descricao";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static bool ExisteRespostaSalva(int codgrupo, int codfunc, int codperg, int idPesq)
        {
            string sql = $"select * from fstrespostasrh where codgrupo = {codgrupo} and codfunc = {codfunc} and codperg = {codperg} and idpergunta = {idPesq} and AVALEXP is null";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            if (dt.Rows.Count > 0)
                return true;
            
            else
                return false;
        }
        
        public static bool ExisteRespostaFinalizada(int codgrupo, int codfunc, int codperg, int idPesq)
        {
            string sql = $"select * from fstrespostasrh where codgrupo = {codgrupo} and codfunc = {codfunc} and codperg = {codperg} and idpergunta = {idPesq} and dtfinaliza is not null";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            if (dt.Rows.Count > 0)
                return true;
            
            else
                return false;
        }

        public static int CodigoResposta()
        {
            string sql = @"select max(codigo) + 1 from fstrespostasrh";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public static void SalvarRespostas(int codGrupo, int codFunc, int codPerg, int respostaFunc, string comentFunc, int IdPesq)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                if (ExisteRespostaSalva(codGrupo, codFunc, codPerg, IdPesq))
                {
                    cmdPagar.CommandText = @"UPDATE fstrespostasrh SET 
                                                respostafunc = :respostafunc,
                                                comentariofunc = :comentfunc,
                                                DTSALVA = sysdate
                                            WHERE codgrupo = :codgrupo
                                            AND codfunc = :codfunc
                                            AND codperg = :codperg
                                            AND idpergunta = :idpesq";

                    cmdPagar.Parameters.AddWithValue(":respostafunc", respostaFunc);
                    cmdPagar.Parameters.AddWithValue(":comentfunc", comentFunc);
                    cmdPagar.Parameters.AddWithValue(":codgrupo", codGrupo);
                    cmdPagar.Parameters.AddWithValue(":codfunc", codFunc);
                    cmdPagar.Parameters.AddWithValue(":codperg", codPerg);
                    cmdPagar.Parameters.AddWithValue(":idpesq", IdPesq);
                }
                else
                {
                    cmdPagar.CommandText = @"INSERT INTO fstrespostasrh (CODIGO, CODGRUPO, CODPERG, RESPOSTAFUNC, COMENTARIOFUNC, DTSALVA, CODFUNC, IDPERGUNTA)
                                            VALUES (:codigo, :codgrupo, :codperg, :respostafunc, :comentariofunc, sysdate, :codfunc, :IDPESQ)";

                    int codigo = CodigoResposta();

                    cmdPagar.Parameters.AddWithValue(":codigo", codigo);
                    cmdPagar.Parameters.AddWithValue(":codgrupo", codGrupo);
                    cmdPagar.Parameters.AddWithValue(":codperg", codPerg);
                    cmdPagar.Parameters.AddWithValue(":respostafunc", respostaFunc);
                    cmdPagar.Parameters.AddWithValue(":comentariofunc", comentFunc);
                    cmdPagar.Parameters.AddWithValue(":codfunc", codFunc);
                    cmdPagar.Parameters.AddWithValue(":IDPESQ", IdPesq);
                }




                cmdPagar.ExecuteNonQuery();

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
        
        public static void FinalizarRespostas(int codGrupo, int codFunc, int codPerg, int respostaFunc, string comentFunc, int idPesq)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                if (ExisteRespostaSalva(codGrupo, codFunc, codPerg, idPesq))
                {
                    cmdPagar.CommandText = @"UPDATE fstrespostasrh SET 
                                                respostafunc = :respostafunc,
                                                comentariofunc = :comentfunc,
                                                DTFINALIZA = sysdate
                                            WHERE codgrupo = :codgrupo
                                            AND codfunc = :codfunc
                                            AND codperg = :codperg
                                            AND idpergunta = :idpesq";

                    cmdPagar.Parameters.AddWithValue(":respostafunc", respostaFunc);
                    cmdPagar.Parameters.AddWithValue(":comentfunc", comentFunc);
                    cmdPagar.Parameters.AddWithValue(":codgrupo", codGrupo);
                    cmdPagar.Parameters.AddWithValue(":codfunc", codFunc);
                    cmdPagar.Parameters.AddWithValue(":codperg", codPerg);
                    cmdPagar.Parameters.AddWithValue(":idpesq", idPesq);
                }
                else
                {
                    cmdPagar.CommandText = @"INSERT INTO fstrespostasrh (CODIGO, CODGRUPO, CODPERG, RESPOSTAFUNC, COMENTARIOFUNC, DTFINALIZA, CODFUNC, IDPERGUNTA)
                                            VALUES (:codigo, :codgrupo, :codperg, :respostafunc, :comentariofunc, sysdate, :codfunc, :idpesq)";

                    int codigo = CodigoResposta();

                    cmdPagar.Parameters.AddWithValue(":codigo", codigo);
                    cmdPagar.Parameters.AddWithValue(":codgrupo", codGrupo);
                    cmdPagar.Parameters.AddWithValue(":codperg", codPerg);
                    cmdPagar.Parameters.AddWithValue(":respostafunc", respostaFunc);
                    cmdPagar.Parameters.AddWithValue(":comentariofunc", comentFunc);
                    cmdPagar.Parameters.AddWithValue(":codfunc", codFunc);
                    cmdPagar.Parameters.AddWithValue(":idpesq", idPesq);
                }




                cmdPagar.ExecuteNonQuery();

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
    }
}
