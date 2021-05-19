using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.Lib.RegraNegocio;
using System.IO;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DRRelatorios.Rel
{
    public class DRRelServer : DRDataBase
    {
        public DataSet1 GetInvestidores(int codProjeto) 
        {
            DataSet1 ds = new DataSet1();
            string sql = @"SELECT DRINVESTIDORES.NOME,
                            (SELECT SUM(ValorPrevistoInvesti) FROM DROBRAINVESTIDOR  (NOLOCK) WHERE 
                            CodInvestidor = DRINVESTIDORES.CodInvestidor AND CODIGOPRJ = @1) AS VLRPREVISTO,
                            (SELECT SUM(VALOR) FROM DRPAGAMENTOINVESTIDOR (NOLOCK) WHERE 
                            CodInvestidor = DRINVESTIDORES.CodInvestidor AND STATUS = 'A' AND CODIGOPRJ = @1) AS TOTALPAGO ,
                            (SELECT Apartamento FROM DROBRAINVESTIDOR  (NOLOCK) WHERE CodInvestidor = DRINVESTIDORES.CodInvestidor AND
                            CODIGOPRJ = @1) AS APTO,
                            (SELECT PercentAdquirido FROM DROBRAINVESTIDOR  (NOLOCK) WHERE CodInvestidor = DRINVESTIDORES.CodInvestidor AND
                            CODIGOPRJ = @1) AS PercentAdquirido,
                            (SELECT FRACAOOBRA FROM DROBRAINVESTIDOR  (NOLOCK)  WHERE CodInvestidor = DRINVESTIDORES.CodInvestidor AND 
                            CODIGOPRJ = @1) AS Fracao FROM DRINVESTIDORES (NOLOCK) ";
            DBCon.Fill(ds.DRInvestidores, sql, codProjeto);
            DBCon.Fill(ds.DREMPRESA, @"SELECT TOP 1 NOME,LOGO FROM DREMPRESA");

            return ds;

        }
        public DataSet1 GetEtapasAtividadesCadastradas(int codProjeto)
        {
            DataSet1 ds = new DataSet1();
            string sql = @" SELECT * FROM 
                            (
                              SELECT CODETAPA CODIGO,DESCRICAO,1 ETAPA  FROM DRETAPA WHERE CODIGOPRJ = @1
                              UNION 
                              SELECT CODATIVIDADE CODIGO,DESCRICAO,0 ETAPA   FROM DRATIVIDADE  WHERE CODIGOPRJ = @1
                            )CRONOGRAMA ORDER BY CODIGO ";
            DBCon.Fill(ds.DRETAPAATIVIDADE, sql, codProjeto);           
            return ds;

        }
        public decimal GetValorTotalPrevistoCota(int codProjeto) 
        {
            string sql = @"SELECT ISNULL(SUM(DRCOTAS.VALORPREVISTO),0) FROM DRCOTAS WHERE
                            EXISTS
                            (
                              SELECT 1 FROM DROBRAINVESTIDOR WHERE 
                                            DROBRAINVESTIDOR.CODIGOPRJ = DRCOTAS.CODIGOPRJ AND
                                            DROBRAINVESTIDOR.IDCOTA    = DRCOTAS.IDCOTA
                            )AND DRCOTAS.CODIGOPRJ = @1";
            return Convert.ToDecimal(DBCon.QueryValue(sql, codProjeto));
        }

        public DSRel_II GetCotas(int codProjeto)
        {
            DSRel_II ds = new DSRel_II();
            string sql = @"SELECT  DRINVESTIDORES.NOME,DRCOTAS.*,DROBRAINVESTIDOR.* FROM DRCOTAS
                            JOIN DROBRAINVESTIDOR ON
                                 DROBRAINVESTIDOR.CODIGOPRJ = DRCOTAS.CODIGOPRJ AND
                                 DROBRAINVESTIDOR.IDCOTA    = DRCOTAS.IDCOTA
                            JOIN DRINVESTIDORES ON
                                 DRINVESTIDORES.CODINVESTIDOR = DROBRAINVESTIDOR.CODINVESTIDOR
                            WHERE DROBRAINVESTIDOR.CODIGOPRJ = @1 ";
            DBCon.Fill(ds.DRRELCOTAS, sql, codProjeto);
            return ds;

        }

        public DataSet1 GetEtapa_Atividade(int codProjeto) 
        {            
            DataSet1 ds = new DataSet1();
            string sql = @"SELECT CODETAPA,DESCRICAO FROM DREtapa WHERE CODIGOPRJ =@1";
            DBCon.Fill(ds.DREtapa, sql, codProjeto);
            return ds;
        }

        public void GetTotalizadores(int codProjeto,DateTime dataIni, DateTime dataFim,
                                     out decimal totalGeral, out decimal despesaAnt, out decimal despesaAtual) 
        {
            string totalGeralSQL = @"SELECT ISNULL( SUM(TOTALGERAL),0) TOTALGERAL FROM DRETAPA  
                                     JOIN DRATIVIDADE ON
                                          DRATIVIDADE.CODIGOPRJ = DRETAPA.CODIGOPRJ  AND
                                          DRATIVIDADE.CODETAPA= DRETAPA.CODETAPA  
                                     WHERE DRETAPA.CODIGOPRJ = @1";
            totalGeral = Convert.ToDecimal( DBCon.QueryValue(totalGeralSQL, codProjeto));

            string despesaAtualSql = @"SELECT ISNULL( SUM(VALOR),0) AS DESPESAATUAL FROM DRDESPESA 
                                       WHERE CODIGOPRJ = @1  AND (CODETAPA IS NOT NULL OR CODATIVIDADE IS NOT NULL) AND  (DATAPAG >= @2 AND DATAPAG <=@3 )";
            despesaAtual = Convert.ToDecimal(DBCon.QueryValue(despesaAtualSql, codProjeto, dataIni, dataFim));

            string despesaAnteriorSql = @"SELECT ISNULL( SUM(VALOR),0) AS DESPESAANTERIOR FROM DRDESPESA 
                                          WHERE CODIGOPRJ = @1 AND (CODETAPA IS NOT NULL OR CODATIVIDADE IS NOT NULL)  AND DATAPAG < @2";
            despesaAnt = Convert.ToDecimal(DBCon.QueryValue(despesaAnteriorSql, codProjeto, dataIni));

        }

        public DataSet1 GetAcompanhamentoPeriodo(int codProjeto,DateTime dataIni, DateTime dataFim, bool mostraSomenteSetiverDespesa)
        {
            string sqlVerificaDespesa = @"AND EXISTS (SELECT 1 FROM DRDESPESA WHERE DRDESPESA.CODIGOPRJ = DRATIVIDADE.CODIGOPRJ AND                                                          
                                                      DRDESPESA.CODETAPA = DRATIVIDADE.CODETAPA  AND DRDESPESA.DATAPAG <=@3  )";

            DataSet1 ds = new DataSet1();
            string sql = @"
            SELECT * FROM
           (
                SELECT CODETAPA CODIGO,DESCRICAO,
                (SELECT MIN(DATAINI) FROM DRATIVIDADE WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ  
                AND CODETAPA LIKE DRETAPA.CODETAPA +'%') DATAINI,
                (SELECT MAX(DATATERMINO) FROM DRATIVIDADE WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ 
                AND CODETAPA LIKE DRETAPA.CODETAPA +'%') DATATERMINO,
                '' UNIDADE,
                0.00 QTD,
                (SELECT ISNULL( SUM( ISNULL(PrecoUnitarioMaterial,0) * ISNULL(QTD,0) ),0) FROM DRATIVIDADE WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ 
                AND CODETAPA LIKE DRETAPA.CODETAPA +'%') PRECOUNITARIOMATERIAL,
                (SELECT ISNULL( SUM(ISNULL(PrecoUnitarioMaoObra,0) * ISNULL(QTD,0) ),0) FROM DRATIVIDADE WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ 
                AND CODETAPA LIKE DRETAPA.CODETAPA +'%') PRECOUNITARIOMAOOBRA,
                (
                   SELECT ISNULL( SUM(TOTALGERAL),0) FROM DRATIVIDADE WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ  
                   AND CODETAPA LIKE DRETAPA.CODETAPA +'%'  {1}

                ) TOTALGERAL,
                (
                  SELECT ISNULL( SUM(VALOR),0) FROM DRDESPESA 
                  LEFT JOIN DRATIVIDADE ON
                       DRATIVIDADE.CODIGOPRJ    = DRDESPESA.CODIGOPRJ AND
                       DRATIVIDADE.CODATIVIDADE = DRDESPESA.CODATIVIDADE                        
                  WHERE 
                        DRDESPESA.CODIGOPRJ= DRETAPA.CODIGOPRJ AND DRDESPESA.STATUS='A' AND
                        (
                          (DRDESPESA.CODETAPA LIKE DRETAPA.CODETAPA +'%') OR
                          (DRATIVIDADE.CODETAPA LIKE DRETAPA.CODETAPA +'%')
                        )AND DATAPAG < @2
                )DESPESAANTERIOR,
                (
                  SELECT ISNULL( SUM(VALOR),0) FROM DRDESPESA 
                  LEFT JOIN DRATIVIDADE ON
                       DRATIVIDADE.CODIGOPRJ    = DRDESPESA.CODIGOPRJ AND
                       DRATIVIDADE.CODATIVIDADE = DRDESPESA.CODATIVIDADE   
                  WHERE 
                       DRDESPESA.CODIGOPRJ= DRETAPA.CODIGOPRJ AND DRDESPESA.STATUS='A' AND 
                       (
                          (DRDESPESA.CODETAPA LIKE DRETAPA.CODETAPA +'%') OR
                          (DRATIVIDADE.CODETAPA LIKE DRETAPA.CODETAPA +'%')
                        ) 
                       AND (DATAPAG >= @2 AND DATAPAG <=@3 )
                ) DESPESAATUAL, 1 ETAPA           
                FROM DRETAPA               
                WHERE DRETAPA.CODIGOPRJ =@1 
            )ACOMPANHAMENTO {0}";

            if (mostraSomenteSetiverDespesa)
                sql = string.Format(sql, "WHERE (DESPESAANTERIOR > 0 OR DESPESAATUAL > 0)", sqlVerificaDespesa);
            else
                sql = string.Format(sql, string.Empty,string.Empty);

            DBCon.Fill(ds.DRACOMPANHAMENTO, sql, codProjeto, dataIni, dataFim);
            
            return ds;
        }

        public DataSet1 GetAcompanhamentoResumido(int codProjeto, bool somenteIniciadas) 
        {
                       DataSet1 ds = new DataSet1();
            string sql = @"SELECT * FROM
                           (
                                SELECT CODETAPA CODIGO,DESCRICAO, 1 ETAPA,
                                (
                                             (
                                               (SELECT ISNULL( SUM(PercentualCompletude),0) FROM DRATIVIDADE(NOLOCK)  WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ 
                                                AND  CODETAPA LIKE DRETAPA.CODETAPA +'%')  
                                              )
                                              /
                                               (SELECT CASE COUNT(*)
                                                            WHEN 0 THEN 1         
                                                            ELSE COUNT(*)
                                                       END
                                                  FROM DRATIVIDADE(NOLOCK)  WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ 
                                                AND CODETAPA LIKE DRETAPA.CODETAPA +'%')
                                )PERCENTUALCOMPLETUDE,NULL AS DATAINI, NULL AS DATATERMINO                     
                                FROM DRETAPA               
                                WHERE CODIGOPRJ =@1 
                            
                                UNION ALL               
                            
                                SELECT CODATIVIDADE CODIGO,DESCRICAO, 0 ETAPA,
                                PERCENTUALCOMPLETUDE, DATAINI , DATATERMINO             
                                FROM DRATIVIDADE (NOLOCK) WHERE CODIGOPRJ =@1 
                            )ACOMPANHAMENTO {0}";

            if (somenteIniciadas)
                sql = string.Format(sql, " WHERE PERCENTUALCOMPLETUDE >0 ");
            else
                sql = string.Format(sql, string.Empty, string.Empty);

            DBCon.Fill(ds.DRACOMPRESUMIDO, sql, codProjeto);

            return ds;
        }

        #region Acompanhamento Pagamento Investidor

        private string GetColumnMes(int mes)
        {
            string result = string.Empty;
            switch (mes)
            {
                case 1: result = "JAN";
                     break;
                case 2: result = "FEV";
                     break;
                case 3: result = "MAR";
                     break;
                case 4: result = "ABRIL";
                     break;
                case 5: result = "MAIO";
                     break;
                case 6: result = "JUNHO";
                     break;
                case 7: result = "JULHO";
                     break;
                case 8: result = "AGOSTO";
                     break;
                case 9: result = "SET";
                     break;
                case 10: result = "OUT";
                     break;
                case 11: result = "NOV";
                     break;
                case 12: result = "DEZ";
                     break;
            }
            return result;
        }
        private void SetValueDefault(DataRow row) 
        {
            for (int i = 1; i <= 12; i++)
            {
                string mes =  GetColumnMes(i);
                row[mes] =0;
            }
        }
        public DataSet1 MontaPagamentoMensal(int codProjeto, int ano)
        {
            DataSet1 ds = new DataSet1();
            string sql = @"SELECT DROBRAINVESTIDOR.CODIGOPRJ,DRINVESTIDORES.CODINVESTIDOR,DRINVESTIDORES.NOME,
                                  MONTH(DATAPAG) AS MES,DROBRAINVESTIDOR.APARTAMENTO,DROBRAINVESTIDOR.ValorPrevistoInvesti AS VALORPREVISTO,
                                  SUM(ISNULL(VALOR,0)) AS VALOR  
                           FROM DRINVESTIDORES
                           JOIN DROBRAINVESTIDOR ON
                                DROBRAINVESTIDOR.CODIGOPRJ = @1 AND
                                DROBRAINVESTIDOR.CODINVESTIDOR = DRINVESTIDORES.CODINVESTIDOR 
                           LEFT JOIN DRPAGAMENTOINVESTIDOR ON 
                                DRPAGAMENTOINVESTIDOR.CODIGOPRJ = @1 AND
                                DRINVESTIDORES.CODINVESTIDOR = DRPAGAMENTOINVESTIDOR.CODINVESTIDOR AND
                                DRPAGAMENTOINVESTIDOR.STATUS = 'A' AND
                                DATAPAG IS NOT NULL AND
                                ( YEAR(DATAPAG)>= @2 AND  YEAR(DATAPAG) <=@2)
                           WHERE 
                                DROBRAINVESTIDOR.CODIGOPRJ = @1  
                           GROUP BY DROBRAINVESTIDOR.CODIGOPRJ,DRINVESTIDORES.CODINVESTIDOR,DRINVESTIDORES.NOME , MONTH(DATAPAG),
                                DROBRAINVESTIDOR.APARTAMENTO,DROBRAINVESTIDOR.ValorPrevistoInvesti";

           DataTable tblPagInvestidor = DBCon.QuerySelect("TBLPAGINVESTIDOR", sql, codProjeto, ano);
           DataTable Investidores = tblPagInvestidor.DefaultView.ToTable(true, "CODINVESTIDOR", "NOME","APARTAMENTO", "VALORPREVISTO");

           //Recupera o total pago antes do ano selecionado
           DataTable TblPagAnterior = GetTotaPagAnterior(codProjeto, ano);
           
           foreach(DataRow row in Investidores.Rows)
           {
               DataRow rowRelatorio = ds.DRACOMPINVESTIDOR.NewRow();
               rowRelatorio["CODINVESTIDOR"] = row["CODINVESTIDOR"];
               rowRelatorio["NOME"]          = row["NOME"];
               rowRelatorio["VALORPREVISTO"] = row["VALORPREVISTO"];
               rowRelatorio["APARTAMENTO"] = row["APARTAMENTO"];
               decimal somatorio = default(decimal);

               DataRow rowPagAnterior = TblPagAnterior.Rows.Find(row["CODINVESTIDOR"]);
               if (rowPagAnterior != null)
               {
                   rowRelatorio["VALORANOANT"] = rowPagAnterior["VALOR"];
                   somatorio = Convert.ToDecimal(rowPagAnterior["VALOR"]);
               }


              
               SetValueDefault(rowRelatorio);
               DataRow[] rowsPagInvestidor = tblPagInvestidor.Select(string.Format("CODINVESTIDOR = {0}", row["CODINVESTIDOR"]));
               foreach (DataRow pagInst in rowsPagInvestidor) 
               {
                   if (pagInst["MES"] != DBNull.Value && pagInst["MES"] != null)
                   {
                       string mes = GetColumnMes(Convert.ToInt16(pagInst["MES"]));
                       rowRelatorio[mes] = pagInst["VALOR"];
                       somatorio += Convert.ToDecimal(pagInst["VALOR"]);
                   }
               }
               rowRelatorio["TOTAL"] = somatorio;
               ds.DRACOMPINVESTIDOR.Rows.Add(rowRelatorio);
           }
           return ds;
        }
        public DataTable GetAnos(int codProjeto) 
        {
            string sql = @"SELECT DISTINCT YEAR(DATAPAG) ANO FROM DRPAGAMENTOINVESTIDOR WHERE CODIGOPRJ = @1";
            return DBCon.QuerySelect("TBLANOS", sql, codProjeto);
        }
        public DataTable GetTotaPagAnterior(int codProjeto, int ano)
        { 
            string sql = @"SELECT DISTINCT DRPAGAMENTOINVESTIDOR.CODINVESTIDOR,SUM(VALOR) AS VALOR FROM DRPAGAMENTOINVESTIDOR
                           WHERE CODIGOPRJ = @1 AND YEAR(DATAPAG) < @2 AND STATUS = 'A'
                           GROUP BY DRPAGAMENTOINVESTIDOR.CODINVESTIDOR";

            DataTable tblPaganterior = DBCon.QuerySelect("TBLPAGANTERIOR", sql, codProjeto, ano);
            tblPaganterior.PrimaryKey = new DataColumn[] { tblPaganterior.Columns["CODINVESTIDOR"] };
            return tblPaganterior;
        }
        private string GetNomeMes(int mes)
        {
            string result = "Anterior";
            switch (mes)
            {
                case 1: result = "Janeiro";
                    break;
                case 2: result = "Fevereiro";
                    break;
                case 3: result = "Março";
                    break;
                case 4: result = "Abril";
                    break;
                case 5: result = "Maio";
                    break;
                case 6: result = "Junho";
                    break;
                case 7: result = "Julho";
                    break;
                case 8: result = "Agosto";
                    break;
                case 9: result = "Setembro";
                    break;
                case 10: result = "Outubro";
                    break;
                case 11: result = "Novembro";
                    break;
                case 12: result = "Dezembro";
                    break;
            }
            return result;
        }

        private void AtualizaRendimento(DataRow row,DataTable tblRendimento) 
        {
            DataRow rowRendimento = tblRendimento.Rows.Find(row["MES"]);
            if (rowRendimento != null)
            {
                row["RENDIMENTOS"] = rowRendimento["VALORRENDIMENTO"];
                decimal saldo = 0;
                if (row["SALDO"] != DBNull.Value)
                    saldo = Convert.ToDecimal(row["SALDO"]);
                //Adiciona o rendimento ao saldo
                row["SALDO"] = saldo + Convert.ToDecimal(row["RENDIMENTOS"]);
            }
        }
           
        public DataTable GetEntrada_X_Despesa(int codProjeto, int ano)
        {
            string sql = @"SELECT CODIGOPRJ,MES,SUM(ENTRADA) ENTRADA,SUM(DESPESA) DESPESA,
                           (SUM(ENTRADA) - SUM(DESPESA)) SALDO, '' NOMEMES,0 RENDIMENTOS FROM
                           (
                               SELECT CODIGOPRJ,0 MES, SUM(VALOR) DESPESA, 0 ENTRADA FROM DRDESPESA   
                               WHERE
                                      CODIGOPRJ=@1 AND STATUS = 'A' AND DATAPAG IS NOT NULL AND YEAR(DATAPAG) < @2
                               GROUP BY CODIGOPRJ
                               UNION ALL     
                               SELECT CODIGOPRJ, MONTH(DATAPAG) MES, SUM(VALOR) DESPESA,0 ENTRADA FROM DRDESPESA   
                               WHERE
                                   CODIGOPRJ=@1 AND STATUS = 'A' AND DATAPAG IS NOT NULL AND ( YEAR(DATAPAG)>= @2 AND  YEAR(DATAPAG) <=@2)  
                               GROUP BY CODIGOPRJ, MONTH(DATAPAG) 
                               UNION ALL  
                               SELECT CODIGOPRJ,0,0 DESPESA,SUM(VALOR) ENTRADA FROM DRPAGAMENTOINVESTIDOR   
                               WHERE
                                   CODIGOPRJ=@1 AND STATUS = 'A'  AND DATAPAG IS NOT NULL AND YEAR(DATAPAG) < @2
                               GROUP BY CODIGOPRJ
                               UNION ALL     
                               SELECT CODIGOPRJ, MONTH(DATAPAG) MES,0 DESPESA,SUM(VALOR) ENTRADA FROM DRPAGAMENTOINVESTIDOR   
                               WHERE
                                   CODIGOPRJ=@1  AND STATUS = 'A' AND DATAPAG IS NOT NULL AND ( YEAR(DATAPAG)>= @2 AND  YEAR(DATAPAG) <=@2)  
                               GROUP BY CODIGOPRJ, MONTH(DATAPAG) 
                           )  ACOMP_DESPESA_ENTRADA
                           GROUP BY CODIGOPRJ,MES";
          DataTable tblEntrada_Despesa =  DBCon.QuerySelect("TBLENTRADA_DESPESA", sql, codProjeto, ano);
          tblEntrada_Despesa.PrimaryKey = new DataColumn[] { tblEntrada_Despesa.Columns["MES"] };

          #region Rendimentos

          string sqlRendimentos = @"SELECT MES,SUM(VALORRENDIMENTO) AS VALORRENDIMENTO FROM DRRENDIMENTO
                                    WHERE CODIGOPRJ=@1 GROUP BY CODIGOPRJ, MES";
          DataTable tblRendimento = DBCon.QuerySelect("TblRendimento", sqlRendimentos, codProjeto);
          tblRendimento.PrimaryKey = new DataColumn[1] { tblRendimento.Columns["MES"] };

          #endregion
          for (int i = 0; i <= 12; i++)
          {
              DataRow row = tblEntrada_Despesa.Rows.Find(i);
              if (row != null)
              {
                  row["NOMEMES"] = GetNomeMes(Convert.ToInt16(row["MES"]));
                  AtualizaRendimento(row, tblRendimento);                 
              }
              else
              {
                  row = tblEntrada_Despesa.NewRow();
                  row["MES"] = i;
                  row["RENDIMENTOS"] = 0;
                  row["SALDO"] = 0;
                  AtualizaRendimento(row, tblRendimento);
                  row["NOMEMES"] = GetNomeMes(Convert.ToInt16(row["MES"]));
                  row["ENTRADA"] = 0;
                  row["DESPESA"] = 0;

                  tblEntrada_Despesa.Rows.Add(row);
              }
          }
          return tblEntrada_Despesa;

        }
        #endregion

        #region Informações Empresa
        public DataRow GetInfoEmpresa()
        {
            DataTable tbl = DBCon.QuerySelect("DREMPRESA", @"SELECT TOP 1 NOME,ENDERECO,NUMERO,BAIRRO,
                                                             TELEFONE1,TELEFONE2,LOGO FROM DREMPRESA");
            if (tbl.Rows.Count == 0)
            {
                throw new Exception("Favor cadastrar os dados da empresa");
            }
           return tbl.Rows[0];                 
            
        }
   
        #endregion

        #region Despesas Não classificadas

        public bool ExisteDespesasNaoClassificadas(int codProjeto, DateTime? dataFim)
        {
            string filtroPer = string.Empty;
            if (dataFim != null)
                filtroPer = "AND DATAPAG <=@2";

            string sql = @"SELECT 1 FROM DRDESPESA WHERE 
                          ( (CODETAPA IS NULL AND CODATIVIDADE IS NULL) OR (STATUS <> 'A') )
                          AND CODIGOPRJ =@1 " + filtroPer;

            if (string.IsNullOrEmpty(filtroPer))
                return DBCon.QueryFind(sql, codProjeto);
            else
                return DBCon.QueryFind(sql, codProjeto,dataFim);
        }
        public bool ExisteDespesasNaoClassificadas(int codProjeto, DateTime? dataIni, DateTime? dataFim)
        {
            string filtroPer = string.Empty;
            if (dataIni != null && dataFim != null)
                filtroPer = "AND DATAPAG >=@2 AND DATAPAG <=@3";

            string sql = @"SELECT 1 FROM DRDESPESA 
                           JOIN DRFORNECEDOR ON
                                DRFORNECEDOR.CODFORNECEDOR = DRDESPESA.CODFORNECEDOR
                                WHERE (CODETAPA IS NULL OR CODATIVIDADE IS NULL OR STATUS <> 'A') 
                                AND CODIGOPRJ =@1 " + filtroPer;

            if (string.IsNullOrEmpty(filtroPer))
               return DBCon.QueryFind( sql, codProjeto);
            else
               return DBCon.QueryFind(sql, codProjeto, dataIni, dataFim);
        }

        public DSRel_II GetDespesasNaoClassificadas(int codProjeto, DateTime? dataIni, DateTime? dataFim) 
        {
            string filtroPer = string.Empty;
            if (dataIni != null && dataFim != null)
                filtroPer = "AND DATAPAG >=@2 AND DATAPAG <=@3";

            DSRel_II ds = new DSRel_II();
            string sql = @"SELECT DRDESPESA.DATAPAG, DRDESPESA.DESCRICAO,DRDESPESA.VALOR,DRFORNECEDOR.NOME,
                                  DRDESPESA.CODETAPA,DRDESPESA.CODATIVIDADE,
                                  CASE STATUS WHEN 'A' THEN 'APROVADO'         
                                  ELSE 'Ñ APROV.' END STATUS
                           FROM DRDESPESA 
                           LEFT JOIN DRFORNECEDOR ON
                                DRFORNECEDOR.CODFORNECEDOR = DRDESPESA.CODFORNECEDOR
                           WHERE 
                              ( (CODETAPA IS NULL AND CODATIVIDADE IS NULL) OR STATUS <> 'A' )
                                AND CODIGOPRJ =@1 " + filtroPer;

            if(string.IsNullOrEmpty(filtroPer))
                DBCon.Fill(ds.DRDESPESANAOCLASSIFICADA, sql, codProjeto);
            else
               DBCon.Fill(ds.DRDESPESANAOCLASSIFICADA, sql, codProjeto, dataIni, dataFim);
            return ds;
            
        }
        #endregion

        #region Despesa por Atividade

        public string GetFiltro(string aliasTable, DataTable tbl,string tipo)
        {
            string campo = "CODETAPA";
            if(tipo=="A")
                campo = "CODATIVIDADE"
                    ;
            string filter = string.Empty;
            foreach (DataRow row in tbl.Rows) 
            {
                string m = string.Format("({0}.{1} = '{2}')",aliasTable,campo,row[campo]);
                if (string.IsNullOrEmpty(filter))
                    filter = m;
                else
                    filter += " OR " + m;
            }
            if (!string.IsNullOrEmpty(filter))
                filter = string.Concat("(", filter, ")");
            return filter;
        }

        public DSRel_II GetEtapa_Atividade_RelDespesa(int codProjeto,DataTable tbFilter,string tipo, 
                                                      DateTime? dataIni, DateTime? dataFim  )
        {
            DSRel_II ds = new DSRel_II();
            string sql =
            @"SELECT * FROM
             (
                   SELECT DRATIVIDADE.CodEtapa,DRATIVIDADE.CodAtividade,DRETAPA.DESCRICAO ETAPA,
                           DRATIVIDADE.DESCRICAO ATIVIDADE, 
                           (
                                  SELECT SUM(VALOR) FROM DRDESPESA WHERE
                                         DRDESPESA.CodigoPrj =  DRATIVIDADE.CodigoPrj AND
                                         DRDESPESA.CodEtapa  = DRATIVIDADE.CodEtapa   AND                                                                 
                                         DRDESPESA.CODATIVIDADE  = DRATIVIDADE.CODATIVIDADE   AND 
                                         DRDESPESA.STATUS = 'A' {1}
                           ) VALORDESPESA 
                    FROM DRATIVIDADE
                    JOIN DRETAPA ON
                         DRETAPA.CodigoPrj = DRATIVIDADE.CodigoPrj AND
                         DRETAPA.CodEtapa = DRATIVIDADE.CodEtapa
                    WHERE DRATIVIDADE.CodigoPrj = @1 {0} 
             ) DESPESA WHERE DESPESA.VALORDESPESA > 0";

            string filter = GetFiltro("DRATIVIDADE", tbFilter, tipo);

            #region Monta Filtro por Periodo
            string filtroData = string.Empty;
            if (dataIni != null && dataFim != null)
            {
                filtroData = " AND (DRDESPESA.DATAPAG >= @2 AND DRDESPESA.DATAPAG <= @3)";
            }
  
           #endregion

            if (!string.IsNullOrEmpty(filter))
                sql = string.Format(sql, " AND "+filter,filtroData);
            else
                sql = string.Format(sql,string.Empty,filtroData);

            if(!string.IsNullOrEmpty(filtroData))
                DBCon.Fill(ds.DRETAPA_ATIVIDADE, sql, codProjeto,dataIni,dataFim);
            else
                DBCon.Fill(ds.DRETAPA_ATIVIDADE, sql, codProjeto);

            string sqlDespesa = @"SELECT DRDESPESA.CODETAPA,DRDESPESA.CODATIVIDADE,
                                         DRDESPESA.Descricao,DATAPAG,VALOR,NumeroNota FROM DRDESPESA                                 
                                  WHERE DRDESPESA.CodigoPrj = @1 AND DRDESPESA.STATUS = 'A' {0} {1}";

            if (!string.IsNullOrEmpty(filter))
            {
                filter = filter.Replace("DRATIVIDADE", "DRDESPESA");
                sqlDespesa = string.Format(sqlDespesa,filtroData, " AND " + filter);
            }
            else
                sqlDespesa = string.Format(sqlDespesa,filtroData, string.Empty);

            if (!string.IsNullOrEmpty(filtroData))
                DBCon.Fill(ds.DRDESPESA, sqlDespesa, codProjeto, dataIni, dataFim);
            else
                DBCon.Fill(ds.DRDESPESA, sqlDespesa, codProjeto);
            return ds;
        }
        #endregion

        #region Extrato de Pagamento do Investidor

        public DSRel_II GetExtratoPagamento(int codProjeto,int? codInvestidor)
        {
            DSRel_II ds = new DSRel_II();
            string sql = @"SELECT DRINVESTIDORES.NOME,DROBRAINVESTIDOR.APARTAMENTO ,DRPAGAMENTOINVESTIDOR.* FROM DRINVESTIDORES
                           JOIN DROBRAINVESTIDOR ON
                                DROBRAINVESTIDOR.CODINVESTIDOR = DRINVESTIDORES.CODINVESTIDOR 
                           JOIN DRPAGAMENTOINVESTIDOR ON 
                                DRPAGAMENTOINVESTIDOR.CODIGOPRJ = DROBRAINVESTIDOR.CODIGOPRJ AND
                                DRINVESTIDORES.CODINVESTIDOR = DRPAGAMENTOINVESTIDOR.CODINVESTIDOR
                           WHERE     
                                DROBRAINVESTIDOR.CODIGOPRJ = @1 AND
                                DRPAGAMENTOINVESTIDOR.STATUS = 'A'";

            if (codInvestidor != null)
            {
                sql = sql + " AND DRINVESTIDORES.CODINVESTIDOR =@2 ";
                DBCon.Fill(ds.DREXTRATOPAG, sql, codProjeto, codInvestidor);
            }
            else
            {
                DBCon.Fill(ds.DREXTRATOPAG, sql, codProjeto);
            }

            
            
            return ds;
        }

        #endregion

        public DSRel_II GetPatrimonios(DateTime? dtIni, DateTime? dtFim, int codProjeto)
        {
            DSRel_II ds = new DSRel_II();
            if(dtIni != null && dtFim!= null)
               DBCon.Fill(ds.DRPATRIMONIO, @"SELECT * FROM DRPATRIMONIO WHERE CODIGOPRJ =@1 AND 
                                             DATAAQUISICAO >=@2 AND DATAAQUISICAO <=@3 ", 
                                             codProjeto,dtIni,dtFim);
            else
               DBCon.Fill(ds.DRPATRIMONIO, "SELECT * FROM DRPATRIMONIO WHERE CODIGOPRJ =@1", codProjeto);
            return ds;
        }

        public DSRel_II GetDespesadoPeriodo(DateTime? dtIni, DateTime? dtFim, int codProjeto)
        {
            DSRel_II ds = new DSRel_II();
            if (dtIni != null && dtFim != null)
            {
                DBCon.Fill(ds.DRDESPESACONFERENCIA, @"SELECT DATAPAG,DESCRICAO,NUMERONOTA,VALOR FROM DRDESPESA
	                                          WHERE CODIGOPRJ =@1 AND DATAPAG >=@2 AND DATAPAG <=@3",
                                              codProjeto, dtIni, dtFim);
            }
            else
                DBCon.Fill(ds.DRDESPESACONFERENCIA, @"SELECT DATAPAG,DESCRICAO,NUMERONOTA,VALOR FROM DRDESPESA
	                                          WHERE CODIGOPRJ =@1", codProjeto);
            return ds;
        }
    }
    
}
