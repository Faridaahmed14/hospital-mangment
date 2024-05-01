namespace hospital_mangment
{
    partial class patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patient));
            this.name = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.emergencyNumber = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.eMail = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.verifyPassword = new System.Windows.Forms.TextBox();
            this.history = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.gender = new System.Windows.Forms.ComboBox();
            this.sickness = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(241, 142);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(224, 34);
            this.name.TabIndex = 1;
            this.name.UseSystemPasswordChar = true;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(241, 209);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(223, 34);
            this.number.TabIndex = 5;
            // 
            // emergencyNumber
            // 
            this.emergencyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencyNumber.Location = new System.Drawing.Point(715, 287);
            this.emergencyNumber.Name = "emergencyNumber";
            this.emergencyNumber.Size = new System.Drawing.Size(209, 34);
            this.emergencyNumber.TabIndex = 7;
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(242, 287);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(223, 34);
            this.address.TabIndex = 13;
            // 
            // eMail
            // 
            this.eMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMail.Location = new System.Drawing.Point(715, 209);
            this.eMail.Name = "eMail";
            this.eMail.Size = new System.Drawing.Size(209, 34);
            this.eMail.TabIndex = 15;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(239, 494);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(223, 34);
            this.password.TabIndex = 17;
            // 
            // verifyPassword
            // 
            this.verifyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyPassword.Location = new System.Drawing.Point(715, 509);
            this.verifyPassword.Name = "verifyPassword";
            this.verifyPassword.Size = new System.Drawing.Size(217, 34);
            this.verifyPassword.TabIndex = 19;
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.Location = new System.Drawing.Point(239, 424);
            this.history.Multiline = true;
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(225, 37);
            this.history.TabIndex = 24;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(242, 361);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(223, 34);
            this.date.TabIndex = 27;
            // 
            // gender
            // 
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(715, 359);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(209, 37);
            this.gender.TabIndex = 28;
            // 
            // sickness
            // 
            this.sickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sickness.Location = new System.Drawing.Point(715, 432);
            this.sickness.Name = "sickness";
            this.sickness.Size = new System.Drawing.Size(223, 34);
            this.sickness.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 53);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(1017, 515);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 52);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1216, 579);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sickness);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.date);
            this.Controls.Add(this.history);
            this.Controls.Add(this.verifyPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.eMail);
            this.Controls.Add(this.address);
            this.Controls.Add(this.emergencyNumber);
            this.Controls.Add(this.number);
            this.Controls.Add(this.name);
            this.Name = "patient";
            this.Text = "patient";
            this.Load += new System.EventHandler(this.patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox emergencyNumber;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox eMail;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox verifyPassword;
        private System.Windows.Forms.TextBox history;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox sickness;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}