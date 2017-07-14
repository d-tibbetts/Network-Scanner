using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Timers;
using System.Data.SqlClient;
using System.Threading;
using System.Configuration;
namespace wifiApp
{
    public partial class fmWifiApp : Form
    {
       
        /*This is a timer that triggers a new scan run every 1 minute
         * if the background worker is available*/
        private static System.Timers.Timer aTimer;
        SqlConnection conn = new SqlConnection();
            
        public fmWifiApp()
        {
            InitializeComponent();
            aTimer = new System.Timers.Timer();
        }

        private void fmWifiApp_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

        private void notifyIconMessages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void fmWifiApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void fmWifiApp_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.firstRun)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                lblProgress.Visible = true;
                progressBarPython.Visible = true;
                labelUpdateUser.Visible = true;
                backgroundWorkerPythonScript.RunWorkerAsync();
            }
        }
        /*############# Code for this method provided by MSDN and StackOverFlow ###############################*/
        private void runPythonScipt()
        {
            
            string path = Path.GetPathRoot(Environment.SystemDirectory);
            path += @"Python27\python.exe";
            //string script = @"C:\Program Files (x86)\404 Team Name Not Found\Wifi_IDS_Setup\Scan.py";

            //test code for debug mode.
            string script = @"Scan.py";
            string DefGateway = Properties.Settings.Default.defaultGateway;
            string UserName = Properties.Settings.Default.serverUserName;
            string passWord = Properties.Settings.Default.password;
            string clientID = Properties.Settings.Default.userName;

            //Create New process start info with python.exe path
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(path);

            //need to read the output in the textbox.
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;
            myProcessStartInfo.CreateNoWindow = true;
            //starting script with 3 arguments name of script, default gateway and 
            myProcessStartInfo.Arguments = script + " " + DefGateway + " " + UserName
                                                  + " " + passWord + " " + clientID;
            Process myProcess = new Process();
            //assign start information to the process
            myProcess.StartInfo = myProcessStartInfo;

            //start process
            myProcess.Start();

            //read the standard output of the app we called.
            //StreamReader myStreamReader = myProcess.StandardOutput;
            //string myString = myStreamReader.ReadToEnd();

            //wait exit signal from the app we called.
            myProcess.WaitForExit();

            //close 
            myProcess.Close();
            // textBox1.Text = myString;
            // Cursor.Current = Cursors.AppStarting;
        }


        private void getDB()
        {
            
            string user = Properties.Settings.Default.userName;
            //create the query string 
            string queryString = "SELECT MAC_address,connection_time,allow FROM corbin WHERE Username='"+user+"' AND disconnect_time is NULL";
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["wifiApp.Properties.Settings.Database_WIFIConnectionString"];
            string connectionString = conSettings.ConnectionString;
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was a problem connecting to the Database, Will retry shortly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlDataAdapter sda = new SqlDataAdapter(queryString, conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            //resize to fit the datagridview
            dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.Visible = true;
           

            
           //will itterate through and change the color of the rows
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                if (dgvr.Cells[2].Value.ToString() == "yes")
                {
                    dgvr.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (dgvr.Cells[2].Value.ToString() == "no")
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Beige;
                }
            }

            conn.Close();

        }
        private void backgroundWorkerPythonScript_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            SafeBeginInvoke(progressBarPython, () => { progressBarPython.Value = e.ProgressPercentage; });
            SafeBeginInvoke(lblProgress, () => { lblProgress.Text = string.Format("Scan in progress...{0}%", e.ProgressPercentage); });
            SafeBeginInvoke(progressBarPython, ()=>{progressBarPython.Update();});
            
        }

        private void backgroundWorkerPythonScript_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 50; i += 10)
            {
                backgroundWorkerPythonScript.ReportProgress(i);
            }

            runPythonScipt();

        }

        private void backgroundWorkerPythonScript_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SafeBeginInvoke(progressBarPython, () => { progressBarPython.Value = 100; });
            
            SafeBeginInvoke(lblProgress, () => { lblProgress.Text = "Scan in progress...100%"; });
            
            SafeBeginInvoke(progressBarPython, () => { progressBarPython.Update(); });
           
            //this.Invoke(new Action(() => { MessageBox.Show(this, "Process Complete"); }));
            SafeBeginInvoke(lblProgress, () => { lblProgress.Visible = false; });
            
            SafeBeginInvoke(progressBarPython, () => { progressBarPython.Visible = false; });

            SafeBeginInvoke(labelUpdateUser, () => { labelUpdateUser.Text = "             Double click to change connection status"; });
            notifyIconMessages.Text = "New scan results click to view";
            notifyIconMessages.BalloonTipText = "A scan has completed and there may be new devices connected to your network.  Click here!";
            notifyIconMessages.ShowBalloonTip(1200000);
           
            aTimer.Interval = 100000;

            aTimer.Elapsed += new ElapsedEventHandler(aTimer_Elapsed);
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

            

            
        }
        private  void aTimer_Elapsed(object source, ElapsedEventArgs e)
        {
            
            SafeBeginInvoke(progressBarPython, () => { progressBarPython.Visible = true; });
            SafeBeginInvoke(lblProgress, () => { lblProgress.Visible = true; });
            //make sure the backgroundworker isn't busy
            if (!backgroundWorkerPythonScript.IsBusy)
            {
                backgroundWorkerPythonScript.RunWorkerAsync();
            }
            else
            {   //if it is reset the timer.
                aTimer.Stop();
                aTimer.Start();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void viewAndChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            formUserInformation m = new formUserInformation();
            m.Show();
        }

        private void notifyIconMessages_BalloonTipClicked(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            this.Refresh();
            getDB();
        }
        /*############# Created By User on Stack OverFlow ###############################*/
        //the function below safely invoke changes that need to happen to the GUI from the backgroundworker thread
        //Or thread they were called on . 
        public static void SafeBeginInvoke(System.Windows.Forms.Control control, System.Action action)
        {
            if (control.InvokeRequired)
                control.BeginInvoke(new System.Windows.Forms.MethodInvoker(() => { action(); }));
            else
                action();
        }
      
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.firstRun)
            {
                MessageBox.Show("There is no data to show yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                fmSearch newSearch = new fmSearch();
                newSearch.ShowDialog();
            }
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutBox newAbout = new aboutBox();
            newAbout.ShowDialog();
        }

        
           

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["wifiApp.Properties.Settings.Database_WIFIConnectionString"];
            string connectionString = conSettings.ConnectionString;
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem connecting to the Database, Will retry shortly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString() == "no")
            //{
                DialogResult result = MessageBox.Show("Would you like to allow " + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value + " Connection?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value = "yes";
                    SqlCommand cmd = new SqlCommand("Update corbin set allow = @allow Where MAC_address=@MAC_address and Username=@Username", conn);
                    cmd.Parameters.AddWithValue("@allow", dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@MAC_address", dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@Username", Properties.Settings.Default.userName);
                    cmd.ExecuteNonQuery();

                    this.WindowState = FormWindowState.Normal;
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].DefaultCellStyle.BackColor = Color.LightGreen;
                    dataGridView1.Refresh();
                }

            //}
           // else if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString() == "yes")
           // {
                //DialogResult result = MessageBox.Show("Would you like to allow " + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value + " Connection?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                {
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value = "no";
                    SqlCommand cmd = new SqlCommand("Update corbin set allow = @allow Where MAC_address=@MAC_address and Username=@Username", conn);
                    cmd.Parameters.AddWithValue("@allow", dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@MAC_address", dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@Username", Properties.Settings.Default.userName);
                    cmd.ExecuteNonQuery();
                    this.WindowState = FormWindowState.Normal;

                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.Refresh();
                }
            //}
            conn.Close();
        
        }

        private void refreshTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!backgroundWorkerPythonScript.IsBusy)
            {
                getDB();
            }
            else
            {
                MessageBox.Show("A Scan is currently in progress, please wait.","Working...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}