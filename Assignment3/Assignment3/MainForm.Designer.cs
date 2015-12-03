namespace Assignment3
{
    partial class MainForm
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
            this.FactoryGroupBoxB = new System.Windows.Forms.GroupBox();
            this.FactoryBStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StopFactoryB = new System.Windows.Forms.Button();
            this.StartFactoryB = new System.Windows.Forms.Button();
            this.FactoryGroupBox = new System.Windows.Forms.GroupBox();
            this.FactoryAStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StopFactoryA = new System.Windows.Forms.Button();
            this.StartFactoryA = new System.Windows.Forms.Button();
            this.ICADeliveryBox = new System.Windows.Forms.GroupBox();
            this.StopDeliver = new System.Windows.Forms.Button();
            this.TruckStatusLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StartDeliver = new System.Windows.Forms.Button();
            this.TruckLimitBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TruckLimitVolume = new System.Windows.Forms.Label();
            this.TruckLimitItems = new System.Windows.Forms.Label();
            this.TruckLimitWeight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeliverList = new System.Windows.Forms.ListBox();
            this.StorageGroupBox = new System.Windows.Forms.GroupBox();
            this.StorageProgressLabel = new System.Windows.Forms.Label();
            this.StorageProgress = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.FactoryGroupBoxB.SuspendLayout();
            this.FactoryGroupBox.SuspendLayout();
            this.ICADeliveryBox.SuspendLayout();
            this.TruckLimitBox.SuspendLayout();
            this.StorageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FactoryGroupBoxB
            // 
            this.FactoryGroupBoxB.Controls.Add(this.FactoryBStatus);
            this.FactoryGroupBoxB.Controls.Add(this.label7);
            this.FactoryGroupBoxB.Controls.Add(this.label2);
            this.FactoryGroupBoxB.Controls.Add(this.StopFactoryB);
            this.FactoryGroupBoxB.Controls.Add(this.StartFactoryB);
            this.FactoryGroupBoxB.Location = new System.Drawing.Point(828, 566);
            this.FactoryGroupBoxB.Name = "FactoryGroupBoxB";
            this.FactoryGroupBoxB.Size = new System.Drawing.Size(659, 301);
            this.FactoryGroupBoxB.TabIndex = 5;
            this.FactoryGroupBoxB.TabStop = false;
            this.FactoryGroupBoxB.Text = "Factory B";
            // 
            // FactoryBStatus
            // 
            this.FactoryBStatus.AutoSize = true;
            this.FactoryBStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactoryBStatus.Location = new System.Drawing.Point(278, 123);
            this.FactoryBStatus.Name = "FactoryBStatus";
            this.FactoryBStatus.Size = new System.Drawing.Size(0, 42);
            this.FactoryBStatus.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 42);
            this.label7.TabIndex = 7;
            this.label7.Text = "Producer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status";
            // 
            // StopFactoryB
            // 
            this.StopFactoryB.Enabled = false;
            this.StopFactoryB.Location = new System.Drawing.Point(369, 201);
            this.StopFactoryB.Name = "StopFactoryB";
            this.StopFactoryB.Size = new System.Drawing.Size(230, 62);
            this.StopFactoryB.TabIndex = 0;
            this.StopFactoryB.Text = "Stop";
            this.StopFactoryB.UseVisualStyleBackColor = true;
            this.StopFactoryB.Click += new System.EventHandler(this.StopFactoryB_Click);
            // 
            // StartFactoryB
            // 
            this.StartFactoryB.Location = new System.Drawing.Point(60, 201);
            this.StartFactoryB.Name = "StartFactoryB";
            this.StartFactoryB.Size = new System.Drawing.Size(230, 62);
            this.StartFactoryB.TabIndex = 0;
            this.StartFactoryB.Text = "Start Working";
            this.StartFactoryB.UseVisualStyleBackColor = true;
            this.StartFactoryB.Click += new System.EventHandler(this.StartFactoryB_Click);
            // 
            // FactoryGroupBox
            // 
            this.FactoryGroupBox.Controls.Add(this.FactoryAStatus);
            this.FactoryGroupBox.Controls.Add(this.label6);
            this.FactoryGroupBox.Controls.Add(this.label1);
            this.FactoryGroupBox.Controls.Add(this.StopFactoryA);
            this.FactoryGroupBox.Controls.Add(this.StartFactoryA);
            this.FactoryGroupBox.Location = new System.Drawing.Point(828, 241);
            this.FactoryGroupBox.Name = "FactoryGroupBox";
            this.FactoryGroupBox.Size = new System.Drawing.Size(659, 301);
            this.FactoryGroupBox.TabIndex = 6;
            this.FactoryGroupBox.TabStop = false;
            this.FactoryGroupBox.Text = "Factory A";
            // 
            // FactoryAStatus
            // 
            this.FactoryAStatus.AutoSize = true;
            this.FactoryAStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactoryAStatus.Location = new System.Drawing.Point(290, 116);
            this.FactoryAStatus.Name = "FactoryAStatus";
            this.FactoryAStatus.Size = new System.Drawing.Size(0, 42);
            this.FactoryAStatus.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 42);
            this.label6.TabIndex = 7;
            this.label6.Text = "Producer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Status";
            // 
            // StopFactoryA
            // 
            this.StopFactoryA.Enabled = false;
            this.StopFactoryA.Location = new System.Drawing.Point(369, 197);
            this.StopFactoryA.Name = "StopFactoryA";
            this.StopFactoryA.Size = new System.Drawing.Size(230, 62);
            this.StopFactoryA.TabIndex = 0;
            this.StopFactoryA.Text = "Stop";
            this.StopFactoryA.UseVisualStyleBackColor = true;
            this.StopFactoryA.Click += new System.EventHandler(this.StopFactoryA_Click);
            // 
            // StartFactoryA
            // 
            this.StartFactoryA.Location = new System.Drawing.Point(60, 197);
            this.StartFactoryA.Name = "StartFactoryA";
            this.StartFactoryA.Size = new System.Drawing.Size(230, 62);
            this.StartFactoryA.TabIndex = 0;
            this.StartFactoryA.Text = "Start Working";
            this.StartFactoryA.UseVisualStyleBackColor = true;
            this.StartFactoryA.Click += new System.EventHandler(this.StartFactoryA_Click);
            // 
            // ICADeliveryBox
            // 
            this.ICADeliveryBox.Controls.Add(this.label9);
            this.ICADeliveryBox.Controls.Add(this.StopDeliver);
            this.ICADeliveryBox.Controls.Add(this.TruckStatusLabel);
            this.ICADeliveryBox.Controls.Add(this.label8);
            this.ICADeliveryBox.Controls.Add(this.StartDeliver);
            this.ICADeliveryBox.Controls.Add(this.TruckLimitBox);
            this.ICADeliveryBox.Controls.Add(this.DeliverList);
            this.ICADeliveryBox.Location = new System.Drawing.Point(32, 222);
            this.ICADeliveryBox.Name = "ICADeliveryBox";
            this.ICADeliveryBox.Size = new System.Drawing.Size(728, 645);
            this.ICADeliveryBox.TabIndex = 4;
            this.ICADeliveryBox.TabStop = false;
            this.ICADeliveryBox.Text = "Delivery to ICA";
            // 
            // StopDeliver
            // 
            this.StopDeliver.Enabled = false;
            this.StopDeliver.Location = new System.Drawing.Point(93, 542);
            this.StopDeliver.Name = "StopDeliver";
            this.StopDeliver.Size = new System.Drawing.Size(168, 65);
            this.StopDeliver.TabIndex = 9;
            this.StopDeliver.Text = "Stop Deliver";
            this.StopDeliver.UseVisualStyleBackColor = true;
            this.StopDeliver.Click += new System.EventHandler(this.StopDeliver_Click);
            // 
            // TruckStatusLabel
            // 
            this.TruckStatusLabel.AutoSize = true;
            this.TruckStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TruckStatusLabel.Location = new System.Drawing.Point(38, 344);
            this.TruckStatusLabel.Name = "TruckStatusLabel";
            this.TruckStatusLabel.Size = new System.Drawing.Size(136, 33);
            this.TruckStatusLabel.TabIndex = 7;
            this.TruckStatusLabel.Text = "Waiting...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Status";
            // 
            // StartDeliver
            // 
            this.StartDeliver.Location = new System.Drawing.Point(93, 447);
            this.StartDeliver.Name = "StartDeliver";
            this.StartDeliver.Size = new System.Drawing.Size(168, 65);
            this.StartDeliver.TabIndex = 9;
            this.StartDeliver.Text = "Start Deliver";
            this.StartDeliver.UseVisualStyleBackColor = true;
            this.StartDeliver.Click += new System.EventHandler(this.StartDeliver_Click);
            // 
            // TruckLimitBox
            // 
            this.TruckLimitBox.Controls.Add(this.label5);
            this.TruckLimitBox.Controls.Add(this.label4);
            this.TruckLimitBox.Controls.Add(this.TruckLimitVolume);
            this.TruckLimitBox.Controls.Add(this.TruckLimitItems);
            this.TruckLimitBox.Controls.Add(this.TruckLimitWeight);
            this.TruckLimitBox.Controls.Add(this.label3);
            this.TruckLimitBox.Location = new System.Drawing.Point(31, 58);
            this.TruckLimitBox.Name = "TruckLimitBox";
            this.TruckLimitBox.Size = new System.Drawing.Size(298, 196);
            this.TruckLimitBox.TabIndex = 8;
            this.TruckLimitBox.TabStop = false;
            this.TruckLimitBox.Text = "Truck Limit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Items:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Volume:";
            // 
            // TruckLimitVolume
            // 
            this.TruckLimitVolume.AutoSize = true;
            this.TruckLimitVolume.Location = new System.Drawing.Point(115, 94);
            this.TruckLimitVolume.Name = "TruckLimitVolume";
            this.TruckLimitVolume.Size = new System.Drawing.Size(0, 25);
            this.TruckLimitVolume.TabIndex = 7;
            // 
            // TruckLimitItems
            // 
            this.TruckLimitItems.AutoSize = true;
            this.TruckLimitItems.Location = new System.Drawing.Point(104, 143);
            this.TruckLimitItems.Name = "TruckLimitItems";
            this.TruckLimitItems.Size = new System.Drawing.Size(0, 25);
            this.TruckLimitItems.TabIndex = 7;
            // 
            // TruckLimitWeight
            // 
            this.TruckLimitWeight.AutoSize = true;
            this.TruckLimitWeight.Location = new System.Drawing.Point(110, 47);
            this.TruckLimitWeight.Name = "TruckLimitWeight";
            this.TruckLimitWeight.Size = new System.Drawing.Size(0, 25);
            this.TruckLimitWeight.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Weight:";
            // 
            // DeliverList
            // 
            this.DeliverList.FormattingEnabled = true;
            this.DeliverList.ItemHeight = 25;
            this.DeliverList.Location = new System.Drawing.Point(357, 111);
            this.DeliverList.Name = "DeliverList";
            this.DeliverList.Size = new System.Drawing.Size(344, 504);
            this.DeliverList.TabIndex = 7;
            // 
            // StorageGroupBox
            // 
            this.StorageGroupBox.Controls.Add(this.StorageProgressLabel);
            this.StorageGroupBox.Controls.Add(this.StorageProgress);
            this.StorageGroupBox.Location = new System.Drawing.Point(32, 12);
            this.StorageGroupBox.Name = "StorageGroupBox";
            this.StorageGroupBox.Size = new System.Drawing.Size(1455, 163);
            this.StorageGroupBox.TabIndex = 3;
            this.StorageGroupBox.TabStop = false;
            this.StorageGroupBox.Text = "Storage";
            // 
            // StorageProgressLabel
            // 
            this.StorageProgressLabel.AutoSize = true;
            this.StorageProgressLabel.Location = new System.Drawing.Point(686, 126);
            this.StorageProgressLabel.Name = "StorageProgressLabel";
            this.StorageProgressLabel.Size = new System.Drawing.Size(42, 25);
            this.StorageProgressLabel.TabIndex = 1;
            this.StorageProgressLabel.Text = "1/1";
            // 
            // StorageProgress
            // 
            this.StorageProgress.Location = new System.Drawing.Point(22, 52);
            this.StorageProgress.Name = "StorageProgress";
            this.StorageProgress.Size = new System.Drawing.Size(1402, 60);
            this.StorageProgress.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "ICA\'s Storage";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 894);
            this.Controls.Add(this.FactoryGroupBoxB);
            this.Controls.Add(this.FactoryGroupBox);
            this.Controls.Add(this.ICADeliveryBox);
            this.Controls.Add(this.StorageGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "ICA Delivery System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FactoryGroupBoxB.ResumeLayout(false);
            this.FactoryGroupBoxB.PerformLayout();
            this.FactoryGroupBox.ResumeLayout(false);
            this.FactoryGroupBox.PerformLayout();
            this.ICADeliveryBox.ResumeLayout(false);
            this.ICADeliveryBox.PerformLayout();
            this.TruckLimitBox.ResumeLayout(false);
            this.TruckLimitBox.PerformLayout();
            this.StorageGroupBox.ResumeLayout(false);
            this.StorageGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FactoryGroupBoxB;
        private System.Windows.Forms.Button StopFactoryB;
        private System.Windows.Forms.Button StartFactoryB;
        private System.Windows.Forms.GroupBox FactoryGroupBox;
        private System.Windows.Forms.Button StopFactoryA;
        private System.Windows.Forms.Button StartFactoryA;
        private System.Windows.Forms.GroupBox ICADeliveryBox;
        private System.Windows.Forms.GroupBox StorageGroupBox;
        private System.Windows.Forms.ProgressBar StorageProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox DeliverList;
        private System.Windows.Forms.Button StartDeliver;
        private System.Windows.Forms.GroupBox TruckLimitBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FactoryBStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label FactoryAStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TruckLimitVolume;
        private System.Windows.Forms.Label TruckLimitItems;
        private System.Windows.Forms.Label TruckLimitWeight;
        private System.Windows.Forms.Button StopDeliver;
        private System.Windows.Forms.Label TruckStatusLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label StorageProgressLabel;
        private System.Windows.Forms.Label label9;
    }
}