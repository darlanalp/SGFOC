﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1026
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DRProjetoCadastro.BLL.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DRProjetoCadastro.BLL.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Não é possível excluir a atividade,pois existem despesas lançadas para a mesma..
        /// </summary>
        internal static string ValidaExclusaoAtividade {
            get {
                return ResourceManager.GetString("ValidaExclusaoAtividade", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Não é possível excluir a etapa, pois existem atidade(s) cadastrada(s) para a mesma..
        /// </summary>
        internal static string ValidaExclusaoEtapa {
            get {
                return ResourceManager.GetString("ValidaExclusaoEtapa", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Não é possível excluir o fornecedor, pois existem despesas associada ao mesmo..
        /// </summary>
        internal static string ValidaExclusaoFornecedor {
            get {
                return ResourceManager.GetString("ValidaExclusaoFornecedor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Não é possível excluir o investidor,pois existem lançamentos financeiros informados para o mesmo..
        /// </summary>
        internal static string ValidaExclusaoInvestidor {
            get {
                return ResourceManager.GetString("ValidaExclusaoInvestidor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Não é possível excluir a obra, pois já existem informações lançadas para a mesma..
        /// </summary>
        internal static string ValidaExclusaoObra {
            get {
                return ResourceManager.GetString("ValidaExclusaoObra", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O investidor não está associado a obra na qual o lançamento financeiro 
        ///está sendo efetuado.
        ///Acesse o cadastro do investidor e efetue o relacionamento..
        /// </summary>
        internal static string ValidaObraRelacionadaInvestidor {
            get {
                return ResourceManager.GetString("ValidaObraRelacionadaInvestidor", resourceCulture);
            }
        }
    }
}