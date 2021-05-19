using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.Lib.RegraNegocio;
using DR.Lib.Winform;

namespace DRProjetoCadastro.BLL
{
    public class DRCronogramaServer : DRDataBase
    {
        public string GetValorTotalOrcadoObra(int codigoPrj) 
        {
            object result =
            DBCon.QueryValue("SELECT ISNULL(SUM(TOTALGERAL),0) FROM DRATIVIDADE WHERE CODIGOPRJ=@1",codigoPrj).ToString();

            return string.Format("{0:c}", Convert.ToDecimal(result));
        }
    }
}
