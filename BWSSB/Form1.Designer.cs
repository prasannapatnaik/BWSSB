namespace BWSSB
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
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbl_dixerror = new System.Windows.Forms.Label();
            this.bttn_status = new System.Windows.Forms.Button();
            this.gridview_status = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_locations = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txt_ToDt = new System.Windows.Forms.TextBox();
            this.txt_fromDt = new System.Windows.Forms.TextBox();
            this.bttn_process = new System.Windows.Forms.Button();
            this.cal_ToDt = new System.Windows.Forms.MonthCalendar();
            this.cal_fromdt = new System.Windows.Forms.MonthCalendar();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_msg2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_TimeSchedule = new System.Windows.Forms.Label();
            this.lbl_timex = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Timex = new System.Windows.Forms.NumericUpDown();
            this.Time_Mins = new System.Windows.Forms.NumericUpDown();
            this.time_Hour = new System.Windows.Forms.NumericUpDown();
            this.Chk_Time = new System.Windows.Forms.CheckBox();
            this.bttn_stopprogress = new System.Windows.Forms.Button();
            this.bttn_startprogress = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bttn_FaultyFolder = new System.Windows.Forms.Button();
            this.txt_faultyFolder = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.bttn_FtpBrowse = new System.Windows.Forms.Button();
            this.bttn_LocBrowse = new System.Windows.Forms.Button();
            this.txt_FTPFolder = new System.Windows.Forms.TextBox();
            this.txt_localpath = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.dp_passive = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dp_binary = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bttn_ftpconnect = new System.Windows.Forms.Button();
            this.txt_PortNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ftppassword = new System.Windows.Forms.TextBox();
            this.txt_ftpurl = new System.Windows.Forms.TextBox();
            this.txt_ftpusername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_msgserver = new System.Windows.Forms.Label();
            this.bttn_Connect = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_dbname = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.bttn_Verify = new System.Windows.Forms.Button();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_Sno_update = new System.Windows.Forms.Label();
            this.Chk_Update = new System.Windows.Forms.CheckBox();
            this.bttn_Validate = new System.Windows.Forms.Button();
            this.txt_SNo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lbl_SNo = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbl_ValidTo = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lbl_ValidFrom = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.Time_HoursInt = new System.Windows.Forms.NumericUpDown();
            this.countermsg = new System.Windows.Forms.Label();
            this.lbl_filegen = new System.Windows.Forms.Label();
            this.bWSSBDataSet = new BWSSB.BWSSBDataSet();
            this.syncBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.syncTableAdapter = new BWSSB.BWSSBDataSetTableAdapters.SyncTableAdapter();
            this.chk_autostart = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_status)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Timex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Mins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_Hour)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Time_HoursInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bWSSBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syncBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(2, 519);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 22);
            this.panel1.TabIndex = 34;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(438, 4);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "info@envirosafetysolutions.in";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Enviro Safety Private Limited";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbl_dixerror);
            this.tabPage4.Controls.Add(this.bttn_status);
            this.tabPage4.Controls.Add(this.gridview_status);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(585, 461);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Status";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lbl_dixerror
            // 
            this.lbl_dixerror.AutoSize = true;
            this.lbl_dixerror.Location = new System.Drawing.Point(8, 422);
            this.lbl_dixerror.Name = "lbl_dixerror";
            this.lbl_dixerror.Size = new System.Drawing.Size(13, 13);
            this.lbl_dixerror.TabIndex = 2;
            this.lbl_dixerror.Text = "0";
            // 
            // bttn_status
            // 
            this.bttn_status.Location = new System.Drawing.Point(503, 417);
            this.bttn_status.Name = "bttn_status";
            this.bttn_status.Size = new System.Drawing.Size(75, 23);
            this.bttn_status.TabIndex = 1;
            this.bttn_status.Text = "Refresh";
            this.bttn_status.UseVisualStyleBackColor = true;
            this.bttn_status.Click += new System.EventHandler(this.bttn_status_Click);
            // 
            // gridview_status
            // 
            this.gridview_status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_status.Location = new System.Drawing.Point(3, 3);
            this.gridview_status.Name = "gridview_status";
            this.gridview_status.Size = new System.Drawing.Size(575, 408);
            this.gridview_status.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_locations);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.progressBar1);
            this.tabPage3.Controls.Add(this.txt_ToDt);
            this.tabPage3.Controls.Add(this.txt_fromDt);
            this.tabPage3.Controls.Add(this.bttn_process);
            this.tabPage3.Controls.Add(this.cal_ToDt);
            this.tabPage3.Controls.Add(this.cal_fromdt);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(585, 461);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manual Transfer";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // txt_locations
            // 
            this.txt_locations.AutoSize = true;
            this.txt_locations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_locations.Location = new System.Drawing.Point(103, 226);
            this.txt_locations.Name = "txt_locations";
            this.txt_locations.Size = new System.Drawing.Size(28, 13);
            this.txt_locations.TabIndex = 9;
            this.txt_locations.Text = "000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Distinct Locations";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 205);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(547, 10);
            this.progressBar1.TabIndex = 7;
            // 
            // txt_ToDt
            // 
            this.txt_ToDt.Location = new System.Drawing.Point(352, 17);
            this.txt_ToDt.Name = "txt_ToDt";
            this.txt_ToDt.ReadOnly = true;
            this.txt_ToDt.Size = new System.Drawing.Size(136, 20);
            this.txt_ToDt.TabIndex = 6;
            // 
            // txt_fromDt
            // 
            this.txt_fromDt.Location = new System.Drawing.Point(42, 17);
            this.txt_fromDt.Name = "txt_fromDt";
            this.txt_fromDt.ReadOnly = true;
            this.txt_fromDt.Size = new System.Drawing.Size(136, 20);
            this.txt_fromDt.TabIndex = 5;
            // 
            // bttn_process
            // 
            this.bttn_process.Enabled = false;
            this.bttn_process.Location = new System.Drawing.Point(481, 221);
            this.bttn_process.Name = "bttn_process";
            this.bttn_process.Size = new System.Drawing.Size(75, 23);
            this.bttn_process.TabIndex = 4;
            this.bttn_process.Text = "Process";
            this.bttn_process.UseVisualStyleBackColor = true;
            this.bttn_process.Click += new System.EventHandler(this.bttn_process_Click);
            // 
            // cal_ToDt
            // 
            this.cal_ToDt.Location = new System.Drawing.Point(329, 42);
            this.cal_ToDt.MaxSelectionCount = 1;
            this.cal_ToDt.Name = "cal_ToDt";
            this.cal_ToDt.TabIndex = 3;
            this.cal_ToDt.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cal_ToDt_DateSelected);
            // 
            // cal_fromdt
            // 
            this.cal_fromdt.Location = new System.Drawing.Point(9, 42);
            this.cal_fromdt.MaxSelectionCount = 1;
            this.cal_fromdt.Name = "cal_fromdt";
            this.cal_fromdt.TabIndex = 2;
            this.cal_fromdt.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cal_fromdt_DateSelected);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(326, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "To";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "From";
            // 
            // lbl_msg2
            // 
            this.lbl_msg2.AutoSize = true;
            this.lbl_msg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_msg2.Location = new System.Drawing.Point(446, 496);
            this.lbl_msg2.Name = "lbl_msg2";
            this.lbl_msg2.Size = new System.Drawing.Size(26, 17);
            this.lbl_msg2.TabIndex = 10;
            this.lbl_msg2.Text = "00";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_TimeSchedule);
            this.tabPage1.Controls.Add(this.lbl_timex);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.Timex);
            this.tabPage1.Controls.Add(this.Time_Mins);
            this.tabPage1.Controls.Add(this.time_Hour);
            this.tabPage1.Controls.Add(this.Chk_Time);
            this.tabPage1.Controls.Add(this.bttn_stopprogress);
            this.tabPage1.Controls.Add(this.bttn_startprogress);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(585, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_TimeSchedule
            // 
            this.lbl_TimeSchedule.AutoSize = true;
            this.lbl_TimeSchedule.Location = new System.Drawing.Point(223, 440);
            this.lbl_TimeSchedule.Name = "lbl_TimeSchedule";
            this.lbl_TimeSchedule.Size = new System.Drawing.Size(34, 13);
            this.lbl_TimeSchedule.TabIndex = 29;
            this.lbl_TimeSchedule.Text = "00:00";
            // 
            // lbl_timex
            // 
            this.lbl_timex.AutoSize = true;
            this.lbl_timex.Location = new System.Drawing.Point(397, 440);
            this.lbl_timex.Name = "lbl_timex";
            this.lbl_timex.Size = new System.Drawing.Size(19, 13);
            this.lbl_timex.TabIndex = 41;
            this.lbl_timex.Text = "00";
            this.lbl_timex.Click += new System.EventHandler(this.lbl_timex_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(268, 439);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Hours Intervel";
            // 
            // Timex
            // 
            this.Timex.Location = new System.Drawing.Point(351, 437);
            this.Timex.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.Timex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Timex.Name = "Timex";
            this.Timex.Size = new System.Drawing.Size(45, 20);
            this.Timex.TabIndex = 37;
            this.Timex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Timex.ValueChanged += new System.EventHandler(this.Timex_ValueChanged);
            // 
            // Time_Mins
            // 
            this.Time_Mins.Enabled = false;
            this.Time_Mins.Location = new System.Drawing.Point(174, 437);
            this.Time_Mins.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Time_Mins.Name = "Time_Mins";
            this.Time_Mins.Size = new System.Drawing.Size(45, 20);
            this.Time_Mins.TabIndex = 27;
            this.Time_Mins.ValueChanged += new System.EventHandler(this.Time_Mins_ValueChanged);
            // 
            // time_Hour
            // 
            this.time_Hour.Enabled = false;
            this.time_Hour.Location = new System.Drawing.Point(123, 437);
            this.time_Hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.time_Hour.Name = "time_Hour";
            this.time_Hour.Size = new System.Drawing.Size(45, 20);
            this.time_Hour.TabIndex = 26;
            this.time_Hour.ValueChanged += new System.EventHandler(this.time_Hour_ValueChanged);
            // 
            // Chk_Time
            // 
            this.Chk_Time.AutoSize = true;
            this.Chk_Time.Location = new System.Drawing.Point(5, 438);
            this.Chk_Time.Name = "Chk_Time";
            this.Chk_Time.Size = new System.Drawing.Size(119, 17);
            this.Chk_Time.TabIndex = 23;
            this.Chk_Time.Text = "Time Bound Trigger";
            this.Chk_Time.UseVisualStyleBackColor = true;
            this.Chk_Time.CheckedChanged += new System.EventHandler(this.Chk_Time_CheckedChanged);
            // 
            // bttn_stopprogress
            // 
            this.bttn_stopprogress.Enabled = false;
            this.bttn_stopprogress.Location = new System.Drawing.Point(505, 435);
            this.bttn_stopprogress.Name = "bttn_stopprogress";
            this.bttn_stopprogress.Size = new System.Drawing.Size(75, 23);
            this.bttn_stopprogress.TabIndex = 22;
            this.bttn_stopprogress.Text = "Stop";
            this.bttn_stopprogress.UseVisualStyleBackColor = true;
            this.bttn_stopprogress.Click += new System.EventHandler(this.bttn_stopprogress_Click);
            // 
            // bttn_startprogress
            // 
            this.bttn_startprogress.Enabled = false;
            this.bttn_startprogress.Location = new System.Drawing.Point(424, 436);
            this.bttn_startprogress.Name = "bttn_startprogress";
            this.bttn_startprogress.Size = new System.Drawing.Size(75, 23);
            this.bttn_startprogress.TabIndex = 0;
            this.bttn_startprogress.Text = "Start";
            this.bttn_startprogress.UseVisualStyleBackColor = true;
            this.bttn_startprogress.Click += new System.EventHandler(this.bttn_startprogress_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttn_FaultyFolder);
            this.groupBox3.Controls.Add(this.txt_faultyFolder);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.bttn_FtpBrowse);
            this.groupBox3.Controls.Add(this.bttn_LocBrowse);
            this.groupBox3.Controls.Add(this.txt_FTPFolder);
            this.groupBox3.Controls.Add(this.txt_localpath);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(8, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 138);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Folder Configuration";
            // 
            // bttn_FaultyFolder
            // 
            this.bttn_FaultyFolder.Location = new System.Drawing.Point(422, 96);
            this.bttn_FaultyFolder.Name = "bttn_FaultyFolder";
            this.bttn_FaultyFolder.Size = new System.Drawing.Size(75, 23);
            this.bttn_FaultyFolder.TabIndex = 2;
            this.bttn_FaultyFolder.Text = "Browse";
            this.bttn_FaultyFolder.UseVisualStyleBackColor = true;
            this.bttn_FaultyFolder.Click += new System.EventHandler(this.bttn_FaultyFolder_Click);
            // 
            // txt_faultyFolder
            // 
            this.txt_faultyFolder.Location = new System.Drawing.Point(101, 98);
            this.txt_faultyFolder.Name = "txt_faultyFolder";
            this.txt_faultyFolder.Size = new System.Drawing.Size(288, 20);
            this.txt_faultyFolder.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Faulty Folder ";
            // 
            // bttn_FtpBrowse
            // 
            this.bttn_FtpBrowse.Location = new System.Drawing.Point(422, 57);
            this.bttn_FtpBrowse.Name = "bttn_FtpBrowse";
            this.bttn_FtpBrowse.Size = new System.Drawing.Size(75, 23);
            this.bttn_FtpBrowse.TabIndex = 26;
            this.bttn_FtpBrowse.Text = "Insert Path";
            this.bttn_FtpBrowse.UseVisualStyleBackColor = true;
            this.bttn_FtpBrowse.Click += new System.EventHandler(this.bttn_FtpBrowse_Click);
            // 
            // bttn_LocBrowse
            // 
            this.bttn_LocBrowse.Location = new System.Drawing.Point(422, 17);
            this.bttn_LocBrowse.Name = "bttn_LocBrowse";
            this.bttn_LocBrowse.Size = new System.Drawing.Size(75, 23);
            this.bttn_LocBrowse.TabIndex = 0;
            this.bttn_LocBrowse.Text = "Browse";
            this.bttn_LocBrowse.UseVisualStyleBackColor = true;
            this.bttn_LocBrowse.Click += new System.EventHandler(this.bttn_LocBrowse_Click);
            // 
            // txt_FTPFolder
            // 
            this.txt_FTPFolder.Location = new System.Drawing.Point(101, 59);
            this.txt_FTPFolder.Name = "txt_FTPFolder";
            this.txt_FTPFolder.Size = new System.Drawing.Size(288, 20);
            this.txt_FTPFolder.TabIndex = 1;
            this.txt_FTPFolder.MouseHover += new System.EventHandler(this.txt_FTPFolder_MouseHover);
            // 
            // txt_localpath
            // 
            this.txt_localpath.Location = new System.Drawing.Point(101, 19);
            this.txt_localpath.Name = "txt_localpath";
            this.txt_localpath.Size = new System.Drawing.Size(288, 20);
            this.txt_localpath.TabIndex = 23;
            this.txt_localpath.TextChanged += new System.EventHandler(this.txt_localpath_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "FTP Folder ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Local Folder ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_msg);
            this.groupBox2.Controls.Add(this.dp_passive);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dp_binary);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.bttn_ftpconnect);
            this.groupBox2.Controls.Add(this.txt_PortNo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_ftppassword);
            this.groupBox2.Controls.Add(this.txt_ftpurl);
            this.groupBox2.Controls.Add(this.txt_ftpusername);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(8, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FTP Connection";
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(22, 103);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(19, 13);
            this.lbl_msg.TabIndex = 1;
            this.lbl_msg.Text = "00";
            // 
            // dp_passive
            // 
            this.dp_passive.FormattingEnabled = true;
            this.dp_passive.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.dp_passive.Location = new System.Drawing.Point(289, 75);
            this.dp_passive.Name = "dp_passive";
            this.dp_passive.Size = new System.Drawing.Size(100, 21);
            this.dp_passive.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Use Passive";
            // 
            // dp_binary
            // 
            this.dp_binary.FormattingEnabled = true;
            this.dp_binary.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.dp_binary.Location = new System.Drawing.Point(101, 75);
            this.dp_binary.Name = "dp_binary";
            this.dp_binary.Size = new System.Drawing.Size(100, 21);
            this.dp_binary.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Binary Status";
            // 
            // bttn_ftpconnect
            // 
            this.bttn_ftpconnect.Location = new System.Drawing.Point(462, 21);
            this.bttn_ftpconnect.Name = "bttn_ftpconnect";
            this.bttn_ftpconnect.Size = new System.Drawing.Size(75, 23);
            this.bttn_ftpconnect.TabIndex = 4;
            this.bttn_ftpconnect.Text = "Connect";
            this.bttn_ftpconnect.UseVisualStyleBackColor = true;
            this.bttn_ftpconnect.Click += new System.EventHandler(this.bttn_ftpconnect_Click);
            // 
            // txt_PortNo
            // 
            this.txt_PortNo.Location = new System.Drawing.Point(289, 23);
            this.txt_PortNo.Name = "txt_PortNo";
            this.txt_PortNo.Size = new System.Drawing.Size(100, 20);
            this.txt_PortNo.TabIndex = 1;
            this.txt_PortNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "PORT";
            // 
            // txt_ftppassword
            // 
            this.txt_ftppassword.Location = new System.Drawing.Point(289, 49);
            this.txt_ftppassword.Name = "txt_ftppassword";
            this.txt_ftppassword.PasswordChar = '*';
            this.txt_ftppassword.Size = new System.Drawing.Size(100, 20);
            this.txt_ftppassword.TabIndex = 3;
            this.txt_ftppassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ftpurl
            // 
            this.txt_ftpurl.Location = new System.Drawing.Point(101, 23);
            this.txt_ftpurl.Name = "txt_ftpurl";
            this.txt_ftpurl.Size = new System.Drawing.Size(100, 20);
            this.txt_ftpurl.TabIndex = 0;
            this.txt_ftpurl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ftpusername
            // 
            this.txt_ftpusername.Location = new System.Drawing.Point(101, 49);
            this.txt_ftpusername.Name = "txt_ftpusername";
            this.txt_ftpusername.Size = new System.Drawing.Size(100, 20);
            this.txt_ftpusername.TabIndex = 2;
            this.txt_ftpusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "UserName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "FTP URL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_msgserver);
            this.groupBox1.Controls.Add(this.bttn_Connect);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.txt_dbname);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.bttn_Verify);
            this.groupBox1.Controls.Add(this.txt_server);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datagate Server Connection";
            // 
            // lbl_msgserver
            // 
            this.lbl_msgserver.AutoSize = true;
            this.lbl_msgserver.Location = new System.Drawing.Point(22, 81);
            this.lbl_msgserver.Name = "lbl_msgserver";
            this.lbl_msgserver.Size = new System.Drawing.Size(19, 13);
            this.lbl_msgserver.TabIndex = 11;
            this.lbl_msgserver.Text = "00";
            // 
            // bttn_Connect
            // 
            this.bttn_Connect.Location = new System.Drawing.Point(462, 47);
            this.bttn_Connect.Name = "bttn_Connect";
            this.bttn_Connect.Size = new System.Drawing.Size(75, 23);
            this.bttn_Connect.TabIndex = 10;
            this.bttn_Connect.Text = "Connect";
            this.bttn_Connect.UseVisualStyleBackColor = true;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(289, 49);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 3;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_dbname
            // 
            this.txt_dbname.Location = new System.Drawing.Point(289, 23);
            this.txt_dbname.Name = "txt_dbname";
            this.txt_dbname.Size = new System.Drawing.Size(100, 20);
            this.txt_dbname.TabIndex = 1;
            this.txt_dbname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(101, 49);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 20);
            this.txt_username.TabIndex = 2;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttn_Verify
            // 
            this.bttn_Verify.Location = new System.Drawing.Point(462, 21);
            this.bttn_Verify.Name = "bttn_Verify";
            this.bttn_Verify.Size = new System.Drawing.Size(75, 23);
            this.bttn_Verify.TabIndex = 4;
            this.bttn_Verify.Text = "Verify";
            this.bttn_Verify.UseVisualStyleBackColor = true;
            this.bttn_Verify.Click += new System.EventHandler(this.bttn_Verify_Click);
            // 
            // txt_server
            // 
            this.txt_server.Location = new System.Drawing.Point(101, 23);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(100, 20);
            this.txt_server.TabIndex = 0;
            this.txt_server.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 487);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_Sno_update);
            this.tabPage2.Controls.Add(this.Chk_Update);
            this.tabPage2.Controls.Add(this.bttn_Validate);
            this.tabPage2.Controls.Add(this.txt_SNo);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(585, 461);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "About";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_Sno_update
            // 
            this.lbl_Sno_update.AutoSize = true;
            this.lbl_Sno_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sno_update.Location = new System.Drawing.Point(292, 178);
            this.lbl_Sno_update.Name = "lbl_Sno_update";
            this.lbl_Sno_update.Size = new System.Drawing.Size(15, 15);
            this.lbl_Sno_update.TabIndex = 5;
            this.lbl_Sno_update.Text = "0";
            // 
            // Chk_Update
            // 
            this.Chk_Update.AutoSize = true;
            this.Chk_Update.Location = new System.Drawing.Point(419, 156);
            this.Chk_Update.Name = "Chk_Update";
            this.Chk_Update.Size = new System.Drawing.Size(130, 17);
            this.Chk_Update.TabIndex = 4;
            this.Chk_Update.Text = "Update Serial Number";
            this.Chk_Update.UseVisualStyleBackColor = true;
            this.Chk_Update.CheckedChanged += new System.EventHandler(this.Chk_Update_CheckedChanged);
            // 
            // bttn_Validate
            // 
            this.bttn_Validate.Enabled = false;
            this.bttn_Validate.Location = new System.Drawing.Point(295, 152);
            this.bttn_Validate.Name = "bttn_Validate";
            this.bttn_Validate.Size = new System.Drawing.Size(75, 23);
            this.bttn_Validate.TabIndex = 3;
            this.bttn_Validate.Text = "Validate";
            this.bttn_Validate.UseVisualStyleBackColor = true;
            this.bttn_Validate.Click += new System.EventHandler(this.bttn_Validate_Click);
            // 
            // txt_SNo
            // 
            this.txt_SNo.Location = new System.Drawing.Point(111, 154);
            this.txt_SNo.Name = "txt_SNo";
            this.txt_SNo.Size = new System.Drawing.Size(165, 20);
            this.txt_SNo.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 157);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Licence Number";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chk_autostart);
            this.groupBox4.Controls.Add(this.txt_Key);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.txt_Name);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.lbl_SNo);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.lbl_ValidTo);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.lbl_ValidFrom);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Location = new System.Drawing.Point(6, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(572, 137);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "About Us";
            // 
            // txt_Key
            // 
            this.txt_Key.Location = new System.Drawing.Point(307, 111);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.ReadOnly = true;
            this.txt_Key.Size = new System.Drawing.Size(233, 20);
            this.txt_Key.TabIndex = 8;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(276, 114);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(25, 13);
            this.label27.TabIndex = 9;
            this.label27.Text = "Key";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(307, 68);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(233, 20);
            this.txt_Name.TabIndex = 3;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(240, 71);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(61, 13);
            this.label26.TabIndex = 4;
            this.label26.Text = "Licence To";
            // 
            // lbl_SNo
            // 
            this.lbl_SNo.AutoSize = true;
            this.lbl_SNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SNo.Location = new System.Drawing.Point(95, 114);
            this.lbl_SNo.Name = "lbl_SNo";
            this.lbl_SNo.Size = new System.Drawing.Size(14, 13);
            this.lbl_SNo.TabIndex = 7;
            this.lbl_SNo.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(27, 114);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 13);
            this.label25.TabIndex = 6;
            this.label25.Text = "System No.  : ";
            // 
            // lbl_ValidTo
            // 
            this.lbl_ValidTo.AutoSize = true;
            this.lbl_ValidTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValidTo.Location = new System.Drawing.Point(95, 92);
            this.lbl_ValidTo.Name = "lbl_ValidTo";
            this.lbl_ValidTo.Size = new System.Drawing.Size(14, 13);
            this.lbl_ValidTo.TabIndex = 5;
            this.lbl_ValidTo.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(27, 71);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 13);
            this.label24.TabIndex = 4;
            this.label24.Text = "Valid From :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(27, 92);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 3;
            this.label23.Text = "Valid To : ";
            // 
            // lbl_ValidFrom
            // 
            this.lbl_ValidFrom.AutoSize = true;
            this.lbl_ValidFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValidFrom.Location = new System.Drawing.Point(95, 71);
            this.lbl_ValidFrom.Name = "lbl_ValidFrom";
            this.lbl_ValidFrom.Size = new System.Drawing.Size(14, 13);
            this.lbl_ValidFrom.TabIndex = 2;
            this.lbl_ValidFrom.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(27, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(149, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Contact : +91(0) 22 42039999";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(211, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Designed By : Enviro Safety Private Limited";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(38, 493);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "File Generation (in Hrs)";
            // 
            // Time_HoursInt
            // 
            this.Time_HoursInt.Location = new System.Drawing.Point(157, 491);
            this.Time_HoursInt.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.Time_HoursInt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Time_HoursInt.Name = "Time_HoursInt";
            this.Time_HoursInt.Size = new System.Drawing.Size(45, 20);
            this.Time_HoursInt.TabIndex = 35;
            this.Time_HoursInt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Time_HoursInt.ValueChanged += new System.EventHandler(this.Time_HoursInt_ValueChanged);
            this.Time_HoursInt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Time_HoursInt_MouseClick);
            // 
            // countermsg
            // 
            this.countermsg.AutoSize = true;
            this.countermsg.Location = new System.Drawing.Point(228, 495);
            this.countermsg.Name = "countermsg";
            this.countermsg.Size = new System.Drawing.Size(19, 13);
            this.countermsg.TabIndex = 39;
            this.countermsg.Text = "00";
            // 
            // lbl_filegen
            // 
            this.lbl_filegen.AutoSize = true;
            this.lbl_filegen.Location = new System.Drawing.Point(205, 495);
            this.lbl_filegen.Name = "lbl_filegen";
            this.lbl_filegen.Size = new System.Drawing.Size(19, 13);
            this.lbl_filegen.TabIndex = 40;
            this.lbl_filegen.Text = "00";
            // 
            // bWSSBDataSet
            // 
            this.bWSSBDataSet.DataSetName = "BWSSBDataSet";
            this.bWSSBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // syncBindingSource
            // 
            this.syncBindingSource.DataMember = "Sync";
            this.syncBindingSource.DataSource = this.bWSSBDataSet;
            // 
            // syncTableAdapter
            // 
            this.syncTableAdapter.ClearBeforeFill = true;
            // 
            // chk_autostart
            // 
            this.chk_autostart.AutoSize = true;
            this.chk_autostart.Location = new System.Drawing.Point(307, 26);
            this.chk_autostart.Name = "chk_autostart";
            this.chk_autostart.Size = new System.Drawing.Size(125, 17);
            this.chk_autostart.TabIndex = 6;
            this.chk_autostart.Text = "Auto Start on Startup";
            this.chk_autostart.UseVisualStyleBackColor = true;
            this.chk_autostart.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 541);
            this.Controls.Add(this.lbl_filegen);
            this.Controls.Add(this.lbl_msg2);
            this.Controls.Add(this.countermsg);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Time_HoursInt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Datagate to FTP Convertor & Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_status)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Timex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Mins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_Hour)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Time_HoursInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bWSSBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syncBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label13;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BWSSBDataSet bWSSBDataSet;
        private System.Windows.Forms.BindingSource syncBindingSource;
        private BWSSBDataSetTableAdapters.SyncTableAdapter syncTableAdapter;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button bttn_status;
        private System.Windows.Forms.DataGridView gridview_status;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbl_msg2;
        private System.Windows.Forms.Label txt_locations;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txt_ToDt;
        private System.Windows.Forms.TextBox txt_fromDt;
        private System.Windows.Forms.Button bttn_process;
        private System.Windows.Forms.MonthCalendar cal_ToDt;
        private System.Windows.Forms.MonthCalendar cal_fromdt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bttn_stopprogress;
        private System.Windows.Forms.Button bttn_startprogress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bttn_FaultyFolder;
        private System.Windows.Forms.TextBox txt_faultyFolder;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button bttn_FtpBrowse;
        private System.Windows.Forms.Button bttn_LocBrowse;
        private System.Windows.Forms.TextBox txt_FTPFolder;
        private System.Windows.Forms.TextBox txt_localpath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.ComboBox dp_passive;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox dp_binary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bttn_ftpconnect;
        private System.Windows.Forms.TextBox txt_PortNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ftppassword;
        private System.Windows.Forms.TextBox txt_ftpurl;
        private System.Windows.Forms.TextBox txt_ftpusername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_msgserver;
        private System.Windows.Forms.Button bttn_Connect;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_dbname;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button bttn_Verify;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown Time_Mins;
        private System.Windows.Forms.NumericUpDown time_Hour;
        private System.Windows.Forms.CheckBox Chk_Time;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown Time_HoursInt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown Timex;
        private System.Windows.Forms.Label countermsg;
        private System.Windows.Forms.Label lbl_timex;
        private System.Windows.Forms.Label lbl_filegen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bttn_Validate;
        private System.Windows.Forms.TextBox txt_SNo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lbl_SNo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbl_ValidTo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbl_ValidFrom;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl_TimeSchedule;
        private System.Windows.Forms.Label lbl_dixerror;
        private System.Windows.Forms.CheckBox Chk_Update;
        private System.Windows.Forms.Label lbl_Sno_update;
        private System.Windows.Forms.TextBox txt_Key;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox chk_autostart;

    }
}

