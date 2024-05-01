namespace hospital_mangment
{
    partial class assignRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(assignRoom));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.TextBox();
            this.doctor = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(0, 21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(86, 56);
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // department
            // 
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.FormattingEnabled = true;
            this.department.Items.AddRange(new object[] {
            "Cardiology",
            "Neurology ",
            "Dermatology ",
            "Oncology",
            "Pediatrics",
            "Pulmonology",
            "Gastroenterology",
            "Psychiatry",
            "Urology",
            "Radiology"});
            this.department.Location = new System.Drawing.Point(468, 371);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(209, 37);
            this.department.TabIndex = 45;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(431, 291);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(209, 34);
            this.id.TabIndex = 42;
            // 
            // doctor
            // 
            this.doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor.Location = new System.Drawing.Point(375, 473);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(209, 34);
            this.doctor.TabIndex = 41;
            this.doctor.TextChanged += new System.EventHandler(this.doctor_TextChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(505, 200);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(224, 34);
            this.name.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(1037, 589);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 56);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // assignRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1213, 680);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.department);
            this.Controls.Add(this.id);
            this.Controls.Add(this.doctor);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox5);
            this.Name = "assignRoom";
            this.Text = "assignRoom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox doctor;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}