namespace Assignment2Students
{
    partial class MainForm
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
            this.Namelable = new System.Windows.Forms.Label();
            this.AddStudent = new System.Windows.Forms.Button();
            this.NameText1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberText1 = new System.Windows.Forms.TextBox();
            this.AddressText1 = new System.Windows.Forms.TextBox();
            this.PhoneText1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditStudent = new System.Windows.Forms.Button();
            this.DeleteStudent = new System.Windows.Forms.Button();
            this.ClearLIsts = new System.Windows.Forms.Button();
            this.ReportText = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NameBox = new System.Windows.Forms.ListBox();
            this.NumberBox = new System.Windows.Forms.ListBox();
            this.AddressBox = new System.Windows.Forms.ListBox();
            this.PhoneBox = new System.Windows.Forms.ListBox();
            this.Num = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Namelable
            // 
            this.Namelable.AutoSize = true;
            this.Namelable.Location = new System.Drawing.Point(39, 236);
            this.Namelable.Name = "Namelable";
            this.Namelable.Size = new System.Drawing.Size(35, 13);
            this.Namelable.TabIndex = 23;
            this.Namelable.Text = "Name";
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(229, 30);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(75, 23);
            this.AddStudent.TabIndex = 18;
            this.AddStudent.Text = "Add";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.Add_Click);
            // 
            // NameText1
            // 
            this.NameText1.Location = new System.Drawing.Point(74, 18);
            this.NameText1.Name = "NameText1";
            this.NameText1.Size = new System.Drawing.Size(120, 20);
            this.NameText1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // NumberText1
            // 
            this.NumberText1.Location = new System.Drawing.Point(74, 44);
            this.NumberText1.Name = "NumberText1";
            this.NumberText1.Size = new System.Drawing.Size(120, 20);
            this.NumberText1.TabIndex = 4;
            // 
            // AddressText1
            // 
            this.AddressText1.Location = new System.Drawing.Point(74, 69);
            this.AddressText1.Name = "AddressText1";
            this.AddressText1.Size = new System.Drawing.Size(120, 20);
            this.AddressText1.TabIndex = 5;
            // 
            // PhoneText1
            // 
            this.PhoneText1.Location = new System.Drawing.Point(74, 95);
            this.PhoneText1.Name = "PhoneText1";
            this.PhoneText1.Size = new System.Drawing.Size(120, 20);
            this.PhoneText1.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(53, 133);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Clear fields";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.PhoneText1);
            this.groupBox1.Controls.Add(this.AddressText1);
            this.groupBox1.Controls.Add(this.NumberText1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NameText1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 179);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students Data";
            // 
            // EditStudent
            // 
            this.EditStudent.Location = new System.Drawing.Point(229, 59);
            this.EditStudent.Name = "EditStudent";
            this.EditStudent.Size = new System.Drawing.Size(75, 23);
            this.EditStudent.TabIndex = 20;
            this.EditStudent.Text = "Edit";
            this.EditStudent.UseVisualStyleBackColor = true;
            this.EditStudent.Click += new System.EventHandler(this.EditStudent_Click);
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.Location = new System.Drawing.Point(229, 104);
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.Size = new System.Drawing.Size(75, 23);
            this.DeleteStudent.TabIndex = 21;
            this.DeleteStudent.Text = "Delete";
            this.DeleteStudent.UseVisualStyleBackColor = true;
            this.DeleteStudent.Click += new System.EventHandler(this.DeleteStudent_Click);
            // 
            // ClearLIsts
            // 
            this.ClearLIsts.Location = new System.Drawing.Point(229, 133);
            this.ClearLIsts.Name = "ClearLIsts";
            this.ClearLIsts.Size = new System.Drawing.Size(75, 23);
            this.ClearLIsts.TabIndex = 22;
            this.ClearLIsts.Text = "Clear lists";
            this.ClearLIsts.UseVisualStyleBackColor = true;
            this.ClearLIsts.Click += new System.EventHandler(this.ClearLIsts_Click);
            // 
            // ReportText
            // 
            this.ReportText.Location = new System.Drawing.Point(113, 18);
            this.ReportText.Name = "ReportText";
            this.ReportText.Size = new System.Drawing.Size(120, 20);
            this.ReportText.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(16, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Report";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.ReportText);
            this.groupBox2.Location = new System.Drawing.Point(487, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 64);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Students Num";
            // 
            // NameBox
            // 
            this.NameBox.FormattingEnabled = true;
            this.NameBox.Location = new System.Drawing.Point(42, 252);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(120, 186);
            this.NameBox.TabIndex = 25;
            // 
            // NumberBox
            // 
            this.NumberBox.FormattingEnabled = true;
            this.NumberBox.Location = new System.Drawing.Point(243, 252);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(120, 186);
            this.NumberBox.TabIndex = 26;
            // 
            // AddressBox
            // 
            this.AddressBox.FormattingEnabled = true;
            this.AddressBox.Location = new System.Drawing.Point(468, 252);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(120, 186);
            this.AddressBox.TabIndex = 27;
            // 
            // PhoneBox
            // 
            this.PhoneBox.FormattingEnabled = true;
            this.PhoneBox.Location = new System.Drawing.Point(658, 252);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(120, 186);
            this.PhoneBox.TabIndex = 28;
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Location = new System.Drawing.Point(240, 236);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(47, 13);
            this.Num.TabIndex = 29;
            this.Num.Text = "Number:";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(465, 236);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 30;
            this.Address.Text = "Address";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(655, 236);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(38, 13);
            this.Phone.TabIndex = 31;
            this.Phone.Text = "Phone";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.Namelable);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ClearLIsts);
            this.Controls.Add(this.DeleteStudent);
            this.Controls.Add(this.EditStudent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddStudent);
            this.Name = "MainForm";
            this.Text = "StudentsAssignment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelable;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.TextBox NameText1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberText1;
        private System.Windows.Forms.TextBox AddressText1;
        private System.Windows.Forms.TextBox PhoneText1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EditStudent;
        private System.Windows.Forms.Button DeleteStudent;
        private System.Windows.Forms.Button ClearLIsts;
        private System.Windows.Forms.TextBox ReportText;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox NameBox;
        private System.Windows.Forms.ListBox NumberBox;
        private System.Windows.Forms.ListBox AddressBox;
        private System.Windows.Forms.ListBox PhoneBox;
        private System.Windows.Forms.Label Num;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Phone;
    }
}

