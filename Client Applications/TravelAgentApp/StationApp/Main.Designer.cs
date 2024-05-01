namespace StationApp
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAvaliableSeats = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.pnlBooking = new System.Windows.Forms.Panel();
            this.btnBook = new System.Windows.Forms.Button();
            this.cbSeatNo = new System.Windows.Forms.ComboBox();
            this.btnBookTrain = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTrainDate = new System.Windows.Forms.DateTimePicker();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTrainInfo = new System.Windows.Forms.DataGridView();
            this.dgvSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Train_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Train_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Train_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schedule_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.pnlTrain = new System.Windows.Forms.Panel();
            this.btnSeatBook = new System.Windows.Forms.Button();
            this.lbTrainName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbTrainNo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndStation = new System.Windows.Forms.Label();
            this.lblStartStation = new System.Windows.Forms.Label();
            this.lblTrainName = new System.Windows.Forms.Label();
            this.lblTrainNo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSearInfo = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblNic = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlBooking.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainInfo)).BeginInit();
            this.pnlTrain.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 90);
            this.panel1.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Gill Sans MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(22, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(208, 31);
            this.label18.TabIndex = 1;
            this.label18.Text = "For Travel Agent Use";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(375, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(269, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Passenger NIC";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // txtNIC
            // 
            this.txtNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.Location = new System.Drawing.Point(412, 235);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(176, 28);
            this.txtNIC.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(261, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Select Class";
            // 
            // cbClass
            // 
            this.cbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Items.AddRange(new object[] {
            "First Class",
            "Second Class",
            "Third Class"});
            this.cbClass.Location = new System.Drawing.Point(412, 63);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(173, 30);
            this.cbClass.TabIndex = 26;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(269, 183);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 22);
            this.label11.TabIndex = 31;
            this.label11.Text = "Select Seat";
            // 
            // lblAvaliableSeats
            // 
            this.lblAvaliableSeats.AutoSize = true;
            this.lblAvaliableSeats.BackColor = System.Drawing.Color.Ivory;
            this.lblAvaliableSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaliableSeats.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblAvaliableSeats.Location = new System.Drawing.Point(201, 14);
            this.lblAvaliableSeats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvaliableSeats.Name = "lblAvaliableSeats";
            this.lblAvaliableSeats.Size = new System.Drawing.Size(184, 25);
            this.lblAvaliableSeats.TabIndex = 35;
            this.lblAvaliableSeats.Text = "No Classs Selected";
            this.lblAvaliableSeats.Click += new System.EventHandler(this.lblAvaliableSeats_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.Ivory;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb.Location = new System.Drawing.Point(11, 15);
            this.lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(148, 25);
            this.lb.TabIndex = 34;
            this.lb.Text = "Avaliable Seats";
            this.lb.Click += new System.EventHandler(this.lb_Click);
            // 
            // pnlBooking
            // 
            this.pnlBooking.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlBooking.Controls.Add(this.btnBook);
            this.pnlBooking.Controls.Add(this.cbSeatNo);
            this.pnlBooking.Controls.Add(this.btnBookTrain);
            this.pnlBooking.Controls.Add(this.txtNIC);
            this.pnlBooking.Controls.Add(this.label3);
            this.pnlBooking.Controls.Add(this.label8);
            this.pnlBooking.Controls.Add(this.cbClass);
            this.pnlBooking.Controls.Add(this.label11);
            this.pnlBooking.Controls.Add(this.panel2);
            this.pnlBooking.ForeColor = System.Drawing.SystemColors.GrayText;
            this.pnlBooking.Location = new System.Drawing.Point(12, 99);
            this.pnlBooking.Name = "pnlBooking";
            this.pnlBooking.Size = new System.Drawing.Size(769, 427);
            this.pnlBooking.TabIndex = 36;
            this.pnlBooking.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.Purple;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBook.Location = new System.Drawing.Point(361, 299);
            this.btnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(133, 45);
            this.btnBook.TabIndex = 46;
            this.btnBook.Text = "Book Now";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // cbSeatNo
            // 
            this.cbSeatNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeatNo.FormattingEnabled = true;
            this.cbSeatNo.Location = new System.Drawing.Point(412, 177);
            this.cbSeatNo.Name = "cbSeatNo";
            this.cbSeatNo.Size = new System.Drawing.Size(176, 30);
            this.cbSeatNo.TabIndex = 36;
            this.cbSeatNo.SelectedIndexChanged += new System.EventHandler(this.cbSeatNo_SelectedIndexChanged);
            // 
            // btnBookTrain
            // 
            this.btnBookTrain.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnBookTrain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBookTrain.FlatAppearance.BorderSize = 0;
            this.btnBookTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookTrain.ForeColor = System.Drawing.Color.Purple;
            this.btnBookTrain.Location = new System.Drawing.Point(18, 24);
            this.btnBookTrain.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookTrain.Name = "btnBookTrain";
            this.btnBookTrain.Size = new System.Drawing.Size(90, 36);
            this.btnBookTrain.TabIndex = 36;
            this.btnBookTrain.Text = "Back";
            this.btnBookTrain.UseVisualStyleBackColor = false;
            this.btnBookTrain.Click += new System.EventHandler(this.btnBookTrain_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.lb);
            this.panel2.Controls.Add(this.lblAvaliableSeats);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(227, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 53);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "End Station";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Start Station";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // dtpTrainDate
            // 
            this.dtpTrainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTrainDate.Location = new System.Drawing.Point(199, 139);
            this.dtpTrainDate.Name = "dtpTrainDate";
            this.dtpTrainDate.Size = new System.Drawing.Size(200, 28);
            this.dtpTrainDate.TabIndex = 16;
            this.dtpTrainDate.ValueChanged += new System.EventHandler(this.dtpTrainDate_ValueChanged);
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.Location = new System.Drawing.Point(199, 216);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(200, 28);
            this.txtEnd.TabIndex = 38;
            this.txtEnd.TextChanged += new System.EventHandler(this.txtEnd_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Purple;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearch.Location = new System.Drawing.Point(136, 279);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 35);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvTrainInfo
            // 
            this.dgvTrainInfo.AllowUserToDeleteRows = false;
            this.dgvTrainInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSelect,
            this.Train_No,
            this.Train_Name,
            this.Type,
            this.StartTime,
            this.ArrivalTime,
            this.Train_Id,
            this.Schedule_Id});
            this.dgvTrainInfo.Location = new System.Drawing.Point(64, 337);
            this.dgvTrainInfo.Name = "dgvTrainInfo";
            this.dgvTrainInfo.RowHeadersWidth = 10;
            this.dgvTrainInfo.RowTemplate.Height = 28;
            this.dgvTrainInfo.Size = new System.Drawing.Size(613, 189);
            this.dgvTrainInfo.TabIndex = 17;
            this.dgvTrainInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvSelect
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.YellowGreen;
            this.dgvSelect.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelect.HeaderText = "Select";
            this.dgvSelect.MinimumWidth = 8;
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelect.Width = 150;
            // 
            // Train_No
            // 
            this.Train_No.HeaderText = "Train_No";
            this.Train_No.MinimumWidth = 8;
            this.Train_No.Name = "Train_No";
            this.Train_No.Width = 150;
            // 
            // Train_Name
            // 
            this.Train_Name.HeaderText = "Train_Name";
            this.Train_Name.MinimumWidth = 8;
            this.Train_Name.Name = "Train_Name";
            this.Train_Name.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.Width = 150;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.MinimumWidth = 8;
            this.StartTime.Name = "StartTime";
            this.StartTime.Visible = false;
            this.StartTime.Width = 150;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.HeaderText = "ArrivalTime";
            this.ArrivalTime.MinimumWidth = 8;
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.Visible = false;
            this.ArrivalTime.Width = 150;
            // 
            // Train_Id
            // 
            this.Train_Id.HeaderText = "Train_Id";
            this.Train_Id.MinimumWidth = 8;
            this.Train_Id.Name = "Train_Id";
            this.Train_Id.Visible = false;
            this.Train_Id.Width = 150;
            // 
            // Schedule_Id
            // 
            this.Schedule_Id.HeaderText = "Schedule_Id";
            this.Schedule_Id.MinimumWidth = 8;
            this.Schedule_Id.Name = "Schedule_Id";
            this.Schedule_Id.Visible = false;
            this.Schedule_Id.Width = 150;
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.Location = new System.Drawing.Point(199, 174);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(200, 28);
            this.txtStart.TabIndex = 39;
            this.txtStart.TextChanged += new System.EventHandler(this.txtStart_TextChanged);
            // 
            // pnlTrain
            // 
            this.pnlTrain.BackColor = System.Drawing.Color.OldLace;
            this.pnlTrain.Controls.Add(this.btnSeatBook);
            this.pnlTrain.Controls.Add(this.lbTrainName);
            this.pnlTrain.Controls.Add(this.label9);
            this.pnlTrain.Controls.Add(this.label);
            this.pnlTrain.Controls.Add(this.lbTrainNo);
            this.pnlTrain.Controls.Add(this.label12);
            this.pnlTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTrain.Location = new System.Drawing.Point(433, 109);
            this.pnlTrain.Name = "pnlTrain";
            this.pnlTrain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlTrain.Size = new System.Drawing.Size(266, 205);
            this.pnlTrain.TabIndex = 40;
            // 
            // btnSeatBook
            // 
            this.btnSeatBook.BackColor = System.Drawing.Color.Orange;
            this.btnSeatBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeatBook.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSeatBook.Location = new System.Drawing.Point(66, 136);
            this.btnSeatBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeatBook.Name = "btnSeatBook";
            this.btnSeatBook.Size = new System.Drawing.Size(144, 44);
            this.btnSeatBook.TabIndex = 40;
            this.btnSeatBook.Text = "Book a Seat";
            this.btnSeatBook.UseVisualStyleBackColor = false;
            this.btnSeatBook.Click += new System.EventHandler(this.btnSeatBook_Click);
            // 
            // lbTrainName
            // 
            this.lbTrainName.AutoSize = true;
            this.lbTrainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrainName.Location = new System.Drawing.Point(158, 91);
            this.lbTrainName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTrainName.Name = "lbTrainName";
            this.lbTrainName.Size = new System.Drawing.Size(75, 22);
            this.lbTrainName.TabIndex = 44;
            this.lbTrainName.Text = "TrainNo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 22);
            this.label9.TabIndex = 45;
            this.label9.Text = "Arrival Time";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(51, 11);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(159, 25);
            this.label.TabIndex = 8;
            this.label.Text = "Train Schedule";
            // 
            // lbTrainNo
            // 
            this.lbTrainNo.AutoSize = true;
            this.lbTrainNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrainNo.Location = new System.Drawing.Point(158, 57);
            this.lbTrainNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTrainNo.Name = "lbTrainNo";
            this.lbTrainNo.Size = new System.Drawing.Size(75, 22);
            this.lbTrainNo.TabIndex = 37;
            this.lbTrainNo.Text = "TrainNo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 22);
            this.label12.TabIndex = 38;
            this.label12.Text = "Depature Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 22);
            this.label5.TabIndex = 41;
            this.label5.Text = "Date";
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.White;
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Controls.Add(this.lblType);
            this.pnlSummary.Controls.Add(this.label20);
            this.pnlSummary.Controls.Add(this.lblArrivalTime);
            this.pnlSummary.Controls.Add(this.lblStartTime);
            this.pnlSummary.Controls.Add(this.lblEndStation);
            this.pnlSummary.Controls.Add(this.lblStartStation);
            this.pnlSummary.Controls.Add(this.lblTrainName);
            this.pnlSummary.Controls.Add(this.lblTrainNo);
            this.pnlSummary.Controls.Add(this.button1);
            this.pnlSummary.Controls.Add(this.lblSearInfo);
            this.pnlSummary.Controls.Add(this.label19);
            this.pnlSummary.Controls.Add(this.lblNic);
            this.pnlSummary.Controls.Add(this.label17);
            this.pnlSummary.Controls.Add(this.label16);
            this.pnlSummary.Controls.Add(this.label15);
            this.pnlSummary.Controls.Add(this.label14);
            this.pnlSummary.Controls.Add(this.label13);
            this.pnlSummary.Controls.Add(this.label10);
            this.pnlSummary.Controls.Add(this.label7);
            this.pnlSummary.Controls.Add(this.label6);
            this.pnlSummary.Location = new System.Drawing.Point(30, 99);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(793, 513);
            this.pnlSummary.TabIndex = 42;
            this.pnlSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSummary_Paint);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblType.Location = new System.Drawing.Point(437, 139);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(20, 23);
            this.lblType.TabIndex = 45;
            this.lblType.Text = "1";
            this.lblType.Click += new System.EventHandler(this.label18_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(316, 139);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 23);
            this.label20.TabIndex = 44;
            this.label20.Text = "Type";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblArrivalTime.Location = new System.Drawing.Point(581, 239);
            this.lblArrivalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(20, 23);
            this.lblArrivalTime.TabIndex = 43;
            this.lblArrivalTime.Text = "1";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartTime.Location = new System.Drawing.Point(581, 200);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(20, 23);
            this.lblStartTime.TabIndex = 42;
            this.lblStartTime.Text = "1";
            // 
            // lblEndStation
            // 
            this.lblEndStation.AutoSize = true;
            this.lblEndStation.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndStation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEndStation.Location = new System.Drawing.Point(322, 239);
            this.lblEndStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndStation.Name = "lblEndStation";
            this.lblEndStation.Size = new System.Drawing.Size(20, 23);
            this.lblEndStation.TabIndex = 41;
            this.lblEndStation.Text = "1";
            // 
            // lblStartStation
            // 
            this.lblStartStation.AutoSize = true;
            this.lblStartStation.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartStation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartStation.Location = new System.Drawing.Point(322, 199);
            this.lblStartStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartStation.Name = "lblStartStation";
            this.lblStartStation.Size = new System.Drawing.Size(20, 23);
            this.lblStartStation.TabIndex = 40;
            this.lblStartStation.Text = "1";
            // 
            // lblTrainName
            // 
            this.lblTrainName.AutoSize = true;
            this.lblTrainName.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTrainName.Location = new System.Drawing.Point(437, 105);
            this.lblTrainName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrainName.Name = "lblTrainName";
            this.lblTrainName.Size = new System.Drawing.Size(20, 23);
            this.lblTrainName.TabIndex = 39;
            this.lblTrainName.Text = "1";
            // 
            // lblTrainNo
            // 
            this.lblTrainNo.AutoSize = true;
            this.lblTrainNo.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTrainNo.Location = new System.Drawing.Point(437, 70);
            this.lblTrainNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrainNo.Name = "lblTrainNo";
            this.lblTrainNo.Size = new System.Drawing.Size(20, 23);
            this.lblTrainNo.TabIndex = 38;
            this.lblTrainNo.Text = "1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(674, 455);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 36);
            this.button1.TabIndex = 37;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblSearInfo
            // 
            this.lblSearInfo.AutoSize = true;
            this.lblSearInfo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSearInfo.Location = new System.Drawing.Point(301, 397);
            this.lblSearInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearInfo.Name = "lblSearInfo";
            this.lblSearInfo.Size = new System.Drawing.Size(168, 31);
            this.lblSearInfo.TabIndex = 36;
            this.lblSearInfo.Text = "First Class - 12";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(356, 361);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 23);
            this.label19.TabIndex = 35;
            this.label19.Text = "Seats";
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNic.Location = new System.Drawing.Point(301, 312);
            this.lblNic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(157, 31);
            this.lblNic.TabIndex = 34;
            this.lblNic.Text = "20023892138";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(356, 289);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 23);
            this.label17.TabIndex = 33;
            this.label17.Text = "NIC";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(428, 239);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 23);
            this.label16.TabIndex = 32;
            this.label16.Text = "Arrival Time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(428, 199);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 23);
            this.label15.TabIndex = 31;
            this.label15.Text = "Depature Time";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(199, 239);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 23);
            this.label14.TabIndex = 30;
            this.label14.Text = "End Station";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(199, 199);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 23);
            this.label13.TabIndex = 29;
            this.label13.Text = "Start Station";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(314, 105);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 28;
            this.label10.Text = "Train Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(314, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Train No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(302, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 29);
            this.label6.TabIndex = 26;
            this.label6.Text = "Booking Summary";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(869, 626);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlBooking);
            this.Controls.Add(this.dtpTrainDate);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvTrainInfo);
            this.Controls.Add(this.pnlTrain);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBooking.ResumeLayout(false);
            this.pnlBooking.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainInfo)).EndInit();
            this.pnlTrain.ResumeLayout(false);
            this.pnlTrain.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAvaliableSeats;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Panel pnlBooking;
        private System.Windows.Forms.ComboBox cbSeatNo;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.DataGridView dgvTrainInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.DateTimePicker dtpTrainDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlTrain;
        private System.Windows.Forms.Button btnSeatBook;
        private System.Windows.Forms.Label lbTrainName;
        private System.Windows.Forms.Button btnBookTrain;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbTrainNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewButtonColumn dgvSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Train_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Train_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Train_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schedule_Id;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSearInfo;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndStation;
        private System.Windows.Forms.Label lblStartStation;
        private System.Windows.Forms.Label lblTrainName;
        private System.Windows.Forms.Label lblTrainNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
    }
}

