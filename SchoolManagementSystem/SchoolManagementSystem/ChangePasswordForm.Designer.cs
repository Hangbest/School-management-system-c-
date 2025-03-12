namespace SchoolManagementSystem
{
    partial class ChangePasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.ConfiPassword_textBox = new System.Windows.Forms.TextBox();
            this.Update_button = new System.Windows.Forms.Button();
            this.UserList_dataGridView = new System.Windows.Forms.DataGridView();
            this.Search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserList_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Password change";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Confirm Password";
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(122, 65);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(659, 26);
            this.Search_textBox.TabIndex = 15;
            // 
            // Username_textBox
            // 
            this.Username_textBox.Location = new System.Drawing.Point(234, 286);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(361, 26);
            this.Username_textBox.TabIndex = 19;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(234, 322);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '*';
            this.Password_textBox.Size = new System.Drawing.Size(361, 26);
            this.Password_textBox.TabIndex = 17;
            // 
            // ConfiPassword_textBox
            // 
            this.ConfiPassword_textBox.Location = new System.Drawing.Point(234, 354);
            this.ConfiPassword_textBox.Name = "ConfiPassword_textBox";
            this.ConfiPassword_textBox.PasswordChar = '*';
            this.ConfiPassword_textBox.Size = new System.Drawing.Size(361, 26);
            this.ConfiPassword_textBox.TabIndex = 18;
            // 
            // Update_button
            // 
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Location = new System.Drawing.Point(300, 395);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(203, 35);
            this.Update_button.TabIndex = 22;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // UserList_dataGridView
            // 
            this.UserList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserList_dataGridView.Location = new System.Drawing.Point(12, 110);
            this.UserList_dataGridView.Name = "UserList_dataGridView";
            this.UserList_dataGridView.RowTemplate.Height = 28;
            this.UserList_dataGridView.Size = new System.Drawing.Size(769, 150);
            this.UserList_dataGridView.TabIndex = 24;
            this.UserList_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserList_dataGridView_CellContentClick);
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.Location = new System.Drawing.Point(12, 61);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(104, 35);
            this.Search_button.TabIndex = 25;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 465);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.UserList_dataGridView);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.ConfiPassword_textBox);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Username_textBox);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserList_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox ConfiPassword_textBox;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.DataGridView UserList_dataGridView;
        private System.Windows.Forms.Button Search_button;


    }
}