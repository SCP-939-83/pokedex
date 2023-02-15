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
            this.ShowAll = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.textFind = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.textTeacherID.Size = new System.Drawing.Size(188, 22);
            this.textTeacherID.TabIndex = 4;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(98, 52);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(188, 22);
            this.textName.TabIndex = 5;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(98, 79);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(188, 22);
            this.textAddress.TabIndex = 6;
            // 
            // textSalary
            // 
            this.textSalary.Location = new System.Drawing.Point(98, 106);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(188, 22);
            this.textSalary.TabIndex = 7;
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(21, 408);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(80, 30);
            this.ShowAll.TabIndex = 8;
            this.ShowAll.Text = "Show all";
            this.ShowAll.UseVisualStyleBackColor = true;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(21, 371);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(80, 30);
            this.Insert.TabIndex = 9;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(107, 371);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(80, 30);
            this.Update.TabIndex = 10;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(193, 371);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(80, 30);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.IndianRed;
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(193, 408);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 30);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // textFind
            // 
            this.textFind.Location = new System.Drawing.Point(292, 25);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(398, 22);
            this.textFind.TabIndex = 13;
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.LawnGreen;
            this.Find.Location = new System.Drawing.Point(696, 25);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(92, 22);
            this.Find.TabIndex = 14;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(292, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(495, 384);
            this.dataGridView1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.textFind);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.ShowAll);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox textFind;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

