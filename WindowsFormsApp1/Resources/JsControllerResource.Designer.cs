﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class JsControllerResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal JsControllerResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WindowsFormsApp1.Resources.JsControllerResource", typeof(JsControllerResource).Assembly);
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
        ///   Looks up a localized string similar to initialiseLookups();.
        /// </summary>
        internal static string callLoadLookupDataFuntion {
            get {
                return ResourceManager.GetString("callLoadLookupDataFuntion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to function {0}($scope, $controller,
        ///	form,
        ///	formField,
        ///	formFieldValidationTypes,
        ///        formFieldTypes,
        ///        iFrameEntity,
        ///        parent,
        ///        lookupData,
        ///        lookupConstants,
        ///        tipousuario,
        ///	globalService,
        ///         inserirEditarService){{
        ///        {1}    
        ///
        ///    }}.
        /// </summary>
        internal static string controllerFunctionStructure {
            get {
                return ResourceManager.GetString("controllerFunctionStructure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var {0} = {{}};.
        /// </summary>
        internal static string declareClassObject {
            get {
                return ResourceManager.GetString("declareClassObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var ctrl = this;.
        /// </summary>
        internal static string declareCtrl {
            get {
                return ResourceManager.GetString("declareCtrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ctrl.form = new form(&quot;{0}&quot;, formFields);.
        /// </summary>
        internal static string declareForm {
            get {
                return ResourceManager.GetString("declareForm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var formFields = {{ {0} }};.
        /// </summary>
        internal static string declareFormFields {
            get {
                return ResourceManager.GetString("declareFormFields", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ctrl.urls = {
        ///webapi: {},
        ///mvc: {}
        ///} .
        /// </summary>
        internal static string declareUrls {
            get {
                return ResourceManager.GetString("declareUrls", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ctrl.pageInit = function (initObject) {{
        ///
        ///            ctrl.successMessageFromServer = initObject.resources.msg;
        ///            initObject.resources.msg = &quot;&quot;;
        ///            ctrl.__proto__.pageInit.call(this, initObject);
        ///
        ///            ctrl.parent = new iFrameEntity(&quot;{0}&quot;, &quot;{1}&quot;, &quot;{1}&quot;,                         
        ///ctrl.page.initObject.resources.labelForTabForSingleRecord,                         
        ///ctrl.page.initObject.resources.labelForTabForMultiRecords,                         
        ///ctrl.page.initObject.resources [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string definePageInit {
            get {
                return ResourceManager.GetString("definePageInit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ctrl.pageLoad = function (id, detail, ids) {
        ///            ctrl.__proto__.pageLoad.call(this, id, detail, ids)
        ///                .then(ctrl.obterEntitySuccessCallback, ctrl.obterEntityErrorCallback);
        ///        }.
        /// </summary>
        internal static string definePageLoad {
            get {
                return ResourceManager.GetString("definePageLoad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.$inject = [&apos;$scope&apos;, &apos;$controller&apos;, 
        ///	&apos;wkp.framework.classes.form&apos;,
        ///        &apos;wkp.framework.classes.formField&apos;,
        ///        &apos;wkp.constants.formFieldValidationTypes&apos;,
        ///        &apos;wkp.constants.formFieldTypes&apos;,
        ///        &apos;wkp.framework.classes.iFrameEntity&apos;,
        ///        &apos;wkp.framework.classes.parent&apos;,
        ///        &apos;wkp.framework.services.lookupData&apos;,
        ///        &apos;wkp.constants.lookupConstants&apos;,
        ///        &apos;wkp.constants.tipousuario&apos;,
        ///	&apos;wkp.framework.services.globalService&apos;,
        ///        &apos;services.inserirEditarService&apos;
        ///    ].
        /// </summary>
        internal static string depedencyInjection {
            get {
                return ResourceManager.GetString("depedencyInjection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //it will accept following variables from main page controller
        /////ctrl.gridItems: &apos;=&apos;, //actual data
        /////parentId: &apos;@&apos;,                
        /////parentMethods: = ( save and clear errors)     
        ///
        ///(function (){{
        ///    &apos;use strict&apos;;
        ///    var controllerId = &apos;controllers.{0}GridDirectiveController&apos;;
        ///    angular.module(&apos;&apos;)
        ///        .controller(controllerId, {0}GridDirectiveController);
        ///
        ///    {0}GridDirectiveController.$inject = [&apos;$controller&apos;,
        ///        &apos;$scope&apos;,
        ///        &apos;wkp.framework.services.globalService&apos;,
        ///        [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string fileDirectiveControllerSructure {
            get {
                return ResourceManager.GetString("fileDirectiveControllerSructure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (function () {{	
        ///       &apos;use strict&apos;;
        ///         angular.module(&apos;&apos;).directive(&apos;{0}Grid&apos;, {0}Grid);
        ///
        ///         function {0}Grid() {{
        ///              return{{
        ///                    restrict: &apos;E&apos;,
        ///                    templateUrl: _userContext.endpoints.StaticContent + &apos;/Views/{0}GridDirective.html&apos;,
        ///                    controller: &apos;controllers.monitoramentoPainelGridDirectiveController&apos;,
        ///                    scope: {{
        ///                          parentMethods: &apos;=&apos;,
        ///                          parentId: &apos;@&apos;,
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string fileGridDirectiveStructure {
            get {
                return ResourceManager.GetString("fileGridDirectiveStructure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (function () {{
        ///    &apos;use strict&apos;;
        ///    var serviceName = &apos;services.inserirEditarService&apos;;
        ///
        ///    angular.module(&apos;&apos;)
        ///        .factory(serviceName, inserirEdiatarService);
        ///
        ///    inserirEditarService.$inject = [&apos;wkp.constants.navButtonsType&apos;,
        ///        &apos;wkp.constants.navButtonsGroupType&apos;,
        ///        &apos;wkp.framework.classes.navButton&apos;,
        ///        &apos;wkp.framework.classes.navButtonGroup&apos;,
        ///        &apos;wkp.framework.services.lookupData&apos;,
        ///        &apos;wkp.constants.lookupConstants&apos;,
        ///        &apos;wkp.framework.services.globalHtt [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string fileInserirEditarServiceStructure {
            get {
                return ResourceManager.GetString("fileInserirEditarServiceStructure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (function () {{
        ///    &apos;use strict&apos;;
        ///    var controllerName = &apos;controllers.{0}&apos;;
        ///    angular.module(&apos;&apos;).controller(controllerName, {0});
        ///
        ///    {1}
        ///
        ///}})();.
        /// </summary>
        internal static string fileJsControllerStructure {
            get {
                return ResourceManager.GetString("fileJsControllerStructure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to function initialiseLookups(){{
        ///    {0}
        ///}}.
        /// </summary>
        internal static string functionInitialiseLookupStructure {
            get {
                return ResourceManager.GetString("functionInitialiseLookupStructure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {{
        ///                    field: &apos;{0}&apos;,
        ///                    title: &apos;&lt;input type=\&apos;checkbox\&apos; id=\&apos;selectAll_{{ctrl.grid.name}}\&apos; name=\&apos;selectAll\&apos; class=\&apos;selectedAll\&apos; ng-click=\&apos;ctrl.gridUtils.selectCheckbox($event, ctrl.grid.selectedItems, true, ctrl.grid.name)\&apos; value=\&apos;#={0}#\&apos; /&gt;&apos;,
        ///                    filterable: false,
        ///                    sortable: false,
        ///                    template: &apos;&lt;input type=\&apos;checkbox\&apos; id=\&apos;select\&apos; name=\&apos;select\&apos; class=\&apos;selectedIds_{{ctrl.grid.name}}\&apos; ng-click=\&apos;ctrl.g [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string gridGenericCheckbox {
            get {
                return ResourceManager.GetString("gridGenericCheckbox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {{
        ///                    field: &apos;{0}&apos;,
        ///                    title: gridNames[_userContext.culture].{0},
        ///                    width: 400
        ///                }}.
        /// </summary>
        internal static string gridGenericColumn {
            get {
                return ResourceManager.GetString("gridGenericColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {{
        ///                    field: &apos;{0}&apos;,
        ///                    title: &apos; &apos;,
        ///                    filterable: false,
        ///                    sortable: false,
        ///                    template: {1},
        ///                    width: 34,
        ///                    locked: true,
        ///                    lockable: false,
        ///                    columnMenu: false,
        ///                    menu: false
        ///                }}.
        /// </summary>
        internal static string gridGenericIcon {
            get {
                return ResourceManager.GetString("gridGenericIcon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to $controller(&apos;wkp.framework.controllers.baseController&apos;, { ctrl: ctrl });
        ///$controller(&apos;Wkp.Framework.Controllers.inserirEditarGlobalController&apos;, { ctrl: ctrl });.
        /// </summary>
        internal static string inheritControllers {
            get {
                return ResourceManager.GetString("inheritControllers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var lookupinfo = {{
        ///                module: &apos;&apos;, page: &apos;InserirEditar&apos;, name: &apos;{0}&apos;,
        ///                type: lookupConstants.types.singleLookup, key: &apos;&apos;
        ///            }};
        ///            var lookupOptions = lookupDataService.get{0}LookupOptions();
        ///            {0}LookupData = new lookupData(lookupOptions, lookupinfo);.
        /// </summary>
        internal static string setLookUp {
            get {
                return ResourceManager.GetString("setLookUp", resourceCulture);
            }
        }
    }
}
