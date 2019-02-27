namespace Pizzaria1
{
    partial class ScoreTracker
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Youtube = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_Overall = new System.Windows.Forms.ProgressBar();
            this.cb_Concentration = new System.Windows.Forms.ComboBox();
            this.lab_Achievement = new System.Windows.Forms.Label();
            this.cb_Workload = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_AchievementLevel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_FinishOnTime = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_StartOnTime = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_StartOnTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_FinishOnTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_AchievementLevel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_Workload);
            this.groupBox1.Controls.Add(this.lab_Achievement);
            this.groupBox1.Controls.Add(this.cb_Concentration);
            this.groupBox1.Controls.Add(this.pb_Overall);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(249, 416);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 39);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Youtube
            // 
            this.btn_Youtube.Location = new System.Drawing.Point(12, 364);
            this.btn_Youtube.Name = "btn_Youtube";
            this.btn_Youtube.Size = new System.Drawing.Size(0, 0);
            this.btn_Youtube.TabIndex = 1;
            this.btn_Youtube.Text = "Put your video";
            this.btn_Youtube.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(148, 416);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(95, 39);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Concentration";
            // 
            // pb_Overall
            // 
            this.pb_Overall.Location = new System.Drawing.Point(16, 316);
            this.pb_Overall.Name = "pb_Overall";
            this.pb_Overall.Size = new System.Drawing.Size(281, 23);
            this.pb_Overall.TabIndex = 4;
            this.pb_Overall.Click += new System.EventHandler(this.pb_Overall_Click);
            // 
            // cb_Concentration
            // 
            this.cb_Concentration.FormattingEnabled = true;
            this.cb_Concentration.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_Concentration.Location = new System.Drawing.Point(154, 115);
            this.cb_Concentration.Name = "cb_Concentration";
            this.cb_Concentration.Size = new System.Drawing.Size(143, 24);
            this.cb_Concentration.TabIndex = 5;
            // 
            // lab_Achievement
            // 
            this.lab_Achievement.AutoSize = true;
            this.lab_Achievement.Location = new System.Drawing.Point(28, 225);
            this.lab_Achievement.Name = "lab_Achievement";
            this.lab_Achievement.Size = new System.Drawing.Size(127, 17);
            this.lab_Achievement.TabIndex = 6;
            this.lab_Achievement.Text = "Satisfaction";
            // 
            // cb_Workload
            // 
            this.cb_Workload.FormattingEnabled = true;
            this.cb_Workload.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_Workload.Location = new System.Drawing.Point(154, 170);
            this.cb_Workload.Name = "cb_Workload";
            this.cb_Workload.Size = new System.Drawing.Size(143, 24);
            this.cb_Workload.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Level of Completion";
            // 
            // cb_AchievementLevel
            // 
            this.cb_AchievementLevel.FormattingEnabled = true;
            this.cb_AchievementLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_AchievementLevel.Location = new System.Drawing.Point(154, 225);
            this.cb_AchievementLevel.Name = "cb_AchievementLevel";
            this.cb_AchievementLevel.Size = new System.Drawing.Size(143, 24);
            this.cb_AchievementLevel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Finish On Time";
            // 
            // cb_FinishOnTime
            // 
            this.cb_FinishOnTime.FormattingEnabled = true;
            this.cb_FinishOnTime.Items.AddRange(new object[] {
            "",
            "Yes",
            "No"});
            this.cb_FinishOnTime.Location = new System.Drawing.Point(154, 276);
            this.cb_FinishOnTime.Name = "cb_FinishOnTime";
            this.cb_FinishOnTime.Size = new System.Drawing.Size(143, 24);
            this.cb_FinishOnTime.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Start On Time";
            // 
            // cb_StartOnTime
            // 
            this.cb_StartOnTime.FormattingEnabled = true;
            this.cb_StartOnTime.Items.AddRange(new object[] {
            "",
            "Yes",
            "No"});
            this.cb_StartOnTime.Location = new System.Drawing.Point(154, 64);
            this.cb_StartOnTime.Name = "cb_StartOnTime";
            this.cb_StartOnTime.Size = new System.Drawing.Size(143, 24);
            this.cb_StartOnTime.TabIndex = 13;
            // 
            // Breakdance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 467);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Youtube);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Breakdance";
            this.Text = "Breakdance";
            this.Load += new System.EventHandler(this.Breakdance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Youtube;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cb_Workload;
        private System.Windows.Forms.Label lab_Achievement;
        private System.Windows.Forms.ComboBox cb_Concentration;
        private System.Windows.Forms.ProgressBar pb_Overall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_AchievementLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_FinishOnTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_StartOnTime;
        private System.Windows.Forms.Label label4;
    }
}