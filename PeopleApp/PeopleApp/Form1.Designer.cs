namespace PeopleApp
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbttypeLecturer = new System.Windows.Forms.RadioButton();
            this.rdbStudentType = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.Lectures = new System.Windows.Forms.Button();
            this.dgPeople = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(68, 84);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name ";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(68, 128);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(68, 13);
            this.lblDOB.TabIndex = 1;
            this.lblDOB.Text = "Date Of Birth";
            this.lblDOB.Click += new System.EventHandler(this.lblDOB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Person Type ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "People";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbttypeLecturer);
            this.groupBox1.Controls.Add(this.rdbStudentType);
            this.groupBox1.Location = new System.Drawing.Point(70, 193);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(171, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person";
            // 
            // rbttypeLecturer
            // 
            this.rbttypeLecturer.AutoSize = true;
            this.rbttypeLecturer.Location = new System.Drawing.Point(4, 36);
            this.rbttypeLecturer.Margin = new System.Windows.Forms.Padding(2);
            this.rbttypeLecturer.Name = "rbttypeLecturer";
            this.rbttypeLecturer.Size = new System.Drawing.Size(64, 17);
            this.rbttypeLecturer.TabIndex = 1;
            this.rbttypeLecturer.TabStop = true;
            this.rbttypeLecturer.Text = "Lecturer";
            this.rbttypeLecturer.UseVisualStyleBackColor = true;
            // 
            // rdbStudentType
            // 
            this.rdbStudentType.AutoSize = true;
            this.rdbStudentType.Location = new System.Drawing.Point(4, 17);
            this.rdbStudentType.Margin = new System.Windows.Forms.Padding(2);
            this.rdbStudentType.Name = "rdbStudentType";
            this.rdbStudentType.Size = new System.Drawing.Size(62, 17);
            this.rdbStudentType.TabIndex = 0;
            this.rdbStudentType.TabStop = true;
            this.rdbStudentType.Text = "Student";
            this.rdbStudentType.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 81);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 20);
            this.txtName.TabIndex = 6;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(140, 128);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(151, 20);
            this.dtpDOB.TabIndex = 7;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(76, 274);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 19);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(353, 274);
            this.btnAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(56, 19);
            this.btnAll.TabIndex = 10;
            this.btnAll.Text = "View All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // Lectures
            // 
            this.Lectures.Location = new System.Drawing.Point(423, 274);
            this.Lectures.Margin = new System.Windows.Forms.Padding(2);
            this.Lectures.Name = "Lectures";
            this.Lectures.Size = new System.Drawing.Size(56, 19);
            this.Lectures.TabIndex = 11;
            this.Lectures.Text = "Lectures";
            this.Lectures.UseVisualStyleBackColor = true;
            this.Lectures.Click += new System.EventHandler(this.Lectures_Click);
            // 
            // dgPeople
            // 
            this.dgPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeople.Location = new System.Drawing.Point(353, 124);
            this.dgPeople.Margin = new System.Windows.Forms.Padding(2);
            this.dgPeople.Name = "dgPeople";
            this.dgPeople.RowHeadersWidth = 51;
            this.dgPeople.RowTemplate.Height = 24;
            this.dgPeople.Size = new System.Drawing.Size(390, 122);
            this.dgPeople.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 366);
            this.Controls.Add(this.dgPeople);
            this.Controls.Add(this.Lectures);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbttypeLecturer;
        private System.Windows.Forms.RadioButton rdbStudentType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button Lectures;
        private System.Windows.Forms.DataGridView dgPeople;
    }
}

