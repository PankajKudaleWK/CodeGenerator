using CshtmlGenerator.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1.Logic
{
    public class JsDirectiveGenerator
    {
        public string GetDirectiveFileContent(List<Field> fields)
        {
            StringBuilder directiveFile = new StringBuilder();
            return directiveFile.ToString();
        }

        public string GetDirectiveControllerFileContent(List<Field> fields)
        {
            StringBuilder directiveControllerFile = new StringBuilder();
            return directiveControllerFile.ToString();
        }

        public void GenerateJsDirectiveFile(string fileString, string modelName)
        {
            var lines = fileString.Split('\r');
            var filePath = ConfigurationManager.AppSettings["FilePath"];
            var fileName = modelName + "Directive" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".js";
            System.IO.File.WriteAllLines(filePath + fileName, lines);
        }

        public void GenerateJsDirectiveControllerFile(string fileString, string modelName)
        {
            var lines = fileString.Split('\r');
            var filePath = ConfigurationManager.AppSettings["FilePath"];
            var fileName = modelName + "DirectiveController" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".js";
            System.IO.File.WriteAllLines(filePath + fileName, lines);
        }
    }
}
