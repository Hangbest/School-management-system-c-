namespace SchoolManagementSystem
{
    partial class ClassesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.CLassName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.CLasses_dataGridView = new System.Windows.Forms.DataGridView();
            this.delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Dept_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CLasses_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Class Name";
            // 
            // CLassName_textBox
            // 
            this.CLassName_textBox.Location = new System.Drawing.Point(281, 366);
            this.CLassName_textBox.Name = "CLassName_textBox";
            this.CLassName_textBox.Size = new System.Drawing.Size(460, 26);
            this.CLassName_textBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Department Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(-137, -360);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(372, 26);
            this.textBox4.TabIndex = 10;
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(125, 17);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(699, 26);
            this.Search_textBox.TabIndex = 11;
            // 
            // Search_button
            // 
            this.Search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.Location = new System.Drawing.Point(18, 11);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(101, 36);
            this.Search_button.TabIndex = 4;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // CLasses_dataGridView
            // 
            this.CLasses_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CLasses_dataGridView.Location = new System.Drawing.Point(12, 53);
            this.CLasses_dataGridView.Name = "CLasses_dataGridView";
            this.CLasses_dataGridView.RowTemplate.Height = 28;
            this.CLasses_dataGridView.Size = new System.Drawing.Size(831, 239);
            this.CLasses_dataGridView.TabIndex = 8;
            this.CLasses_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CLasses_dataGridView_CellContentClick);
            // 
            // delete_button
            // 
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Location = new System.Drawing.Point(598, 409);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(101, 36);
            this.delete_button.TabIndex = 5;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Location = new System.Drawing.Point(452, 409);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(101, 36);
            this.Update_button.TabIndex = 6;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Location = new System.Drawing.Point(309, 409);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(101, 36);
            this.Save_button.TabIndex = 7;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Dept_comboBox
            // 
            this.Dept_comboBox.FormattingEnabled = true;
            this.Dept_comboBox.Location = new System.Drawing.Point(281, 319);
            this.Dept_comboBox.Name = "Dept_comboBox";
            this.Dept_comboBox.Size = new System.Drawing.Size(460, 28);
            this.Dept_comboBox.TabIndex = 15;

            // 
            // ClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 457);
            this.Controls.Add(this.Dept_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CLassName_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.CLasses_dataGridView);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Save_button);
            this.Name = "ClassesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ClassesForm";
            this.Load += new System.EventHandler(this.ClassesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CLasses_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CLassName_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.DataGridView CLasses_dataGridView;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.ComboBox Dept_comboBox;
    }
}