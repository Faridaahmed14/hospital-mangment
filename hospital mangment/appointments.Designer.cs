namespace hospital_mangment
{
    partial class appointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appointments));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.room = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
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
            this.pictureBox5.Location = new System.Drawing.Point(1077, 604);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(104, 56);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // room
            // 
            this.room.Location = new System.Drawing.Point(260, 579);
            this.room.Multiline = true;
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(223, 28);
            this.room.TabIndex = 40;
            // 
            // department
            // 
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
            this.department.Location = new System.Drawing.Point(353, 313);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(209, 24);
            this.department.TabIndex = 39;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(234, 444);
            this.date.Multiline = true;
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(225, 31);
            this.date.TabIndex = 37;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(250, 511);
            this.time.Multiline = true;
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(223, 31);
            this.time.TabIndex = 35;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(317, 241);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(209, 31);
            this.id.TabIndex = 34;
            // 
            // doctor
            // 
            this.doctor.Location = new System.Drawing.Point(285, 376);
            this.doctor.Multiline = true;
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(209, 31);
            this.doctor.TabIndex = 32;
            this.doctor.TextChanged += new System.EventHandler(this.doctor_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(379, 176);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(224, 30);
            this.name.TabIndex = 30;
            this.name.UseSystemPasswordChar = true;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 61);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1217, 665);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.room);
            this.Controls.Add(this.department);
            this.Controls.Add(this.date);
            this.Controls.Add(this.time);
            this.Controls.Add(this.id);
            this.Controls.Add(this.doctor);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox5);
            this.Name = "appointments";
            this.Text = "appointments";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox room;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox doctor;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}