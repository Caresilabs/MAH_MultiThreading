namespace Assignment4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SouceTab = new System.Windows.Forms.TabPage();
            this.SourceTextBox = new System.Windows.Forms.RichTextBox();
            this.DestinationTab = new System.Windows.Forms.TabPage();
            this.DestinationTextBox = new System.Windows.Forms.RichTextBox();
            this.CopyToDestButton = new System.Windows.Forms.Button();
            this.ClearDestinationButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NotifyCheckBox = new System.Windows.Forms.CheckBox();
            this.NumOfReplacements = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReplaceTextBox = new System.Windows.Forms.TextBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.ReplaceLabel = new System.Windows.Forms.Label();
            this.FindLabel = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.SouceTab.SuspendLayout();
            this.DestinationTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.SouceTab);
            this.tabControl1.Controls.Add(this.DestinationTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 269);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1270, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // SouceTab
            // 
            this.SouceTab.Controls.Add(this.SourceTextBox);
            this.SouceTab.Location = new System.Drawing.Point(8, 39);
            this.SouceTab.Name = "SouceTab";
            this.SouceTab.Padding = new System.Windows.Forms.Padding(3);
            this.SouceTab.Size = new System.Drawing.Size(1254, 533);
            this.SouceTab.TabIndex = 0;
            this.SouceTab.Text = "Source";
            this.SouceTab.UseVisualStyleBackColor = true;
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceTextBox.Location = new System.Drawing.Point(3, 3);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(1248, 527);
            this.SourceTextBox.TabIndex = 0;
            this.SourceTextBox.Text = "";
            this.SourceTextBox.WordWrap = false;
            this.SourceTextBox.TextChanged += new System.EventHandler(this.SourceTextBox_TextChanged);
            // 
            // DestinationTab
            // 
            this.DestinationTab.Controls.Add(this.DestinationTextBox);
            this.DestinationTab.Location = new System.Drawing.Point(8, 39);
            this.DestinationTab.Name = "DestinationTab";
            this.DestinationTab.Padding = new System.Windows.Forms.Padding(3);
            this.DestinationTab.Size = new System.Drawing.Size(1254, 533);
            this.DestinationTab.TabIndex = 1;
            this.DestinationTab.Text = "Destination";
            this.DestinationTab.UseVisualStyleBackColor = true;
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DestinationTextBox.Location = new System.Drawing.Point(3, 3);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(1248, 527);
            this.DestinationTextBox.TabIndex = 0;
            this.DestinationTextBox.Text = "";
            // 
            // CopyToDestButton
            // 
            this.CopyToDestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyToDestButton.Location = new System.Drawing.Point(908, 85);
            this.CopyToDestButton.Name = "CopyToDestButton";
            this.CopyToDestButton.Size = new System.Drawing.Size(335, 64);
            this.CopyToDestButton.TabIndex = 11;
            this.CopyToDestButton.Text = "Copy to Destination";
            this.CopyToDestButton.UseVisualStyleBackColor = true;
            this.CopyToDestButton.Click += new System.EventHandler(this.CopyToDestButton_Click);
            // 
            // ClearDestinationButton
            // 
            this.ClearDestinationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearDestinationButton.Location = new System.Drawing.Point(908, 168);
            this.ClearDestinationButton.Name = "ClearDestinationButton";
            this.ClearDestinationButton.Size = new System.Drawing.Size(335, 64);
            this.ClearDestinationButton.TabIndex = 12;
            this.ClearDestinationButton.Text = "Clear Dest. and remove marks";
            this.ClearDestinationButton.UseVisualStyleBackColor = true;
            this.ClearDestinationButton.Click += new System.EventHandler(this.ClearDestinationButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.NotifyCheckBox);
            this.groupBox1.Controls.Add(this.NumOfReplacements);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ReplaceTextBox);
            this.groupBox1.Controls.Add(this.FindTextBox);
            this.groupBox1.Controls.Add(this.ReplaceLabel);
            this.groupBox1.Controls.Add(this.FindLabel);
            this.groupBox1.Location = new System.Drawing.Point(23, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find and Replace";
            // 
            // NotifyCheckBox
            // 
            this.NotifyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NotifyCheckBox.AutoSize = true;
            this.NotifyCheckBox.Location = new System.Drawing.Point(574, 148);
            this.NotifyCheckBox.Name = "NotifyCheckBox";
            this.NotifyCheckBox.Size = new System.Drawing.Size(252, 29);
            this.NotifyCheckBox.TabIndex = 3;
            this.NotifyCheckBox.Text = "Notify on every match";
            this.NotifyCheckBox.UseVisualStyleBackColor = true;
            // 
            // NumOfReplacements
            // 
            this.NumOfReplacements.AutoSize = true;
            this.NumOfReplacements.Location = new System.Drawing.Point(222, 152);
            this.NumOfReplacements.Name = "NumOfReplacements";
            this.NumOfReplacements.Size = new System.Drawing.Size(24, 25);
            this.NumOfReplacements.TabIndex = 5;
            this.NumOfReplacements.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "No Replacements:";
            // 
            // ReplaceTextBox
            // 
            this.ReplaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplaceTextBox.Location = new System.Drawing.Point(184, 85);
            this.ReplaceTextBox.Name = "ReplaceTextBox";
            this.ReplaceTextBox.Size = new System.Drawing.Size(632, 31);
            this.ReplaceTextBox.TabIndex = 2;
            // 
            // FindTextBox
            // 
            this.FindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindTextBox.Location = new System.Drawing.Point(184, 44);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(632, 31);
            this.FindTextBox.TabIndex = 1;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // ReplaceLabel
            // 
            this.ReplaceLabel.AutoSize = true;
            this.ReplaceLabel.Location = new System.Drawing.Point(27, 91);
            this.ReplaceLabel.Name = "ReplaceLabel";
            this.ReplaceLabel.Size = new System.Drawing.Size(146, 25);
            this.ReplaceLabel.TabIndex = 0;
            this.ReplaceLabel.Text = "Replace With:";
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(27, 50);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(60, 25);
            this.FindLabel.TabIndex = 0;
            this.FindLabel.Text = "Find:";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1294, 40);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(174, 38);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = ".txt | *.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 861);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClearDestinationButton);
            this.Controls.Add(this.CopyToDestButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Text File Copier - With Amazing Find and Replace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.SouceTab.ResumeLayout(false);
            this.DestinationTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SouceTab;
        private System.Windows.Forms.TabPage DestinationTab;
        private System.Windows.Forms.Button CopyToDestButton;
        private System.Windows.Forms.Button ClearDestinationButton;
        private System.Windows.Forms.RichTextBox SourceTextBox;
        private System.Windows.Forms.RichTextBox DestinationTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ReplaceTextBox;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label ReplaceLabel;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox NotifyCheckBox;
        private System.Windows.Forms.Label NumOfReplacements;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

