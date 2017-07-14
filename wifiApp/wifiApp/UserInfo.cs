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
    public partial class formUserInformation : Form
    {
        public formUserInformation()
        {
            InitializeComponent();
        }

        private void buttonChange_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            SqlConnection conn = new SqlConnection();
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["wifiApp.Properties.Settings.Database_WIFIConnectionString"];
            string connectionString = conSettings.ConnectionString;
            conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("Update corbin set Username = @NewUsername Where  Username=@Username", conn);
            cmd.Parameters.AddWithValue("@NewUsername", textBoxUserName.Text);
            cmd.Parameters.AddWithValue("@Username", Properties.Settings.Default.userName);
            cmd.ExecuteNonQuery();
            Properties.Settings.Default.defaultGateway = mTextBoxChangeGateway.Text + "/24";
            Properties.Settings.Default.userName = textBoxUserName.Text;
            Properties.Settings.Default.Save();
            conn.Close();

            Cursor.Current = Cursors.Default;
            this.Close();
        }
    }
}
