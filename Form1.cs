using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownTimer
{
    public partial class ShutdownTimer : Form
    {

        public ShutdownTimer()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            /*
             *  GET Action and time from UI
             * 
             */

            string selectedCMD = actionDropDown.SelectedItem?.ToString() ?? "unselect";
            double time = double.Parse(timerSetter.Value.ToString()) * 3600;

            // Ignore unselected action and time is eqaul to 0
            if (selectedCMD == "unselect")
            {
                summary_box.Text = "Please set time before click confirm button";

                return;
            }


            // Show Alert Message for time equal 0 
            if (time == 0.0)
            {
                //
                // Dialog box with two buttons: yes and no.
                //
                DialogResult result = MessageBox.Show($"Are you sure to {selectedCMD} now?", "Are you sure ???", MessageBoxButtons.YesNo);

                if (DialogResult.No == result)
                    return;
            }
            
             
            try
            {
                switch (selectedCMD)
                {
                    case "Shutdown":
                        System.Diagnostics.Process.Start("cmd.exe", $"/c shutdown /s /t {time}");
                        summary_box.Text = $"Action Successfully : Windows will Shutdown in {time / 60} Minutes.";
                        break;

                    case "Restart":
                        System.Diagnostics.Process.Start("cmd.exe", $"/c shutdown /r /t {time}");
                        summary_box.Text = $"Action Successfully : Windows will Restart in {time / 60} Minutes.";
                        break;

                    default:
                        System.Diagnostics.Process.Start("CMD.exe", "/c shutdown /a");
                        summary_box.Text = $"Action Successfully : The schedule has been cancelled!.";
                        break;
                }


            }
            catch (Exception ex)
            {

                summary_box.Text = $"Action Fail : {ex.Message}";
            }




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timerSetter_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
