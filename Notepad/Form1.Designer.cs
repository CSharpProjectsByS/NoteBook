namespace Notepad
{
    partial class Form1
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
            this.optionGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveAsButton = new System.Windows.Forms.Button();
            this.ClearTextAreaButton = new System.Windows.Forms.Button();
            this.SOptionGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ZipCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ContentOfFileArea = new System.Windows.Forms.RichTextBox();
            this.optionGroupBox.SuspendLayout();
            this.SOptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionGroupBox
            // 
            this.optionGroupBox.Controls.Add(this.SaveAsButton);
            this.optionGroupBox.Controls.Add(this.ClearTextAreaButton);
            this.optionGroupBox.Controls.Add(this.SOptionGroupBox);
            this.optionGroupBox.Controls.Add(this.SaveButton);
            this.optionGroupBox.Controls.Add(this.OpenButton);
            this.optionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.optionGroupBox.Location = new System.Drawing.Point(26, 12);
            this.optionGroupBox.Name = "optionGroupBox";
            this.optionGroupBox.Size = new System.Drawing.Size(764, 87);
            this.optionGroupBox.TabIndex = 0;
            this.optionGroupBox.TabStop = false;
            this.optionGroupBox.Text = "Option";
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.Location = new System.Drawing.Point(216, 32);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(99, 34);
            this.SaveAsButton.TabIndex = 4;
            this.SaveAsButton.Text = "Save As";
            this.SaveAsButton.UseVisualStyleBackColor = true;
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // ClearTextAreaButton
            // 
            this.ClearTextAreaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ClearTextAreaButton.Location = new System.Drawing.Point(330, 32);
            this.ClearTextAreaButton.Name = "ClearTextAreaButton";
            this.ClearTextAreaButton.Size = new System.Drawing.Size(87, 34);
            this.ClearTextAreaButton.TabIndex = 3;
            this.ClearTextAreaButton.Text = "Clear Text";
            this.ClearTextAreaButton.UseVisualStyleBackColor = true;
            this.ClearTextAreaButton.Click += new System.EventHandler(this.ClearTextAreaButton_Click);
            // 
            // SOptionGroupBox
            // 
            this.SOptionGroupBox.Controls.Add(this.checkBox2);
            this.SOptionGroupBox.Controls.Add(this.ZipCheckBox);
            this.SOptionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SOptionGroupBox.Location = new System.Drawing.Point(433, 22);
            this.SOptionGroupBox.Name = "SOptionGroupBox";
            this.SOptionGroupBox.Size = new System.Drawing.Size(312, 59);
            this.SOptionGroupBox.TabIndex = 2;
            this.SOptionGroupBox.TabStop = false;
            this.SOptionGroupBox.Text = "Sophisticated Option";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox2.Location = new System.Drawing.Point(139, 25);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(152, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Encrypt/Decrypt";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ZipCheckBox
            // 
            this.ZipCheckBox.AutoSize = true;
            this.ZipCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ZipCheckBox.Location = new System.Drawing.Point(16, 24);
            this.ZipCheckBox.Name = "ZipCheckBox";
            this.ZipCheckBox.Size = new System.Drawing.Size(108, 24);
            this.ZipCheckBox.TabIndex = 0;
            this.ZipCheckBox.Text = "Compress";
            this.ZipCheckBox.UseVisualStyleBackColor = true;
            this.ZipCheckBox.CheckedChanged += new System.EventHandler(this.ZipCheckBox_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaveButton.Location = new System.Drawing.Point(109, 32);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(88, 34);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OpenButton.Location = new System.Drawing.Point(6, 32);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(86, 34);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ContentOfFileArea
            // 
            this.ContentOfFileArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ContentOfFileArea.Location = new System.Drawing.Point(26, 105);
            this.ContentOfFileArea.Name = "ContentOfFileArea";
            this.ContentOfFileArea.Size = new System.Drawing.Size(764, 393);
            this.ContentOfFileArea.TabIndex = 1;
            this.ContentOfFileArea.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 510);
            this.Controls.Add(this.ContentOfFileArea);
            this.Controls.Add(this.optionGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.optionGroupBox.ResumeLayout(false);
            this.SOptionGroupBox.ResumeLayout(false);
            this.SOptionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox optionGroupBox;
        private System.Windows.Forms.Button ClearTextAreaButton;
        private System.Windows.Forms.GroupBox SOptionGroupBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox ZipCheckBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.RichTextBox ContentOfFileArea;
        private System.Windows.Forms.Button SaveAsButton;
    }
}

