/****************************************************************
 * Graphics provided by David Dang
 * Python Script Author Corbin Govers
 * All other code authored by Denee Tibbetts unless otherwise 
 * stated in the comments. 
 * *************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
namespace wifiApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //This line is test code for the initializationForm
            //remove for final release and testing on Form1
           Properties.Settings.Default.Reset();

            //this line of code must run before any windows forms object run
            Application.SetCompatibleTextRenderingDefault(false);

            //firstRun is a boolean in the application properties.
            //wifiApp>properties>settings 
            //if this is the first run of the application the property
            //will be set to false and the window showing where the user enters 
            // their subnet mask will be saved. 
            if (Properties.Settings.Default.firstRun)
            {
                

                // this runs only on firstRun to get the subnet mask of the network
                formInitialization initForm = new formInitialization();
                initForm.ShowDialog();
            }


            Application.EnableVisualStyles();
            Application.Run(new fmWifiApp());


           
            
        }
    }
}
