namespace Login
{
    partial class Departmentwise
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
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.showButton = new System.Windows.Forms.Button();
            this.DepartmentWisedataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Excelbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.plantComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentWisedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(134, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date From";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(218, 95);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(153, 20);
            this.fromDateTimePicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(388, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ToDate";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(454, 93);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(117, 20);
            this.toDateTimePicker.TabIndex = 3;
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.showButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showButton.Location = new System.Drawing.Point(496, 119);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 25);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // DepartmentWisedataGridView
            // 
            this.DepartmentWisedataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DepartmentWisedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentWisedataGridView.Location = new System.Drawing.Point(199, 160);
            this.DepartmentWisedataGridView.Name = "DepartmentWisedataGridView";
            this.DepartmentWisedataGridView.Size = new System.Drawing.Size(372, 292);
            this.DepartmentWisedataGridView.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(194, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Department wise sample summery";
            // 
            // Excelbutton
            // 
            this.Excelbutton.Location = new System.Drawing.Point(496, 458);
            this.Excelbutton.Name = "Excelbutton";
            this.Excelbutton.Size = new System.Drawing.Size(75, 23);
            this.Excelbutton.TabIndex = 7;
            this.Excelbutton.Text = "Excel";
            this.Excelbutton.UseVisualStyleBackColor = true;
            this.Excelbutton.Click += new System.EventHandler(this.Excelbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(134, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Plant";
            // 
            // plantComboBox
            // 
            this.plantComboBox.FormattingEnabled = true;
            this.plantComboBox.Items.AddRange(new object[] {
            "K1",
            "K2",
            "R1"});
            this.plantComboBox.Location = new System.Drawing.Point(183, 121);
            this.plantComboBox.Name = "plantComboBox";
            this.plantComboBox.Size = new System.Drawing.Size(121, 21);
            this.plantComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(95, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(580, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "HIRDARAMANI APPARELS BANGLADESH";
            // 
            // Departmentwise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.plantComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Excelbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DepartmentWisedataGridView);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.label1);
            this.Name = "Departmentwise";
            this.Text = "Departmentwise";
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentWisedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataGridView DepartmentWisedataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Excelbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox plantComboBox;
        private System.Windows.Forms.Label label5;
    }
}