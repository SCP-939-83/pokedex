namespace WindowsFormsApp1
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
            this.TeacherID = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.textTeacherID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TeacherID
            // 
            this.TeacherID.AutoSize = true;
            this.TeacherID.Location = new System.Drawing.Point(18, 25);
            this.TeacherID.Name = "TeacherID";
            this.TeacherID.Size = new System.Drawing.Size(74, 16);
            this.TeacherID.TabIndex = 0;
            this.TeacherID.Text = "Teacher ID";
            this.TeacherID.Click += new System.EventHandler(this.label1_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(18, 52);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(44, 16);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(18, 106);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(46, 16);
            this.Salary.TabIndex = 3;
            this.Salary.Text = "Salary";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(18, 79);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(58, 16);
            this.Address.TabIndex = 2;
            this.Address.Text = "Address";
            // 
            // textTeacherID
            // 
            this.textTeacherID.Location = new System.Drawing.Point(98, 25);
            this.textTeacherID.Name = "textTeacherID";
            this.textTeacherID.Size = new System.Drawing.Size(116, 22);
            this.textTeacherID.TabIndex = 4;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(98, 52);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(116, 22);
            this.textName.TabIndex = 5;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(98, 79);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(116, 22);
            this.textAddress.TabIndex = 6;
            // 
            // textSalary
            // 
            this.textSalary.Location = new System.Drawing.Point(98, 106);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(116, 22);
            this.textSalary.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.textSalary);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textTeacherID);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.TeacherID);
            this.Name = "Form1";
            this.Text = "Pokédex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TeacherID;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox textTeacherID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textSalary;
    }
}

