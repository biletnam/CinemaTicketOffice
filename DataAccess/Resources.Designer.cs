﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DataAccess.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to осталось {0} ч {1} мин.
        /// </summary>
        internal static string HoursLeftString {
            get {
                return ResourceManager.GetString("HoursLeftString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to минуту.
        /// </summary>
        internal static string MinutesGenetivePlural {
            get {
                return ResourceManager.GetString("MinutesGenetivePlural", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to минуты.
        /// </summary>
        internal static string MinutesGenitiveSingular {
            get {
                return ResourceManager.GetString("MinutesGenitiveSingular", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to осталось {0} мин.
        /// </summary>
        internal static string MinutesLeftString {
            get {
                return ResourceManager.GetString("MinutesLeftString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to минута.
        /// </summary>
        internal static string MinutesNominative {
            get {
                return ResourceManager.GetString("MinutesNominative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Нет сеансов сегодня.
        /// </summary>
        internal static string NoShowtimesTodayText {
            get {
                return ResourceManager.GetString("NoShowtimesTodayText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 3D.
        /// </summary>
        internal static string ThreeDeeText {
            get {
                return ResourceManager.GetString("ThreeDeeText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to завтра.
        /// </summary>
        internal static string TomorrowText {
            get {
                return ResourceManager.GetString("TomorrowText", resourceCulture);
            }
        }
    }
}