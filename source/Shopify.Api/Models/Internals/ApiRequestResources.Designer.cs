﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shopify.Api.Models.Internals {
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
    internal class ApiRequestResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ApiRequestResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Shopify.Api.Models.Internals.ApiRequestResources", typeof(ApiRequestResources).Assembly);
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
        ///   Looks up a localized string similar to /admin/webhooks/{0}.json.
        /// </summary>
        internal static string DeleteWebhook {
            get {
                return ResourceManager.GetString("DeleteWebhook", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /admin/webhooks.json.
        /// </summary>
        internal static string GetWebhooksAll {
            get {
                return ResourceManager.GetString("GetWebhooksAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /admin/webhooks/count.json.
        /// </summary>
        internal static string GetWebhooksAllCount {
            get {
                return ResourceManager.GetString("GetWebhooksAllCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /admin/webhooks/{0}.json.
        /// </summary>
        internal static string GetWebhookSingle {
            get {
                return ResourceManager.GetString("GetWebhookSingle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /admin/webhooks.json.
        /// </summary>
        internal static string PostWebhookCreate {
            get {
                return ResourceManager.GetString("PostWebhookCreate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /admin/webhooks/{0}.json.
        /// </summary>
        internal static string PutWebhookUpdate {
            get {
                return ResourceManager.GetString("PutWebhookUpdate", resourceCulture);
            }
        }
    }
}