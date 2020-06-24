namespace Login
{
    partial class IncentiveSummery
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
            this.FromDatelabel = new System.Windows.Forms.Label();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.showButton = new System.Windows.Forms.Button();
            this.incentiveDataGridView = new System.Windows.Forms.DataGridView();
            this.Excelbutton = new System.Windows.Forms.Button();
            this.plantComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.incentiveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FromDatelabel
            // 
            this.FromDatelabel.AutoSize = true;
            this.FromDatelabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDatelabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FromDatelabel.Location = new System.Drawing.Point(380, 108);
            this.FromDatelabel.Name = "FromDatelabel";
            this.FromDatelabel.Size = new System.Drawing.Size(73, 20);
            this.FromDatelabel.TabIndex = 0;
            this.FromDatelabel.Text = "From Date";
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toDateLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toDateLabel.Location = new System.Drawing.Point(748, 110);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(56, 20);
            this.toDateLabel.TabIndex = 1;
            this.toDateLabel.Text = "To Date";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(459, 110);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker.TabIndex = 2;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(810, 110);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.toDateTimePicker.TabIndex = 3;
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.showButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showButton.Location = new System.Drawing.Point(1113, 107);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(67, 29);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show Report";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // incentiveDataGridView
            // 
            this.incentiveDataGridView.AllowUserToAddRows = false;
            this.incentiveDataGridView.AllowUserToDeleteRows = false;
            this.incentiveDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incentiveDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.incentiveDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.incentiveDataGridView.Location = new System.Drawing.Point(42, 151);
            this.incentiveDataGridView.Name = "incentiveDataGridView";
            this.incentiveDataGridView.ReadOnly = true;
            this.incentiveDataGridView.Size = new System.Drawing.Size(1138, 351);
            this.incentiveDataGridView.TabIndex = 5;
            // 
            // Excelbutton
            // 
            this.Excelbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Excelbutton.Location = new System.Drawing.Point(1105, 508);
            this.Excelbutton.Name = "Excelbutton";
            this.Excelbutton.Size = new System.Drawing.Size(75, 23);
            this.Excelbutton.TabIndex = 6;
            this.Excelbutton.Text = "Excel";
            this.Excelbutton.UseVisualStyleBackColor = true;
            this.Excelbutton.Click += new System.EventHandler(this.Excelbutton_Click);
            // 
            // plantComboBox
            // 
            this.plantComboBox.FormattingEnabled = true;
            this.plantComboBox.Items.AddRange(new object[] {
            "K1",
            "K2",
            "R1"});
            this.plantComboBox.Location = new System.Drawing.Point(142, 110);
            this.plantComboBox.Name = "plantComboBox";
            this.plantComboBox.Size = new System.Drawing.Size(121, 21);
            this.plantComboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(95, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Plant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(343, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(580, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "HIRDARAMANI APPARELS BANGLADESH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(364, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(547, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "SAMPLE ROOM MONTHLY INCENTIVE SUMMERY";
            // 
            // IncentiveSummery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1223, 543);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plantComboBox);
            this.Controls.Add(this.Excelbutton);
            this.Controls.Add(this.incentiveDataGridView);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.toDateLabel);
            this.Controls.Add(this.FromDatelabel);
            this.Name = "IncentiveSummery";
            this.Text = "IncentiveSummery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.incentiveDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FromDatelabel;
        private System.Windows.Forms.Label toDateLabel;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataGridView incentiveDataGridView;
        private System.Windows.Forms.Button Excelbutton;
        private System.Windows.Forms.ComboBox plantComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}