using CshtmlGenerator.Enum;
using CshtmlGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApp1.Resources;

namespace CshtmlGenerator.Logic
{
    public class CshtmlGenerator
    {
        public Field GetFieldObject(string name, string title, string modelName, int length, string dropdownViewdata,
            DropdownDatasource dropdownDatasource, bool isRequired, bool isHelpIcon, string helpText, bool isMultiLookup,
            FieldType fieldType, int min, int max, int step, int precision, string className)
        {
            return new Field
            {
                DropdownDatasource = dropdownDatasource,
                DropdownViewDataName = dropdownViewdata,
                FieldType = fieldType,
                HelpIconText = helpText,
                IsHelpIconRequired = isHelpIcon,
                IsMultiLoopup = isMultiLookup,
                IsRequired = isRequired,
                Length = length,
                Max = max,
                Min = min,
                ModelName = modelName,
                Name = name,
                Precision = precision,
                Step = step,
                Title = title,
                ClassName = className
            };
        }

        public string GenerateCshtmlString(List<Field> fields)
        {
            StringBuilder cshtmlString = new StringBuilder();
            foreach (var field in fields)
            {
                switch (field.FieldType)
                {
                    case FieldType.Title:
                        cshtmlString.Append(GetTitleString(field));
                        break;
                    case FieldType.Textbox:
                        cshtmlString.Append(GetTextboxString(field));
                        break;
                    case FieldType.TextArea:
                        cshtmlString.Append(GetTextAreaString(field));
                        break;
                    case FieldType.Dropdown:
                        cshtmlString.Append(GetDropdownString(field));
                        break;
                    case FieldType.Lookup:
                        cshtmlString.Append(GetLookupString(field));
                        break;
                    case FieldType.Date:
                        cshtmlString.Append(GetDateString(field, false));
                        break;
                    case FieldType.Month:
                        cshtmlString.Append(GetDateString(field, true));
                        break;
                    case FieldType.Time:
                        cshtmlString.Append(GetTimeString(field));
                        break;
                    case FieldType.Number:
                        cshtmlString.Append(GetNumberString(field));
                        break;
                    case FieldType.Grid:
                        break;
                    default:
                        break;

                }
            }
            GenerateFiles(cshtmlString.ToString());
            return cshtmlString.ToString();
        }

        private string GetTitleString(Field field)
        {
            StringBuilder title = new StringBuilder();
            title.Append(string.Format(htmlGeneratorResource.tagDivStart, field.ClassName));
            title.Append(Environment.NewLine);
            title.Append(string.Format(htmlGeneratorResource.fieldTitle, field.Title));
            title.Append(Environment.NewLine);
            title.Append(htmlGeneratorResource.tagDivClose);
            title.Append(Environment.NewLine);
            return title.ToString();
        }

        private string GetTextboxString(Field field)
        {
            var maxLengthAttribute = field.Length > 0 
                ? string.Format(htmlGeneratorResource.attrMaxLength, field.Length) 
                : string.Empty;
            StringBuilder textBox = new StringBuilder();
            textBox.Append(string.Format(htmlGeneratorResource.tagDivStart, field.ClassName));
            textBox.Append(Environment.NewLine);

            textBox.Append(string.Format(htmlGeneratorResource.tagLabel, field.Title));
            textBox.Append(Environment.NewLine);

            textBox.Append(string.Format(htmlGeneratorResource.fieldTextBox, 
                field.Name, maxLengthAttribute, field.ModelName));
            textBox.Append(Environment.NewLine);

            if (field.IsRequired)
            {
                textBox.Append(string.Format(htmlGeneratorResource.tagRequiredField,
                    field.ModelName + "inserirEditarForm", field.Name));
                textBox.Append(Environment.NewLine);
            }

            textBox.Append(htmlGeneratorResource.tagDivClose);
            textBox.Append(Environment.NewLine);
            
            return textBox.ToString();
        }

        private string GetTextAreaString(Field field)
        {
            var maxLengthAttribute = field.Length > 0
                ? string.Format(htmlGeneratorResource.attrMaxLength, field.Length)
                : string.Empty;
            StringBuilder textArea = new StringBuilder();
            textArea.Append(string.Format(htmlGeneratorResource.tagDivStart, field.ClassName));
            textArea.Append(Environment.NewLine);

            textArea.Append(string.Format(htmlGeneratorResource.tagLabel, field.Title));
            textArea.Append(Environment.NewLine);

            textArea.Append(string.Format(htmlGeneratorResource.fieldTextArea,
                field.Name, maxLengthAttribute, field.ModelName));
            textArea.Append(Environment.NewLine);

            if (field.IsRequired)
            {
                textArea.Append(string.Format(htmlGeneratorResource.tagRequiredField,
                    field.ModelName + "inserirEditarForm", field.Name));
                textArea.Append(Environment.NewLine);
            }

            textArea.Append(htmlGeneratorResource.tagDivClose);
            textArea.Append(Environment.NewLine);

            return textArea.ToString();
        }

