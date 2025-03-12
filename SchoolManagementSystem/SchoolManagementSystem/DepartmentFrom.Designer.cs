namespace SchoolManagementSystem
{
    partial class DepartmentFrom
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
            this.Save_button = new System.Windows.Forms.Button();
            this.Dept_dataGridView = new System.Windows.Forms.DataGridView();
            this.DpName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hdp_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dept_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Save_button
            // 
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Location = new System.Drawing.Point(297, 412);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(101, 36);
            this.Save_button.TabIndex = 0;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Dept_dataGridView
            // 
            this.Dept_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dept_dataGridView.Location = new System.Drawing.Point(0, 56);
            this.Dept_dataGridView.Name = "Dept_dataGridView";
            this.Dept_dataGridView.RowTemplate.Height = 28;
            this.Dept_dataGridView.Size = new System.Drawing.Size(831, 239);
            this.Dept_dataGridView.TabIndex = 1;
            this.Dept_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dept_dataGridView_CellContentClick);
            // 
            // DpName_textBox
            // 
            this.DpName_textBox.Location = new System.Drawing.Point(269, 323);
            this.DpName_textBox.Name = "DpName_textBox";
            this.DpName_textBox.Size = new System.Drawing.Size(460, 26);
            this.DpName_textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Department Name";
            // 
            // Hdp_textBox
            // 
            this.Hdp_textBox.Location = new System.Drawing.Point(269, 369);
            this.Hdp_textBox.Name = "Hdp_textBox";
            this.Hdp_textBox.Size = new System.Drawing.Size(460, 26);
            this.Hdp_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Haed of Department";
            // 
            // Update_button
            // 
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Location = new System.Drawing.Point(440, 412);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(101, 36);
            this.Update_button.TabIndex = 0;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Location = new System.Drawing.Point(586, 412);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(101, 36);
            this.delete_button.TabIndex = 0;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(113, 20);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(699, 26);
            this.Search_textBox.TabIndex = 2;
            // 
            // Search_button
            // 
            this.Search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.Location = new System.Drawing.Point(6, 14);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(101, 36);
            this.Search_button.TabIndex = 0;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(-149, -357);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(372, 26);
            this.textBox4.TabIndex = 2;
            // 
            // DepartmentFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hdp_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.DpName_textBox);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Dept_dataGridView);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Save_button);
            this.Name = "DepartmentFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DepartmentFrom";
            this.Load += new System.EventHandler(this.DepartmentFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dept_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.DataGridView Dept_dataGridView;
        private System.Windows.Forms.TextBox DpName_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Hdp_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.TextBox textBox4;
    }
}