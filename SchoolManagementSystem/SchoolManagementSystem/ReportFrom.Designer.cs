namespace SchoolManagementSystem
{
    partial class ReportFrom
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
            this.label4 = new System.Windows.Forms.Label();
            this.List_dataGridView = new System.Windows.Forms.DataGridView();
            this.Report_button = new System.Windows.Forms.Button();
            this.Male_radioButton = new System.Windows.Forms.RadioButton();
            this.Female_radioButton = new System.Windows.Forms.RadioButton();
            this.All_radioButton = new System.Windows.Forms.RadioButton();
            this.Class_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.List_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.Location = new System.Drawing.Point(859, 23);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(104, 35);
            this.Search_button.TabIndex = 57;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 54);
            this.label4.TabIndex = 52;
            this.label4.Text = "To Report";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // List_dataGridView
            // 
            this.List_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_dataGridView.Location = new System.Drawing.Point(12, 66);
            this.List_dataGridView.Name = "List_dataGridView";
            this.List_dataGridView.RowTemplate.Height = 28;
            this.List_dataGridView.Size = new System.Drawing.Size(951, 491);
            this.List_dataGridView.TabIndex = 48;
            // 
            // Report_button
            // 
            this.Report_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Report_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report_button.Location = new System.Drawing.Point(862, 574);
            this.Report_button.Name = "Report_button";
            this.Report_button.Size = new System.Drawing.Size(101, 36);
            this.Report_button.TabIndex = 47;
            this.Report_button.Text = "Report";
            this.Report_button.UseVisualStyleBackColor = false;
            this.Report_button.Click += new System.EventHandler(this.Report_button_Click);
            // 
            // Male_radioButton
            // 
            this.Male_radioButton.AutoSize = true;
            this.Male_radioButton.Location = new System.Drawing.Point(121, 586);
            this.Male_radioButton.Name = "Male_radioButton";
            this.Male_radioButton.Size = new System.Drawing.Size(68, 24);
            this.Male_radioButton.TabIndex = 58;
            this.Male_radioButton.TabStop = true;
            this.Male_radioButton.Text = "Male";
            this.Male_radioButton.UseVisualStyleBackColor = true;
            this.Male_radioButton.CheckedChanged += new System.EventHandler(this.Male_radioButton_CheckedChanged);
            // 
            // Female_radioButton
            // 
            this.Female_radioButton.AutoSize = true;
            this.Female_radioButton.Location = new System.Drawing.Point(208, 586);
            this.Female_radioButton.Name = "Female_radioButton";
            this.Female_radioButton.Size = new System.Drawing.Size(87, 24);
            this.Female_radioButton.TabIndex = 58;
            this.Female_radioButton.TabStop = true;
            this.Female_radioButton.Text = "Female";
            this.Female_radioButton.UseVisualStyleBackColor = true;
            this.Female_radioButton.CheckedChanged += new System.EventHandler(this.Female_radioButton_CheckedChanged);
            // 
            // All_radioButton
            // 
            this.All_radioButton.AutoSize = true;
            this.All_radioButton.Location = new System.Drawing.Point(314, 586);
            this.All_radioButton.Name = "All_radioButton";
            this.All_radioButton.Size = new System.Drawing.Size(51, 24);
            this.All_radioButton.TabIndex = 58;
            this.All_radioButton.TabStop = true;
            this.All_radioButton.Text = "All";
            this.All_radioButton.UseVisualStyleBackColor = true;
            this.All_radioButton.CheckedChanged += new System.EventHandler(this.All_radioButton_CheckedChanged);
            // 
            // Class_comboBox
            // 
            this.Class_comboBox.FormattingEnabled = true;
            this.Class_comboBox.Location = new System.Drawing.Point(673, 26);
            this.Class_comboBox.Name = "Class_comboBox";
            this.Class_comboBox.Size = new System.Drawing.Size(180, 28);
            this.Class_comboBox.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(512, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 52;
            this.label1.Text = "Select Classes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(12, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 52;
            this.label2.Text = "Gender :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 622);
            this.Controls.Add(this.Class_comboBox);
            this.Controls.Add(this.All_radioButton);
            this.Controls.Add(this.Female_radioButton);
            this.Controls.Add(this.Male_radioButton);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.List_dataGridView);
            this.Controls.Add(this.Report_button);
            this.Name = "ReportFrom";
            this.Text = "ReportFrom";
            this.Load += new System.EventHandler(this.ReportFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.List_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView List_dataGridView;
        private System.Windows.Forms.Button Report_button;
        private System.Windows.Forms.RadioButton Male_radioButton;
        private System.Windows.Forms.RadioButton Female_radioButton;
        private System.Windows.Forms.RadioButton All_radioButton;
        private System.Windows.Forms.ComboBox Class_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}