        private string GetDropdownString(Field field)
        {
            var dropdownKeyValue = field.DropdownDatasource == DropdownDatasource.ViewData
                ? htmlGeneratorResource.attrTextValueForDropdown : string.Empty;
            var dropdownEnum = field.DropdownDatasource == DropdownDatasource.ViewData
                ? string.Format(htmlGeneratorResource.attrKOptionValueForDropdownViewData, field.DropdownViewDataName)
                : string.Empty;
            var attrKOptions = field.DropdownDatasource == DropdownDatasource.ViewData
                ? string.Format(htmlGeneratorResource.attrKOptionsForDropdown, dropdownEnum)
                : string.Format(htmlGeneratorResource.attrKOptionsForDropdown, "ctrl." + field.Name + "options");

            StringBuilder dropdown = new StringBuilder();
            dropdown.Append(string.Format(htmlGeneratorResource.tagDivStart, field.ClassName));
            dropdown.Append(Environment.NewLine);

            dropdown.Append(string.Format(htmlGeneratorResource.tagLabel, field.Title));
            dropdown.Append(Environment.NewLine);

            dropdown.Append(string.Format(htmlGeneratorResource.fieldDropdown,
                field.Name, dropdownKeyValue, attrKOptions ,field.ModelName));
            dropdown.Append(Environment.NewLine);

            if (field.IsRequired)
            {
                dropdown.Append(string.Format(htmlGeneratorResource.tagRequiredField,
                    field.ModelName + "inserirEditarForm", field.Name));
                dropdown.Append(Environment.NewLine);
            }

            dropdown.Append(htmlGeneratorResource.tagDivClose);
            dropdown.Append(Environment.NewLine);

            return dropdown.ToString();
        }

        private string GetLookupString(Field field)
        {
            var multipleLookupAttr = field.IsMultiLoopup ? htmlGeneratorResource.attrLookupMultiple : string.Empty;

            StringBuilder lookup = new StringBuilder();
            lookup.Append(string.Format(htmlGeneratorResource.tagDivStart, field.ClassName));
            lookup.Append(Environment.NewLine);

            lookup.Append(string.Format(htmlGeneratorResource.tagLabel, field.Title));
            lookup.Append(Environment.NewLine);

            lookup.Append(string.Format(htmlGeneratorResource.fieldLookup,
                field.Name, multipleLookupAttr, field.Name + "LookupOptions" ,field.ModelName, field.Title));
            lookup.Append(Environment.NewLine);

            if (field.IsRequired)
            {
                lookup.Append(string.Format(htmlGeneratorResource.tagRequiredField,
                    field.ModelName + "inserirEditarForm", field.Name));
                lookup.Append(Environment.NewLine);
            }

            lookup.Append(htmlGeneratorResource.tagDivClose);
            lookup.Append(Environment.NewLine);

            return lookup.ToString();
        }

        private string GetDateString(Field field, bool isMesAno)
        {
            var dateOrMesAno = isMesAno 
                ? htmlGeneratorResource.attrMonthField 
                : htmlGeneratorResource.attrDateField;

            StringBuilder date = new StringBuilder();
            date.Append(string.Format(htmlGeneratorResource.tagDivStart, field.ClassName));
            date.Append(Environment.NewLine);

            date.Append(string.Format(htmlGeneratorResource.tagLabel, field.Title));
            date.Append(Environment.NewLine);

            date.Append(string.Format(htmlGeneratorResource.fieldDateMonth,
                field.Name, dateOrMesAno, field.ModelName));
            date.Append(Environment.NewLine);

            if (field.IsRequired)
            {
                date.Append(string.Format(htmlGeneratorResource.tagRequiredField,
                    field.ModelName + "inserirEditarForm", field.Name));
                date.Append(Environment.NewLine);
            }

            date.Append(htmlGeneratorResource.tagDivClose);
            date.Append(Environment.NewLine);

            return date.ToString();
        }

        private string GetTimeString(Field field)
        {
            var attrRequired = field.IsRequired ? htmlGeneratorResource.attrRequired : string.Empty;

            StringBuilder time = new StringBuilder();
            time.Append(string.Format(htmlGeneratorResource.tagDivStart, field.ClassName));
            time.Append(Environment.NewLine);

            time.Append(string.Format(htmlGeneratorResource.tagLabel, field.Title));
            time.Append(Environment.NewLine);

            time.Append(string.Format(htmlGeneratorResource.fieldTime,
                field.Name, field.ModelName, attrRequired));
            time.Append(Environment.NewLine);

            if (field.IsRequired)
            {
                time.Append(string.Format(htmlGeneratorResource.tagRequiredField,
                    field.ModelName + "inserirEditarForm", field.Name));
                time.Append(Environment.NewLine);
            }

            time.Append(htmlGeneratorResource.tagDivClose);
            time.Append(Environment.NewLine);

            return time.ToString();
        }

        private string GetNumberString(Field field)
        {
            var attrMin = field.Min > 0
                ? string.Format(htmlGeneratorResource.attrNumberMin, field.Min) : string.Empty;
            var attrMax = field.Max > 0
                ? string.Format(htmlGeneratorResource.attrNumberMax, field.Max) : string.Empty;
            var attrStep = field.Step > 0
                ? string.Format(htmlGeneratorResource.attrNumberStep, field.Step) : string.Empty;

            StringBuilder number = new StringBuilder();
            number.Append(string.Format(htmlGeneratorResource.tagDivStart, field.ClassName));
            number.Append(Environment.NewLine);

            number.Append(string.Format(htmlGeneratorResource.tagLabel, field.Title));
            number.Append(Environment.NewLine);

            number.Append(string.Format(htmlGeneratorResource.fieldNumber,
                field.Name, field.ModelName, attrMin, attrMax, attrStep));
            number.Append(Environment.NewLine);

            if (field.IsRequired)
            {
                number.Append(string.Format(htmlGeneratorResource.tagRequiredField,
                    field.ModelName + "inserirEditarForm", field.Name));
                number.Append(Environment.NewLine);
            }

            number.Append(htmlGeneratorResource.tagDivClose);
            number.Append(Environment.NewLine);

            return number.ToString();
        }

        private void GenerateFiles(string text)
        {
            var lines = text.Split('\r');
            System.IO.File.WriteAllLines(@"D:\WriteText.txt", lines);
        }
    }
}
