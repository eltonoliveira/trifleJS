﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5472
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrifleJS.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TrifleJS.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to 
        ///// Initialise Namespace
        ///this.triflejs = this.triflejs || {};
        ///
        ///(function(GLOBAL) {
        ///
        ///    // Add UID generation
        ///    triflejs.uid = function() {
        ///        var s4 = function() {
        ///            return Math.floor((1 + Math.random()) * 0x10000)
        ///             .toString(16)
        ///             .substring(1);
        ///        };
        ///
        ///        return s4() + s4();
        ///    };
        ///
        ///    // Set interop inside trifle
        ///    triflejs._interop = GLOBAL._interop;
        ///    delete GLOBAL._interop;
        ///
        ///    // Initialize callback hashmap
        ///    triflejs.cal [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string triflejs_core {
            get {
                return ResourceManager.GetString("triflejs_core", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* triflejs.init.js
        ///*
        ///* By: Steven de Salas
        ///* On: Sep 2013
        ///* 
        ///*
        ///* Runs instructions to initialize the host environment.
        ///*
        ///* This is particularly important in order to pipe
        ///* asyncronous callbacks as these are not currently
        ///* supported in the Javascript.NET project.
        ///* 
        ///*/
        ///
        ///
        ///console._debug(&quot;Initializing require()&quot;);
        ///
        ///// Loading module framework
        ///// @see http://wiki.commonjs.org/wiki/Modules/1.1.1
        ///this.exports = {
        ///    webpage: function() {
        ///        return new triflejs.modules.WebPage();
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string triflejs_init {
            get {
                return ResourceManager.GetString("triflejs_init", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///// Initialise Namespace
        ///this.triflejs = this.triflejs || {};
        ///
        ///// Wrap code to avoid global vars
        ///(function(triflejs) {
        ///
        ///    // Define namespace
        ///    modules = triflejs.modules = triflejs.modules || {};
        ///
        ///    // WebPage Class
        ///    // Define Constructor
        ///    var WebPage = triflejs.modules.WebPage = function() {
        ///        console._debug(&quot;new WebPage()&quot;);
        ///        // Instantiate a C# webpage and store it in _interop property
        ///        this._interop = triflejs._interop[&apos;WebPage&apos;]();
        ///        // Fire Initia [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string triflejs_modules {
            get {
                return ResourceManager.GetString("triflejs_modules", resourceCulture);
            }
        }
    }
}