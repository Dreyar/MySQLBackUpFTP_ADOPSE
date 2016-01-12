namespace MySQLBackUpFTP_ADOPSE
{
    partial class Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.minuteNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.hourNUD = new System.Windows.Forms.NumericUpDown();
            this.daysLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.minuteNUD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.hourNUD);
            this.panel1.Controls.Add(this.daysLB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 133);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // minuteNUD
            // 
            this.minuteNUD.Location = new System.Drawing.Point(170, 76);
            this.minuteNUD.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteNUD.Name = "minuteNUD";
            this.minuteNUD.Size = new System.Drawing.Size(38, 20);
            this.minuteNUD.TabIndex = 4;
            this.minuteNUD.ValueChanged += new System.EventHandler(this.minuteNUD_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "at";
            // 
            // hourNUD
            // 
            this.hourNUD.Location = new System.Drawing.Point(110, 76);
            this.hourNUD.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourNUD.Name = "hourNUD";
            this.hourNUD.Size = new System.Drawing.Size(38, 20);
            this.hourNUD.TabIndex = 2;
            // 
            // daysLB
            // 
            this.daysLB.FormattingEnabled = true;
            this.daysLB.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.daysLB.Location = new System.Drawing.Point(7, 20);
            this.daysLB.Name = "daysLB";
            this.daysLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.daysLB.Size = new System.Drawing.Size(68, 95);
            this.daysLB.TabIndex = 1;
            this.daysLB.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto-backup every:";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 157);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(307, 195);
            this.MinimumSize = new System.Drawing.Size(307, 195);
            this.Name = "Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox daysLB;
        private System.Windows.Forms.NumericUpDown hourNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown minuteNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}