namespace Questionnaire
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.gbQuestionnaire = new System.Windows.Forms.GroupBox();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblFahterName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtLoadFile = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gbQuestionnaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Location = new System.Drawing.Point(75, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(212, 32);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(6, 325);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 15);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Gender:";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.BackColor = System.Drawing.SystemColors.Control;
            this.rbMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbMale.Location = new System.Drawing.Point(109, 323);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(51, 19);
            this.rbMale.TabIndex = 9;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = false;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(176, 323);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(63, 19);
            this.rbFemale.TabIndex = 10;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // gbQuestionnaire
            // 
            this.gbQuestionnaire.Controls.Add(this.birthDatePicker);
            this.gbQuestionnaire.Controls.Add(this.txtPhone);
            this.gbQuestionnaire.Controls.Add(this.txtFatherName);
            this.gbQuestionnaire.Controls.Add(this.txtCity);
            this.gbQuestionnaire.Controls.Add(this.txtCountry);
            this.gbQuestionnaire.Controls.Add(this.txtSurname);
            this.gbQuestionnaire.Controls.Add(this.lblBirthDate);
            this.gbQuestionnaire.Controls.Add(this.lblPhone);
            this.gbQuestionnaire.Controls.Add(this.txtName);
            this.gbQuestionnaire.Controls.Add(this.lblCity);
            this.gbQuestionnaire.Controls.Add(this.lblFahterName);
            this.gbQuestionnaire.Controls.Add(this.lblCountry);
            this.gbQuestionnaire.Controls.Add(this.lblSurname);
            this.gbQuestionnaire.Controls.Add(this.lblName);
            this.gbQuestionnaire.Controls.Add(this.rbMale);
            this.gbQuestionnaire.Controls.Add(this.rbFemale);
            this.gbQuestionnaire.Controls.Add(this.lblGender);
            this.gbQuestionnaire.Location = new System.Drawing.Point(12, 47);
            this.gbQuestionnaire.Name = "gbQuestionnaire";
            this.gbQuestionnaire.Size = new System.Drawing.Size(330, 353);
            this.gbQuestionnaire.TabIndex = 4;
            this.gbQuestionnaire.TabStop = false;
            this.gbQuestionnaire.Text = "Questionnaire";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.CustomFormat = "dd MMMM, yyyy";
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDatePicker.Location = new System.Drawing.Point(109, 270);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(130, 23);
            this.birthDatePicker.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(109, 215);
            this.txtPhone.MaxLength = 25;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(130, 23);
            this.txtPhone.TabIndex = 7;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(109, 89);
            this.txtFatherName.MaxLength = 25;
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(130, 23);
            this.txtFatherName.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(109, 182);
            this.txtCity.MaxLength = 25;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(130, 23);
            this.txtCity.TabIndex = 6;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(109, 147);
            this.txtCountry.MaxLength = 25;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(130, 23);
            this.txtCountry.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(109, 56);
            this.txtSurname.MaxLength = 25;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(130, 23);
            this.txtSurname.TabIndex = 3;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(6, 278);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(59, 15);
            this.lblBirthDate.TabIndex = 5;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 218);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 15);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 21);
            this.txtName.MaxLength = 25;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 23);
            this.txtName.TabIndex = 2;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 185);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 15);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City";
            // 
            // lblFahterName
            // 
            this.lblFahterName.AutoSize = true;
            this.lblFahterName.Location = new System.Drawing.Point(6, 92);
            this.lblFahterName.Name = "lblFahterName";
            this.lblFahterName.Size = new System.Drawing.Size(75, 15);
            this.lblFahterName.TabIndex = 5;
            this.lblFahterName.Text = "Father Name";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(6, 150);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(50, 15);
            this.lblCountry.TabIndex = 5;
            this.lblCountry.Text = "Country";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 59);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(54, 15);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // txtLoadFile
            // 
            this.txtLoadFile.Location = new System.Drawing.Point(61, 12);
            this.txtLoadFile.Name = "txtLoadFile";
            this.txtLoadFile.PlaceholderText = "Load File Name";
            this.txtLoadFile.Size = new System.Drawing.Size(100, 23);
            this.txtLoadFile.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.AutoSize = true;
            this.btnLoad.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLoad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Location = new System.Drawing.Point(206, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(103, 31);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 455);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtLoadFile);
            this.Controls.Add(this.gbQuestionnaire);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Questionnaire";
            this.gbQuestionnaire.ResumeLayout(false);
            this.gbQuestionnaire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private Label lblGender;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private GroupBox gbQuestionnaire;
        private TextBox txtFatherName;
        private TextBox txtSurname;
        private TextBox txtName;
        private Label lblFahterName;
        private Label lblSurname;
        private Label lblName;
        private DateTimePicker birthDatePicker;
        private TextBox txtPhone;
        private TextBox txtCity;
        private TextBox txtCountry;
        private Label lblBirthDate;
        private Label lblPhone;
        private Label lblCity;
        private Label lblCountry;
        private TextBox txtLoadFile;
        private Button btnLoad;
    }
}