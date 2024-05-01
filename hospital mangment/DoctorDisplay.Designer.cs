namespace hospital_mangment
{
    partial class DoctorDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDisplay));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regDoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.person_DatabaseDataSet = new hospital_mangment.Person_DatabaseDataSet();
            this.regDoctorTableAdapter = new hospital_mangment.Person_DatabaseDataSetTableAdapters.RegDoctorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDoctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.person_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(1, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.specializationDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.regDoctorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(401, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 389);
            this.dataGridView1.TabIndex = 48;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // specializationDataGridViewTextBoxColumn
            // 
            this.specializationDataGridViewTextBoxColumn.DataPropertyName = "specialization";
            this.specializationDataGridViewTextBoxColumn.HeaderText = "specialization";
            this.specializationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specializationDataGridViewTextBoxColumn.Name = "specializationDataGridViewTextBoxColumn";
            this.specializationDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "eMail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "eMail";
            this.eMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            this.eMailDataGridViewTextBoxColumn.Width = 125;
            // 
            // regDoctorBindingSource
            // 
            this.regDoctorBindingSource.DataMember = "RegDoctor";
            this.regDoctorBindingSource.DataSource = this.person_DatabaseDataSet;
            // 
            // person_DatabaseDataSet
            // 
            this.person_DatabaseDataSet.DataSetName = "Person_DatabaseDataSet";
            this.person_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regDoctorTableAdapter
            // 
            this.regDoctorTableAdapter.ClearBeforeFill = true;
            // 
            // DoctorDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1213, 591);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DoctorDisplay";
            this.Text = "DoctorDisplay";
            this.Load += new System.EventHandler(this.DoctorDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDoctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.person_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Person_DatabaseDataSet person_DatabaseDataSet;
        private System.Windows.Forms.BindingSource regDoctorBindingSource;
        private Person_DatabaseDataSetTableAdapters.RegDoctorTableAdapter regDoctorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
    }
}