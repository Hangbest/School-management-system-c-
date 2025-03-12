namespace SchoolManagementSystem
{
    partial class CourseForm
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
            this.CoursName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CourseDescrip_textBox = new System.Windows.Forms.TextBox();
            this.CourseHours_textBox = new System.Windows.Forms.TextBox();
            this.Course_dataGridView = new System.Windows.Forms.DataGridView();
            this.delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Course_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CoursName_textBox
            // 
            this.CoursName_textBox.Location = new System.Drawing.Point(265, 90);
            this.CoursName_textBox.Name = "CoursName_textBox";
            this.CoursName_textBox.Size = new System.Drawing.Size(569, 26);
            this.CoursName_textBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 36);
            this.label2.TabIndex = 27;
            this.label2.Text = "Course Description";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 36);
            this.label3.TabIndex = 27;
            this.label3.Text = "Course Hours ";
            // 
            // CourseDescrip_textBox
            // 
            this.CourseDescrip_textBox.Location = new System.Drawing.Point(265, 142);
            this.CourseDescrip_textBox.Name = "CourseDescrip_textBox";
            this.CourseDescrip_textBox.Size = new System.Drawing.Size(569, 26);
            this.CourseDescrip_textBox.TabIndex = 26;
            // 
            // CourseHours_textBox
            // 
            this.CourseHours_textBox.Location = new System.Drawing.Point(265, 187);
            this.CourseHours_textBox.Name = "CourseHours_textBox";
            this.CourseHours_textBox.Size = new System.Drawing.Size(569, 26);
            this.CourseHours_textBox.TabIndex = 26;
            // 
            // Course_dataGridView
            // 
            this.Course_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Course_dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Course_dataGridView.Location = new System.Drawing.Point(0, 325);
            this.Course_dataGridView.Name = "Course_dataGridView";
            this.Course_dataGridView.RowTemplate.Height = 28;
            this.Course_dataGridView.Size = new System.Drawing.Size(846, 198);
            this.Course_dataGridView.TabIndex = 28;
            this.Course_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Course_dataGridView_CellContentClick);
            // 
            // delete_button
            // 
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Location = new System.Drawing.Point(576, 229);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(101, 36);
            this.delete_button.TabIndex = 29;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Location = new System.Drawing.Point(430, 229);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(101, 36);
            this.Update_button.TabIndex = 30;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Location = new System.Drawing.Point(287, 229);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(101, 36);
            this.Save_button.TabIndex = 31;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(118, 289);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(716, 26);
            this.Search_textBox.TabIndex = 33;
            // 
            // Search_button
            // 
            this.Search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.Location = new System.Drawing.Point(11, 283);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(101, 36);
            this.Search_button.TabIndex = 32;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(202, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(454, 54);
            this.label4.TabIndex = 34;
            this.label4.Text = "Course Management ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 523);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Course_dataGridView);
            this.Controls.Add(this.CourseHours_textBox);
            this.Controls.Add(this.CourseDescrip_textBox);
            this.Controls.Add(this.CoursName_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Course_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CoursName_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CourseDescrip_textBox;
        private System.Windows.Forms.TextBox CourseHours_textBox;
        private System.Windows.Forms.DataGridView Course_dataGridView;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Label label4;
    }
}