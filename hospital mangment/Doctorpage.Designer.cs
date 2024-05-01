namespace hospital_mangment
{
    partial class Doctorpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctorpage));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sicknessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.person_DatabaseDataSet = new hospital_mangment.Person_DatabaseDataSet();
            this.prescription = new System.Windows.Forms.TextBox();
            this.registerTableAdapter = new hospital_mangment.Person_DatabaseDataSetTableAdapters.registerTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.person_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(12, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(86, 56);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.sicknessDataGridViewTextBoxColumn,
            this.historyDataGridViewTextBoxColumn,
            this.prescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.registerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(439, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 575);
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
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sicknessDataGridViewTextBoxColumn
            // 
            this.sicknessDataGridViewTextBoxColumn.DataPropertyName = "sickness";
            this.sicknessDataGridViewTextBoxColumn.HeaderText = "sickness";
            this.sicknessDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sicknessDataGridViewTextBoxColumn.Name = "sicknessDataGridViewTextBoxColumn";
            this.sicknessDataGridViewTextBoxColumn.Width = 125;
            // 
            // historyDataGridViewTextBoxColumn
            // 
            this.historyDataGridViewTextBoxColumn.DataPropertyName = "history";
            this.historyDataGridViewTextBoxColumn.HeaderText = "history";
            this.historyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.historyDataGridViewTextBoxColumn.Name = "historyDataGridViewTextBoxColumn";
            this.historyDataGridViewTextBoxColumn.Width = 125;
            // 
            // prescriptionDataGridViewTextBoxColumn
            // 
            this.prescriptionDataGridViewTextBoxColumn.DataPropertyName = "prescription";
            this.prescriptionDataGridViewTextBoxColumn.HeaderText = "prescription";
            this.prescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prescriptionDataGridViewTextBoxColumn.Name = "prescriptionDataGridViewTextBoxColumn";
            this.prescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataMember = "register";
            this.registerBindingSource.DataSource = this.person_DatabaseDataSet;
            // 
            // person_DatabaseDataSet
            // 
            this.person_DatabaseDataSet.DataSetName = "Person_DatabaseDataSet";
            this.person_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prescription
            // 
            this.prescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescription.Location = new System.Drawing.Point(96, 300);
            this.prescription.Multiline = true;
            this.prescription.Name = "prescription";
            this.prescription.Size = new System.Drawing.Size(289, 180);
            this.prescription.TabIndex = 49;
            // 
            // registerTableAdapter
            // 
            this.registerTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(166, 579);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 40);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Doctorpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1187, 645);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.prescription);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox5);
            this.Name = "Doctorpage";
            this.Text = "Doctorpage";
            this.Load += new System.EventHandler(this.Doctorpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.person_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox prescription;
        private Person_DatabaseDataSet person_DatabaseDataSet;
        private System.Windows.Forms.BindingSource registerBindingSource;
        private Person_DatabaseDataSetTableAdapters.registerTableAdapter registerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicknessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        //  private Person_DatabaseDataSetTableAdapters.registerTableAdapter registerTableAdapter;
    }
}