﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grabacr07.KanColleWrapper.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Grabacr07.KanColleWrapper.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to 初動作戦.
        /// </summary>
        internal static string SallyArea_Area1_Name {
            get {
                return ResourceManager.GetString("SallyArea_Area1_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 機動部隊.
        /// </summary>
        internal static string SallyArea_Area2_Name {
            get {
                return ResourceManager.GetString("SallyArea_Area2_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 挺身部隊.
        /// </summary>
        internal static string SallyArea_Area3_Name {
            get {
                return ResourceManager.GetString("SallyArea_Area3_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 艦娘と装備の索敵値の単純な合計値.
        /// </summary>
        internal static string ViewRange_Type1_Description {
            get {
                return ResourceManager.GetString("ViewRange_Type1_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 単純計算.
        /// </summary>
        internal static string ViewRange_Type1_Name {
            get {
                return ResourceManager.GetString("ViewRange_Type1_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (偵察機 × 2) + (電探) + √(装備込みの艦隊索敵値合計 - 偵察機 - 電探).
        /// </summary>
        internal static string ViewRange_Type2_Description {
            get {
                return ResourceManager.GetString("ViewRange_Type2_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 2-5 式 (旧).
        /// </summary>
        internal static string ViewRange_Type2_Name {
            get {
                return ResourceManager.GetString("ViewRange_Type2_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (艦上爆撃機 × 1.04) + (艦上攻撃機 × 1.37) + (艦上偵察機 × 1.66)
        ///+ (水上偵察機 × 2.00) + (水上爆撃機 × 1.78) + (探照灯 × 0.91)
        ///+ (小型電探 × 1.00) + (大型電探 × 0.99) + (√各艦毎の素索敵 × 1.69)
        ///+ (司令部レベルを 5 の倍数に切り上げ × -0.61).
        /// </summary>
        internal static string ViewRange_Type3_Description {
            get {
                return ResourceManager.GetString("ViewRange_Type3_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 2-5 式 (秋).
        /// </summary>
        internal static string ViewRange_Type3_Name {
            get {
                return ResourceManager.GetString("ViewRange_Type3_Name", resourceCulture);
            }
        }
    }
}
