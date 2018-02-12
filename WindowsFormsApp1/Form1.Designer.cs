namespace CshtmlGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFieldType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaxLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.txtFieldTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDropdownDataSource = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtViewdataProperty = new System.Windows.Forms.TextBox();
            this.cbHelpIcon = new System.Windows.Forms.CheckBox();
            this.cbRequiredField = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbMultiLookup = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtPrecision = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHelpIconText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddField = new System.Windows.Forms.Button();
            this.dgvFields = new System.Windows.Forms.DataGridView();
            this.btnGenerateFiles = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtIdField = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGridOtherdFields = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGridIdField = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model Name";
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(150, 24);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(187, 20);
            this.txtModelName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Field Type";
            // 
            // cmbFieldType
            // 
            this.cmbFieldType.FormattingEnabled = true;
            this.cmbFieldType.Location = new System.Drawing.Point(539, 12);
            this.cmbFieldType.Name = "cmbFieldType";
            this.cmbFieldType.Size = new System.Drawing.Size(187, 21);
            this.cmbFieldType.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaxLength);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(29, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 95);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TextBox / TextArea";
            // 
            // txtMaxLength
            // 
            this.txtMaxLength.Location = new System.Drawing.Point(124, 34);
            this.txtMaxLength.Name = "txtMaxLength";
            this.txtMaxLength.Size = new System.Drawing.Size(187, 20);
            this.txtMaxLength.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Max Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Field Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Field Title";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(539, 84);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(187, 20);
            this.txtFieldName.TabIndex = 5;
            // 
            // txtFieldTitle
            // 
            this.txtFieldTitle.Location = new System.Drawing.Point(539, 47);
            this.txtFieldTitle.Name = "txtFieldTitle";
            this.txtFieldTitle.Size = new System.Drawing.Size(187, 20);
            this.txtFieldTitle.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data Source";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDropdownDataSource);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtViewdataProperty);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(29, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 95);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dropdown";
            // 
            // cmbDropdownDataSource
            // 
            this.cmbDropdownDataSource.FormattingEnabled = true;
            this.cmbDropdownDataSource.Location = new System.Drawing.Point(133, 26);
            this.cmbDropdownDataSource.Name = "cmbDropdownDataSource";
            this.cmbDropdownDataSource.Size = new System.Drawing.Size(178, 21);
            this.cmbDropdownDataSource.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "ViewData Property";
            // 
            // txtViewdataProperty
            // 
            this.txtViewdataProperty.Location = new System.Drawing.Point(133, 56);
            this.txtViewdataProperty.Name = "txtViewdataProperty";
            this.txtViewdataProperty.Size = new System.Drawing.Size(178, 20);
            this.txtViewdataProperty.TabIndex = 10;
            // 
            // cbHelpIcon
            // 
            this.cbHelpIcon.AutoSize = true;
            this.cbHelpIcon.Location = new System.Drawing.Point(624, 156);
            this.cbHelpIcon.Name = "cbHelpIcon";
            this.cbHelpIcon.Size = new System.Drawing.Size(72, 17);
            this.cbHelpIcon.TabIndex = 8;
            this.cbHelpIcon.Text = "Help Icon";
            this.cbHelpIcon.UseVisualStyleBackColor = true;
            // 
            // cbRequiredField
            // 
            this.cbRequiredField.AutoSize = true;
            this.cbRequiredField.Location = new System.Drawing.Point(463, 156);
            this.cbRequiredField.Name = "cbRequiredField";
            this.cbRequiredField.Size = new System.Drawing.Size(94, 17);
            this.cbRequiredField.TabIndex = 7;
            this.cbRequiredField.Text = "Required Field";
            this.cbRequiredField.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbMultiLookup);
            this.groupBox3.Location = new System.Drawing.Point(449, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 58);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lookup";
            // 
            // cbMultiLookup
            // 
            this.cbMultiLookup.AutoSize = true;
            this.cbMultiLookup.Location = new System.Drawing.Point(29, 29);
            this.cbMultiLookup.Name = "cbMultiLookup";
            this.cbMultiLookup.Size = new System.Drawing.Size(87, 17);
            this.cbMultiLookup.TabIndex = 16;
            this.cbMultiLookup.Text = "Multi Lookup";
            this.cbMultiLookup.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtStep);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtMin);
            this.groupBox4.Controls.Add(this.txtPrecision);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtMax);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(449, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 150);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Number";
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(133, 113);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(165, 20);
            this.txtStep.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Step";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(133, 27);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(165, 20);
            this.txtMin.TabIndex = 15;
            // 
            // txtPrecision
            // 
            this.txtPrecision.Location = new System.Drawing.Point(133, 85);
            this.txtPrecision.Name = "txtPrecision";
            this.txtPrecision.Size = new System.Drawing.Size(165, 20);
            this.txtPrecision.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Precision ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Max";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(133, 56);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(165, 20);
            this.txtMax.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Min";
            // 
            // txtHelpIconText
            // 
            this.txtHelpIconText.Location = new System.Drawing.Point(561, 190);
            this.txtHelpIconText.Name = "txtHelpIconText";
            this.txtHelpIconText.Size = new System.Drawing.Size(187, 20);
            this.txtHelpIconText.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(462, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Help icon text";
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(800, 27);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(126, 42);
            this.btnAddField.TabIndex = 10;
            this.btnAddField.Text = "Add Field";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // dgvFields
            // 
            this.dgvFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFields.Location = new System.Drawing.Point(42, 474);
            this.dgvFields.Name = "dgvFields";
            this.dgvFields.Size = new System.Drawing.Size(884, 189);
            this.dgvFields.TabIndex = 19;
            // 
            // btnGenerateFiles
            // 
            this.btnGenerateFiles.Location = new System.Drawing.Point(800, 88);
            this.btnGenerateFiles.Name = "btnGenerateFiles";
            this.btnGenerateFiles.Size = new System.Drawing.Size(126, 42);
            this.btnGenerateFiles.TabIndex = 20;
            this.btnGenerateFiles.Text = "Generate Files";
            this.btnGenerateFiles.UseVisualStyleBackColor = true;
            this.btnGenerateFiles.Click += new System.EventHandler(this.btnGenerateFiles_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(570, 121);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(158, 20);
            this.txtClass.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(462, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Class (other than xs)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 2;
            // 
            // txtIdField
            // 
            this.txtIdField.AutoSize = true;
            this.txtIdField.Location = new System.Drawing.Point(52, 69);
            this.txtIdField.Name = "txtIdField";
            this.txtIdField.Size = new System.Drawing.Size(72, 13);
            this.txtIdField.TabIndex = 23;
            this.txtIdField.Text = "Id Field Name";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtGridIdField);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtGridOtherdFields);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(29, 355);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(345, 95);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Grid";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Other Grid Fields";
            // 
            // txtGridOtherdFields
            // 
            this.txtGridOtherdFields.Location = new System.Drawing.Point(133, 56);
            this.txtGridOtherdFields.Name = "txtGridOtherdFields";
            this.txtGridOtherdFields.Size = new System.Drawing.Size(178, 20);
            this.txtGridOtherdFields.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Id Field Name";
            // 
            // txtGridIdField
            // 
            this.txtGridIdField.Location = new System.Drawing.Point(133, 26);
            this.txtGridIdField.Name = "txtGridIdField";
            this.txtGridIdField.Size = new System.Drawing.Size(178, 20);
            this.txtGridIdField.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 675);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtIdField);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnGenerateFiles);
            this.Controls.Add(this.dgvFields);
            this.Controls.Add(this.btnAddField);
            this.Controls.Add(this.txtHelpIconText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbRequiredField);
            this.Controls.Add(this.cbHelpIcon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtFieldTitle);
            this.Controls.Add(this.txtFieldName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbFieldType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Code Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFieldType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.TextBox txtFieldTitle;
        private System.Windows.Forms.TextBox txtMaxLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtViewdataProperty;
        private System.Windows.Forms.ComboBox cmbDropdownDataSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbHelpIcon;
        private System.Windows.Forms.CheckBox cbRequiredField;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbMultiLookup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtPrecision;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHelpIconText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.DataGridView dgvFields;
        private System.Windows.Forms.Button btnGenerateFiles;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtIdField;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtGridIdField;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGridOtherdFields;
        private System.Windows.Forms.Label label15;
    }
}

