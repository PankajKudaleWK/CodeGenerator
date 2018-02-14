using CshtmlGenerator.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Resources;

namespace CshtmlGenerator.Logic
{
    public class JsControllerGenerator
    {
        public string GenerateJsControllerString(List<Field> fields)
        {
            StringBuilder jsControllerString = new StringBuilder();

            var dependency = string.Format(JsControllerResource.depedencyInjection, fields.FirstOrDefault().ModelName);
            var controllerFunctionStructure =
                string.Format(JsControllerResource.controllerFunctionStructure, fields.FirstOrDefault().ModelName,
                GetFunctionBody(fields));
            var jsControllerStructure = dependency + Environment.NewLine + controllerFunctionStructure;

            jsControllerString.Append(
                string.Format(JsControllerResource.fileJsControllerStructure
                    , fields.FirstOrDefault().ModelName, jsControllerStructure));

            return jsControllerString.ToString();
        }

        private string GetFunctionBody(List<Field> fields)
        {
            StringBuilder functionBodyString = new StringBuilder();

            functionBodyString.Append(JsControllerResource.declareCtrl);
            functionBodyString.Append(Environment.NewLine);

            functionBodyString.Append(JsControllerResource.inheritControllers);
            functionBodyString.Append(Environment.NewLine);

            functionBodyString.Append(
                string.Format(JsControllerResource.declareClassObject, fields.FirstOrDefault().ModelName));
            functionBodyString.Append(Environment.NewLine);

            functionBodyString.Append(
                string.Format(JsControllerResource.declareFormFields, GetFormFields(fields)));
            functionBodyString.Append(Environment.NewLine);

            functionBodyString.Append(
               string.Format(JsControllerResource.declareForm, fields.FirstOrDefault().ModelName + "InserirEditarForm"));
            functionBodyString.Append(Environment.NewLine);

            functionBodyString.Append(JsControllerResource.declareUrls);
            functionBodyString.Append(Environment.NewLine);

            functionBodyString.Append(
                string.Format(JsControllerResource.definePageInit, fields.FirstOrDefault().ModelName,
                fields.FirstOrDefault().IdField,
                fields.Any(f => f.FieldType == Enum.FieldType.Lookup)
                    ? JsControllerResource.callLoadLookupDataFuntion : string.Empty));
            functionBodyString.Append(Environment.NewLine);

            functionBodyString.Append(JsControllerResource.definePageLoad);
            functionBodyString.Append(Environment.NewLine);

            if (fields.Any(f => f.FieldType == Enum.FieldType.Lookup))
            {
                functionBodyString.Append(string.Format(JsControllerResource.functionInitialiseLookupStructure,
                    GetLookupFunctionDefination(fields)));
                functionBodyString.Append(Environment.NewLine);
            }

            if (fields.Any(f => f.FieldType == Enum.FieldType.Dropdown
                 && f.DropdownDatasource == Enum.DropdownDatasource.ServiceCall))
            {
                foreach (var dropdown in fields.Where(f => f.FieldType == Enum.FieldType.Dropdown
                 && f.DropdownDatasource == Enum.DropdownDatasource.ServiceCall))
                {
                    functionBodyString.Append("ctrl." + dropdown.Name + "Options = ctrl.populateDropDownList(data)");
                    functionBodyString.Append(Environment.NewLine);
                }
            }

            return functionBodyString.ToString();
        }

        private string GetLookupFunctionDefination(List<Field> fields)
        {
            StringBuilder functionBody = new StringBuilder();
            var lookups = fields.Where(f => f.FieldType == Enum.FieldType.Lookup);
            foreach (var lookup in lookups)
            {
                string lookupString = string.Empty;
                lookupString = "ctrl." + lookup.Name + "Lookup = inserirEditarService.get" + lookup.Name + "LookupData();";
                lookupString += Environment.NewLine;
                lookupString += "ctrl." + lookup.Name + "Lookup.onSelect = function(item, obj) { }";
                lookupString += Environment.NewLine;
                functionBody.Append(lookupString);
            }
            return functionBody.ToString();
        }

