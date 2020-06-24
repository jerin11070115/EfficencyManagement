namespace Login
{
    partial class Buyerwise
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
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buyerWisedataGridView = new System.Windows.Forms.DataGridView();
            this.excellButton = new System.Windows.Forms.Button();
            this.plantComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buyerWisedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(202, 148);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker.TabIndex = 0;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(420, 148);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.toDateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(199, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(417, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Date";
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.showButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showButton.Location = new System.Drawing.Point(506, 175);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(114, 32);
            this.showButton.TabIndex = 5;
            this.showButton.Text = "Show Report";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(233, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buyer Wise Sample Summery";
            // 
            // buyerWisedataGridView
            // 
            this.buyerWisedataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.buyerWisedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyerWisedataGridView.Location = new System.Drawing.Point(191, 213);
            this.buyerWisedataGridView.Name = "buyerWisedataGridView";
            this.buyerWisedataGridView.Size = new System.Drawing.Size(431, 325);
            this.buyerWisedataGridView.TabIndex = 7;
            // 
            // excellButton
            // 
            this.excellButton.Location = new System.Drawing.Point(544, 544);
            this.excellButton.Name = "excellButton";
            this.excellButton.Size = new System.Drawing.Size(78, 23);
            this.excellButton.TabIndex = 8;
            this.excellButton.Text = "Excel";
            this.excellButton.UseVisualStyleBackColor = true;
            this.excellButton.Click += new System.EventHandler(this.excellButton_Click);
            // 
            // plantComboBox
            // 
            this.plantComboBox.FormattingEnabled = true;
            this.plantComboBox.Items.AddRange(new object[] {
            "K1",
            "K2",
            "R1"});
            this.plantComboBox.Location = new System.Drawing.Point(248, 177);
            this.plantComboBox.Name = "plantComboBox";
            this.plantComboBox.Size = new System.Drawing.Size(154, 21);
            this.plantComboBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(199, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Plant";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(108, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(580, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "HIRDARAMANI APPARELS BANGLADESH";
            // 
            // Buyerwise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plantComboBox);
            this.Controls.Add(this.excellButton);
            this.Controls.Add(this.buyerWisedataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Name = "Buyerwise";
            this.Text = "Buyerwise";
            ((System.ComponentModel.ISupportInitialize)(this.buyerWisedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView buyerWisedataGridView;
        private System.Windows.Forms.Button excellButton;
        private System.Windows.Forms.ComboBox plantComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}