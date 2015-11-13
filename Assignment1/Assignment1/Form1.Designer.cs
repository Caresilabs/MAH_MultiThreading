namespace Assignment1
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
            this.musicBox = new System.Windows.Forms.GroupBox();
            this.displayBox = new System.Windows.Forms.GroupBox();
            this.triangleBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openMusicButton = new System.Windows.Forms.Button();
            this.startMusicButton = new System.Windows.Forms.Button();
            this.stopMusicButton = new System.Windows.Forms.Button();
            this.musicFilePathLabel = new System.Windows.Forms.Label();
            this.trianglePanel = new System.Windows.Forms.Panel();
            this.startTriangleButton = new System.Windows.Forms.Button();
            this.stopTriangleButton = new System.Windows.Forms.Button();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.stopDisplayButton = new System.Windows.Forms.Button();
            this.startDisplayButton = new System.Windows.Forms.Button();
            this.openMusicDialog = new System.Windows.Forms.OpenFileDialog();
            this.musicBox.SuspendLayout();
            this.displayBox.SuspendLayout();
            this.triangleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // musicBox
            // 
            this.musicBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicBox.Controls.Add(this.musicFilePathLabel);
            this.musicBox.Controls.Add(this.stopMusicButton);
            this.musicBox.Controls.Add(this.startMusicButton);
            this.musicBox.Controls.Add(this.openMusicButton);
            this.musicBox.Controls.Add(this.label1);
            this.musicBox.Location = new System.Drawing.Point(12, 12);
            this.musicBox.Name = "musicBox";
            this.musicBox.Size = new System.Drawing.Size(1064, 168);
            this.musicBox.TabIndex = 0;
            this.musicBox.TabStop = false;
            this.musicBox.Text = "Music Player";
            // 
            // displayBox
            // 
            this.displayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayBox.Controls.Add(this.displayPanel);
            this.displayBox.Controls.Add(this.stopDisplayButton);
            this.displayBox.Controls.Add(this.startDisplayButton);
            this.displayBox.Location = new System.Drawing.Point(12, 200);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(506, 597);
            this.displayBox.TabIndex = 1;
            this.displayBox.TabStop = false;
            this.displayBox.Text = "Display Thread";
            // 
            // triangleBox
            // 
            this.triangleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.triangleBox.Controls.Add(this.trianglePanel);
            this.triangleBox.Controls.Add(this.stopTriangleButton);
            this.triangleBox.Controls.Add(this.startTriangleButton);
            this.triangleBox.Location = new System.Drawing.Point(539, 200);
            this.triangleBox.Name = "triangleBox";
            this.triangleBox.Size = new System.Drawing.Size(537, 597);
            this.triangleBox.TabIndex = 2;
            this.triangleBox.TabStop = false;
            this.triangleBox.Text = "Triangle Thread";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loaded Audio File:";
            // 
            // openMusicButton
            // 
            this.openMusicButton.Location = new System.Drawing.Point(38, 98);
            this.openMusicButton.Name = "openMusicButton";
            this.openMusicButton.Size = new System.Drawing.Size(174, 49);
            this.openMusicButton.TabIndex = 1;
            this.openMusicButton.Text = "Open";
            this.openMusicButton.UseVisualStyleBackColor = true;
            this.openMusicButton.Click += new System.EventHandler(this.openMusicButton_Click);
            // 
            // startMusicButton
            // 
            this.startMusicButton.Location = new System.Drawing.Point(231, 98);
            this.startMusicButton.Name = "startMusicButton";
            this.startMusicButton.Size = new System.Drawing.Size(174, 49);
            this.startMusicButton.TabIndex = 1;
            this.startMusicButton.Text = "Play";
            this.startMusicButton.UseVisualStyleBackColor = true;
            this.startMusicButton.Click += new System.EventHandler(this.startMusicButton_Click);
            // 
            // stopMusicButton
            // 
            this.stopMusicButton.Location = new System.Drawing.Point(425, 98);
            this.stopMusicButton.Name = "stopMusicButton";
            this.stopMusicButton.Size = new System.Drawing.Size(174, 49);
            this.stopMusicButton.TabIndex = 1;
            this.stopMusicButton.Text = "Stop";
            this.stopMusicButton.UseVisualStyleBackColor = true;
            this.stopMusicButton.Click += new System.EventHandler(this.stopMusicButton_Click);
            // 
            // musicFilePathLabel
            // 
            this.musicFilePathLabel.AutoSize = true;
            this.musicFilePathLabel.Location = new System.Drawing.Point(242, 50);
            this.musicFilePathLabel.Name = "musicFilePathLabel";
            this.musicFilePathLabel.Size = new System.Drawing.Size(0, 25);
            this.musicFilePathLabel.TabIndex = 2;
            // 
            // trianglePanel
            // 
            this.trianglePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trianglePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.trianglePanel.Location = new System.Drawing.Point(22, 40);
            this.trianglePanel.Name = "trianglePanel";
            this.trianglePanel.Size = new System.Drawing.Size(496, 462);
            this.trianglePanel.TabIndex = 0;
            this.trianglePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.trianglePanel_Paint);
            // 
            // startTriangleButton
            // 
            this.startTriangleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startTriangleButton.Location = new System.Drawing.Point(22, 522);
            this.startTriangleButton.Name = "startTriangleButton";
            this.startTriangleButton.Size = new System.Drawing.Size(304, 49);
            this.startTriangleButton.TabIndex = 1;
            this.startTriangleButton.Text = "Start Rotate";
            this.startTriangleButton.UseVisualStyleBackColor = true;
            this.startTriangleButton.Click += new System.EventHandler(this.startTriangleButton_Click);
            // 
            // stopTriangleButton
            // 
            this.stopTriangleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopTriangleButton.Location = new System.Drawing.Point(344, 522);
            this.stopTriangleButton.Name = "stopTriangleButton";
            this.stopTriangleButton.Size = new System.Drawing.Size(174, 49);
            this.stopTriangleButton.TabIndex = 1;
            this.stopTriangleButton.Text = "Stop";
            this.stopTriangleButton.UseVisualStyleBackColor = true;
            this.stopTriangleButton.Click += new System.EventHandler(this.stopTriangleButton_Click);
            // 
            // displayPanel
            // 
            this.displayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.displayPanel.Location = new System.Drawing.Point(19, 32);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(467, 462);
            this.displayPanel.TabIndex = 2;
            this.displayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.displayPanel_Paint);
            // 
            // stopDisplayButton
            // 
            this.stopDisplayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopDisplayButton.Location = new System.Drawing.Point(315, 514);
            this.stopDisplayButton.Name = "stopDisplayButton";
            this.stopDisplayButton.Size = new System.Drawing.Size(174, 49);
            this.stopDisplayButton.TabIndex = 3;
            this.stopDisplayButton.Text = "Stop";
            this.stopDisplayButton.UseVisualStyleBackColor = true;
            this.stopDisplayButton.Click += new System.EventHandler(this.stopDisplayButton_Click);
            // 
            // startDisplayButton
            // 
            this.startDisplayButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDisplayButton.Location = new System.Drawing.Point(19, 514);
            this.startDisplayButton.Name = "startDisplayButton";
            this.startDisplayButton.Size = new System.Drawing.Size(274, 49);
            this.startDisplayButton.TabIndex = 4;
            this.startDisplayButton.Text = "Start Display";
            this.startDisplayButton.UseVisualStyleBackColor = true;
            this.startDisplayButton.Click += new System.EventHandler(this.startDisplayButton_Click);
            // 
            // openMusicDialog
            // 
            this.openMusicDialog.FileName = "openMusicDialog";
            this.openMusicDialog.Filter = "Music | *.mp3;*.wav";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 809);
            this.Controls.Add(this.triangleBox);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.musicBox);
            this.Name = "Form1";
            this.Text = "Multiple Thread Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.musicBox.ResumeLayout(false);
            this.musicBox.PerformLayout();
            this.displayBox.ResumeLayout(false);
            this.triangleBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox musicBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox displayBox;
        private System.Windows.Forms.GroupBox triangleBox;
        private System.Windows.Forms.Button openMusicButton;
        private System.Windows.Forms.Label musicFilePathLabel;
        private System.Windows.Forms.Button stopMusicButton;
        private System.Windows.Forms.Button startMusicButton;
        private System.Windows.Forms.Panel trianglePanel;
        private System.Windows.Forms.Button stopTriangleButton;
        private System.Windows.Forms.Button startTriangleButton;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Button stopDisplayButton;
        private System.Windows.Forms.Button startDisplayButton;
        private System.Windows.Forms.OpenFileDialog openMusicDialog;
    }
}

