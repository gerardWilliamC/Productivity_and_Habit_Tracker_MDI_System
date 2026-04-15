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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            try
            {
                string noteTitle = txtNoteTitle.Text.Trim();

                if (string.IsNullOrEmpty(noteTitle))
                {
                    MessageBox.Show("Note Title cannot be empty.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (IsDuplicate(noteTitle))
                {
                    throw new DuplicateNameException();
                }

                lstNotes.Items.Add($"{noteTitle} - {DateTime.Now.ToString("g")}");
            }

            catch (DuplicateNameException)
            {
                MessageBox.Show("This note title already exists. Please enter a unique title.", "Duplicate Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsDuplicate(string note)
        {
            try
            {
                foreach (var item in lstNotes.Items)
                {
                    if (item.ToString().Contains(note))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                MessageBox.Show("An error occurred while checking for duplicates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNotes.Clear();
            txtNoteTitle.Clear();

        }

        private void btnRemoveNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstNotes.SelectedItem != null)
                {
                    lstNotes.Items.Remove(lstNotes.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Please select a note to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing the note: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstNotes.SelectedItem != null)
                {
                    MessageBox.Show($"Opening note: {lstNotes.SelectedItem.ToString()}", "Open Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a note to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the note: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