        private string GetFormFields(List<Field> fields)
        {
            StringBuilder formFields = new StringBuilder();
            foreach (var field in fields)
            {
                if (field.FieldType != Enum.FieldType.Title)
                {
                    var formField = field.Name + ": new formField('" + field.Name + "', {0}, [{1}]),";
                    switch (field.FieldType)
                    {
                        case Enum.FieldType.Lookup:
                            if (field.IsRequired)
                                formFields.Append(string.Format(
                                    formField, "formFieldTypes.singleLookup", "formFieldValidationTypes.required"));

                            else
                                formFields.Append(string.Format(
                                    formField, "formFieldTypes.singleLookup", string.Empty));
                            formFields.Append(Environment.NewLine);
                            break;
                        case Enum.FieldType.Dropdown:
                            if (field.IsRequired)
                                formFields.Append(string.Format(
                                    formField, "formFieldTypes.dropdown", "formFieldValidationTypes.required"));
                            else
                                formFields.Append(string.Format(
                                    formField, "formFieldTypes.dropdown", string.Empty));
                            formFields.Append(Environment.NewLine);
                            break;
                        case Enum.FieldType.Grid:
                            break;
                        default:
                            if (field.IsRequired)
                                formFields.Append(string.Format(
                                    formField, "formFieldTypes.textbox", "formFieldValidationTypes.required"));
                            else
                                formFields.Append(string.Format(
                                    formField, "formFieldTypes.textbox", string.Empty));
                            formFields.Append(Environment.NewLine);
                            break;
                    }
                }
            }
            return formFields.ToString();
        }

        public void GenerateJsControllerFile(string fileString, string modelName)
        {
            var lines = fileString.Split('\r');
            var filePath = ConfigurationManager.AppSettings["FilePath"];
            var fileName = modelName + "InserirEditarController" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".js";
            System.IO.File.WriteAllText(filePath + fileName, fileString);
        }

        public string GetServiceString(List<Field> fields)
        {
            StringBuilder serviceFile = new StringBuilder();
            serviceFile.Append(
                string.Format(JsControllerResource.fileInserirEditarServiceStructure,
                GetAllVariables(fields), GetReturnObjectVariables(fields), GetServiceFunctionBody(fields)));
            return serviceFile.ToString();
        }

        private string GetAllVariables(List<Field> fields)
        {
            StringBuilder allVariables = new StringBuilder();
            foreach (var lookup in fields.Where(f => f.FieldType == Enum.FieldType.Lookup))
            {
                allVariables.Append(string.Format("var {0}LookupData;", lookup.Name));
                allVariables.Append(Environment.NewLine);
            }
            return allVariables.ToString();
        }

        private string GetReturnObjectVariables(List<Field> fields)
        {
            StringBuilder allVariables = new StringBuilder();
            foreach (var lookup in fields.Where(f => f.FieldType == Enum.FieldType.Lookup))
            {
                allVariables.Append(string.Format("get{0}LookupData: get{0}LookupData,", lookup.Name));
                allVariables.Append(Environment.NewLine);
            }
            return allVariables.ToString();
        }

        private string GetServiceFunctionBody(List<Field> fields)
        {
            StringBuilder functionBody = new StringBuilder();
            foreach (var lookup in fields.Where(f => f.FieldType == Enum.FieldType.Lookup))
            {
                functionBody.Append(GetLookupDataFunction(lookup));
                functionBody.Append(Environment.NewLine);
                functionBody.Append(SetLookupDataFunction(lookup));
                functionBody.Append(Environment.NewLine);
            }
            return functionBody.ToString();
        }

        private string SetLookupDataFunction(Field lookup)
        {
            StringBuilder setLookpdataFunctionBody = new StringBuilder();
            setLookpdataFunctionBody.Append(
                string.Format("function set{0}LookupData() {{", lookup.Name));
            setLookpdataFunctionBody.Append(Environment.NewLine);
            setLookpdataFunctionBody.Append(
                    string.Format(JsControllerResource.setLookUp, lookup.Name));
            setLookpdataFunctionBody.Append("}");
            setLookpdataFunctionBody.Append(Environment.NewLine);

            return setLookpdataFunctionBody.ToString();
        }

        private string GetLookupDataFunction(Field lookup)
        {
            StringBuilder getFunctionBody = new StringBuilder();
            getFunctionBody.Append(string.Format("function get{0}LookupData(){{,", lookup.Name));
            getFunctionBody.Append(Environment.NewLine);
            getFunctionBody.Append(
                string.Format("if(!{0}LookupData) {{ set{0}LookupData(); }}", lookup.Name));
            getFunctionBody.Append(Environment.NewLine);
            getFunctionBody.Append(string.Format("return {0}LookupData;", lookup.Name));
            getFunctionBody.Append(Environment.NewLine);
            getFunctionBody.Append("}");
            getFunctionBody.Append(Environment.NewLine);
            return getFunctionBody.ToString();
        }

        public void GenerateJsServiceFile(string fileString, string modelName)
        {
            var lines = fileString.Split('\r');
            var filePath = ConfigurationManager.AppSettings["FilePath"];
            var fileName = modelName + "InserirEditarService" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".js";
            System.IO.File.WriteAllText(filePath + fileName, fileString);
        }
    }
}
