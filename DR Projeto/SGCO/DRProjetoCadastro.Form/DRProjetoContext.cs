using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DRProjetoCadastro.BLL;

namespace DRProjetoCadastro.Form
{
    public class Projeto 
    {
        public string GetSysName() 
        {
            return @"SGFOC - Sistema de Gerenciamento Financeiro de Obra Civil";
        }
        public string VersionSys 
        {
            get { return "1.5"; }
        }
        public string GetVersionSys() 
        {
            return "Versão " + VersionSys;
        }

        public int CodProjeto;
        public DateTime DataUltimoBck;
        public string NomeProjeto;
        public string strCon;
        public string GetFiltroProjeto() 
        {
             return string.Format("(CODIGOPRJ = {0})", this.CodProjeto);
        }
        public InfoCxt InforParam 
        {
            get
            {
                if (_InforParam == null)
                     _InforParam = new InfoCxt();
                return _InforParam;
            }
            set { _InforParam = value; }
        }
        private InfoCxt _InforParam;
        public DRUltils_SGFOC PreferenciaLocal
        {
            get
            {
                if (_PreferenciaLocal == null)
                    _PreferenciaLocal = new DRUltils_SGFOC();
                return _PreferenciaLocal;
            }
        }DRUltils_SGFOC _PreferenciaLocal;
    }
    public static class DRProjetoContext
    {
        public static Projeto DRProjeto
        {
            get
            {
                if (_DRProjeto == null) { _DRProjeto = new Projeto(); }
                return _DRProjeto;
            }
        }
        public static Projeto _DRProjeto;

    }

    public class InfoCxt
    {
        public string CodEtapa;
        public int CodProjeto;
        public string CodAtividade;
        public bool TotalizadoresAtivado = false;
    }
}
