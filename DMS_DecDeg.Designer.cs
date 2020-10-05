namespace SimpleCoordTranslator
{
    partial class DMS_DecDeg
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LonDecTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LatDecTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DMSTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DECTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SCTTextBox = new System.Windows.Forms.TextBox();
            this.LonSCTTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LatSCTTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PasteButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ResetButton = new System.Windows.Forms.Button();
            this.DMSHelpButton = new System.Windows.Forms.Button();
            this.LatDMSTextBox = new System.Windows.Forms.TextBox();
            this.LonDMSTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DMS Latitude ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Longitude DMS";
            // 
            // LonDecTextBox
            // 
            this.LonDecTextBox.Location = new System.Drawing.Point(207, 97);
            this.LonDecTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LonDecTextBox.Name = "LonDecTextBox";
            this.LonDecTextBox.Size = new System.Drawing.Size(119, 20);
            this.LonDecTextBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.LonDecTextBox, "(+/-)DDD.dddd");
            this.LonDecTextBox.DoubleClick += new System.EventHandler(this.LonDecTextBox_DoubleClick);
            this.LonDecTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LonDecTextBox_KeyPress);
            this.LonDecTextBox.Validated += new System.EventHandler(this.LonDecTextBox_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Longitude Decimal";
            // 
            // LatDecTextBox
            // 
            this.LatDecTextBox.Location = new System.Drawing.Point(208, 57);
            this.LatDecTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LatDecTextBox.Name = "LatDecTextBox";
            this.LatDecTextBox.Size = new System.Drawing.Size(119, 20);
            this.LatDecTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.LatDecTextBox, " (+/-)DD.dddd");
            this.LatDecTextBox.DoubleClick += new System.EventHandler(this.LatDecTextBox_DoubleClick);
            this.LatDecTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LatDecTextBox_KeyPress);
            this.LatDecTextBox.Validated += new System.EventHandler(this.LatDecTextBox_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Latitude Decimal";
            // 
            // DMSTextBox
            // 
            this.DMSTextBox.Location = new System.Drawing.Point(29, 172);
            this.DMSTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DMSTextBox.Name = "DMSTextBox";
            this.DMSTextBox.Size = new System.Drawing.Size(222, 20);
            this.DMSTextBox.TabIndex = 7;
            this.DMSTextBox.DoubleClick += new System.EventHandler(this.DMSTextBox_DoubleClick);
            this.DMSTextBox.Validated += new System.EventHandler(this.DMSTextBox_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "DMS Coordinates (Lat, Lon)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Decimal Coordinates (Lat, Lon)";
            // 
            // DECTextBox
            // 
            this.DECTextBox.Location = new System.Drawing.Point(262, 172);
            this.DECTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DECTextBox.Name = "DECTextBox";
            this.DECTextBox.Size = new System.Drawing.Size(222, 20);
            this.DECTextBox.TabIndex = 8;
            this.DECTextBox.DoubleClick += new System.EventHandler(this.DECTextBox_DoubleClick);
            this.DECTextBox.Validated += new System.EventHandler(this.DECTextBox_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "SCT Coordinates";
            // 
            // SCTTextBox
            // 
            this.SCTTextBox.Location = new System.Drawing.Point(487, 172);
            this.SCTTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SCTTextBox.Name = "SCTTextBox";
            this.SCTTextBox.Size = new System.Drawing.Size(222, 20);
            this.SCTTextBox.TabIndex = 9;
            this.SCTTextBox.DoubleClick += new System.EventHandler(this.SCTTextBox_DoubleClick);
            this.SCTTextBox.Validated += new System.EventHandler(this.SCTTextBox_Validated);
            // 
            // LonSCTTextBox
            // 
            this.LonSCTTextBox.Location = new System.Drawing.Point(360, 97);
            this.LonSCTTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LonSCTTextBox.Name = "LonSCTTextBox";
            this.LonSCTTextBox.Size = new System.Drawing.Size(119, 20);
            this.LonSCTTextBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.LonSCTTextBox, "(W/E)DDD.MM.DD.ddd");
            this.LonSCTTextBox.DoubleClick += new System.EventHandler(this.LonSCTTextBox_DoubleClick);
            this.LonSCTTextBox.Validated += new System.EventHandler(this.LonSCTTextBox_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Longitude SCT";
            // 
            // LatSCTTextBox
            // 
            this.LatSCTTextBox.Location = new System.Drawing.Point(361, 57);
            this.LatSCTTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LatSCTTextBox.Name = "LatSCTTextBox";
            this.LatSCTTextBox.Size = new System.Drawing.Size(119, 20);
            this.LatSCTTextBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.LatSCTTextBox, "(N/S)DDD.MM.DD.ddd");
            this.LatSCTTextBox.DoubleClick += new System.EventHandler(this.LatSCTTextBox_DoubleClick);
            this.LatSCTTextBox.Validated += new System.EventHandler(this.LatSCTTextBox_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Latitude SCT";
            // 
            // PasteButton
            // 
            this.PasteButton.Location = new System.Drawing.Point(610, 129);
            this.PasteButton.Margin = new System.Windows.Forms.Padding(2);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(99, 37);
            this.PasteButton.TabIndex = 0;
            this.PasteButton.Text = "  Paste to\r\nSCT Textbox";
            this.toolTip1.SetToolTip(this.PasteButton, "Pastes clipboard to line below");
            this.PasteButton.UseVisualStyleBackColor = true;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.PowderBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(367, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Double click any textbox to copy that textbox to clipboard.";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(497, 57);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(77, 45);
            this.ResetButton.TabIndex = 29;
            this.ResetButton.Text = "Reset all text boxes";
            this.toolTip1.SetToolTip(this.ResetButton, "Pastes clipboard to line below");
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DMSHelpButton
            // 
            this.DMSHelpButton.BackColor = System.Drawing.Color.Violet;
            this.DMSHelpButton.Location = new System.Drawing.Point(162, 142);
            this.DMSHelpButton.Name = "DMSHelpButton";
            this.DMSHelpButton.Size = new System.Drawing.Size(20, 24);
            this.DMSHelpButton.TabIndex = 20;
            this.DMSHelpButton.Text = "?";
            this.DMSHelpButton.UseVisualStyleBackColor = false;
            this.DMSHelpButton.Click += new System.EventHandler(this.DMSHelpButton_Click);
            // 
            // LatDMSTextBox
            // 
            this.LatDMSTextBox.Location = new System.Drawing.Point(29, 56);
            this.LatDMSTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LatDMSTextBox.Name = "LatDMSTextBox";
            this.LatDMSTextBox.Size = new System.Drawing.Size(153, 20);
            this.LatDMSTextBox.TabIndex = 1;
            this.LatDMSTextBox.Validated += new System.EventHandler(this.LatDMSTextBox_Validated);
            // 
            // LonDMSTextBox
            // 
            this.LonDMSTextBox.Location = new System.Drawing.Point(29, 97);
            this.LonDMSTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LonDMSTextBox.Name = "LonDMSTextBox";
            this.LonDMSTextBox.Size = new System.Drawing.Size(153, 20);
            this.LonDMSTextBox.TabIndex = 2;
            this.LonDMSTextBox.Validated += new System.EventHandler(this.LonDMSTextBox_Validated);
            // 
            // DMS_DecDeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(731, 203);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.LonDMSTextBox);
            this.Controls.Add(this.LatDMSTextBox);
            this.Controls.Add(this.DMSHelpButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SCTTextBox);
            this.Controls.Add(this.LonSCTTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LatSCTTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DECTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DMSTextBox);
            this.Controls.Add(this.LonDecTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LatDecTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "DMS_DecDeg";
            this.Text = "Coordinate Converter v2.0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LonDecTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LatDecTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DMSTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DECTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SCTTextBox;
        private System.Windows.Forms.TextBox LonSCTTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LatSCTTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button DMSHelpButton;
        private System.Windows.Forms.TextBox LatDMSTextBox;
        private System.Windows.Forms.TextBox LonDMSTextBox;
        private System.Windows.Forms.Button ResetButton;
    }
}