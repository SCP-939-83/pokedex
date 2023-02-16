namespace WindowsFormsApp2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.shortdescription = new System.Windows.Forms.TextBox();
            this.nickname = new System.Windows.Forms.TextBox();
            this.scpname = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.scp = new System.Windows.Forms.Label();
            this.TeacherID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(671, 392);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.IndianRed;
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(228, 402);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 30);
            this.Exit.TabIndex = 28;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(228, 365);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(80, 30);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(56, 402);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(166, 30);
            this.Update.TabIndex = 26;
            this.Update.Text = "Update page";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Insert.Location = new System.Drawing.Point(56, 365);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(80, 30);
            this.Insert.TabIndex = 25;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(142, 365);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(80, 30);
            this.edit.TabIndex = 24;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // shortdescription
            // 
            this.shortdescription.Location = new System.Drawing.Point(133, 100);
            this.shortdescription.Name = "shortdescription";
            this.shortdescription.Size = new System.Drawing.Size(188, 22);
            this.shortdescription.TabIndex = 23;
            // 
            // nickname
            // 
            this.nickname.Location = new System.Drawing.Point(133, 73);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(188, 22);
            this.nickname.TabIndex = 22;
            // 
            // scpname
            // 
            this.scpname.Location = new System.Drawing.Point(133, 46);
            this.scpname.Name = "scpname";
            this.scpname.Size = new System.Drawing.Size(188, 22);
            this.scpname.TabIndex = 21;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(133, 19);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(188, 22);
            this.ID.TabIndex = 20;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(23, 106);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(104, 16);
            this.Salary.TabIndex = 19;
            this.Salary.Text = "Shortdescription";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(59, 79);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(68, 16);
            this.Address.TabIndex = 18;
            this.Address.Text = "Nickname";
            this.Address.Click += new System.EventHandler(this.Address_Click);
            // 
            // scp
            // 
            this.scp.AutoSize = true;
            this.scp.Location = new System.Drawing.Point(93, 52);
            this.scp.Name = "scp";
            this.scp.Size = new System.Drawing.Size(34, 16);
            this.scp.TabIndex = 17;
            this.scp.Text = "SCP";
            this.scp.Click += new System.EventHandler(this.scp_Click);
            // 
            // TeacherID
            // 
            this.TeacherID.AutoSize = true;
            this.TeacherID.Location = new System.Drawing.Point(107, 25);
            this.TeacherID.Name = "TeacherID";
            this.TeacherID.Size = new System.Drawing.Size(20, 16);
            this.TeacherID.TabIndex = 16;
            this.TeacherID.Text = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.SCP_Foundation;
            this.pictureBox1.Location = new System.Drawing.Point(81, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(468, 19);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(532, 22);
            this.search.TabIndex = 33;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.buttonSearch.Location = new System.Drawing.Point(328, 17);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(134, 25);
            this.buttonSearch.TabIndex = 34;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1012, 453);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.shortdescription);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.scpname);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.scp);
            this.Controls.Add(this.TeacherID);
            this.Name = "Form1";
            this.Text = "SCP database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.TextBox shortdescription;
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.TextBox scpname;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label scp;
        private System.Windows.Forms.Label TeacherID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button buttonSearch;
    }
}

