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
            this.ComboBoxTables = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // ComboBoxTables
            // 
            this.ComboBoxTables.FormattingEnabled = true;
            this.ComboBoxTables.Location = new System.Drawing.Point(60, 196);
            this.ComboBoxTables.Name = "ComboBoxTables";
            this.ComboBoxTables.Size = new System.Drawing.Size(318, 23);
            this.ComboBoxTables.TabIndex = 10;
            this.ComboBoxTables.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTables_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(941, 324);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 665);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ComboBoxTables);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox ComboBoxTables;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}
