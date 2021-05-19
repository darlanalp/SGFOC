using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data;
using DRProjetoCadastro.BLL;

namespace DRProjetoCadastro.BLL
{
    public class DRUltils_SGFOC
    {
        public DSConfigPref DsPref 
        {
            get 
            {
                if (_DsPref == null)
                    ReadXML();                
                return _DsPref;
            }
        }private DSConfigPref _DsPref = null;
 
        public const string FileName = "SFFOC_PREFPC.XML";
        public string FilePath 
        {
            get { return Application.StartupPath+@"\"+ FileName; }
        }
    
        private void ReadXML() 
        {
            if (File.Exists(FilePath))
            {
                _DsPref = new DSConfigPref();
                _DsPref.ReadXml(FilePath);
            }
            else
                _DsPref = new DSConfigPref();
        }
       
        private void SaveXML() 
        {
            _DsPref.WriteXml(FilePath);
        }

        public bool MostraGrafico() 
        {
            if (DsPref.Tables["PREFERENCIA"].Rows.Count == 0)
                return true;
            return
            !Convert.ToBoolean(DsPref.Tables["PREFERENCIA"].Rows[0]["NaoMostraGraficoAbriSistema"]);            
        }

        public DateTime DataUltimoBackupPres() 
        {
            if (DsPref.Tables["PREFERENCIA"].Rows.Count == 0)
                return DateTime.MinValue;
            if (DsPref.Tables["PREFERENCIA"].Rows[0]["DataUltimoBck"] != DBNull.Value)
                return Convert.ToDateTime(DsPref.Tables["PREFERENCIA"].Rows[0]["DataUltimoBck"]);
            else
                return DateTime.MinValue;
            
        }
        public void SetDataUltimoBackupPres(DateTime dataBackup)
        {
            if (DsPref.Tables["PREFERENCIA"].Rows.Count == 0)
            {
                DataRow row = DsPref.Tables["PREFERENCIA"].NewRow();
                row["DataUltimoBck"] = dataBackup;
                DsPref.Tables["PREFERENCIA"].Rows.Add(row);
            }
            else
                DsPref.Tables["PREFERENCIA"].Rows[0]["DataUltimoBck"] = dataBackup;
            this.SaveXML();
        }
        public void SetMostraGrafico(bool mostra) 
        {
            if (DsPref.Tables["PREFERENCIA"].Rows.Count == 0)
            {
               DataRow row = DsPref.Tables["PREFERENCIA"].NewRow();
               row["NaoMostraGraficoAbriSistema"] = mostra;
               DsPref.Tables["PREFERENCIA"].Rows.Add(row);
            }
            else
                DsPref.Tables["PREFERENCIA"].Rows[0]["NaoMostraGraficoAbriSistema"] = mostra;
            this.SaveXML();
        }
        
    }

   
}
