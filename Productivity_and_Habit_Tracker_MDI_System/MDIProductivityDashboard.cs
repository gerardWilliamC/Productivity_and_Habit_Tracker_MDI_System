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
    public partial class MDIProductivityDashboard : Form
    {
        public MDIProductivityDashboard()
        {
            InitializeComponent();
        }

        private void OpenChild<T>() where T : Form, new()
        {
            try
            {
                foreach (Form child in this.MdiChildren)
                {
                    if (child is T)
                    {
                        child.Activate();
                        return;
                    }
                }

                T frm = new T();
                frm.MdiParent = this;
                frm.Show();
            }
            catch
            {
                MessageBox.Show("An error occurred while opening the form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dailyPlannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild<DailyPlanner>();
        }

        private void habitTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild<HabitTracker>();
        }

        private void notesOrJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild<Notes>();
        }

        private void focusTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild<FocusTimer>();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild<About>();
        }

        private void tbtnDailyPlanner_Click(object sender, EventArgs e)
        {
            OpenChild<DailyPlanner>();
        }

        private void tbtnHabitTracker_Click(object sender, EventArgs e)
        {
            OpenChild<HabitTracker>();
        }

        private void tbtnNotes_Click(object sender, EventArgs e)
        {
            OpenChild<Notes>();
        }

        private void tbtnFocusTimer_Click(object sender, EventArgs e)
        {
            OpenChild<FocusTimer>();
        }

        private void MDIProductivityDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
