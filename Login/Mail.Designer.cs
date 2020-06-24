namespace Login
{
    partial class Mail
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mailDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.sampleCostdataGridView = new System.Windows.Forms.DataGridView();
            this.SampleMailbutton = new System.Windows.Forms.Button();
            this.Costbrkbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleCostdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sample Room Efficiency";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(710, 28);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(124, 32);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "Show Report";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(171, 33);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker.TabIndex = 4;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(485, 33);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.toDateTimePicker.TabIndex = 5;
            // 
            // mailDataGridView
            // 
            this.mailDataGridView.AllowUserToAddRows = false;
            this.mailDataGridView.AllowUserToDeleteRows = false;
            this.mailDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.mailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mailDataGridView.Location = new System.Drawing.Point(121, 138);
            this.mailDataGridView.Name = "mailDataGridView";
            this.mailDataGridView.ReadOnly = true;
            this.mailDataGridView.Size = new System.Drawing.Size(579, 150);
            this.mailDataGridView.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sample Cost Break Down";
            // 
            // sampleCostdataGridView
            // 
            this.sampleCostdataGridView.AllowUserToAddRows = false;
            this.sampleCostdataGridView.AllowUserToDeleteRows = false;
            this.sampleCostdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.sampleCostdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sampleCostdataGridView.Location = new System.Drawing.Point(121, 343);
            this.sampleCostdataGridView.Name = "sampleCostdataGridView";
            this.sampleCostdataGridView.ReadOnly = true;
            this.sampleCostdataGridView.Size = new System.Drawing.Size(579, 150);
            this.sampleCostdataGridView.TabIndex = 8;
            // 
            // SampleMailbutton
            // 
            this.SampleMailbutton.Location = new System.Drawing.Point(734, 118);
            this.SampleMailbutton.Name = "SampleMailbutton";
            this.SampleMailbutton.Size = new System.Drawing.Size(75, 23);
            this.SampleMailbutton.TabIndex = 9;
            this.SampleMailbutton.Text = "Excel";
            this.SampleMailbutton.UseVisualStyleBackColor = true;
            this.SampleMailbutton.Click += new System.EventHandler(this.SampleMailbutton_Click);
            // 
            // Costbrkbutton
            // 
            this.Costbrkbutton.Location = new System.Drawing.Point(745, 343);
            this.Costbrkbutton.Name = "Costbrkbutton";
            this.Costbrkbutton.Size = new System.Drawing.Size(75, 23);
            this.Costbrkbutton.TabIndex = 10;
            this.Costbrkbutton.Text = "Excel";
            this.Costbrkbutton.UseVisualStyleBackColor = true;
            this.Costbrkbutton.Click += new System.EventHandler(this.Costbrkbutton_Click);
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 662);
            this.Controls.Add(this.Costbrkbutton);
            this.Controls.Add(this.SampleMailbutton);
            this.Controls.Add(this.sampleCostdataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mailDataGridView);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mail";
            this.Text = "Mail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.mailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleCostdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.DataGridView mailDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView sampleCostdataGridView;
        private System.Windows.Forms.Button SampleMailbutton;
        private System.Windows.Forms.Button Costbrkbutton;
    }
}