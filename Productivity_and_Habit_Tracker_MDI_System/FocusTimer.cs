using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productivity_and_Habit_Tracker_MDI_System
{
    public partial class FocusTimer : Form
    {
        int remainingSeconds = 0;
        bool isPaused = false;


        public FocusTimer()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMinutes.Text))
                {
                    MessageBox.Show("Please enter time in minutes.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtMinutes.Text.Trim(), out int minutes) || minutes <= 0)
                {
                    MessageBox.Show("Enter a valid positive number.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                remainingSeconds = minutes * 60;   // ← THIS is how you add the time
                UpdateLabel();

                tmrFocus.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting timer: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tmrFocus_Tick(object sender, EventArgs e)
        {
            try
            {
                if (remainingSeconds > 0)
                {
                    remainingSeconds--;
                    UpdateLabel();

                    if (remainingSeconds == 0)
                    {
                        tmrFocus.Stop();
                        MessageBox.Show("Time's up!", "Focus Timer",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                tmrFocus.Stop();
                MessageBox.Show("Timer error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateLabel()
        {
            try
            {
                int minutes = remainingSeconds / 60;
                int seconds = remainingSeconds % 60;
                lblTime.Text = $"{minutes:00}:{seconds:00}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating time display: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {

                if (!isPaused)
                {
                    // To stop/pause the timer
                    tmrFocus.Stop();
                    isPaused = true;
                    btnStop.Text = "CONTINUE";
                }
                else
                {
                    // To continue when paused
                    if (remainingSeconds > 0)
                    {
                        tmrFocus.Start();
                        isPaused = false;
                        btnStop.Text = "STOP";
                    }
                    else
                    {
                        MessageBox.Show("No time left to continue.", "Focus Timer",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error toggling timer: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                tmrFocus.Stop();
                remainingSeconds = 0;
                lblTime.Text = "00:00";
                txtMinutes.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error resetting timer: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
