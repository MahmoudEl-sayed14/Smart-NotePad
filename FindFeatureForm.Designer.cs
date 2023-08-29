namespace Smart_Notepad
{
    partial class FindFeatureForm
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
            FindLabel = new Label();
            ReplaceLabel = new Label();
            FindTextBox = new TextBox();
            ReplaceTextBox = new TextBox();
            OkBtn = new Button();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // FindLabel
            // 
            FindLabel.AutoSize = true;
            FindLabel.Location = new Point(63, 51);
            FindLabel.Name = "FindLabel";
            FindLabel.Size = new Size(40, 20);
            FindLabel.TabIndex = 0;
            FindLabel.Text = "Find:";
            // 
            // ReplaceLabel
            // 
            ReplaceLabel.AutoSize = true;
            ReplaceLabel.Location = new Point(63, 98);
            ReplaceLabel.Name = "ReplaceLabel";
            ReplaceLabel.Size = new Size(65, 20);
            ReplaceLabel.TabIndex = 0;
            ReplaceLabel.Text = "Replace:";
            // 
            // FindTextBox
            // 
            FindTextBox.Location = new Point(160, 44);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(169, 27);
            FindTextBox.TabIndex = 1;
            // 
            // ReplaceTextBox
            // 
            ReplaceTextBox.Location = new Point(158, 91);
            ReplaceTextBox.Name = "ReplaceTextBox";
            ReplaceTextBox.Size = new Size(171, 27);
            ReplaceTextBox.TabIndex = 1;
            // 
            // OkBtn
            // 
            OkBtn.Location = new Point(180, 151);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(94, 29);
            OkBtn.TabIndex = 2;
            OkBtn.Text = "Ok";
            OkBtn.UseVisualStyleBackColor = true;
            OkBtn.Click += OkBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(289, 151);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(94, 29);
            CancelBtn.TabIndex = 2;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // FindFeatureForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 192);
            Controls.Add(CancelBtn);
            Controls.Add(OkBtn);
            Controls.Add(ReplaceTextBox);
            Controls.Add(FindTextBox);
            Controls.Add(ReplaceLabel);
            Controls.Add(FindLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FindFeatureForm";
            Text = "Find Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FindLabel;
        private Label ReplaceLabel;
        private TextBox FindTextBox;
        private TextBox ReplaceTextBox;
        private Button OkBtn;
        private Button CancelBtn;
    }
}