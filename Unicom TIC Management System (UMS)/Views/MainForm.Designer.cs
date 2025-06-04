namespace Unicom_TIC_Management_System__UMS_.Views
{
    partial class MainForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTimetables = new System.Windows.Forms.Button();
            this.btnMarks = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(341, 374);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(149, 23);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTimetables
            // 
            this.btnTimetables.Location = new System.Drawing.Point(341, 333);
            this.btnTimetables.Name = "btnTimetables";
            this.btnTimetables.Size = new System.Drawing.Size(149, 23);
            this.btnTimetables.TabIndex = 14;
            this.btnTimetables.Text = "MANAGE TIMETABLES";
            this.btnTimetables.UseVisualStyleBackColor = true;
            this.btnTimetables.Click += new System.EventHandler(this.btnTimetables_Click);
            // 
            // btnMarks
            // 
            this.btnMarks.Location = new System.Drawing.Point(341, 290);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(149, 23);
            this.btnMarks.TabIndex = 13;
            this.btnMarks.Text = "MANAGE MARKS";
            this.btnMarks.UseVisualStyleBackColor = true;
            this.btnMarks.Click += new System.EventHandler(this.btnMarks_Click);
            // 
            // btnExams
            // 
            this.btnExams.Location = new System.Drawing.Point(341, 247);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(149, 23);
            this.btnExams.TabIndex = 12;
            this.btnExams.Text = "MANAGE EXAMS";
            this.btnExams.UseVisualStyleBackColor = true;
            this.btnExams.Click += new System.EventHandler(this.btnExams_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(341, 204);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(149, 23);
            this.btnStudents.TabIndex = 11;
            this.btnStudents.Text = "MANAGE STUDENTS";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Location = new System.Drawing.Point(341, 158);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(149, 23);
            this.btnSubjects.TabIndex = 10;
            this.btnSubjects.Text = "MANAGE SUBJECTS";
            this.btnSubjects.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSubjects.UseVisualStyleBackColor = true;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(341, 113);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(149, 23);
            this.btnCourses.TabIndex = 9;
            this.btnCourses.Text = "MANAGE COURSES";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(250, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "UNICOM TIC MANAGEMENT SYSTEM";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTimetables);
            this.Controls.Add(this.btnMarks);
            this.Controls.Add(this.btnExams);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnSubjects);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTimetables;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Label label1;
    }
}