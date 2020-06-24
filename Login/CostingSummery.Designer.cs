namespace Login
{
    partial class CostingSummery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.showButton = new System.Windows.Forms.Button();
            this.efficencyReportDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productionDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.sampleCostDataGridView = new System.Windows.Forms.DataGridView();
            this.Excelbutton = new System.Windows.Forms.Button();
            this.Excelbutton1 = new System.Windows.Forms.Button();
            this.SampleCostExcelbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.efficencyReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleCostDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(345, 67);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(186, 20);
            this.fromDateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(277, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(615, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "To Date";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(677, 66);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(186, 20);
            this.toDateTimePicker.TabIndex = 3;
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.showButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showButton.Location = new System.Drawing.Point(897, 61);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(98, 35);
            this.showButton.TabIndex = 10;
            this.showButton.Text = "Show Reports";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // efficencyReportDataGridView
            // 
            this.efficencyReportDataGridView.AllowUserToAddRows = false;
            this.efficencyReportDataGridView.AllowUserToDeleteRows = false;
            this.efficencyReportDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.efficencyReportDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.efficencyReportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.efficencyReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.efficencyReportDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.efficencyReportDataGridView.Location = new System.Drawing.Point(246, 137);
            this.efficencyReportDataGridView.Name = "efficencyReportDataGridView";
            this.efficencyReportDataGridView.ReadOnly = true;
            this.efficencyReportDataGridView.Size = new System.Drawing.Size(749, 192);
            this.efficencyReportDataGridView.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(553, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Efficency Report";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(470, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Production And OT Summery Report";
            // 
            // productionDataGridView
            // 
            this.productionDataGridView.AllowUserToAddRows = false;
            this.productionDataGridView.AllowUserToDeleteRows = false;
            this.productionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productionDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productionDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.productionDataGridView.Location = new System.Drawing.Point(246, 360);
            this.productionDataGridView.Name = "productionDataGridView";
            this.productionDataGridView.ReadOnly = true;
            this.productionDataGridView.Size = new System.Drawing.Size(749, 161);
            this.productionDataGridView.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(444, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sample Cost Brake Down Summery Report";
            // 
            // sampleCostDataGridView
            // 
            this.sampleCostDataGridView.AllowUserToAddRows = false;
            this.sampleCostDataGridView.AllowUserToDeleteRows = false;
            this.sampleCostDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleCostDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sampleCostDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.sampleCostDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sampleCostDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.sampleCostDataGridView.Location = new System.Drawing.Point(246, 567);
            this.sampleCostDataGridView.Name = "sampleCostDataGridView";
            this.sampleCostDataGridView.ReadOnly = true;
            this.sampleCostDataGridView.Size = new System.Drawing.Size(749, 140);
            this.sampleCostDataGridView.TabIndex = 16;
            // 
            // Excelbutton
            // 
            this.Excelbutton.Location = new System.Drawing.Point(920, 332);
            this.Excelbutton.Name = "Excelbutton";
            this.Excelbutton.Size = new System.Drawing.Size(75, 23);
            this.Excelbutton.TabIndex = 17;
            this.Excelbutton.Text = "Excel";
            this.Excelbutton.UseVisualStyleBackColor = true;
            this.Excelbutton.Click += new System.EventHandler(this.Excelbutton_Click);
            // 
            // Excelbutton1
            // 
            this.Excelbutton1.Location = new System.Drawing.Point(920, 527);
            this.Excelbutton1.Name = "Excelbutton1";
            this.Excelbutton1.Size = new System.Drawing.Size(75, 23);
            this.Excelbutton1.TabIndex = 18;
            this.Excelbutton1.Text = "Excel\r\n";
            this.Excelbutton1.UseVisualStyleBackColor = true;
            this.Excelbutton1.Click += new System.EventHandler(this.Excelbutton1_Click);
            // 
            // SampleCostExcelbutton
            // 
            this.SampleCostExcelbutton.Location = new System.Drawing.Point(920, 713);
            this.SampleCostExcelbutton.Name = "SampleCostExcelbutton";
            this.SampleCostExcelbutton.Size = new System.Drawing.Size(75, 23);
            this.SampleCostExcelbutton.TabIndex = 19;
            this.SampleCostExcelbutton.Text = "Excel";
            this.SampleCostExcelbutton.UseVisualStyleBackColor = true;
            this.SampleCostExcelbutton.Click += new System.EventHandler(this.SampleCostExcelbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(309, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(607, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "SAMPLE ROOM PRODUCTION & EFFICIENCY SUMMERY";
            // 
            // CostingSummery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1239, 742);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SampleCostExcelbutton);
            this.Controls.Add(this.Excelbutton1);
            this.Controls.Add(this.Excelbutton);
            this.Controls.Add(this.sampleCostDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productionDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.efficencyReportDataGridView);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromDateTimePicker);
            this.Name = "CostingSummery";
            this.Text = "CostingSummery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.efficencyReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleCostDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataGridView efficencyReportDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView productionDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView sampleCostDataGridView;
        private System.Windows.Forms.Button Excelbutton;
        private System.Windows.Forms.Button Excelbutton1;
        private System.Windows.Forms.Button SampleCostExcelbutton;
        private System.Windows.Forms.Label label5;
    }
}