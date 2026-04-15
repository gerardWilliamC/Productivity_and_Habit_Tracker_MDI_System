namespace Productivity_and_Habit_Tracker_MDI_System
{
    partial class HabitTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddHabit = new System.Windows.Forms.Button();
            this.txtHabitName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveHabit = new System.Windows.Forms.Button();
            this.btnMarkAsDone = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstHabits = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnAddHabit);
            this.groupBox1.Controls.Add(this.txtHabitName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(382, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Linen;
            this.btnClear.Location = new System.Drawing.Point(269, 49);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 25);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddHabit
            // 
            this.btnAddHabit.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddHabit.Location = new System.Drawing.Point(269, 20);
            this.btnAddHabit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddHabit.Name = "btnAddHabit";
            this.btnAddHabit.Size = new System.Drawing.Size(98, 25);
            this.btnAddHabit.TabIndex = 4;
            this.btnAddHabit.Text = "Add Habit";
            this.btnAddHabit.UseVisualStyleBackColor = false;
            this.btnAddHabit.Click += new System.EventHandler(this.btnAddHabit_Click);
            // 
            // txtHabitName
            // 
            this.txtHabitName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHabitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHabitName.Location = new System.Drawing.Point(104, 21);
            this.txtHabitName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHabitName.Name = "txtHabitName";
            this.txtHabitName.Size = new System.Drawing.Size(161, 23);
            this.txtHabitName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Habit Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "HABIT TRACKER";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveHabit);
            this.groupBox2.Controls.Add(this.btnMarkAsDone);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lstHabits);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(41, 154);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(382, 261);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Habits";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnRemoveHabit
            // 
            this.btnRemoveHabit.BackColor = System.Drawing.Color.Pink;
            this.btnRemoveHabit.Location = new System.Drawing.Point(243, 219);
            this.btnRemoveHabit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveHabit.Name = "btnRemoveHabit";
            this.btnRemoveHabit.Size = new System.Drawing.Size(124, 29);
            this.btnRemoveHabit.TabIndex = 7;
            this.btnRemoveHabit.Text = "Remove";
            this.btnRemoveHabit.UseVisualStyleBackColor = false;
            this.btnRemoveHabit.Click += new System.EventHandler(this.btnRemoveHabit_Click);
            // 
            // btnMarkAsDone
            // 
            this.btnMarkAsDone.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMarkAsDone.Location = new System.Drawing.Point(243, 186);
            this.btnMarkAsDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMarkAsDone.Name = "btnMarkAsDone";
            this.btnMarkAsDone.Size = new System.Drawing.Size(124, 29);
            this.btnMarkAsDone.TabIndex = 6;
            this.btnMarkAsDone.Text = "Done";
            this.btnMarkAsDone.UseVisualStyleBackColor = false;
            this.btnMarkAsDone.Click += new System.EventHandler(this.btnMarkAsDone_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 6;
            // 
            // lstHabits
            // 
            this.lstHabits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHabits.FormattingEnabled = true;
            this.lstHabits.ItemHeight = 17;
            this.lstHabits.Location = new System.Drawing.Point(17, 22);
            this.lstHabits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstHabits.Name = "lstHabits";
            this.lstHabits.Size = new System.Drawing.Size(350, 157);
            this.lstHabits.TabIndex = 0;
            // 
            // HabitTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HabitTracker";
            this.Text = "HabitTracker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddHabit;
        private System.Windows.Forms.TextBox txtHabitName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMarkAsDone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstHabits;
        private System.Windows.Forms.Button btnRemoveHabit;
    }
}