namespace Phonebook
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
            this.components = new System.ComponentModel.Container();
            this.DeleteRecordBtn = new System.Windows.Forms.Button();
            this.AddRecordBtn = new System.Windows.Forms.Button();
            this.FindRecordBtn = new System.Windows.Forms.Button();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.PhoneNumberInput = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phonebookDataSet = new Phonebook.PhonebookDataSet();
            this.peopleTableAdapter = new Phonebook.PhonebookDataSetTableAdapters.PeopleTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefreshTableBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteRecordBtn
            // 
            this.DeleteRecordBtn.Location = new System.Drawing.Point(562, 722);
            this.DeleteRecordBtn.Name = "DeleteRecordBtn";
            this.DeleteRecordBtn.Size = new System.Drawing.Size(168, 41);
            this.DeleteRecordBtn.TabIndex = 1;
            this.DeleteRecordBtn.Text = "Delete Record";
            this.DeleteRecordBtn.UseVisualStyleBackColor = true;
            this.DeleteRecordBtn.Click += new System.EventHandler(this.DeleteRecordBtn_Click);
            // 
            // AddRecordBtn
            // 
            this.AddRecordBtn.Location = new System.Drawing.Point(332, 722);
            this.AddRecordBtn.Name = "AddRecordBtn";
            this.AddRecordBtn.Size = new System.Drawing.Size(168, 41);
            this.AddRecordBtn.TabIndex = 2;
            this.AddRecordBtn.Text = "Add Record";
            this.AddRecordBtn.UseVisualStyleBackColor = true;
            this.AddRecordBtn.Click += new System.EventHandler(this.AddRecordBtn_Click);
            // 
            // FindRecordBtn
            // 
            this.FindRecordBtn.Location = new System.Drawing.Point(114, 722);
            this.FindRecordBtn.Name = "FindRecordBtn";
            this.FindRecordBtn.Size = new System.Drawing.Size(168, 41);
            this.FindRecordBtn.TabIndex = 3;
            this.FindRecordBtn.Text = "Find Record";
            this.FindRecordBtn.UseVisualStyleBackColor = true;
            this.FindRecordBtn.Click += new System.EventHandler(this.FindRecordBtn_Click);
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Location = new System.Drawing.Point(384, 130);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(298, 20);
            this.FirstNameInput.TabIndex = 4;
            this.FirstNameInput.TextChanged += new System.EventHandler(this.FirstNameInput_TextChanged);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(292, 130);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(90, 20);
            this.FirstName.TabIndex = 5;
            this.FirstName.Text = "First Name:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(292, 177);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(90, 20);
            this.LastName.TabIndex = 7;
            this.LastName.Text = "Last Name:";
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(388, 179);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(298, 20);
            this.LastNameInput.TabIndex = 6;
            this.LastNameInput.TextChanged += new System.EventHandler(this.LastNameInput_TextChanged);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.Location = new System.Drawing.Point(292, 224);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.PhoneNumber.TabIndex = 9;
            this.PhoneNumber.Text = "Phone Number:";
            // 
            // PhoneNumberInput
            // 
            this.PhoneNumberInput.Location = new System.Drawing.Point(413, 224);
            this.PhoneNumberInput.Name = "PhoneNumberInput";
            this.PhoneNumberInput.Size = new System.Drawing.Size(295, 20);
            this.PhoneNumberInput.TabIndex = 8;
            this.PhoneNumberInput.TextChanged += new System.EventHandler(this.PhoneNumberInput_TextChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(405, 30);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(233, 46);
            this.Title.TabIndex = 10;
            this.Title.Text = "Phonebook";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.peopleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(114, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(844, 390);
            this.dataGridView1.TabIndex = 11;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.phonebookDataSet;
            // 
            // phonebookDataSet
            // 
            this.phonebookDataSet.DataSetName = "PhonebookDataSet";
            this.phonebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.firstnameDataGridViewTextBoxColumn.Width = 250;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lastnameDataGridViewTextBoxColumn.Width = 250;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phonenumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.phonenumberDataGridViewTextBoxColumn.Width = 250;
            // 
            // RefreshTableBtn
            // 
            this.RefreshTableBtn.Location = new System.Drawing.Point(790, 722);
            this.RefreshTableBtn.Name = "RefreshTableBtn";
            this.RefreshTableBtn.Size = new System.Drawing.Size(168, 41);
            this.RefreshTableBtn.TabIndex = 12;
            this.RefreshTableBtn.Text = "Refresh Table";
            this.RefreshTableBtn.UseVisualStyleBackColor = true;
            this.RefreshTableBtn.Click += new System.EventHandler(this.RefreshTableBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 809);
            this.Controls.Add(this.RefreshTableBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.PhoneNumberInput);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.FirstNameInput);
            this.Controls.Add(this.FindRecordBtn);
            this.Controls.Add(this.AddRecordBtn);
            this.Controls.Add(this.DeleteRecordBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteRecordBtn;
        private System.Windows.Forms.Button AddRecordBtn;
        private System.Windows.Forms.Button FindRecordBtn;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.TextBox PhoneNumberInput;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PhonebookDataSet phonebookDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private PhonebookDataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button RefreshTableBtn;
    }
}

