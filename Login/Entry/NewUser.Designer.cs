namespace Login.Entry
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.label1 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.isActiveComboBox = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.massagelabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.userNameTextBox.Location = new System.Drawing.Point(192, 25);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(161, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(52, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fullNameTextBox.Location = new System.Drawing.Point(194, 87);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(159, 20);
            this.fullNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(52, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordTextBox.Location = new System.Drawing.Point(194, 165);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(157, 20);
            this.passwordTextBox.TabIndex = 5;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(197, 235);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(156, 20);
            this.confirmPasswordTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(52, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(52, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Is Active";
            // 
            // isActiveComboBox
            // 
            this.isActiveComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.isActiveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isActiveComboBox.FormattingEnabled = true;
            this.isActiveComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.isActiveComboBox.Location = new System.Drawing.Point(197, 306);
            this.isActiveComboBox.Name = "isActiveComboBox";
            this.isActiveComboBox.Size = new System.Drawing.Size(156, 21);
            this.isActiveComboBox.TabIndex = 10;
            this.isActiveComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.submitButton.Location = new System.Drawing.Point(212, 413);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(96, 30);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // massagelabel
            // 
            this.massagelabel.AutoSize = true;
            this.massagelabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.massagelabel.Location = new System.Drawing.Point(470, 137);
            this.massagelabel.Name = "massagelabel";
            this.massagelabel.Size = new System.Drawing.Size(0, 13);
            this.massagelabel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "User Type";
            // 
            // userTypeComboBox
            // 
            this.userTypeComboBox.FormattingEnabled = true;
            this.userTypeComboBox.Items.AddRange(new object[] {
            "Select User Type",
            "Admin"});
            this.userTypeComboBox.Location = new System.Drawing.Point(197, 369);
            this.userTypeComboBox.Name = "userTypeComboBox";
            this.userTypeComboBox.Size = new System.Drawing.Size(153, 21);
            this.userTypeComboBox.TabIndex = 14;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.userTypeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.massagelabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.isActiveComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewUser";
            this.Text = "New User Entry";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox isActiveComboBox;
        private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.Label massagelabel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox userTypeComboBox;
	}
}