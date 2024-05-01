namespace hospital_mangment
{
    partial class RegFront
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegFront));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.verifyPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.eMail = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(7, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 53);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gender
            // 
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(244, 340);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(209, 37);
            this.gender.TabIndex = 43;
            this.gender.SelectedIndexChanged += new System.EventHandler(this.gender_SelectedIndexChanged);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(707, 342);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(223, 34);
            this.date.TabIndex = 42;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // verifyPassword
            // 
            this.verifyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyPassword.Location = new System.Drawing.Point(707, 417);
            this.verifyPassword.Name = "verifyPassword";
            this.verifyPassword.Size = new System.Drawing.Size(217, 34);
            this.verifyPassword.TabIndex = 40;
            this.verifyPassword.TextChanged += new System.EventHandler(this.verifyPassword_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(244, 417);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(223, 34);
            this.password.TabIndex = 39;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // eMail
            // 
            this.eMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMail.Location = new System.Drawing.Point(707, 183);
            this.eMail.Name = "eMail";
            this.eMail.Size = new System.Drawing.Size(209, 34);
            this.eMail.TabIndex = 38;
            this.eMail.TextChanged += new System.EventHandler(this.eMail_TextChanged);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(244, 259);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(223, 34);
            this.number.TabIndex = 35;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(244, 183);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(224, 34);
            this.name.TabIndex = 34;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
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
            this.department.Location = new System.Drawing.Point(707, 259);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(209, 37);
            this.department.TabIndex = 47;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(1011, 544);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 52);
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // RegFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1204, 608);
            this.Controls.Add(this.department);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.date);
            this.Controls.Add(this.verifyPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.eMail);
            this.Controls.Add(this.number);
            this.Controls.Add(this.name);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "RegFront";
            this.Text = "RegFront";
            this.Load += new System.EventHandler(this.RegFront_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox verifyPassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox eMail;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}