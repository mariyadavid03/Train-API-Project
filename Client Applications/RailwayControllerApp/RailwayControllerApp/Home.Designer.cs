namespace RailwayControllerApp
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnScheduleManage = new System.Windows.Forms.Button();
            this.btnTrainManage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addTrainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSchduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Railway Controller";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnScheduleManage);
            this.panel1.Controls.Add(this.btnTrainManage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(212, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 343);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnScheduleManage
            // 
            this.btnScheduleManage.BackColor = System.Drawing.Color.LightGreen;
            this.btnScheduleManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleManage.Location = new System.Drawing.Point(84, 227);
            this.btnScheduleManage.Name = "btnScheduleManage";
            this.btnScheduleManage.Size = new System.Drawing.Size(213, 56);
            this.btnScheduleManage.TabIndex = 4;
            this.btnScheduleManage.Text = "Manage Schedules";
            this.btnScheduleManage.UseVisualStyleBackColor = false;
            this.btnScheduleManage.Click += new System.EventHandler(this.btnScheduleManage_Click);
            // 
            // btnTrainManage
            // 
            this.btnTrainManage.BackColor = System.Drawing.Color.LightGreen;
            this.btnTrainManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainManage.Location = new System.Drawing.Point(84, 140);
            this.btnTrainManage.Name = "btnTrainManage";
            this.btnTrainManage.Size = new System.Drawing.Size(213, 56);
            this.btnTrainManage.TabIndex = 3;
            this.btnTrainManage.Text = "Manage Trains";
            this.btnTrainManage.UseVisualStyleBackColor = false;
            this.btnTrainManage.Click += new System.EventHandler(this.btnTrainManage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(147, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menu";
            // 
            // addTrainsToolStripMenuItem
            // 
            this.addTrainsToolStripMenuItem.Name = "addTrainsToolStripMenuItem";
            this.addTrainsToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.addTrainsToolStripMenuItem.Text = "Train";
            this.addTrainsToolStripMenuItem.Click += new System.EventHandler(this.addTrainsToolStripMenuItem_Click);
            // 
            // addSchduleToolStripMenuItem
            // 
            this.addSchduleToolStripMenuItem.Name = "addSchduleToolStripMenuItem";
            this.addSchduleToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.addSchduleToolStripMenuItem.Text = "Schedule";
            this.addSchduleToolStripMenuItem.Click += new System.EventHandler(this.addSchduleToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTrainsToolStripMenuItem,
            this.addSchduleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(796, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnScheduleManage;
        private System.Windows.Forms.Button btnTrainManage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem addTrainsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSchduleToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

