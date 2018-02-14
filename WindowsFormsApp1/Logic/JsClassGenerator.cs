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
    public class JsClassGenerator
    {
        public string GetJsClassString(List<Field> fields)
        {
            StringBuilder jsClassString = new StringBuilder();
            StringBuilder properties = new StringBuilder();
            foreach (var field in fields)
            {
                if (field.FieldType != Enum.FieldType.Title)
                {
                    properties.Append("\r this.");
                    properties.Append(field.Name);
                    properties.Append(" = null;");
                }
            }
            if (!string.IsNullOrEmpty(properties.ToString()))
            {
                jsClassString.Append(
                string.Format(htmlGeneratorResource.fileJsClassStructure, fields.FirstOrDefault().ModelName,
                properties));
            }
            
            return jsClassString.ToString();
        }

        public void GenerateJsFile(string text, string modelName)
        {
            var filePath = ConfigurationManager.AppSettings["FilePath"];
            var fileName = modelName + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".js";
            System.IO.File.WriteAllText(filePath + fileName, text);
        }
    }
}
