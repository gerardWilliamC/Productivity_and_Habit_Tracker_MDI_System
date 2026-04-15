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
    public partial class DailyPlanner : Form
    {
        public DailyPlanner()
        {
            InitializeComponent();
            cboPrio.SelectedIndex = 0;
            cboPrio.Items.Clear();
            cboPrio.Items.AddRange(new[] { "High", "Medium", "Low" });
            cboPrio.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                string task = txtTaskName.Text.Trim();
                string priority = cboPrio.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(task))
                {
                    MessageBox.Show("Task Name cannot be empty.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (IsDuplicate(task, priority))
                {
                    throw new DuplicateNameException();
                }

                switch (priority)
                {
                    case "High":
                        lstHighPrio.Items.Add(task);
                        break;

                    case "Medium":
                        lstMedPrio.Items.Add(task);
                        break;

                    case "Low":
                        lstLowPrio.Items.Add(task);
                        break;
                }

            }
            catch (DuplicateNameException)
            {
                MessageBox.Show("This task already exists. Please enter a unique task.", "Duplicate Task", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the task: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsDuplicate(string task, string priority)
        {
            try
            {
                switch (priority)
                {
                    case "High":
                        return lstHighPrio.Items.Contains(task);
                    case "Medium":
                        return lstMedPrio.Items.Contains(task);
                    case "Low":
                        return lstLowPrio.Items.Contains(task);
                }
                return false;
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking for duplicates: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtTaskName.Clear();
                txtTaskName.Focus();
                cboPrio.SelectedIndex = 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while clearing the input: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstHighPrio.SelectedItem != null)
                {
                    lstHighPrio.Items.Remove(lstHighPrio.SelectedItem);
                }
                else if (lstMedPrio.SelectedItem != null)
                {
                    lstMedPrio.Items.Remove(lstMedPrio.SelectedItem);
                }
                else if (lstLowPrio.SelectedItem != null)
                {
                    lstLowPrio.Items.Remove(lstLowPrio.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Select a task to remove.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing the task: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstMedPrio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboPrio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
