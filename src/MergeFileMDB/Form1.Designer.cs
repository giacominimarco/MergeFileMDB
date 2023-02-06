namespace MergeFileMDB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelPathFileFirst = new System.Windows.Forms.Label();
            this.LabelPathFileSecond = new System.Windows.Forms.Label();
            this.TextBoxPathFirstFile = new System.Windows.Forms.TextBox();
            this.TextBoxPathSecondFile = new System.Windows.Forms.TextBox();
            this.ButtonSearchPathFileFirst = new System.Windows.Forms.Button();
            this.ButtonSearchPathFileSecond = new System.Windows.Forms.Button();
            this.ButtonSavePathMergeFile = new System.Windows.Forms.Button();
            this.TextBoxSavePathMergeFile = new System.Windows.Forms.TextBox();
            this.LabelPathSavePathMergeFile = new System.Windows.Forms.Label();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.ComboBoxTables = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelPathFileFirst
            // 
            this.LabelPathFileFirst.AutoSize = true;
            this.LabelPathFileFirst.Location = new System.Drawing.Point(12, 22);
            this.LabelPathFileFirst.Name = "LabelPathFileFirst";
            this.LabelPathFileFirst.Size = new System.Drawing.Size(99, 15);
            this.LabelPathFileFirst.TabIndex = 0;
            this.LabelPathFileFirst.Text = "LabelPathFileFirst";
            // 
            // LabelPathFileSecond
            // 
            this.LabelPathFileSecond.AutoSize = true;
            this.LabelPathFileSecond.Location = new System.Drawing.Point(12, 78);
            this.LabelPathFileSecond.Name = "LabelPathFileSecond";
            this.LabelPathFileSecond.Size = new System.Drawing.Size(116, 15);
            this.LabelPathFileSecond.TabIndex = 1;
            this.LabelPathFileSecond.Text = "LabelPathFileSecond";
            // 
            // TextBoxPathFirstFile
            // 
            this.TextBoxPathFirstFile.Location = new System.Drawing.Point(12, 40);
            this.TextBoxPathFirstFile.Name = "TextBoxPathFirstFile";
            this.TextBoxPathFirstFile.Size = new System.Drawing.Size(318, 23);
            this.TextBoxPathFirstFile.TabIndex = 2;
            // 
            // TextBoxPathSecondFile
            // 
            this.TextBoxPathSecondFile.Location = new System.Drawing.Point(12, 96);
            this.TextBoxPathSecondFile.Name = "TextBoxPathSecondFile";
            this.TextBoxPathSecondFile.Size = new System.Drawing.Size(318, 23);
            this.TextBoxPathSecondFile.TabIndex = 3;
            // 
            // ButtonSearchPathFileFirst
            // 
            this.ButtonSearchPathFileFirst.Location = new System.Drawing.Point(336, 39);
            this.ButtonSearchPathFileFirst.Name = "ButtonSearchPathFileFirst";
            this.ButtonSearchPathFileFirst.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearchPathFileFirst.TabIndex = 4;
            this.ButtonSearchPathFileFirst.Text = "Search";
            this.ButtonSearchPathFileFirst.UseVisualStyleBackColor = true;
            this.ButtonSearchPathFileFirst.Click += new System.EventHandler(this.ButtonSearchPathFileFirst_Click);
            // 
            // ButtonSearchPathFileSecond
            // 
            this.ButtonSearchPathFileSecond.Location = new System.Drawing.Point(336, 95);
            this.ButtonSearchPathFileSecond.Name = "ButtonSearchPathFileSecond";
            this.ButtonSearchPathFileSecond.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearchPathFileSecond.TabIndex = 5;
            this.ButtonSearchPathFileSecond.Text = "Search";
            this.ButtonSearchPathFileSecond.UseVisualStyleBackColor = true;
            this.ButtonSearchPathFileSecond.Click += new System.EventHandler(this.ButtonSearchPathFileSecond_Click);
            // 
            // ButtonSavePathMergeFile
            // 
            this.ButtonSavePathMergeFile.Location = new System.Drawing.Point(336, 152);
            this.ButtonSavePathMergeFile.Name = "ButtonSavePathMergeFile";
            this.ButtonSavePathMergeFile.Size = new System.Drawing.Size(75, 23);
            this.ButtonSavePathMergeFile.TabIndex = 8;
            this.ButtonSavePathMergeFile.Text = "Search";
            this.ButtonSavePathMergeFile.UseVisualStyleBackColor = true;
            this.ButtonSavePathMergeFile.Click += new System.EventHandler(this.ButtonSavePathMergeFile_Click);
            // 
            // TextBoxSavePathMergeFile
            // 
            this.TextBoxSavePathMergeFile.Location = new System.Drawing.Point(12, 153);
            this.TextBoxSavePathMergeFile.Name = "TextBoxSavePathMergeFile";
            this.TextBoxSavePathMergeFile.Size = new System.Drawing.Size(318, 23);
            this.TextBoxSavePathMergeFile.TabIndex = 7;
            // 
            // LabelPathSavePathMergeFile
            // 
            this.LabelPathSavePathMergeFile.AutoSize = true;
            this.LabelPathSavePathMergeFile.Location = new System.Drawing.Point(12, 135);
            this.LabelPathSavePathMergeFile.Name = "LabelPathSavePathMergeFile";
            this.LabelPathSavePathMergeFile.Size = new System.Drawing.Size(135, 15);
            this.LabelPathSavePathMergeFile.TabIndex = 6;
            this.LabelPathSavePathMergeFile.Text = "LabelPathSaveMergeFile";
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Location = new System.Drawing.Point(12, 234);
            this.TextBoxMessage.Multiline = true;
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.ReadOnly = true;
            this.TextBoxMessage.Size = new System.Drawing.Size(399, 31);
            this.TextBoxMessage.TabIndex = 9;
            this.TextBoxMessage.TextChanged += new System.EventHandler(this.TextBoxMessage_TextChanged);
            // 
            // ComboBoxTables
            // 
            this.ComboBoxTables.FormattingEnabled = true;
            this.ComboBoxTables.Location = new System.Drawing.Point(12, 195);
            this.ComboBoxTables.Name = "ComboBoxTables";
            this.ComboBoxTables.Size = new System.Drawing.Size(318, 23);
            this.ComboBoxTables.TabIndex = 10;
            this.ComboBoxTables.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTables_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 280);
            this.Controls.Add(this.ComboBoxTables);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.ButtonSavePathMergeFile);
            this.Controls.Add(this.TextBoxSavePathMergeFile);
            this.Controls.Add(this.LabelPathSavePathMergeFile);
            this.Controls.Add(this.ButtonSearchPathFileSecond);
            this.Controls.Add(this.ButtonSearchPathFileFirst);
            this.Controls.Add(this.TextBoxPathSecondFile);
            this.Controls.Add(this.TextBoxPathFirstFile);
            this.Controls.Add(this.LabelPathFileSecond);
            this.Controls.Add(this.LabelPathFileFirst);
            this.Name = "Form1";
            this.Text = "FormMergeFileMDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPathFileFirst;
        private System.Windows.Forms.Label LabelPathFileSecond;
        private System.Windows.Forms.TextBox TextBoxPathFirstFile;
        private System.Windows.Forms.TextBox TextBoxPathSecondFile;
        private System.Windows.Forms.Button ButtonSearchPathFileFirst;
        private System.Windows.Forms.Button ButtonSearchPathFileSecond;
        private System.Windows.Forms.Button ButtonSavePathMergeFile;
        private System.Windows.Forms.TextBox TextBoxSavePathMergeFile;
        private System.Windows.Forms.Label LabelPathSavePathMergeFile;
        private System.Windows.Forms.TextBox TextBoxMessage;
        private System.Windows.Forms.ComboBox ComboBoxTables;
    }
}
