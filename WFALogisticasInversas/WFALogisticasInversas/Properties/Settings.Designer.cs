﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFALogisticasInversas.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=sql7003.site4now.net;Initial Catalog=DB_A3F19C_OpenGate;Persist Secur" +
            "ity Info=True;User ID=DB_A3F19C_OpenGate_admin;Password=xQ9znAhU")]
        public string DB_A3F19C_OpenGateConnectionString {
            get {
                return ((string)(this["DB_A3F19C_OpenGateConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=sql7001.site4now.net;Initial Catalog=DB_A3F19C_Inventarios;Persist Se" +
            "curity Info=True;User ID=DB_A3F19C_Inventarios_admin;Password=xQ9znAhU")]
        public string DB_A3F19C_InventariosConnectionString {
            get {
                return ((string)(this["DB_A3F19C_InventariosConnectionString"]));
            }
        }
    }
}
