﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.269
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace JCNCDTDLL {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class JCNCDTCommSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static JCNCDTCommSettings defaultInstance = ((JCNCDTCommSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new JCNCDTCommSettings())));
        
        public static JCNCDTCommSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192.168.0.200")]
        public string defaultIPAddress {
            get {
                return ((string)(this["defaultIPAddress"]));
            }
            set {
                this["defaultIPAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("root")]
        public string defaultUser {
            get {
                return ((string)(this["defaultUser"]));
            }
            set {
                this["defaultUser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("deltatau")]
        public string defaultPassword {
            get {
                return ((string)(this["defaultPassword"]));
            }
            set {
                this["defaultPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("22")]
        public int defaultPort {
            get {
                return ((int)(this["defaultPort"]));
            }
            set {
                this["defaultPort"] = value;
            }
        }
    }
}
