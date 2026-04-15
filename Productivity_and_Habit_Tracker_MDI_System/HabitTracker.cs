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
    public partial class HabitTracker : Form
    {
        public HabitTracker()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddHabit_Click(object sender, EventArgs e)
        {
            try
            {
                string habit = txtHabitName.Text.Trim();

                if (string.IsNullOrEmpty(habit))
                {
                    MessageBox.Show("Habit Name cannot be empty.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (IsDuplicate(habit))
                {
                    throw new DuplicateNameException();
                }

                lstHabits.Items.Add($" [ ] {habit}");

            }
            catch (DuplicateNameException)
            {
                MessageBox.Show("This habit already exists. Please enter a unique habit.", "Duplicate Habit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

            private bool IsDuplicate(string habit)
        {
            try
            {
                foreach (var item in lstHabits.Items)
                {
                    if (item.ToString().Contains(habit))
                    {
                        return true;
                    }
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
            txtHabitName.Clear();
            txtHabitName.Focus();
        }

        private void btnMarkAsDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstHabits.SelectedItem != null)
                {
                    string selectedHabit = lstHabits.SelectedItem.ToString();
                    if (selectedHabit.StartsWith(" [ ]"))
                    {
                        lstHabits.Items[lstHabits.SelectedIndex] = selectedHabit.Replace(" [ ]", " [/]");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a habit to mark as done.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while marking the habit as done: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveHabit_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstHabits.SelectedItem != null)
                {
                    lstHabits.Items.Remove(lstHabits.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Please select a habit to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing the habit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
