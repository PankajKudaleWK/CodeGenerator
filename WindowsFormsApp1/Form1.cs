using CshtmlGenerator.Enum;
using CshtmlGenerator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CshtmlGenerator
{
    public partial class Form1 : Form
    {
        private List<Field> _fields;
        private Logic.CshtmlGenerator _cshtmlGenerator;
        private Logic.JsClassGenerator _jsClassGenerator;
        private Logic.JsControllerGenerator _jsControllerGenerator;
        private Logic.JsDirectiveGenerator _jsDirectiveGenerator;

        public Form1()
        {
            InitializeComponent();
            _fields = new List<Field>();
            _cshtmlGenerator = new Logic.CshtmlGenerator();
            _jsClassGenerator = new Logic.JsClassGenerator();
            _jsControllerGenerator = new Logic.JsControllerGenerator();
            _jsDirectiveGenerator = new Logic.JsDirectiveGenerator();
            cmbFieldType.DataSource = System.Enum.GetValues(typeof(FieldType));
            cmbDropdownDataSource.DataSource = System.Enum.GetValues(typeof(DropdownDatasource));
            var bindingList = new BindingList<Field>(_fields);
            var source = new BindingSource(bindingList, null);
            source.ResetBindings(false);
            dgvFields.DataSource = source;
        }

        private void AddFieldToList()
        {
            var dropdownDataSource = (DropdownDatasource)cmbDropdownDataSource.SelectedIndex;
            var fieldType = (FieldType)cmbFieldType.SelectedIndex;
            int maxLength, min, max, step, precision;
            int.TryParse(txtMaxLength.Text, out maxLength);
            int.TryParse(txtMin.Text, out min);
            int.TryParse(txtMax.Text, out max);
            int.TryParse(txtStep.Text, out step);
            int.TryParse(txtPrecision.Text, out precision);

            var field = _cshtmlGenerator.GetFieldObject(txtFieldName.Text, txtFieldTitle.Text, txtModelName.Text,
                maxLength, txtViewdataProperty.Text, dropdownDataSource, cbRequiredField.Checked,
                cbHelpIcon.Checked, txtHelpIconText.Text, cbMultiLookup.Checked, fieldType,
                min, max, step, precision, txtClass.Text, txtIdField.Text, txtGridIdField.Text, txtGridOtherdFields.Text);

            _fields.Add(field);
        }

        private void ClearFields()
        {
            txtFieldName.Text = string.Empty;
            txtFieldTitle.Text = string.Empty;
            txtHelpIconText.Text = string.Empty;
            txtClass.Text = string.Empty;
            cmbFieldType.SelectedIndex = 0;

            cbRequiredField.Checked = false;
            cbHelpIcon.Checked = false;
            cbMultiLookup.Checked = false;

            txtMaxLength.Text = string.Empty;
            cmbDropdownDataSource.SelectedIndex = 0;
            txtViewdataProperty.Text = string.Empty;

            txtMin.Text = string.Empty;
            txtMax.Text = string.Empty;
            txtPrecision.Text = string.Empty;
            txtStep.Text = string.Empty;
        }

        private void btnAddField_Click(object sender, System.EventArgs e)
        {
            dgvFields.DataSource = null;
            AddFieldToList();
            ClearFields();
            dgvFields.DataSource = _fields;
        }

        private void btnGenerateFiles_Click(object sender, System.EventArgs e)
        {
            try
            {
                var cshtmlFileText = _cshtmlGenerator.GenerateCshtmlString(_fields);
                var jsClassFileText = _jsClassGenerator.GetJsClassString(_fields);
                var jsControllerFileText = _jsControllerGenerator.GenerateJsControllerString(_fields);

                _cshtmlGenerator.GenerateCshtmlFile(cshtmlFileText, txtModelName.Text);
                _jsClassGenerator.GenerateJsFile(jsClassFileText, txtModelName.Text);
                _jsControllerGenerator.GenerateJsControllerFile(jsControllerFileText, txtModelName.Text);

                if (_fields.Any(f => f.FieldType == FieldType.Lookup))
                {
                    var serviceFileContent = _jsControllerGenerator.GetServiceString(_fields);
                    _jsControllerGenerator.GenerateJsServiceFile(serviceFileContent, txtModelName.Text);
                }

                if (_fields.Any(f => f.FieldType == FieldType.Grid))
                {
                    _jsDirectiveGenerator.GenerateJsDirectiveFile(_fields, txtModelName.Text);
                    _jsDirectiveGenerator.GenerateJsDirectiveControllerFile(_fields, txtModelName.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
