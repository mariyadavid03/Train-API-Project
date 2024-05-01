namespace RailwayControllerApp
{
    partial class ScheduleManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEndStation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStartStation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbTrainNo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.lblScheduleID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(189, 135);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 22);
            this.lblID.TabIndex = 38;
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 22);
            this.label8.TabIndex = 37;
            this.label8.Text = "TrainID";
            this.label8.Visible = false;
            // 
            // txtEndStation
            // 
            this.txtEndStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndStation.Location = new System.Drawing.Point(170, 153);
            this.txtEndStation.Name = "txtEndStation";
            this.txtEndStation.Size = new System.Drawing.Size(150, 28);
            this.txtEndStation.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 22);
            this.label9.TabIndex = 35;
            this.label9.Text = "End Station";
            // 
            // txtStartStation
            // 
            this.txtStartStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartStation.Location = new System.Drawing.Point(170, 113);
            this.txtStartStation.Name = "txtStartStation";
            this.txtStartStation.Size = new System.Drawing.Size(150, 28);
            this.txtStartStation.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Start Station";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Enter Schedule Details";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(209, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 44);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(60, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 44);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Train No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(93, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Manage Schedules";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(170, 67);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(216, 26);
            this.dtpDate.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "End Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 22);
            this.label10.TabIndex = 42;
            this.label10.Text = "Start Time";
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.dgvSchedule.Location = new System.Drawing.Point(466, 71);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 62;
            this.dgvSchedule.RowTemplate.Height = 28;
            this.dgvSchedule.Size = new System.Drawing.Size(658, 526);
            this.dgvSchedule.TabIndex = 48;
            this.dgvSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellContentClick);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Edit";
            this.dataGridViewButtonColumn1.MinimumWidth = 8;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn1.Width = 50;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewButtonColumn2.HeaderText = "Delete";
            this.dataGridViewButtonColumn2.MinimumWidth = 8;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn2.Width = 50;
            // 
            // cbTrainNo
            // 
            this.cbTrainNo.FormattingEnabled = true;
            this.cbTrainNo.Location = new System.Drawing.Point(193, 165);
            this.cbTrainNo.Name = "cbTrainNo";
            this.cbTrainNo.Size = new System.Drawing.Size(149, 28);
            this.cbTrainNo.TabIndex = 49;
            this.cbTrainNo.SelectedIndexChanged += new System.EventHandler(this.cbTrainNo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(189, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 22);
            this.label11.TabIndex = 50;
            this.label11.Text = "Select Train";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtStartTime);
            this.panel1.Controls.Add(this.txtEndTime);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtStartStation);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtEndStation);
            this.panel1.Location = new System.Drawing.Point(12, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 380);
            this.panel1.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(50, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(311, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "Enter time in 24 formate (eg.. 12:00, 20:00)";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartTime.Location = new System.Drawing.Point(169, 223);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(90, 28);
            this.txtStartTime.TabIndex = 45;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndTime.Location = new System.Drawing.Point(169, 263);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(90, 28);
            this.txtEndTime.TabIndex = 46;
            // 
            // lblScheduleID
            // 
            this.lblScheduleID.AutoSize = true;
            this.lblScheduleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleID.Location = new System.Drawing.Point(217, 135);
            this.lblScheduleID.Name = "lblScheduleID";
            this.lblScheduleID.Size = new System.Drawing.Size(20, 22);
            this.lblScheduleID.TabIndex = 52;
            this.lblScheduleID.Text = "0";
            this.lblScheduleID.Visible = false;
            // 
            // ScheduleManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 669);
            this.Controls.Add(this.lblScheduleID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbTrainNo);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleManage";
            this.Text = "ScheduleManage";
            this.Load += new System.EventHandler(this.ScheduleManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEndStation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStartStation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.ComboBox cbTrainNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblScheduleID;
    }
}