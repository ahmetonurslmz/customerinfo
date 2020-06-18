namespace CustomerInfo
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
            this.grpCustomerInformation = new System.Windows.Forms.GroupBox();
            this.mTxtSalary = new System.Windows.Forms.MaskedTextBox();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.lblTry = new System.Windows.Forms.Label();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFamilyName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpDetailsList = new System.Windows.Forms.GroupBox();
            this.lvCustomers = new System.Windows.Forms.ListView();
            this.clmnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnFamilyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpGraphicByJob = new System.Windows.Forms.GroupBox();
            this.lblTotalCustomerCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSelectedJobCount = new System.Windows.Forms.Label();
            this.prgressBarSelectedJob = new System.Windows.Forms.ProgressBar();
            this.cbSelectJob = new System.Windows.Forms.ComboBox();
            this.lblSelectedJob = new System.Windows.Forms.Label();
            this.lblSelectJob = new System.Windows.Forms.Label();
            this.grpByCity = new System.Windows.Forms.GroupBox();
            this.lblTotalCustomerCountCity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSelectedCityCount = new System.Windows.Forms.Label();
            this.prgressBarSelectedCity = new System.Windows.Forms.ProgressBar();
            this.cbSelectCity = new System.Windows.Forms.ComboBox();
            this.lblSelectedCity = new System.Windows.Forms.Label();
            this.lblSelectCity = new System.Windows.Forms.Label();
            this.grpCustomerInformation.SuspendLayout();
            this.grpDetailsList.SuspendLayout();
            this.grpGraphicByJob.SuspendLayout();
            this.grpByCity.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerInformation
            // 
            this.grpCustomerInformation.Controls.Add(this.mTxtSalary);
            this.grpCustomerInformation.Controls.Add(this.btnClearForm);
            this.grpCustomerInformation.Controls.Add(this.btnUpdateRecord);
            this.grpCustomerInformation.Controls.Add(this.btnDeleteRecord);
            this.grpCustomerInformation.Controls.Add(this.btnAddRecord);
            this.grpCustomerInformation.Controls.Add(this.cbCity);
            this.grpCustomerInformation.Controls.Add(this.cbJob);
            this.grpCustomerInformation.Controls.Add(this.lblTry);
            this.grpCustomerInformation.Controls.Add(this.lblIdValue);
            this.grpCustomerInformation.Controls.Add(this.lblCity);
            this.grpCustomerInformation.Controls.Add(this.lblSalary);
            this.grpCustomerInformation.Controls.Add(this.lblJob);
            this.grpCustomerInformation.Controls.Add(this.txtFamilyName);
            this.grpCustomerInformation.Controls.Add(this.txtName);
            this.grpCustomerInformation.Controls.Add(this.lblFamilyName);
            this.grpCustomerInformation.Controls.Add(this.lblName);
            this.grpCustomerInformation.Controls.Add(this.lblId);
            this.grpCustomerInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpCustomerInformation.Location = new System.Drawing.Point(12, 12);
            this.grpCustomerInformation.Name = "grpCustomerInformation";
            this.grpCustomerInformation.Size = new System.Drawing.Size(618, 170);
            this.grpCustomerInformation.TabIndex = 0;
            this.grpCustomerInformation.TabStop = false;
            this.grpCustomerInformation.Text = "Customer Information";
            // 
            // mTxtSalary
            // 
            this.mTxtSalary.Location = new System.Drawing.Point(427, 54);
            this.mTxtSalary.Mask = "00000";
            this.mTxtSalary.Name = "mTxtSalary";
            this.mTxtSalary.Size = new System.Drawing.Size(117, 26);
            this.mTxtSalary.TabIndex = 16;
            this.mTxtSalary.ValidatingType = typeof(int);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClearForm.Location = new System.Drawing.Point(469, 124);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(143, 33);
            this.btnClearForm.TabIndex = 15;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.Enabled = false;
            this.btnUpdateRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateRecord.Location = new System.Drawing.Point(147, 124);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(146, 33);
            this.btnUpdateRecord.TabIndex = 14;
            this.btnUpdateRecord.Text = "Update Record";
            this.btnUpdateRecord.UseVisualStyleBackColor = true;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Enabled = false;
            this.btnDeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteRecord.Location = new System.Drawing.Point(299, 124);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(164, 33);
            this.btnDeleteRecord.TabIndex = 14;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddRecord.Location = new System.Drawing.Point(10, 124);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(131, 33);
            this.btnAddRecord.TabIndex = 13;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // cbCity
            // 
            this.cbCity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.ForeColor = System.Drawing.Color.Black;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(427, 84);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(141, 28);
            this.cbCity.TabIndex = 12;
            // 
            // cbJob
            // 
            this.cbJob.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJob.ForeColor = System.Drawing.Color.Black;
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Location = new System.Drawing.Point(427, 20);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(141, 28);
            this.cbJob.TabIndex = 11;
            // 
            // lblTry
            // 
            this.lblTry.AutoSize = true;
            this.lblTry.Location = new System.Drawing.Point(550, 55);
            this.lblTry.Name = "lblTry";
            this.lblTry.Size = new System.Drawing.Size(41, 20);
            this.lblTry.TabIndex = 10;
            this.lblTry.Text = "TRY";
            // 
            // lblIdValue
            // 
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.Location = new System.Drawing.Point(116, 22);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(18, 20);
            this.lblIdValue.TabIndex = 8;
            this.lblIdValue.Text = "0";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(382, 82);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 20);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(364, 52);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(57, 20);
            this.lblSalary.TabIndex = 6;
            this.lblSalary.Text = "Salary:";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(382, 23);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(39, 20);
            this.lblJob.TabIndex = 5;
            this.lblJob.Text = "Job:";
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Location = new System.Drawing.Point(117, 83);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(117, 26);
            this.txtFamilyName.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 26);
            this.txtName.TabIndex = 3;
            // 
            // lblFamilyName
            // 
            this.lblFamilyName.AutoSize = true;
            this.lblFamilyName.Location = new System.Drawing.Point(6, 82);
            this.lblFamilyName.Name = "lblFamilyName";
            this.lblFamilyName.Size = new System.Drawing.Size(104, 20);
            this.lblFamilyName.TabIndex = 2;
            this.lblFamilyName.Text = "Family Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(55, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(80, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // grpDetailsList
            // 
            this.grpDetailsList.Controls.Add(this.lvCustomers);
            this.grpDetailsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpDetailsList.Location = new System.Drawing.Point(12, 197);
            this.grpDetailsList.Name = "grpDetailsList";
            this.grpDetailsList.Size = new System.Drawing.Size(618, 128);
            this.grpDetailsList.TabIndex = 1;
            this.grpDetailsList.TabStop = false;
            this.grpDetailsList.Text = "Details List";
            // 
            // lvCustomers
            // 
            this.lvCustomers.BackColor = System.Drawing.SystemColors.Window;
            this.lvCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnID,
            this.clmnName,
            this.clmnFamilyName,
            this.clmnJob,
            this.clmnSalary,
            this.clmnCity});
            this.lvCustomers.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvCustomers.FullRowSelect = true;
            this.lvCustomers.HideSelection = false;
            this.lvCustomers.Location = new System.Drawing.Point(3, 22);
            this.lvCustomers.Name = "lvCustomers";
            this.lvCustomers.Size = new System.Drawing.Size(609, 97);
            this.lvCustomers.TabIndex = 0;
            this.lvCustomers.UseCompatibleStateImageBehavior = false;
            this.lvCustomers.View = System.Windows.Forms.View.Details;
            this.lvCustomers.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // clmnID
            // 
            this.clmnID.Text = "ID";
            // 
            // clmnName
            // 
            this.clmnName.Text = "Name";
            this.clmnName.Width = 120;
            // 
            // clmnFamilyName
            // 
            this.clmnFamilyName.Text = "Family Name";
            this.clmnFamilyName.Width = 120;
            // 
            // clmnJob
            // 
            this.clmnJob.Text = "Job";
            this.clmnJob.Width = 80;
            // 
            // clmnSalary
            // 
            this.clmnSalary.Text = "Salary";
            this.clmnSalary.Width = 120;
            // 
            // clmnCity
            // 
            this.clmnCity.Text = "City";
            this.clmnCity.Width = 105;
            // 
            // grpGraphicByJob
            // 
            this.grpGraphicByJob.Controls.Add(this.lblTotalCustomerCount);
            this.grpGraphicByJob.Controls.Add(this.label2);
            this.grpGraphicByJob.Controls.Add(this.lblSelectedJobCount);
            this.grpGraphicByJob.Controls.Add(this.prgressBarSelectedJob);
            this.grpGraphicByJob.Controls.Add(this.cbSelectJob);
            this.grpGraphicByJob.Controls.Add(this.lblSelectedJob);
            this.grpGraphicByJob.Controls.Add(this.lblSelectJob);
            this.grpGraphicByJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpGraphicByJob.Location = new System.Drawing.Point(12, 331);
            this.grpGraphicByJob.Name = "grpGraphicByJob";
            this.grpGraphicByJob.Size = new System.Drawing.Size(618, 116);
            this.grpGraphicByJob.TabIndex = 2;
            this.grpGraphicByJob.TabStop = false;
            this.grpGraphicByJob.Text = "Graphic by Job";
            // 
            // lblTotalCustomerCount
            // 
            this.lblTotalCustomerCount.AutoSize = true;
            this.lblTotalCustomerCount.Location = new System.Drawing.Point(586, 74);
            this.lblTotalCustomerCount.Name = "lblTotalCustomerCount";
            this.lblTotalCustomerCount.Size = new System.Drawing.Size(18, 20);
            this.lblTotalCustomerCount.TabIndex = 15;
            this.lblTotalCustomerCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "/";
            // 
            // lblSelectedJobCount
            // 
            this.lblSelectedJobCount.AutoSize = true;
            this.lblSelectedJobCount.Location = new System.Drawing.Point(565, 74);
            this.lblSelectedJobCount.Name = "lblSelectedJobCount";
            this.lblSelectedJobCount.Size = new System.Drawing.Size(18, 20);
            this.lblSelectedJobCount.TabIndex = 4;
            this.lblSelectedJobCount.Text = "0";
            // 
            // prgressBarSelectedJob
            // 
            this.prgressBarSelectedJob.BackColor = System.Drawing.Color.White;
            this.prgressBarSelectedJob.Cursor = System.Windows.Forms.Cursors.Default;
            this.prgressBarSelectedJob.ForeColor = System.Drawing.Color.White;
            this.prgressBarSelectedJob.Location = new System.Drawing.Point(163, 70);
            this.prgressBarSelectedJob.Name = "prgressBarSelectedJob";
            this.prgressBarSelectedJob.Size = new System.Drawing.Size(393, 28);
            this.prgressBarSelectedJob.TabIndex = 13;
            // 
            // cbSelectJob
            // 
            this.cbSelectJob.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbSelectJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectJob.ForeColor = System.Drawing.Color.Black;
            this.cbSelectJob.FormattingEnabled = true;
            this.cbSelectJob.Location = new System.Drawing.Point(163, 28);
            this.cbSelectJob.Name = "cbSelectJob";
            this.cbSelectJob.Size = new System.Drawing.Size(141, 28);
            this.cbSelectJob.TabIndex = 12;
            this.cbSelectJob.SelectedValueChanged += new System.EventHandler(this.cbSelectJob_SelectedValueChanged);
            // 
            // lblSelectedJob
            // 
            this.lblSelectedJob.AutoSize = true;
            this.lblSelectedJob.Location = new System.Drawing.Point(22, 70);
            this.lblSelectedJob.Name = "lblSelectedJob";
            this.lblSelectedJob.Size = new System.Drawing.Size(39, 20);
            this.lblSelectedJob.TabIndex = 3;
            this.lblSelectedJob.Text = "Job:";
            // 
            // lblSelectJob
            // 
            this.lblSelectJob.AutoSize = true;
            this.lblSelectJob.Location = new System.Drawing.Point(22, 31);
            this.lblSelectJob.Name = "lblSelectJob";
            this.lblSelectJob.Size = new System.Drawing.Size(88, 20);
            this.lblSelectJob.TabIndex = 2;
            this.lblSelectJob.Text = "Select Job:";
            // 
            // grpByCity
            // 
            this.grpByCity.Controls.Add(this.lblTotalCustomerCountCity);
            this.grpByCity.Controls.Add(this.label4);
            this.grpByCity.Controls.Add(this.lblSelectedCityCount);
            this.grpByCity.Controls.Add(this.prgressBarSelectedCity);
            this.grpByCity.Controls.Add(this.cbSelectCity);
            this.grpByCity.Controls.Add(this.lblSelectedCity);
            this.grpByCity.Controls.Add(this.lblSelectCity);
            this.grpByCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpByCity.Location = new System.Drawing.Point(12, 453);
            this.grpByCity.Name = "grpByCity";
            this.grpByCity.Size = new System.Drawing.Size(618, 116);
            this.grpByCity.TabIndex = 3;
            this.grpByCity.TabStop = false;
            this.grpByCity.Text = "Graphic by City";
            // 
            // lblTotalCustomerCountCity
            // 
            this.lblTotalCustomerCountCity.AutoSize = true;
            this.lblTotalCustomerCountCity.Location = new System.Drawing.Point(582, 69);
            this.lblTotalCustomerCountCity.Name = "lblTotalCustomerCountCity";
            this.lblTotalCustomerCountCity.Size = new System.Drawing.Size(18, 20);
            this.lblTotalCustomerCountCity.TabIndex = 22;
            this.lblTotalCustomerCountCity.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "/";
            // 
            // lblSelectedCityCount
            // 
            this.lblSelectedCityCount.AutoSize = true;
            this.lblSelectedCityCount.Location = new System.Drawing.Point(562, 69);
            this.lblSelectedCityCount.Name = "lblSelectedCityCount";
            this.lblSelectedCityCount.Size = new System.Drawing.Size(18, 20);
            this.lblSelectedCityCount.TabIndex = 18;
            this.lblSelectedCityCount.Text = "0";
            // 
            // prgressBarSelectedCity
            // 
            this.prgressBarSelectedCity.BackColor = System.Drawing.Color.White;
            this.prgressBarSelectedCity.Cursor = System.Windows.Forms.Cursors.Default;
            this.prgressBarSelectedCity.ForeColor = System.Drawing.Color.White;
            this.prgressBarSelectedCity.Location = new System.Drawing.Point(159, 65);
            this.prgressBarSelectedCity.Name = "prgressBarSelectedCity";
            this.prgressBarSelectedCity.Size = new System.Drawing.Size(393, 28);
            this.prgressBarSelectedCity.TabIndex = 20;
            // 
            // cbSelectCity
            // 
            this.cbSelectCity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbSelectCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectCity.ForeColor = System.Drawing.Color.Black;
            this.cbSelectCity.FormattingEnabled = true;
            this.cbSelectCity.Location = new System.Drawing.Point(159, 23);
            this.cbSelectCity.Name = "cbSelectCity";
            this.cbSelectCity.Size = new System.Drawing.Size(141, 28);
            this.cbSelectCity.TabIndex = 19;
            this.cbSelectCity.SelectedValueChanged += new System.EventHandler(this.cbSelectCity_SelectedValueChanged);
            // 
            // lblSelectedCity
            // 
            this.lblSelectedCity.AutoSize = true;
            this.lblSelectedCity.Location = new System.Drawing.Point(18, 65);
            this.lblSelectedCity.Name = "lblSelectedCity";
            this.lblSelectedCity.Size = new System.Drawing.Size(39, 20);
            this.lblSelectedCity.TabIndex = 17;
            this.lblSelectedCity.Text = "City:";
            // 
            // lblSelectCity
            // 
            this.lblSelectCity.AutoSize = true;
            this.lblSelectCity.Location = new System.Drawing.Point(18, 26);
            this.lblSelectCity.Name = "lblSelectCity";
            this.lblSelectCity.Size = new System.Drawing.Size(88, 20);
            this.lblSelectCity.TabIndex = 16;
            this.lblSelectCity.Text = "Select City:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(642, 574);
            this.Controls.Add(this.grpByCity);
            this.Controls.Add(this.grpGraphicByJob);
            this.Controls.Add(this.grpDetailsList);
            this.Controls.Add(this.grpCustomerInformation);
            this.Name = "Form1";
            this.Text = "Customer Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCustomerInformation.ResumeLayout(false);
            this.grpCustomerInformation.PerformLayout();
            this.grpDetailsList.ResumeLayout(false);
            this.grpGraphicByJob.ResumeLayout(false);
            this.grpGraphicByJob.PerformLayout();
            this.grpByCity.ResumeLayout(false);
            this.grpByCity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerInformation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpDetailsList;
        private System.Windows.Forms.GroupBox grpGraphicByJob;
        private System.Windows.Forms.GroupBox grpByCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TextBox txtFamilyName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblFamilyName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.Label lblTry;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.ListView lvCustomers;
        private System.Windows.Forms.Label lblTotalCustomerCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelectedJobCount;
        private System.Windows.Forms.ProgressBar prgressBarSelectedJob;
        private System.Windows.Forms.ComboBox cbSelectJob;
        private System.Windows.Forms.Label lblSelectedJob;
        private System.Windows.Forms.Label lblSelectJob;
        private System.Windows.Forms.Label lblTotalCustomerCountCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSelectedCityCount;
        private System.Windows.Forms.ProgressBar prgressBarSelectedCity;
        private System.Windows.Forms.ComboBox cbSelectCity;
        private System.Windows.Forms.Label lblSelectedCity;
        private System.Windows.Forms.Label lblSelectCity;
        private System.Windows.Forms.ColumnHeader clmnID;
        private System.Windows.Forms.ColumnHeader clmnName;
        private System.Windows.Forms.ColumnHeader clmnFamilyName;
        private System.Windows.Forms.ColumnHeader clmnJob;
        private System.Windows.Forms.ColumnHeader clmnSalary;
        private System.Windows.Forms.ColumnHeader clmnCity;
        private System.Windows.Forms.MaskedTextBox mTxtSalary;
    }
}

