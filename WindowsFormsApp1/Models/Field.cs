using CshtmlGenerator.Enum;

namespace CshtmlGenerator.Models
{
    public class Field
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public string ModelName { get; set; }
        public DropdownDatasource DropdownDatasource { get; set; }
        public string DropdownViewDataName { get; set; }
        public bool IsRequired { get; set; }
        public bool IsHelpIconRequired { get; set; }
        public bool IsMultiLoopup { get; set; }
        public FieldType FieldType { get; set; }
        public string HelpIconText { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int Step { get; set; }
        public int Precision { get; set; }
        public string ClassName { get; set; }
        public string IdField { get; set; }
        public string GridIdField { get; set; }
        public string GridOtherFields { get; set; }
    }
}
