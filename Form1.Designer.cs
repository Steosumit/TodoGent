namespace TodoGent_UI_2
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

        private Button GetSubmitButton()
        {
            return SubmitButton;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Button submitButton)
        {
            richTextBox1 = new RichTextBox();
            DateLabel = new Label();
            NewButton = new Button();
            SubmitButton = new Button();
            QueryTextBox = new TextBox();
            progressBar1 = new ProgressBar();
            HeadLabel = new Label();
            OutputLabel = new Label();
            QueryButton = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1, 117);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(364, 388);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "Type entry with -";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateLabel.Location = new Point(1, 84);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(53, 25);
            DateLabel.TabIndex = 2;
            DateLabel.Text = "Date";
            DateLabel.Click += DateLabel_Click;
            // 
            // NewButton
            // 
            NewButton.Location = new Point(1, 15);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(75, 26);
            NewButton.TabIndex = 3;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(290, 84);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 26);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            submitButton.Click += SubmitButton_Click;
            // 
            // QueryTextBox
            // 
            QueryTextBox.Location = new Point(376, 117);
            QueryTextBox.Multiline = true;
            QueryTextBox.Name = "QueryTextBox";
            QueryTextBox.Size = new Size(407, 39);
            QueryTextBox.TabIndex = 6;
            QueryTextBox.Text = "Write to query...";
            QueryTextBox.TextChanged += QueryTextBox_TextChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1, 0);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(794, 11);
            progressBar1.TabIndex = 8;
            progressBar1.Visible = false;
            // 
            // HeadLabel
            // 
            HeadLabel.AutoSize = true;
            HeadLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeadLabel.Location = new Point(290, 15);
            HeadLabel.Name = "HeadLabel";
            HeadLabel.Size = new Size(209, 30);
            HeadLabel.TabIndex = 9;
            HeadLabel.Text = "TodoGent: PA for u!";
            // 
            // OutputLabel
            // 
            OutputLabel.BackColor = SystemColors.GradientInactiveCaption;
            OutputLabel.Location = new Point(376, 193);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(407, 312);
            OutputLabel.TabIndex = 10;
            OutputLabel.Text = "Respone...zzz";
            // 
            // QueryButton
            // 
            QueryButton.Location = new Point(708, 162);
            QueryButton.Name = "QueryButton";
            QueryButton.Size = new Size(75, 23);
            QueryButton.TabIndex = 11;
            QueryButton.Text = "Push";
            QueryButton.UseVisualStyleBackColor = true;
            QueryButton.Click += QueryButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 510);
            Controls.Add(QueryButton);
            Controls.Add(OutputLabel);
            Controls.Add(HeadLabel);
            Controls.Add(progressBar1);
            Controls.Add(QueryTextBox);
            Controls.Add(SubmitButton);
            Controls.Add(NewButton);
            Controls.Add(DateLabel);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private Label DateLabel;
        private Button NewButton;
        private Button SubmitButton;
        private TextBox QueryTextBox;
        private ProgressBar progressBar1;
        private Label HeadLabel;
        private Label OutputLabel;
        private Button QueryButton;
    }
}