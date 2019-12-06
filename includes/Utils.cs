using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Scanner_Application
{
    /***
     * All useful utility tools are stored in this class
     */
    class Utils
    {
        
        public void closeApplication(FormClosingEventArgs e)
        { 
            // ---- If windows is shutting down, 
            // ---- I don't want to hold up the process
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            {

                // ---- Ok, Windows is not shutting down so
                // ---- either btnExit or Alt + x or Alt + f4 has been clicked or
                // ---- another form closing event was intiated
                //      *)  Confirm user wants to close the application
                switch (MessageBox.Show("Are you sure you want to close the Application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    // ---- *)  if No keep the application alive 
                    //----  *)  else close the application
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
