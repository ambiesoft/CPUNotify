﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CPUNotify.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CPUNotify.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &amp;Pause.
        /// </summary>
        internal static string PAUSE {
            get {
                return ResourceManager.GetString("PAUSE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Start.
        /// </summary>
        internal static string START {
            get {
                return ResourceManager.GetString("START", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Average Usage.
        /// </summary>
        internal static string STR_AVERAGE_USAGE {
            get {
                return ResourceManager.GetString("STR_AVERAGE_USAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to consecutively.
        /// </summary>
        internal static string STR_CONSECUTIVELY {
            get {
                return ResourceManager.GetString("STR_CONSECUTIVELY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the cpu usage hits ({0} &lt;= usage &lt;= {1}) {2} for {3} seconds,.
        /// </summary>
        internal static string STR_CPU_USAGE {
            get {
                return ResourceManager.GetString("STR_CPU_USAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to in average.
        /// </summary>
        internal static string STR_IN_AVERAGE {
            get {
                return ResourceManager.GetString("STR_IN_AVERAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}%&apos; in average for last {1} secs, current usage &apos;{2}%&apos;.
        /// </summary>
        internal static string STR_PROGRESS_AVERAGE {
            get {
                return ResourceManager.GetString("STR_PROGRESS_AVERAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Hits in consecutive {1} secs, current cpu &apos;{2}%&apos;.
        /// </summary>
        internal static string STR_PROGRESS_CONSECUTIVE {
            get {
                return ResourceManager.GetString("STR_PROGRESS_CONSECUTIVE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to seconds.
        /// </summary>
        internal static string STR_SECONDS {
            get {
                return ResourceManager.GetString("STR_SECONDS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage.
        /// </summary>
        internal static string STR_USAGE {
            get {
                return ResourceManager.GetString("STR_USAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Paused.
        /// </summary>
        internal static string TITLE_PAUSED {
            get {
                return ResourceManager.GetString("TITLE_PAUSED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Watching.
        /// </summary>
        internal static string TITLE_WATCHING {
            get {
                return ResourceManager.GetString("TITLE_WATCHING", resourceCulture);
            }
        }
    }
}
