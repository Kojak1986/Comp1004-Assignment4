namespace Assignment4
{
    partial class SelectForm
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
            this.YourSelectionTextBox = new System.Windows.Forms.TextBox();
            this.YourSelectionLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ComputersDataGridView = new System.Windows.Forms.DataGridView();
            this.GridViewLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ComputersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // YourSelectionTextBox
            // 
            this.YourSelectionTextBox.Location = new System.Drawing.Point(121, 395);
            this.YourSelectionTextBox.Name = "YourSelectionTextBox";
            this.YourSelectionTextBox.Size = new System.Drawing.Size(399, 26);
            this.YourSelectionTextBox.TabIndex = 0;
            // 
            // YourSelectionLabel
            // 
            this.YourSelectionLabel.AutoSize = true;
            this.YourSelectionLabel.BackColor = System.Drawing.Color.Transparent;
            this.YourSelectionLabel.Location = new System.Drawing.Point(13, 398);
            this.YourSelectionLabel.Name = "YourSelectionLabel";
            this.YourSelectionLabel.Size = new System.Drawing.Size(100, 19);
            this.YourSelectionLabel.TabIndex = 1;
            this.YourSelectionLabel.Text = "Your Selection:";
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NextButton.Location = new System.Drawing.Point(640, 391);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 30);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton.Location = new System.Drawing.Point(542, 391);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 30);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // ComputersDataGridView
            // 
            this.ComputersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComputersDataGridView.Location = new System.Drawing.Point(12, 49);
            this.ComputersDataGridView.Name = "ComputersDataGridView";
            this.ComputersDataGridView.Size = new System.Drawing.Size(703, 329);
            this.ComputersDataGridView.TabIndex = 4;
            // 
            // GridViewLabel
            // 
            this.GridViewLabel.AutoSize = true;
            this.GridViewLabel.BackColor = System.Drawing.Color.Transparent;
            this.GridViewLabel.Location = new System.Drawing.Point(13, 13);
            this.GridViewLabel.Name = "GridViewLabel";
            this.GridViewLabel.Size = new System.Drawing.Size(215, 19);
            this.GridViewLabel.TabIndex = 5;
            this.GridViewLabel.Text = "Dollar Computers Hardware List :";
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment4.Properties.Resources.backGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 426);
            this.ControlBox = false;
            this.Controls.Add(this.GridViewLabel);
            this.Controls.Add(this.ComputersDataGridView);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.YourSelectionLabel);
            this.Controls.Add(this.YourSelectionTextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            ((System.ComponentModel.ISupportInitialize)(this.ComputersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox YourSelectionTextBox;
        private System.Windows.Forms.Label YourSelectionLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DataGridView ComputersDataGridView;
        private System.Windows.Forms.Label GridViewLabel;
    }
}