namespace Productivity_and_Habit_Tracker_MDI_System
{
    partial class Notes
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpenNote = new System.Windows.Forms.Button();
            this.btnRemoveNote = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstNotes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveNote = new System.Windows.Forms.Button();
            this.txtNoteTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOTES";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpenNote);
            this.groupBox2.Controls.Add(this.btnRemoveNote);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lstNotes);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(46, 356);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(413, 243);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notes";
            // 
            // btnOpenNote
            // 
            this.btnOpenNote.BackColor = System.Drawing.Color.PowderBlue;
            this.btnOpenNote.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenNote.Location = new System.Drawing.Point(241, 200);
            this.btnOpenNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenNote.Name = "btnOpenNote";
            this.btnOpenNote.Size = new System.Drawing.Size(77, 24);
            this.btnOpenNote.TabIndex = 8;
            this.btnOpenNote.Text = "Open";
            this.btnOpenNote.UseVisualStyleBackColor = false;
            this.btnOpenNote.Click += new System.EventHandler(this.btnOpenNote_Click);
            // 
            // btnRemoveNote
            // 
            this.btnRemoveNote.BackColor = System.Drawing.Color.Pink;
            this.btnRemoveNote.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNote.Location = new System.Drawing.Point(321, 200);
            this.btnRemoveNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveNote.Name = "btnRemoveNote";
            this.btnRemoveNote.Size = new System.Drawing.Size(77, 24);
            this.btnRemoveNote.TabIndex = 7;
            this.btnRemoveNote.Text = "Remove";
            this.btnRemoveNote.UseVisualStyleBackColor = false;
            this.btnRemoveNote.Click += new System.EventHandler(this.btnRemoveNote_Click);
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
            // lstNotes
            // 
            this.lstNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNotes.FormattingEnabled = true;
            this.lstNotes.ItemHeight = 17;
            this.lstNotes.Location = new System.Drawing.Point(17, 22);
            this.lstNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.Size = new System.Drawing.Size(381, 174);
            this.lstNotes.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSaveNote);
            this.groupBox1.Controls.Add(this.txtNoteTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(413, 297);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(22, 73);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(376, 181);
            this.txtNotes.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Notes:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Linen;
            this.btnClear.Location = new System.Drawing.Point(321, 258);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 24);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSaveNote.Location = new System.Drawing.Point(241, 258);
            this.btnSaveNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(77, 24);
            this.btnSaveNote.TabIndex = 4;
            this.btnSaveNote.Text = "Save";
            this.btnSaveNote.UseVisualStyleBackColor = false;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // txtNoteTitle
            // 
            this.txtNoteTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoteTitle.Location = new System.Drawing.Point(97, 20);
            this.txtNoteTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNoteTitle.Name = "txtNoteTitle";
            this.txtNoteTitle.Size = new System.Drawing.Size(301, 23);
            this.txtNoteTitle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Note Title:";
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Notes";
            this.Text = "NotesJournal";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstNotes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveNote;
        private System.Windows.Forms.TextBox txtNoteTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenNote;
    }
}