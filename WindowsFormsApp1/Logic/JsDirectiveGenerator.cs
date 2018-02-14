using CshtmlGenerator.Enum;
using CshtmlGenerator.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using WindowsFormsApp1.Resources;

namespace CshtmlGenerator.Logic
{
    public class JsDirectiveGenerator
    {
        public string GetDirectiveFileContent(List<Field> fields)
        {
            StringBuilder directiveFile = new StringBuilder();
            foreach (var grid in fields.Where(f => f.FieldType == FieldType.Grid))
            {
                directiveFile.Append(
                string.Format(JsControllerResource.fileGridDirectiveStructure, grid.Name));
            }
            return directiveFile.ToString();
        }

        public string GetDirectiveControllerFileContent(List<Field> fields)
        {
            StringBuilder directiveControllerFile = new StringBuilder();
            foreach (var field in fields.Where(f => f.FieldType == FieldType.Grid))
            {
                directiveControllerFile.Append(
                string.Format(JsControllerResource.fileDirectiveControllerSructure,
                field.Name, field.GridIdField, GetGridFields(field), GetGridColumns(field)));
            }
            return directiveControllerFile.ToString();
        }

        public void GenerateJsDirectiveFile(List<Field> fields, string modelName)
        {
            string fileString = GetDirectiveFileContent(fields);
            var filePath = ConfigurationManager.AppSettings["FilePath"];
            var fileName = modelName + "Directive" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".js";
            System.IO.File.WriteAllText(filePath + fileName, fileString);
        }

        public void GenerateJsDirectiveControllerFile(List<Field> fields, string modelName)
        {
            string fileString = GetDirectiveControllerFileContent(fields);
            var filePath = ConfigurationManager.AppSettings["FilePath"];
            var fileName = modelName + "DirectiveController" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".js";
            System.IO.File.WriteAllText(filePath + fileName, fileString);
        }

        private string GetGridColumns(Field field)
        {
            StringBuilder gridColumns = new StringBuilder();
            gridColumns.Append(
                string.Format(JsControllerResource.gridGenericCheckbox, field.GridIdField));
            gridColumns.Append(",");
            gridColumns.Append(Environment.NewLine);

            gridColumns.Append(
                string.Format(JsControllerResource.gridGenericIcon, field.GridIdField, "visualizeTemplate"));
            gridColumns.Append(",");
            gridColumns.Append(Environment.NewLine);

            gridColumns.Append(
                string.Format(JsControllerResource.gridGenericIcon, field.GridIdField, "editTemplate"));
            gridColumns.Append(",");
            gridColumns.Append(Environment.NewLine);

            gridColumns.Append(
                string.Format(JsControllerResource.gridGenericIcon, field.GridIdField, "deleteTemplate "));
            gridColumns.Append(",");
            gridColumns.Append(Environment.NewLine);

            foreach (var column in field.GridOtherFields.Split(','))
            {
                gridColumns.Append(
                    string.Format(JsControllerResource.gridGenericColumn, column));
                gridColumns.Append(",");
                gridColumns.Append(Environment.NewLine);
            }

            return gridColumns.ToString();
        }

        private string GetGridFields(Field field)
        {
            StringBuilder gridFields = new StringBuilder();
            gridFields.Append(
                    string.Format("{0}: {{type: 'number'}}", field.GridIdField));
            gridFields.Append(",");
            gridFields.Append(Environment.NewLine);
            foreach (var gridField in field.GridOtherFields.Split(','))
            {
                gridFields.Append(
                    string.Format("{0}: {{type: 'string'}}", gridField));
                gridFields.Append(",");
                gridFields.Append(Environment.NewLine);
            }
            return gridFields.ToString();
        }
    }
}
