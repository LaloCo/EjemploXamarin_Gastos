﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpensesExample.Resources {
    using System;
    using System.Reflection;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AppResources_es {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources_es() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("ExpensesExample.Resources.AppResources.es", typeof(AppResources_es).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string transportCategory {
            get {
                return ResourceManager.GetString("transportCategory", resourceCulture);
            }
        }
        
        internal static string personalCategory {
            get {
                return ResourceManager.GetString("personalCategory", resourceCulture);
            }
        }
        
        internal static string healthCategory {
            get {
                return ResourceManager.GetString("healthCategory", resourceCulture);
            }
        }
        
        internal static string savingsCategory {
            get {
                return ResourceManager.GetString("savingsCategory", resourceCulture);
            }
        }
        
        internal static string playCategory {
            get {
                return ResourceManager.GetString("playCategory", resourceCulture);
            }
        }
        
        internal static string housingCategory {
            get {
                return ResourceManager.GetString("housingCategory", resourceCulture);
            }
        }
        
        internal static string otherCategory {
            get {
                return ResourceManager.GetString("otherCategory", resourceCulture);
            }
        }
    }
}