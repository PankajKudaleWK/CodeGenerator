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
            return directiveControllerFile.ToString();
        }

        public void GenerateJsDirectiveFile(List<Field> fields, string modelName)
        {
            string fileString = GetDirectiveFileContent(fields);
            var lines = fileString.Split('\r');
            var filePath = ConfigurationManager.AppSettings["FilePath"];
            var fileName = modelName + "Directive" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".js";
            System.IO.File.WriteAllLines(filePath + fileName, lines);
        }

        public void GenerateJsDirectiveControllerFile(List<Field> fields, string modelName)
        {
            string fileString = GetDirectiveControllerFileContent(fields);
            var lines = fileString.Split('\r');
            var filePath = ConfigurationManager.AppSettings["FilePath"];
            var fileName = modelName + "DirectiveController" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".js";
            System.IO.File.WriteAllLines(filePath + fileName, lines);
        }
    }
}
