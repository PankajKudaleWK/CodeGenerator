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

        private static string GetFunctionBody(List<Field> fields)
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
                fields.FirstOrDefault().IdField));
            functionBodyString.Append(Environment.NewLine);

            functionBodyString.Append(JsControllerResource.definePageLoad);
            functionBodyString.Append(Environment.NewLine);

            return functionBodyString.ToString();
        }

        private static string GetFormFields(List<Field> fields)
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
            System.IO.File.WriteAllLines(filePath + fileName, lines);
        }
    }
}
