using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using WinSCP;
using System.Management;
using Microsoft.Win32;
using System.Timers;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace BWSSB
{
    public partial class Form1 : Form
    {
        RegistryKey reg=Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run",true);
        string RemoteFtpPath,Remotepath,Remotepath2  = "";
        int counter = 0;
        int rotate = 0;
        //Boolean UseBinary;
        //Boolean UsePassive;
        SqlCommand cmd = new SqlCommand();
        SqlConnection hwmcon, bwssbcon;
        int success = 0;
        string query3 = "";
        string mispath = "";
        string typeprocess,Autochk = "";
        string hours = "";
        string mins,Sch = "";
        System.Timers.Timer timer1;
        System.Windows.Forms.Timer timer2,timer3;
        SessionOptions sessionOptions;
        String dt1, dt2 = "";
        Session session;
        //int count;
        private readonly SynchronizationContext synchronizationContext;  
        public Form1()
        {
            
            //reg.SetValue("FTPScheduler", Application.ExecutablePath.ToString());
            InitializeComponent();
            synchronizationContext = SynchronizationContext.Current; //context from UI thread  
            
        }

        private void bttn_ftpconnect_Click(object sender, EventArgs e)
        {
            //RemoteFtpPath = "ftp://"+txt_ftpurl.Text;
            //Port = Convert.ToInt32(txt_PortNo.Text);
            //RemoteFileName = "TheDataFile.txt";
            //LocalDestinationFilename = "TheDataFile.txt";
            //Username = txt_ftpusername.Text;
            //Password = txt_ftppassword.Text;
            if (txt_ftpurl.Text != "")
            {
                Properties.Settings.Default["FTPServer"] = txt_ftpurl.Text;
                Properties.Settings.Default["PORT"] = txt_PortNo.Text;
                Properties.Settings.Default["FTPUserName"] = txt_ftpusername.Text;
                Properties.Settings.Default["FTPPassword"] = txt_ftppassword.Text;

                Properties.Settings.Default.Save();
            }
            
        }

        private void FTPPush(string path, string location, string filename)
        {
            try
            {
                // Set up session options
                sessionOptions = new SessionOptions
                {

                    //Protocol = Protocol.Ftp,
                    //HostName = "182.156.215.230",
                    //PortNumber = 21,
                    //UserName = "admin",
                    //Password = "meter$#2018",

                    //Protocol = Protocol.Ftp,
                    //HostName = "ftp.quickarry.com",
                    //PortNumber = 21,
                    //UserName = "prasanna@quickarry.com",
                    //Password = "Enviro@123",

                    Protocol = Protocol.Ftp,
                    HostName = txt_ftpurl.Text,
                    PortNumber = Convert.ToInt32(txt_PortNo.Text),
                    UserName = txt_ftpusername.Text,
                    Password = txt_ftppassword.Text,
                };

                using (session = new Session())
                {
                    // Connect
                    session.Open(sessionOptions);
                    bttn_ftpconnect.BackColor = Color.Green;

                    if (string.IsNullOrEmpty(path))
                    {

                    }
                    else
                    {
                        RemoteFtpPath = txt_FTPFolder.Text;
                        //if (!File.Exists("/public_html/HWM/" + location + "/"+filename+".txt"))
                        if (!File.Exists(RemoteFtpPath + location + "/" + filename + ".txt"))
                        {

                            // Upload files
                            TransferOptions transferOptions = new TransferOptions();
                            transferOptions.TransferMode = TransferMode.Binary;

                            TransferOperationResult transferResult;
                            //transferResult = session.PutFiles(@"d:\toupload\*", "/home/user/", false, transferOptions);
                            transferResult = session.PutFiles(path, RemoteFtpPath + location + "/", false, transferOptions);

                            //if (transferResult.Transfers.Count > 0) { success = 1; }
                            //else if (transferResult.Failures.Count > 0) { success = -1; }

                            //Throw on any error
                            transferResult.Check();
                            success = 1;
                        }
                    }
                    session.Close();
                }
            }
            catch (Exception Ex)
            { 
                success = -1; 
                lbl_msg.Text = Ex.Message + "Retrying after 5mins."; 
                bttn_ftpconnect.BackColor = Color.Red; 
                //session.Close();
                //lbl_msg2.Text = "Retrying after 5mins.";
                System.Threading.Thread.Sleep(300000);
                InitTimer(); 
                //bttn_ftpconnect.PerformClick();
            }

        }

        private void bttn_LocBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK) 
            { 
                txt_localpath.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default["LocalPath"] = txt_localpath.Text;
                Properties.Settings.Default.Save();
            }

        }

        private void bttn_startprogress_Click(object sender, EventArgs e)
        {
            //Task.Factory.StartNew();
                if (Sch == "Y") { }
                else if (Sch == "N") { }

                Timex.Enabled = false;
                Time_HoursInt.Enabled = false;
                if (txt_server.Text != "" || txt_ftpurl.Text != "")
                {
                    //start();
                    InitTimer();
                    //DateTime present = DateTime.Today;
                    //DateTime past = DateTime.Today.AddDays(-1);
                    //starttoconvert(present, past);
                    lbl_msg2.Text = "Completed";
                } 
                
        }

        private void InitTimer()
        { 
            if (rotate==1)
            {
                System.Threading.Thread.Sleep(Convert.ToInt32(lbl_filegen.Text) * 3600000);
                start();
                
            }
            else if (rotate==0)
            {
                //timer3 = new System.Windows.Forms.Timer();
                System.Threading.Thread.Sleep(5000);
                rotate = 1;
                start();
                
            }  
        }

        private EventHandler start()
        {
            DateTime present = DateTime.Today;
            DateTime past = DateTime.Today.AddDays(-1);
            typeprocess = "R";
            starttoconvert(present,past,typeprocess);
            //throw new NotImplementedException();
            return null;
        }

        private void starttoconvert(DateTime present, DateTime past, string typeprocess)
        {
            string path1 = System.IO.Path.GetDirectoryName(Application.ExecutablePath).ToString();
            try
            {
                counter = counter + 1;
                countermsg.Text = counter.ToString();
                Time_HoursInt.Enabled = false;
                //String query = "SELECT MIN(MeterRead) AS MINIMUM, MAX(MeterRead) AS MAXIMUM FROM dataExportEwp WHERE (Mprn = 'JAMIYA MAJID_2')";
                String query = "SELECT MIN(MeterRead) AS MINIMUM, MAX(MeterRead) AS MAXIMUM, AVG(Consumption) FROM dataExportEwp";
                string disQuery = "SELECT DISTINCT Mprn FROM dataExportEwp";
                hwmcon = new SqlConnection(Remotepath);
                bwssbcon = new SqlConnection(Remotepath2);
                hwmcon.Open();

                //Get Distinct Location Names
                SqlCommand QueryChk = new SqlCommand(disQuery, hwmcon);
                List<LocationsID> results = new List<LocationsID>();
                using (SqlDataReader oReader = QueryChk.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        LocationsID Loc = new LocationsID();
                        Loc.LocID = oReader[0].ToString();
                        results.Add(Loc);
                    }
                }
                txt_locations.Text = results.Count.ToString();

                //Thread.Sleep(1000);

                //Get Readings from SQL
                if (typeprocess == "R")
                {
                    dt2 = present.ToString("M/d/yyyy 00:00:00");
                    dt1 = past.ToString("M/d/yyyy 00:00:00");
                }
                else if (typeprocess == "M")
                {
                    dt1 = present.ToString("M/d/yyyy 00:00:00");
                    dt2 = past.ToString("M/d/yyyy 00:00:00");
                }

                for (int i = 0; i < results.Count; i++)
                {
                    //count++;
                    progressBar1.Maximum = results.Count;
                    progressBar1.Value = i + 1;
                    progressBar1.Style = ProgressBarStyle.Continuous;
                    //DateTime present = DateTime.Today;
                    //DateTime past = DateTime.Today.AddDays(-1);
                    DateTime chk = present;
                    //string chkpresent=chk.ToString("M/d/yyyy HH:mm:ss");
                    String dt4, dt3 = "";
                    DateTime inc1 = DateTime.Now;
                    if (typeprocess == "R") { inc1 = past; } else if (typeprocess == "M") { inc1 = present; }

                    do
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        //DateTime inc=past.AddHours(1);  
                        dt3 = inc1.ToString("M/d/yyyy HH:mm:ss");
                        //lbl_timex Int32 Hours = Convert.ToInt32(Time_HoursInt.Value);
                        Int32 Hours = Convert.ToInt32(lbl_timex.Text);
                        DateTime inc2 = inc1.AddHours(Hours);
                        dt4 = inc2.ToString("M/d/yyyy HH:mm:ss");
                        String query2 = query + " Where Mprn = '" + results[i].LocID + "' AND datetime >='" + dt3 + "' AND datetime<='" + dt4 + "'";
                        SqlCommand QueryChk2 = new SqlCommand(query2, hwmcon);
                        using (SqlDataReader oReader2 = QueryChk2.ExecuteReader())
                        {
                            while (oReader2.Read())
                            {
                                string matter = "";
                                success = 0;
                                Double LastPeriod = 0;
                                if (String.IsNullOrEmpty(oReader2[0].ToString())) { LastPeriod = 0; } else { LastPeriod = Convert.ToDouble(oReader2[0].ToString()); }

                                Double CurrentPeriod = 0;
                                if (String.IsNullOrEmpty(oReader2[1].ToString())) { CurrentPeriod = 0; } else { CurrentPeriod = Convert.ToDouble(oReader2[1].ToString()); }

                                Double FlowRate = 0;
                                if (String.IsNullOrEmpty(oReader2[2].ToString())) { FlowRate = 0; } else { FlowRate = Convert.ToDouble(oReader2[2].ToString()); }
                                Double ActFlowRate = FlowRate * 4;

                                string Location = results[i].LocID.Substring(0, results[i].LocID.IndexOf('_'));

                                string dttime = inc2.ToString("d/M/yyyy HH:mm:ss");
                                string datemod = Regex.Replace(dttime, "[^.0-9]", "");
                                string filename = Location + datemod;
                                string path = txt_localpath.Text + "\\" + filename + ".txt";
                                //string path = "C:\\Temp\\Temp\\" + filename + ".txt";
                                matter = "#," + Location + "," + ActFlowRate + "," + LastPeriod + "," + CurrentPeriod + ",1," + datemod + ",0," + datemod + ",1," + datemod + ",$";

                                TextWriter txt = new StreamWriter(path);
                                txt.Write(matter);
                                txt.Close();

                                FTPPush(path, Location, filename);

                                if (success > 0)
                                {
                                    if (File.Exists(path))
                                    {
                                        File.Delete(path);
                                        watch.Stop();
                                        var elapsedMs = watch.ElapsedMilliseconds;
                                        query3 = "INSERT INTO [Status] ([Location],[FileLoc],[DateTime],[Type],[Status_1],[ReTry],[Act_Dt],[Timelap]) VALUES ( '" + Location + "','" + path + "','" + dttime + "','FTP','Y','','" + DateTime.Now + "','" + elapsedMs + "')";
                                        //MessageBox.Show(elapsedMs.ToString());
                                    }
                                    //TryAgain();
                                }
                                else if (success < 0)
                                {
                                    watch.Stop();
                                    var elapsedMs = watch.ElapsedMilliseconds;
                                    mispath = txt_faultyFolder + "\\";
                                    //mispath = "C:\\Temp\\";
                                    string filemispath = mispath + filename + ".txt";
                                    System.IO.File.Move(path, filemispath);
                                    query3 = "INSERT INTO [Status] ([Location],[FileLoc],[DateTime],[Type],[Status_1],[ReTry],[Act_Dt],[Timelap]) VALUES ( '" + Location + "','" + mispath + "','" + dttime + "','FTP','N','','" + DateTime.Now + "','" + elapsedMs + "')";
                                    //TryAgain();
                                }
                            }
                            //hwmcon.Close();
                            bwssbcon.Open();
                            SqlCommand cmd = new SqlCommand(query3, bwssbcon);
                            cmd.ExecuteNonQuery();
                            bwssbcon.Close();
                        }
                        inc1 = inc2;
                    }
                    while (dt2 != dt4);
                }
                Timex.Enabled = true;
                lbl_msg2.Text = "Completed";
                string pathTxt = System.IO.Path.GetDirectoryName(Application.ExecutablePath).ToString();
                //rotate = 1;
                File.AppendAllText(pathTxt+"\\Timesheet.txt", DateTime.Now + Environment.NewLine);
                if (typeprocess == "R") 
                {
                    InitTimer(); 
                }
            }
            catch (Exception Ex) { lbl_msg2.Text = Ex.Message; }    
        }      

        private void TryAgain()
        {
            string[] filePaths = Directory.GetFiles(mispath, "*.txt");

            for (int i = 0; i < filePaths.Count(); i++) 
            {
                try
                {
                    using (Session session = new Session())
                    {
                        // Connect
                        session.Open(sessionOptions);
                        bttn_ftpconnect.BackColor = Color.Green;

                        
                            //// Upload files
                            //TransferOptions transferOptions = new TransferOptions();
                            //transferOptions.TransferMode = TransferMode.Binary;

                            //TransferOperationResult transferResult;
                            ////transferResult = session.PutFiles(@"d:\toupload\*", "/home/user/", false, transferOptions);
                            //transferResult = session.PutFiles(filePaths[i], "/public_html/HWM/" + location + "/", false, transferOptions);

                            ////if (transferResult.Transfers.Count > 0) { success = 1; }
                            ////else if (transferResult.Failures.Count > 0) { success = -1; }
                            ////Throw on any error
                            //transferResult.Check();
                            //success = 1;
                        
                    }
                }
                catch (Exception Ex)
                { success = -1; lbl_msg.Text = Ex.Message; bttn_ftpconnect.BackColor = Color.Red; }
            }

            //throw new NotImplementedException();
        }

        public class LocationsID
        { public string LocID { get; set; } }

        private void cal_fromdt_DateSelected(object sender, DateRangeEventArgs e)
        {
            txt_fromDt.Text = cal_fromdt.SelectionRange.Start.ToString();
        }

        private void cal_ToDt_DateSelected(object sender, DateRangeEventArgs e)
        {
            txt_ToDt.Text = cal_ToDt.SelectionRange.Start.ToString();
        }

        private void bttn_process_Click(object sender, EventArgs e)
        {
            Time_HoursInt.Enabled = false;
            lbl_msg2.Text = "";
            DateTime from = Convert.ToDateTime(txt_fromDt.Text);
            DateTime to = Convert.ToDateTime(txt_ToDt.Text);
            typeprocess = "M";
            if (from < to) { starttoconvert(from, to,typeprocess); } else { lbl_msg2.Text = "Check the Dates."; }
            Time_HoursInt.Enabled = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bWSSBDataSet.Sync' table. You can move, or remove it, as needed.
            //this.syncTableAdapter.Fill(this.bWSSBDataSet.Sync);
            txt_server.Text = Properties.Settings.Default["Server"].ToString();
            txt_dbname.Text = Properties.Settings.Default["Database"].ToString();
            txt_username.Text = Properties.Settings.Default["UserName"].ToString();
            txt_password.Text = Properties.Settings.Default["Password"].ToString();
            txt_ftpurl.Text = Properties.Settings.Default["FTPServer"].ToString();
            txt_PortNo.Text = Properties.Settings.Default["PORT"].ToString();
            txt_ftpusername.Text = Properties.Settings.Default["FTPUserName"].ToString();
            txt_ftppassword.Text = Properties.Settings.Default["FTPPassword"].ToString();
            txt_localpath.Text = Properties.Settings.Default["LocalPath"].ToString();
            txt_FTPFolder.Text = Properties.Settings.Default["FTPFolder"].ToString();
            txt_faultyFolder.Text = Properties.Settings.Default["FaultyFolder"].ToString();
            lbl_timex.Text = Properties.Settings.Default["Timex"].ToString();
            lbl_filegen.Text = Properties.Settings.Default["FileHrs"].ToString();
            txt_Key.Text = Properties.Settings.Default["Key"].ToString();
            lbl_TimeSchedule.Text = Properties.Settings.Default["TriggerHr"].ToString() + ":" + Properties.Settings.Default["TriggerMins"].ToString();
            Sch = Properties.Settings.Default["TriggerChk"].ToString();
            if (Sch == "Y") { Time_HoursInt.Enabled = false; Chk_Time.CheckState = CheckState.Checked; }
            else if (Sch == "N") { Time_HoursInt.Enabled = true; Chk_Time.CheckState = CheckState.Unchecked; }
            else if (Sch == "") { Time_HoursInt.Enabled = true; Chk_Time.CheckState = CheckState.Unchecked; }

            if (txt_server.Text != "")
            {
                Remotepath = "Data Source=" + txt_server.Text + ";MultipleActiveResultSets=true;Initial Catalog=" + txt_dbname.Text + ";User ID=" + txt_username.Text + ";Password=" + txt_password.Text + ";";
                //Remotepath2 = "Data Source=192.168.1.225;MultipleActiveResultSets=true;Initial Catalog=BWSSB;User ID=Enviro;Password=Enviro1@!@#$;";
                Remotepath2 = "Data Source=" + txt_server.Text + ";MultipleActiveResultSets=true;Initial Catalog=BWSSB;User ID=" + txt_username.Text + ";Password=" + txt_password.Text + ";";
            }

            if (txt_server.Text != "" && txt_ftpurl.Text != "")
            { 
                bttn_startprogress.Enabled = true;
                bttn_stopprogress.Enabled = true;
                bttn_process.Enabled = true;
            }
            string ValidDt = Properties.Settings.Default["ToDt"].ToString();
            if (ValidDt == "") { bttn_Validate.Enabled = true; bttn_process.Enabled = false; bttn_startprogress.Enabled = false; Chk_Update.Enabled = false; }
            else if(ValidDt != "")
            {
                if(DateTime.Today.Date <= Convert.ToDateTime(ValidDt))
                {
                    bttn_process.Enabled = true; bttn_startprogress.Enabled = true;
                    txt_Name.Text = Properties.Settings.Default["CompName"].ToString();
                    lbl_ValidFrom.Text = Properties.Settings.Default["FromDt"].ToString();
                    lbl_ValidTo.Text = Properties.Settings.Default["ToDt"].ToString();

                    lbl_SNo.Text = Properties.Settings.Default["MAC"].ToString();
                    lbl_Sno_update.Text = "Valid Subscription";
                    
                    lbl_Sno_update.ForeColor = Color.Green;
                }
                else
                {
                    bttn_Validate.Enabled = true;
                    Chk_Update.CheckState = CheckState.Checked;
                    Chk_Update.Enabled = false;
                    bttn_process.Enabled = false; bttn_startprogress.Enabled = false;
                    txt_Name.Text = Properties.Settings.Default["CompName"].ToString();
                    lbl_ValidFrom.Text = Properties.Settings.Default["FromDt"].ToString();
                    lbl_ValidTo.Text = Properties.Settings.Default["ToDt"].ToString();

                    lbl_SNo.Text = Properties.Settings.Default["MAC"].ToString();
                    lbl_Sno_update.Text = "Licence Expired";

                    lbl_Sno_update.ForeColor = Color.Red;
                }

            }
            Autochk = Properties.Settings.Default["AutoStart"].ToString();
            if (string.IsNullOrEmpty(Autochk) || Autochk == "N") { chk_autostart.CheckState = CheckState.Unchecked; }
            else if (Autochk == "Y")
            {
                chk_autostart.CheckState = CheckState.Checked; 
                //reg.SetValue("FTPScheduler", Application.ExecutablePath.ToString());
                countermsg.Text = "Process starts in 30 secs";
                System.Threading.Thread.Sleep(30000);
                //InitTimer();
            }
        }

        private void bttn_Refresh_Click(object sender, EventArgs e)
        {
            String query = "SELECT [SiteID],[LatEast],[LongNorth] FROM [HWMDB].[dbo].[sites]";
            string disQuery = "SELECT DISTINCT Mprn FROM dataExportEwp";
            //hwmcon = new SqlConnection(@"Data Source="+ txt_server.Text +";MultipleActiveResultSets=true;Initial Catalog=hwmdb;User ID=Enviro;Password=Enviro1@!@#$; MultipleActiveResultSets=true;");
            //hwmcon.Open();
        }

        private void txt_localpath_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttn_FaultyFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK) 
            { 
                txt_faultyFolder.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default["FaultyFolder"] = txt_faultyFolder.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void bttn_status_Click(object sender, EventArgs e)
        {
            string disQuery = "SELECT [Location],[FileLoc],[DateTime],[Type],[Status_1],[ReTry],[Act_Dt],[Timelap] FROM Status";
            try
            {
                hwmcon = new SqlConnection(Remotepath2);
                hwmcon.Open();
                SqlDataAdapter Adp = new SqlDataAdapter(disQuery, hwmcon);
                DataTable Dt = new DataTable();
                Adp.Fill(Dt);
                gridview_status.DataSource = Dt;
            }
            catch (Exception Ex) { lbl_dixerror.Text = Ex.Message; }
            
            //gridview_status.DataBind();
              
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void bttn_stopprogress_Click(object sender, EventArgs e)
        {
            Time_HoursInt.Enabled = true;
            timer1.Stop();
        }

        private void bttn_Verify_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source='" + txt_server.Text + "';MultipleActiveResultSets=true;Initial Catalog='" + txt_dbname.Text + "';User ID='" + txt_username.Text + "';Password='" + txt_password.Text + "'"))
                {
                    try
                    {
                        connection.Open();
                        if (connection.State == ConnectionState.Open) // if connection.Open was successful
                        {

                            Properties.Settings.Default["Server"] = txt_server.Text;
                            Properties.Settings.Default["Database"] = txt_dbname.Text;
                            Properties.Settings.Default["UserName"] = txt_username.Text;
                            Properties.Settings.Default["Password"] = txt_password.Text;

                            Properties.Settings.Default.Save();
                            lbl_msgserver.Text = "Connected successfully";
                            lbl_msgserver.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            lbl_msgserver.Text = "Connection Unsuccessful";
                            lbl_msgserver.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    catch (SqlException ex)
                    {
                        lbl_msgserver.Text = ex.Message;
                        lbl_msgserver.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Connectivity");
            }
            
        }

        private void bttn_FtpBrowse_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["FTPFolder"] = txt_FTPFolder.Text;
            Properties.Settings.Default.Save();
        }

        private void txt_FTPFolder_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txt_FTPFolder, "Format in /Root_Folder/Main_Folder/");
        }

        private void Chk_Time_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Chk_Time.CheckState == CheckState.Checked)
            {
                time_Hour.Enabled = true; Time_Mins.Enabled = true; string Trigger = "Y"; Properties.Settings.Default["TriggerChk"] = Trigger;
                Properties.Settings.Default.Save();
                Time_HoursInt.Enabled = false;
            }
            else if (Chk_Time.CheckState == CheckState.Unchecked)
            {
                time_Hour.Enabled = false; Time_Mins.Enabled = false; string Trigger = "N"; Properties.Settings.Default["TriggerChk"] = Trigger;
                Properties.Settings.Default.Save();
                Time_HoursInt.Enabled = true;
            }

        }

        private void Timex_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["Timex"] = Convert.ToInt32(Timex.Value);
            Properties.Settings.Default.Save();
            lbl_timex.Text = Timex.Value.ToString();
        }

        private void Time_HoursInt_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["FileHrs"] = Convert.ToInt32(Time_HoursInt.Value);
            Properties.Settings.Default.Save();
            lbl_filegen.Text = Time_HoursInt.Value.ToString();
        }

        private void Time_HoursInt_MouseClick(object sender, MouseEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(Time_HoursInt, "Time Interval Between the Files");
        }

        private void bttn_Validate_Click(object sender, EventArgs e)
        {
            if (txt_SNo.Text != "")
            {
                string Key = "ENVI-THAN-MUMBAI";
                //if (txt_SNo.Text == "2ZUAMDEKNBJSPPFRV75EH36") { } else { }
                String SNO = "0";
                ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
                foreach (ManagementObject getserial in MOS.Get())
                {
                    //label1.Text = "Your motherboard serial is : " + getserial["SerialNumber"].ToString();
                    SNO = getserial["SerialNumber"].ToString();
                }

                string Textsend = "";
                
                string Decrpt = Decrypt(Key, txt_SNo.Text);
                if (Decrpt!=null)
                {
                    txt_Key.Text = txt_SNo.Text;

                    string[] tokens = Decrpt.Split('-');

                    txt_Name.Text = tokens[0];
                    Textsend = txt_Name.Text;
                    string EComp = Encrypt(Key, Textsend);

                    lbl_ValidFrom.Text = tokens[1];
                    Textsend = lbl_ValidFrom.Text;
                    string EFrm = Encrypt(Key, Textsend);

                    lbl_ValidTo.Text = tokens[2];
                    Textsend = lbl_ValidTo.Text;
                    string ETo = Encrypt(Key, Textsend);

                    string Stat = tokens[3];
                    Textsend = Stat;
                    string EStat = Encrypt(Key, Textsend);

                    lbl_SNo.Text = SNO;
                    string InsertQ = "";
                    hwmcon = new SqlConnection(@"Data Source=" + txt_server.Text + ";MultipleActiveResultSets=true;Initial Catalog=BWSSB;User ID=" + txt_username.Text + ";Password=" + txt_password.Text + ";");

                    if (Chk_Update.CheckState == CheckState.Unchecked)
                    {
                        InsertQ = "INSERT INTO [Serial_NO] ([SNo],[FromDt],[ToDt],[LicTo],[MAC],[Valid]) VALUES ('" + txt_SNo.Text + "','" + EFrm + "','" + ETo + "','" + EComp + "','" + lbl_SNo.Text + "','" + EStat + "')";
                        SqlCommand command = new SqlCommand(InsertQ, hwmcon);
                        hwmcon.Open();
                        command.ExecuteNonQuery();
                        lbl_Sno_update.Text = "Licence Inserted";
                        lbl_Sno_update.ForeColor = Color.Green;
                    }
                    else if (Chk_Update.CheckState == CheckState.Checked)
                    {
                        InsertQ = "UPDATE [Serial_NO] SET [SNo] = '" + txt_SNo.Text + "',[FromDt] = '" + EFrm + "',[ToDt] = '" + ETo + "',[LicTo] = '" + EComp + "',[Valid] = '" + EStat + "' WHERE [MAC] = '" + lbl_SNo.Text + "'";
                        SqlCommand command = new SqlCommand(InsertQ, hwmcon);
                        hwmcon.Open();
                        command.ExecuteNonQuery();
                        lbl_Sno_update.Text = "Licence Updated";
                        lbl_Sno_update.ForeColor = Color.Green;
                    }


                    Properties.Settings.Default["CompName"] = txt_Name.Text;
                    Properties.Settings.Default["FromDt"] = lbl_ValidFrom.Text;
                    Properties.Settings.Default["ToDt"] = lbl_ValidTo.Text;
                    Properties.Settings.Default["Status"] = Stat;
                    Properties.Settings.Default["MAC"] = lbl_SNo.Text;
                    Properties.Settings.Default["Key"] = txt_Key.Text;
                    Properties.Settings.Default.Save();
                }
                }
                
            
        }

        private string Encrypt(string Key, string Textsend)
        {
            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(Textsend);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(Key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        private string Decrypt(string Key, String txt_SNo)
        {
            try
            {
                byte[] inputArray = Convert.FromBase64String(txt_SNo);
                TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
                tripleDES.Key = UTF8Encoding.UTF8.GetBytes(Key);
                tripleDES.Mode = CipherMode.ECB;
                tripleDES.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tripleDES.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
                tripleDES.Clear();
                return UTF8Encoding.UTF8.GetString(resultArray);
                
            }
            catch (Exception Ex) { 
                lbl_Sno_update.Text = "Key Incorrect.";
                lbl_Sno_update.ForeColor = Color.Red;
                return null; 
            }
            //throw new NotImplementedException();
        }

        private void time_Hour_ValueChanged(object sender, EventArgs e)
        {
            hours = time_Hour.Value.ToString();
            Properties.Settings.Default["TriggerHr"] = Convert.ToInt32(hours);
            Properties.Settings.Default.Save();
            lbl_TimeSchedule.Text = hours + ":" + mins;
        }

        private void Time_Mins_ValueChanged(object sender, EventArgs e)
        {
            mins = Time_Mins.Value.ToString();
            Properties.Settings.Default["TriggerMins"] = Convert.ToInt32(mins);
            Properties.Settings.Default.Save();
            lbl_TimeSchedule.Text = hours + ":" + mins;
        }

        private void lbl_timex_Click(object sender, EventArgs e)
        {

        }

        private void Chk_Update_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Update.CheckState == CheckState.Checked) { bttn_Validate.Enabled = true; }
            if (Chk_Update.CheckState == CheckState.Unchecked) { bttn_Validate.Enabled = false; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Auto check
            if (chk_autostart.CheckState == CheckState.Checked)
            {
                Properties.Settings.Default["AutoStart"] = "Y";
                Properties.Settings.Default.Save();
            }
            if (chk_autostart.CheckState == CheckState.Unchecked)
            {
                Properties.Settings.Default["AutoStart"] = "N";
                Properties.Settings.Default.Save();
            }
        }
    }
}
