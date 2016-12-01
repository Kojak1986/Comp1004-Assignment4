namespace Assignment4
{
    partial class ProductInfoForm
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
            this.ProductInfoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.TechSpecGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductIdLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ProductIdTextBox = new System.Windows.Forms.TextBox();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.ManufaturerLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumberTextBox = new System.Windows.Forms.TextBox();
            this.LCDTextBox = new System.Windows.Forms.TextBox();
            this.WebCamTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.LCDLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.ClickNextlabel = new System.Windows.Forms.Label();
            this.SelectAnotherButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ProductInfoMenuStrip.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductInfoMenuStrip
            // 
            this.ProductInfoMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.ProductInfoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.ProductInfoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductInfoMenuStrip.Name = "ProductInfoMenuStrip";
            this.ProductInfoMenuStrip.Size = new System.Drawing.Size(727, 24);
            this.ProductInfoMenuStrip.TabIndex = 0;
            this.ProductInfoMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.selectAnotherProductToolStripMenuItem.Text = "Select Another Product";
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ProductInfoGroupBox.Controls.Add(this.ModelTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.OSTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufaturerLabel);
            this.ProductInfoGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductInfoGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(12, 64);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(703, 121);
            this.ProductInfoGroupBox.TabIndex = 1;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "ProductInfo";
            // 
            // TechSpecGroupBox
            // 
            this.TechSpecGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.TechSpecGroupBox.Controls.Add(this.WebCamLabel);
            this.TechSpecGroupBox.Controls.Add(this.GPUTypeLabel);
            this.TechSpecGroupBox.Controls.Add(this.HDDLabel);
            this.TechSpecGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.TechSpecGroupBox.Controls.Add(this.CPUNumberLabel);
            this.TechSpecGroupBox.Controls.Add(this.LCDLabel);
            this.TechSpecGroupBox.Controls.Add(this.CPUTypeLabel);
            this.TechSpecGroupBox.Controls.Add(this.CPUBrandLabel);
            this.TechSpecGroupBox.Controls.Add(this.MemoryLabel);
            this.TechSpecGroupBox.Controls.Add(this.WebCamTextBox);
            this.TechSpecGroupBox.Controls.Add(this.GPUTypeTextBox);
            this.TechSpecGroupBox.Controls.Add(this.HDDTextBox);
            this.TechSpecGroupBox.Controls.Add(this.CPUSpeedTextBox);
            this.TechSpecGroupBox.Controls.Add(this.CPUNumberTextBox);
            this.TechSpecGroupBox.Controls.Add(this.LCDTextBox);
            this.TechSpecGroupBox.Controls.Add(this.CPUTypeTextBox);
            this.TechSpecGroupBox.Controls.Add(this.CPUBrandTextBox);
            this.TechSpecGroupBox.Controls.Add(this.MemoryTextBox);
            this.TechSpecGroupBox.Location = new System.Drawing.Point(12, 191);
            this.TechSpecGroupBox.Name = "TechSpecGroupBox";
            this.TechSpecGroupBox.Size = new System.Drawing.Size(703, 175);
            this.TechSpecGroupBox.TabIndex = 2;
            this.TechSpecGroupBox.TabStop = false;
            this.TechSpecGroupBox.Text = "Tech Specs";
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.AutoSize = true;
            this.ProductIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProductIdLabel.Location = new System.Drawing.Point(46, 35);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(80, 19);
            this.ProductIdLabel.TabIndex = 3;
            this.ProductIdLabel.Text = "Product ID:";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConditionLabel.Location = new System.Drawing.Point(238, 35);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(71, 19);
            this.ConditionLabel.TabIndex = 4;
            this.ConditionLabel.Text = "Condition:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.BackColor = System.Drawing.Color.Transparent;
            this.CostLabel.Location = new System.Drawing.Point(430, 35);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(41, 19);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost:";
            // 
            // ProductIdTextBox
            // 
            this.ProductIdTextBox.Location = new System.Drawing.Point(132, 32);
            this.ProductIdTextBox.Name = "ProductIdTextBox";
            this.ProductIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.ProductIdTextBox.TabIndex = 6;
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Location = new System.Drawing.Point(315, 32);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(100, 26);
            this.ConditionTextBox.TabIndex = 7;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(477, 32);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 26);
            this.CostTextBox.TabIndex = 8;
            // 
            // ManufaturerLabel
            // 
            this.ManufaturerLabel.AutoSize = true;
            this.ManufaturerLabel.Location = new System.Drawing.Point(6, 81);
            this.ManufaturerLabel.Name = "ManufaturerLabel";
            this.ManufaturerLabel.Size = new System.Drawing.Size(93, 19);
            this.ManufaturerLabel.TabIndex = 0;
            this.ManufaturerLabel.Text = "Manufacturer:";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(34, 37);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(63, 19);
            this.PlatformLabel.TabIndex = 1;
            this.PlatformLabel.Text = "Platform:";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(273, 37);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(33, 19);
            this.OSLabel.TabIndex = 2;
            this.OSLabel.Text = "OS:";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(252, 81);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(52, 19);
            this.ModelLabel.TabIndex = 3;
            this.ModelLabel.Text = "Model:";
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Location = new System.Drawing.Point(103, 34);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.Size = new System.Drawing.Size(100, 26);
            this.PlatformTextBox.TabIndex = 4;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(103, 78);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(100, 26);
            this.ManufacturerTextBox.TabIndex = 5;
            // 
            // OSTextBox
            // 
            this.OSTextBox.Location = new System.Drawing.Point(312, 34);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.Size = new System.Drawing.Size(385, 26);
            this.OSTextBox.TabIndex = 6;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(312, 78);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(385, 26);
            this.ModelTextBox.TabIndex = 7;
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Location = new System.Drawing.Point(103, 34);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.Size = new System.Drawing.Size(100, 26);
            this.MemoryTextBox.TabIndex = 0;
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.Location = new System.Drawing.Point(103, 81);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.Size = new System.Drawing.Size(100, 26);
            this.CPUBrandTextBox.TabIndex = 1;
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.Location = new System.Drawing.Point(103, 128);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.Size = new System.Drawing.Size(100, 26);
            this.CPUTypeTextBox.TabIndex = 2;
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(312, 128);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(100, 26);
            this.CPUSpeedTextBox.TabIndex = 5;
            // 
            // CPUNumberTextBox
            // 
            this.CPUNumberTextBox.Location = new System.Drawing.Point(312, 81);
            this.CPUNumberTextBox.Name = "CPUNumberTextBox";
            this.CPUNumberTextBox.Size = new System.Drawing.Size(100, 26);
            this.CPUNumberTextBox.TabIndex = 4;
            // 
            // LCDTextBox
            // 
            this.LCDTextBox.Location = new System.Drawing.Point(312, 34);
            this.LCDTextBox.Name = "LCDTextBox";
            this.LCDTextBox.Size = new System.Drawing.Size(100, 26);
            this.LCDTextBox.TabIndex = 3;
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.Location = new System.Drawing.Point(512, 128);
            this.WebCamTextBox.Name = "WebCamTextBox";
            this.WebCamTextBox.Size = new System.Drawing.Size(185, 26);
            this.WebCamTextBox.TabIndex = 8;
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.Location = new System.Drawing.Point(512, 81);
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            this.GPUTypeTextBox.Size = new System.Drawing.Size(185, 26);
            this.GPUTypeTextBox.TabIndex = 7;
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.Location = new System.Drawing.Point(512, 34);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.Size = new System.Drawing.Size(185, 26);
            this.HDDTextBox.TabIndex = 6;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(33, 37);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(64, 19);
            this.MemoryLabel.TabIndex = 9;
            this.MemoryLabel.Text = "Memory:";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(13, 84);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(84, 19);
            this.CPUBrandLabel.TabIndex = 10;
            this.CPUBrandLabel.Text = "CPU Brand:";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(20, 131);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(77, 19);
            this.CPUTypeLabel.TabIndex = 11;
            this.CPUTypeLabel.Text = "CPU Type:";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(218, 131);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(86, 19);
            this.CPUSpeedLabel.TabIndex = 14;
            this.CPUSpeedLabel.Text = "CPU Speed:";
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Location = new System.Drawing.Point(207, 84);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(97, 19);
            this.CPUNumberLabel.TabIndex = 13;
            this.CPUNumberLabel.Text = "CPU Number:";
            // 
            // LCDLabel
            // 
            this.LCDLabel.AutoSize = true;
            this.LCDLabel.Location = new System.Drawing.Point(234, 37);
            this.LCDLabel.Name = "LCDLabel";
            this.LCDLabel.Size = new System.Drawing.Size(72, 19);
            this.LCDLabel.TabIndex = 12;
            this.LCDLabel.Text = "LCD Size:";
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(436, 131);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(70, 19);
            this.WebCamLabel.TabIndex = 17;
            this.WebCamLabel.Text = "WebCam:";
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(429, 84);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(77, 19);
            this.GPUTypeLabel.TabIndex = 16;
            this.GPUTypeLabel.Text = "GPU Type:";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(461, 37);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(45, 19);
            this.HDDLabel.TabIndex = 15;
            this.HDDLabel.Text = "HDD:";
            // 
            // ClickNextlabel
            // 
            this.ClickNextlabel.AutoSize = true;
            this.ClickNextlabel.BackColor = System.Drawing.Color.Transparent;
            this.ClickNextlabel.Location = new System.Drawing.Point(13, 386);
            this.ClickNextlabel.Name = "ClickNextlabel";
            this.ClickNextlabel.Size = new System.Drawing.Size(235, 19);
            this.ClickNextlabel.TabIndex = 9;
            this.ClickNextlabel.Text = "Click Next to Confirm Your Selection";
            // 
            // SelectAnotherButton
            // 
            this.SelectAnotherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SelectAnotherButton.Location = new System.Drawing.Point(372, 386);
            this.SelectAnotherButton.Name = "SelectAnotherButton";
            this.SelectAnotherButton.Size = new System.Drawing.Size(167, 28);
            this.SelectAnotherButton.TabIndex = 10;
            this.SelectAnotherButton.Text = "Select Another Product";
            this.SelectAnotherButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton.Location = new System.Drawing.Point(559, 386);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 28);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NextButton.Location = new System.Drawing.Point(640, 386);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 28);
            this.NextButton.TabIndex = 12;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment4.Properties.Resources.backGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 426);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectAnotherButton);
            this.Controls.Add(this.ClickNextlabel);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.ProductIdTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIdLabel);
            this.Controls.Add(this.TechSpecGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.ProductInfoMenuStrip);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ProductInfoMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Info";
            this.ProductInfoMenuStrip.ResumeLayout(false);
            this.ProductInfoMenuStrip.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechSpecGroupBox.ResumeLayout(false);
            this.TechSpecGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ProductInfoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.GroupBox TechSpecGroupBox;
        private System.Windows.Forms.Label ProductIdLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox ProductIdTextBox;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ManufaturerLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label LCDLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.TextBox WebCamTextBox;
        private System.Windows.Forms.TextBox GPUTypeTextBox;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.TextBox CPUSpeedTextBox;
        private System.Windows.Forms.TextBox CPUNumberTextBox;
        private System.Windows.Forms.TextBox LCDTextBox;
        private System.Windows.Forms.TextBox CPUTypeTextBox;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.Label ClickNextlabel;
        private System.Windows.Forms.Button SelectAnotherButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}