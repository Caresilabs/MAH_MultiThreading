namespace Assignment5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.carParkProgress = new System.Windows.Forms.ProgressBar();
            this.startstopbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.northProgress = new System.Windows.Forms.ProgressBar();
            this.eastProgress = new System.Windows.Forms.ProgressBar();
            this.westProgress = new System.Windows.Forms.ProgressBar();
            this.southProgress = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.carParkProgress);
            this.panel1.Location = new System.Drawing.Point(176, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 216);
            this.panel1.TabIndex = 0;
            // 
            // carParkProgress
            // 
            this.carParkProgress.ForeColor = System.Drawing.Color.Red;
            this.carParkProgress.Location = new System.Drawing.Point(69, 103);
            this.carParkProgress.Name = "carParkProgress";
            this.carParkProgress.Size = new System.Drawing.Size(313, 23);
            this.carParkProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.carParkProgress.TabIndex = 0;
            // 
            // startstopbutton
            // 
            this.startstopbutton.Location = new System.Drawing.Point(12, 12);
            this.startstopbutton.Name = "startstopbutton";
            this.startstopbutton.Size = new System.Drawing.Size(89, 50);
            this.startstopbutton.TabIndex = 1;
            this.startstopbutton.Text = "Start";
            this.startstopbutton.UseVisualStyleBackColor = true;
            this.startstopbutton.Click += new System.EventHandler(this.startstopbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carpark";
            // 
            // northProgress
            // 
            this.northProgress.Location = new System.Drawing.Point(323, 67);
            this.northProgress.Name = "northProgress";
            this.northProgress.Size = new System.Drawing.Size(148, 23);
            this.northProgress.TabIndex = 0;
            // 
            // eastProgress
            // 
            this.eastProgress.Location = new System.Drawing.Point(630, 215);
            this.eastProgress.Name = "eastProgress";
            this.eastProgress.Size = new System.Drawing.Size(148, 23);
            this.eastProgress.TabIndex = 0;
            // 
            // westProgress
            // 
            this.westProgress.Location = new System.Drawing.Point(13, 216);
            this.westProgress.Name = "westProgress";
            this.westProgress.Size = new System.Drawing.Size(148, 23);
            this.westProgress.TabIndex = 0;
            // 
            // southProgress
            // 
            this.southProgress.Location = new System.Drawing.Point(323, 378);
            this.southProgress.Name = "southProgress";
            this.southProgress.Size = new System.Drawing.Size(148, 23);
            this.southProgress.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "North";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "East";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "South";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "West";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.northProgress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.eastProgress);
            this.groupBox1.Controls.Add(this.westProgress);
            this.groupBox1.Controls.Add(this.southProgress);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 434);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Group";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 514);
            this.Controls.Add(this.startstopbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Carpark";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar carParkProgress;
        private System.Windows.Forms.Button startstopbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar northProgress;
        private System.Windows.Forms.ProgressBar eastProgress;
        private System.Windows.Forms.ProgressBar westProgress;
        private System.Windows.Forms.ProgressBar southProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

