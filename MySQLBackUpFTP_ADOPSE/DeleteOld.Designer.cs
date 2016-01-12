namespace MySQLBackUpFTP_ADOPSE
{
    partial class DeleteOld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteOld));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keepOnLocalNUD = new System.Windows.Forms.NumericUpDown();
            this.keepOnFTPNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.okB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keepOnLocalNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keepOnFTPNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.okB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.keepOnFTPNUD);
            this.panel1.Controls.Add(this.keepOnLocalNUD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 97);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keep only the";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keep only the";
            // 
            // keepOnLocalNUD
            // 
            this.keepOnLocalNUD.Location = new System.Drawing.Point(81, 8);
            this.keepOnLocalNUD.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.keepOnLocalNUD.Name = "keepOnLocalNUD";
            this.keepOnLocalNUD.Size = new System.Drawing.Size(33, 20);
            this.keepOnLocalNUD.TabIndex = 2;
            // 
            // keepOnFTPNUD
            // 
            this.keepOnFTPNUD.Location = new System.Drawing.Point(81, 34);
            this.keepOnFTPNUD.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.keepOnFTPNUD.Name = "keepOnFTPNUD";
            this.keepOnFTPNUD.Size = new System.Drawing.Size(33, 20);
            this.keepOnFTPNUD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "latest backup files for each database on your disk.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "latest backup files for each database on the FTP server.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "(0 is infinite)";
            // 
            // okB
            // 
            this.okB.Location = new System.Drawing.Point(316, 74);
            this.okB.Name = "okB";
            this.okB.Size = new System.Drawing.Size(75, 23);
            this.okB.TabIndex = 7;
            this.okB.Text = "OK";
            this.okB.UseVisualStyleBackColor = true;
            this.okB.Click += new System.EventHandler(this.okB_Click);
            // 
            // DeleteOld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 111);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(420, 149);
            this.MinimumSize = new System.Drawing.Size(420, 149);
            this.Name = "DeleteOld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-delete old backups";
            this.Load += new System.EventHandler(this.DeleteOld_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keepOnLocalNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keepOnFTPNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown keepOnFTPNUD;
        private System.Windows.Forms.NumericUpDown keepOnLocalNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okB;
        private System.Windows.Forms.Label label5;
    }
}