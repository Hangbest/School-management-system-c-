namespace SchoolManagementSystem
{
    partial class StudentForm
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
            this.Search_button = new System.Windows.Forms.Button();
            this.StdList_dataGridView = new System.Windows.Forms.DataGridView();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Gender_comboBox = new System.Windows.Forms.ComboBox();
            this.Phone_textBox = new System.Windows.Forms.TextBox();
            this.Stdname_textBox = new System.Windows.Forms.TextBox();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dob_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Class_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StdList_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.Location = new System.Drawing.Point(12, 69);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(104, 35);
            this.Search_button.TabIndex = 25;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // StdList_dataGridView
            // 
            this.StdList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StdList_dataGridView.Location = new System.Drawing.Point(12, 120);
            this.StdList_dataGridView.Name = "StdList_dataGridView";
            this.StdList_dataGridView.RowTemplate.Height = 28;
            this.StdList_dataGridView.Size = new System.Drawing.Size(906, 226);
            this.StdList_dataGridView.TabIndex = 24;
            this.StdList_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StdList_dataGridView_CellContentClick);
            // 
            // Delete_button
            // 
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Location = new System.Drawing.Point(490, 545);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(105, 35);
            this.Delete_button.TabIndex = 23;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Location = new System.Drawing.Point(363, 545);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(105, 35);
            this.Update_button.TabIndex = 22;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Location = new System.Drawing.Point(234, 545);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(105, 35);
            this.Save_button.TabIndex = 21;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Gender_comboBox
            // 
            this.Gender_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender_comboBox.FormattingEnabled = true;
            this.Gender_comboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender_comboBox.Location = new System.Drawing.Point(234, 501);
            this.Gender_comboBox.Name = "Gender_comboBox";
            this.Gender_comboBox.Size = new System.Drawing.Size(361, 28);
            this.Gender_comboBox.TabIndex = 20;
            // 
            // Phone_textBox
            // 
            this.Phone_textBox.Location = new System.Drawing.Point(234, 400);
            this.Phone_textBox.Name = "Phone_textBox";
            this.Phone_textBox.Size = new System.Drawing.Size(361, 26);
            this.Phone_textBox.TabIndex = 19;
            // 
            // Stdname_textBox
            // 
            this.Stdname_textBox.Location = new System.Drawing.Point(234, 367);
            this.Stdname_textBox.Name = "Stdname_textBox";
            this.Stdname_textBox.Size = new System.Drawing.Size(361, 26);
            this.Stdname_textBox.TabIndex = 16;
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(122, 75);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(796, 26);
            this.Search_textBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Student Name";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student Registration";
            // 
            // Dob_dateTimePicker
            // 
            this.Dob_dateTimePicker.Location = new System.Drawing.Point(234, 471);
            this.Dob_dateTimePicker.Name = "Dob_dateTimePicker";
            this.Dob_dateTimePicker.Size = new System.Drawing.Size(361, 26);
            this.Dob_dateTimePicker.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Class";
            // 
            // Class_comboBox
            // 
            this.Class_comboBox.FormattingEnabled = true;
            this.Class_comboBox.Location = new System.Drawing.Point(234, 432);
            this.Class_comboBox.Name = "Class_comboBox";
            this.Class_comboBox.Size = new System.Drawing.Size(361, 28);
            this.Class_comboBox.TabIndex = 27;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 587);
            this.Controls.Add(this.Class_comboBox);
            this.Controls.Add(this.Dob_dateTimePicker);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.StdList_dataGridView);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Gender_comboBox);
            this.Controls.Add(this.Phone_textBox);
            this.Controls.Add(this.Stdname_textBox);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StdList_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.DataGridView StdList_dataGridView;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.ComboBox Gender_comboBox;
        private System.Windows.Forms.TextBox Phone_textBox;
        private System.Windows.Forms.TextBox Stdname_textBox;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dob_dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Class_comboBox;

    }
}