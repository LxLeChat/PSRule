﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSRule.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ReasonStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ReasonStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PSRule.Resources.ReasonStrings", typeof(ReasonStrings).Assembly);
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
        ///   Looks up a localized string similar to None of the field(s) existed: {0}.
        /// </summary>
        internal static string Exists {
            get {
                return ResourceManager.GetString("Exists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The field &apos;{0}&apos; exists..
        /// </summary>
        internal static string ExistsNot {
            get {
                return ResourceManager.GetString("ExistsNot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to None of the regex(s) matched: {0}.
        /// </summary>
        internal static string Match {
            get {
                return ResourceManager.GetString("Match", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The regex &apos;{0}&apos; matched..
        /// </summary>
        internal static string MatchNot {
            get {
                return ResourceManager.GetString("MatchNot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to None of the type name(s) match: {0}.
        /// </summary>
        internal static string TypeOf {
            get {
                return ResourceManager.GetString("TypeOf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The field value didn&apos;t match the set..
        /// </summary>
        internal static string Within {
            get {
                return ResourceManager.GetString("Within", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; was within the set..
        /// </summary>
        internal static string WithinNot {
            get {
                return ResourceManager.GetString("WithinNot", resourceCulture);
            }
        }
    }
}