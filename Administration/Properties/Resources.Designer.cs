﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Administration.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Administration.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Предпринимается попытка удалить зал &quot;{0}&quot;. Все сеансы в этом зале будут удалены. Подтвердить удаление?.
        /// </summary>
        internal static string DeleteAuditoriumConfirmationText {
            get {
                return ResourceManager.GetString("DeleteAuditoriumConfirmationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Подтверждение.
        /// </summary>
        internal static string DeleteConfirmationCaption {
            get {
                return ResourceManager.GetString("DeleteConfirmationCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Предпринимается попытка удалить жанр &quot;{0}&quot;. Подтвердить удаление?.
        /// </summary>
        internal static string DeleteGenreConfirmationText {
            get {
                return ResourceManager.GetString("DeleteGenreConfirmationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Предпринимается попытка удалить фильм &quot;{0}&quot;. Подтвердить удаление?.
        /// </summary>
        internal static string DeleteMovieConfirmationText {
            get {
                return ResourceManager.GetString("DeleteMovieConfirmationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Предпринимается попытка удалить сеанс {0} (&quot;{1}&quot;). Подтвердить удаление?.
        /// </summary>
        internal static string DeleteShowtimeConfirmatonText {
            get {
                return ResourceManager.GetString("DeleteShowtimeConfirmatonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Предпринимается попытка аннулировать билет. Подтвердить аннулирование?.
        /// </summary>
        internal static string DeleteTicketConfirmatonText {
            get {
                return ResourceManager.GetString("DeleteTicketConfirmatonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Предпринимается попытка удалить пользователя {0}. Подтвердить удаление?.
        /// </summary>
        internal static string DeleteUserConfirmatonText {
            get {
                return ResourceManager.GetString("DeleteUserConfirmatonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Пользователь, с которым производится вход не является  администратором GreenBird.
        /// </summary>
        internal static string InvalidUserMessageText {
            get {
                return ResourceManager.GetString("InvalidUserMessageText", resourceCulture);
            }
        }
    }
}
