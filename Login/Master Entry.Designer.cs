namespace Login
{
    partial class Master_Entry
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reportsComboBox = new System.Windows.Forms.ComboBox();
            this.reportLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(41, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "New User";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(173, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Master  Report";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportsComboBox
            // 
            this.reportsComboBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsComboBox.FormattingEnabled = true;
            this.reportsComboBox.Items.AddRange(new object[] {
            "Costing Summery",
            "Incentive",
            "Email",
            "Buyerwise",
            "Itemwise",
            "Departmentwise",
            "Weekly Lost Time Report",
            "Supervisor Lost Time"});
            this.reportsComboBox.Location = new System.Drawing.Point(378, 82);
            this.reportsComboBox.Name = "reportsComboBox";
            this.reportsComboBox.Size = new System.Drawing.Size(210, 32);
            this.reportsComboBox.TabIndex = 5;
            this.reportsComboBox.SelectedIndexChanged += new System.EventHandler(this.reportsComboBox_SelectedIndexChanged);
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.reportLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportLabel.Location = new System.Drawing.Point(378, 41);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(210, 32);
            this.reportLabel.TabIndex = 6;
            this.reportLabel.Text = "Reports Status";
            // 
            // Master_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 478);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.reportsComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Master_Entry";
            this.Text = "Master_Entry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox reportsComboBox;
        private System.Windows.Forms.Label reportLabel;
    }
}