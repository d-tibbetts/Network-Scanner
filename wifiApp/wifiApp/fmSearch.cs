using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace wifiApp
{
    public partial class fmSearch : Form
    {
        SqlConnection conn = new SqlConnection();

        public fmSearch()
        {
            InitializeComponent();
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            if (radioButtondate.Checked || radioButtonMac.Checked)
            {
                Cursor.Current = Cursors.WaitCursor;
                ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["wifiApp.Properties.Settings.Database_WIFIConnectionString"];
                string connectionString = conSettings.ConnectionString;
                conn = new SqlConnection(connectionString);
                string queryString = "SELECT * FROM corbin Where Username='" + Properties.Settings.Default.userName + "'";
                if (radioButtondate.Checked)
                {
                    DateTime aDate = dateTimePickerSearch.Value;
                    DateTime Cutoff = aDate.AddDays(1);
                    string sqlFormattedDate = aDate.ToString("yyyy-MM-dd 00:00:00.000");
                    string sqlCutoffDate = Cutoff.ToString("yyyy-MM-dd 00:00:00.000");

                    queryString = "SELECT * FROM corbin WHERE Username='" + Properties.Settings.Default.userName + "' AND connection_time >= '" + sqlFormattedDate + "' And connection_time < '" + sqlCutoffDate + "'";
                }
                if (radioButtonMac.Checked)
                {
                    queryString = "SELECT * FROM corbin WHERE Username='" + Properties.Settings.Default.userName + "'AND MAC_address='" + textBoxMacAddress.Text + "'";
                }

                try
                {
                    conn.Open();
                }
                catch (Exception ex)
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
                dataGridView1.Refresh();
                //will itterate through and change the color of the rows
                foreach (DataGridViewRow dgvr in dataGridView1.Rows)
                {
                    if (dgvr.Cells[4].Value.ToString() == "yes")
                    {
                        dgvr.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else if (dgvr.Cells[4].Value.ToString() == "no")
                    {
                        dgvr.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        dgvr.DefaultCellStyle.BackColor = Color.Beige;
                    }
                }

                dataGridView1.Refresh();
                conn.Close();
                Cursor.Current = Cursors.Default;
            }
       }

        private void fmSearch_Load(object sender, EventArgs e)
        {
            this.textBoxMacAddress.GotFocus += new EventHandler(textBoxMacAddress_Focus);
            this.textBoxMacAddress.Text = "Enter MAC address here";



        }

        protected void textBoxMacAddress_Focus(object sender, EventArgs e)
        {
            textBoxMacAddress.Text = "";
            textBoxMacAddress.ForeColor = Color.Blue;
        }
    }
}
