using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace wifiApp
{
    public partial class formInitialization : Form
    {
        public formInitialization()
        {
            InitializeComponent();
        }

        private void bttnSubmit_Click_1(object sender, EventArgs e)
        {
            //Check and make sure user is not entering blank values
            //if they are a label will show and the user will be reprompted to enter 
            //a correct response.
            if ((!mTextBoxDefaultGateway.MaskCompleted) || (String.IsNullOrEmpty(textBoxUserName.Text)))
            {
                lblErrorMessage.Visible = true;
                this.Refresh();
                return;

            }
            //The value written in the subnet mask text box, username text box and password textbox will be 
            //written to an application setting an option to change it will be made available 
            //later
            Properties.Settings.Default.defaultGateway = mTextBoxDefaultGateway.Text + "/24";
            Properties.Settings.Default.userName = textBoxUserName.Text;
            Properties.Settings.Default.firstRun = false;
            Properties.Settings.Default.Save();

            MessageBox.Show("Your information has been saved. Initial Scan is starting", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //this will close the current instance of the initialization form.
            this.Close();
        }

       


        }
 }

