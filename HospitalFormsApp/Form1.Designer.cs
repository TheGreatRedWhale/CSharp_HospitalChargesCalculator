namespace HospitalFormsApp
{
    partial class hospForm
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
            this.daysBox = new System.Windows.Forms.MaskedTextBox();
            this.rxBox = new System.Windows.Forms.MaskedTextBox();
            this.surgBox = new System.Windows.Forms.MaskedTextBox();
            this.rehabBox = new System.Windows.Forms.MaskedTextBox();
            this.labBox = new System.Windows.Forms.MaskedTextBox();
            this.daysLabel = new System.Windows.Forms.Label();
            this.rxLabel = new System.Windows.Forms.Label();
            this.surgLabel = new System.Windows.Forms.Label();
            this.labLabel = new System.Windows.Forms.Label();
            this.rehabLabel = new System.Windows.Forms.Label();
            this.dividerLabel1 = new System.Windows.Forms.Label();
            this.stayChargeBox = new System.Windows.Forms.MaskedTextBox();
            this.stayChargeLabel = new System.Windows.Forms.Label();
            this.miscChargeBox = new System.Windows.Forms.MaskedTextBox();
            this.miscChargeLabel = new System.Windows.Forms.Label();
            this.dividerLabel2 = new System.Windows.Forms.Label();
            this.totalChargeBox = new System.Windows.Forms.MaskedTextBox();
            this.totalChargeLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daysBox
            // 
            this.daysBox.Location = new System.Drawing.Point(164, 19);
            this.daysBox.Mask = "0000000000";
            this.daysBox.Name = "daysBox";
            this.daysBox.Size = new System.Drawing.Size(100, 20);
            this.daysBox.TabIndex = 0;
            this.daysBox.Text = "0";
            this.daysBox.TextChanged += new System.EventHandler(this.resetTotals);
            // 
            // rxBox
            // 
            this.rxBox.Location = new System.Drawing.Point(164, 45);
            this.rxBox.Mask = "0000000000";
            this.rxBox.Name = "rxBox";
            this.rxBox.Size = new System.Drawing.Size(100, 20);
            this.rxBox.TabIndex = 1;
            this.rxBox.Text = "0";
            this.rxBox.TextChanged += new System.EventHandler(this.resetTotals);
            // 
            // surgBox
            // 
            this.surgBox.Location = new System.Drawing.Point(164, 71);
            this.surgBox.Mask = "0000000000";
            this.surgBox.Name = "surgBox";
            this.surgBox.Size = new System.Drawing.Size(100, 20);
            this.surgBox.TabIndex = 2;
            this.surgBox.Text = "0";
            this.surgBox.TextChanged += new System.EventHandler(this.resetTotals);
            // 
            // rehabBox
            // 
            this.rehabBox.Location = new System.Drawing.Point(164, 123);
            this.rehabBox.Mask = "0000000000";
            this.rehabBox.Name = "rehabBox";
            this.rehabBox.Size = new System.Drawing.Size(100, 20);
            this.rehabBox.TabIndex = 3;
            this.rehabBox.Text = "0";
            this.rehabBox.TextChanged += new System.EventHandler(this.resetTotals);
            // 
            // labBox
            // 
            this.labBox.Location = new System.Drawing.Point(164, 97);
            this.labBox.Mask = "0000000000";
            this.labBox.Name = "labBox";
            this.labBox.Size = new System.Drawing.Size(100, 20);
            this.labBox.TabIndex = 4;
            this.labBox.Text = "0";
            this.labBox.TextChanged += new System.EventHandler(this.resetTotals);
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(27, 22);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(131, 13);
            this.daysLabel.TabIndex = 5;
            this.daysLabel.Text = "Days spent in the hospital:";
            // 
            // rxLabel
            // 
            this.rxLabel.AutoSize = true;
            this.rxLabel.Location = new System.Drawing.Point(55, 48);
            this.rxLabel.Name = "rxLabel";
            this.rxLabel.Size = new System.Drawing.Size(103, 13);
            this.rxLabel.TabIndex = 6;
            this.rxLabel.Text = "Medication charges:";
            // 
            // surgLabel
            // 
            this.surgLabel.AutoSize = true;
            this.surgLabel.Location = new System.Drawing.Point(87, 74);
            this.surgLabel.Name = "surgLabel";
            this.surgLabel.Size = new System.Drawing.Size(71, 13);
            this.surgLabel.TabIndex = 7;
            this.surgLabel.Text = "Surgical fees:";
            // 
            // labLabel
            // 
            this.labLabel.AutoSize = true;
            this.labLabel.Location = new System.Drawing.Point(107, 100);
            this.labLabel.Name = "labLabel";
            this.labLabel.Size = new System.Drawing.Size(51, 13);
            this.labLabel.TabIndex = 8;
            this.labLabel.Text = "Lab fees:";
            // 
            // rehabLabel
            // 
            this.rehabLabel.AutoSize = true;
            this.rehabLabel.Location = new System.Drawing.Point(43, 126);
            this.rehabLabel.Name = "rehabLabel";
            this.rehabLabel.Size = new System.Drawing.Size(115, 13);
            this.rehabLabel.TabIndex = 9;
            this.rehabLabel.Text = "Rehabilitation charges:";
            // 
            // dividerLabel1
            // 
            this.dividerLabel1.AutoSize = true;
            this.dividerLabel1.Location = new System.Drawing.Point(27, 146);
            this.dividerLabel1.Name = "dividerLabel1";
            this.dividerLabel1.Size = new System.Drawing.Size(241, 13);
            this.dividerLabel1.TabIndex = 10;
            this.dividerLabel1.Text = "------------------------------------------------------------------------------";
            this.dividerLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // stayChargeBox
            // 
            this.stayChargeBox.Location = new System.Drawing.Point(164, 162);
            this.stayChargeBox.Mask = "0000000000";
            this.stayChargeBox.Name = "stayChargeBox";
            this.stayChargeBox.ReadOnly = true;
            this.stayChargeBox.Size = new System.Drawing.Size(100, 20);
            this.stayChargeBox.TabIndex = 11;
            // 
            // stayChargeLabel
            // 
            this.stayChargeLabel.AutoSize = true;
            this.stayChargeLabel.Location = new System.Drawing.Point(65, 165);
            this.stayChargeLabel.Name = "stayChargeLabel";
            this.stayChargeLabel.Size = new System.Drawing.Size(93, 13);
            this.stayChargeLabel.TabIndex = 12;
            this.stayChargeLabel.Text = "Hospital stay cost:";
            // 
            // miscChargeBox
            // 
            this.miscChargeBox.Location = new System.Drawing.Point(164, 188);
            this.miscChargeBox.Mask = "0000000000";
            this.miscChargeBox.Name = "miscChargeBox";
            this.miscChargeBox.ReadOnly = true;
            this.miscChargeBox.Size = new System.Drawing.Size(100, 20);
            this.miscChargeBox.TabIndex = 13;
            // 
            // miscChargeLabel
            // 
            this.miscChargeLabel.AutoSize = true;
            this.miscChargeLabel.Location = new System.Drawing.Point(40, 191);
            this.miscChargeLabel.Name = "miscChargeLabel";
            this.miscChargeLabel.Size = new System.Drawing.Size(118, 13);
            this.miscChargeLabel.TabIndex = 14;
            this.miscChargeLabel.Text = "Miscellaneous charges:";
            // 
            // dividerLabel2
            // 
            this.dividerLabel2.AutoSize = true;
            this.dividerLabel2.Location = new System.Drawing.Point(27, 211);
            this.dividerLabel2.Name = "dividerLabel2";
            this.dividerLabel2.Size = new System.Drawing.Size(241, 13);
            this.dividerLabel2.TabIndex = 15;
            this.dividerLabel2.Text = "------------------------------------------------------------------------------";
            this.dividerLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalChargeBox
            // 
            this.totalChargeBox.Location = new System.Drawing.Point(164, 227);
            this.totalChargeBox.Mask = "0000000000";
            this.totalChargeBox.Name = "totalChargeBox";
            this.totalChargeBox.ReadOnly = true;
            this.totalChargeBox.Size = new System.Drawing.Size(100, 20);
            this.totalChargeBox.TabIndex = 16;
            // 
            // totalChargeLabel
            // 
            this.totalChargeLabel.AutoSize = true;
            this.totalChargeLabel.Location = new System.Drawing.Point(43, 230);
            this.totalChargeLabel.Name = "totalChargeLabel";
            this.totalChargeLabel.Size = new System.Drawing.Size(118, 13);
            this.totalChargeLabel.TabIndex = 17;
            this.totalChargeLabel.Text = "Miscellaneous charges:";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(30, 267);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(234, 23);
            this.calcButton.TabIndex = 18;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calculateTotals);
            // 
            // hospForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 310);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.totalChargeLabel);
            this.Controls.Add(this.totalChargeBox);
            this.Controls.Add(this.dividerLabel2);
            this.Controls.Add(this.miscChargeLabel);
            this.Controls.Add(this.miscChargeBox);
            this.Controls.Add(this.stayChargeLabel);
            this.Controls.Add(this.stayChargeBox);
            this.Controls.Add(this.dividerLabel1);
            this.Controls.Add(this.rehabLabel);
            this.Controls.Add(this.labLabel);
            this.Controls.Add(this.surgLabel);
            this.Controls.Add(this.rxLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.labBox);
            this.Controls.Add(this.rehabBox);
            this.Controls.Add(this.surgBox);
            this.Controls.Add(this.rxBox);
            this.Controls.Add(this.daysBox);
            this.Name = "hospForm";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox daysBox;
        private System.Windows.Forms.MaskedTextBox rxBox;
        private System.Windows.Forms.MaskedTextBox surgBox;
        private System.Windows.Forms.MaskedTextBox rehabBox;
        private System.Windows.Forms.MaskedTextBox labBox;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label rxLabel;
        private System.Windows.Forms.Label surgLabel;
        private System.Windows.Forms.Label labLabel;
        private System.Windows.Forms.Label rehabLabel;
        private System.Windows.Forms.Label dividerLabel1;
        private System.Windows.Forms.MaskedTextBox stayChargeBox;
        private System.Windows.Forms.Label stayChargeLabel;
        private System.Windows.Forms.MaskedTextBox miscChargeBox;
        private System.Windows.Forms.Label miscChargeLabel;
        private System.Windows.Forms.Label dividerLabel2;
        private System.Windows.Forms.MaskedTextBox totalChargeBox;
        private System.Windows.Forms.Label totalChargeLabel;
        private System.Windows.Forms.Button calcButton;
    }
}

