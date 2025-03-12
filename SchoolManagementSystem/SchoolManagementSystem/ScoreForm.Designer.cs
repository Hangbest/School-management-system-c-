namespace SchoolManagementSystem
{
    partial class ScoreForm
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
            this.Student_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Score_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Score_dataGridView = new System.Windows.Forms.DataGridView();
            this.delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Course_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Search_button = new System.Windows.Forms.Button();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Score_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Student_comboBox
            // 
            this.Student_comboBox.FormattingEnabled = true;
            this.Student_comboBox.Location = new System.Drawing.Point(281, 401);
            this.Student_comboBox.Name = "Student_comboBox";
            this.Student_comboBox.Size = new System.Drawing.Size(460, 28);
            this.Student_comboBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Score";
            // 
            // Score_textBox
            // 
            this.Score_textBox.Location = new System.Drawing.Point(281, 501);
            this.Score_textBox.Name = "Score_textBox";
            this.Score_textBox.Size = new System.Drawing.Size(460, 26);
            this.Score_textBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "Stduent";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(-137, -358);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(372, 26);
            this.textBox4.TabIndex = 22;
            // 
            // Score_dataGridView
            // 
            this.Score_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Score_dataGridView.Location = new System.Drawing.Point(12, 135);
            this.Score_dataGridView.Name = "Score_dataGridView";
            this.Score_dataGridView.RowTemplate.Height = 28;
            this.Score_dataGridView.Size = new System.Drawing.Size(831, 239);
            this.Score_dataGridView.TabIndex = 20;
            this.Score_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Score_dataGridView_CellContentClick);
            // 
            // delete_button
            // 
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Location = new System.Drawing.Point(598, 544);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(101, 36);
            this.delete_button.TabIndex = 17;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Location = new System.Drawing.Point(452, 544);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(101, 36);
            this.Update_button.TabIndex = 18;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Location = new System.Drawing.Point(309, 544);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(101, 36);
            this.Save_button.TabIndex = 19;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 36);
            this.label3.TabIndex = 25;
            this.label3.Text = "Course";
            // 
            // Course_comboBox
            // 
            this.Course_comboBox.FormattingEnabled = true;
            this.Course_comboBox.Location = new System.Drawing.Point(281, 450);
            this.Course_comboBox.Name = "Course_comboBox";
            this.Course_comboBox.Size = new System.Drawing.Size(460, 28);
            this.Course_comboBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(272, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 54);
            this.label4.TabIndex = 25;
            this.label4.Text = "Student Score";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.Location = new System.Drawing.Point(11, 84);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(104, 35);
            this.Search_button.TabIndex = 44;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(121, 90);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(711, 26);
            this.Search_textBox.TabIndex = 43;
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 587);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.Course_comboBox);
            this.Controls.Add(this.Student_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Score_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Score_dataGridView);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Save_button);
            this.Name = "ScoreForm";
            this.Text = "ScoreForm";
            this.Load += new System.EventHandler(this.ScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Score_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Student_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Score_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView Score_dataGridView;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Course_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.TextBox Search_textBox;
    }
}