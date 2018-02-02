﻿using CshtmlGenerator.Enum;
using CshtmlGenerator.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CshtmlGenerator
{
    public partial class Form1 : Form
    {
        private List<Field> _fields;
        private Logic.CshtmlGenerator _cshtmlGenerator;
        public Form1()
        {
            InitializeComponent();
            _fields = new List<Field>();
            _cshtmlGenerator = new Logic.CshtmlGenerator();
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
                min, max, step, precision, txtClass.Text);

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
            var result = _cshtmlGenerator.GenerateCshtmlString(_fields);
        }
    }
}
