namespace Unicom_TIC_Management_System__UMS_
{
    partial class Form1
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
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnMarks = new System.Windows.Forms.Button();
            this.btnTimetables = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(223, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "UNICOM TIC MANAGEMENT SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(314, 128);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(149, 23);
            this.btnCourses.TabIndex = 1;
            this.btnCourses.Text = "MANAGE COURSES";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Location = new System.Drawing.Point(314, 173);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(149, 23);
            this.btnSubjects.TabIndex = 2;
            this.btnSubjects.Text = "MANAGE SUBJECTS";
            this.btnSubjects.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSubjects.UseVisualStyleBackColor = true;
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(314, 219);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(149, 23);
            this.btnStudents.TabIndex = 3;
            this.btnStudents.Text = "MANAGE STUDENTS";
            this.btnStudents.UseVisualStyleBackColor = true;
            // 
            // btnExams
            // 
            this.btnExams.Location = new System.Drawing.Point(314, 262);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(149, 23);
            this.btnExams.TabIndex = 4;
            this.btnExams.Text = "MANAGE EXAMS";
            this.btnExams.UseVisualStyleBackColor = true;
            // 
            // btnMarks
            // 
            this.btnMarks.Location = new System.Drawing.Point(314, 305);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(149, 23);
            this.btnMarks.TabIndex = 5;
            this.btnMarks.Text = "MANAGE MARKS";
            this.btnMarks.UseVisualStyleBackColor = true;
            // 
            // btnTimetables
            // 
            this.btnTimetables.Location = new System.Drawing.Point(314, 348);
            this.btnTimetables.Name = "btnTimetables";
            this.btnTimetables.Size = new System.Drawing.Size(149, 23);
            this.btnTimetables.TabIndex = 6;
            this.btnTimetables.Text = "MANAGE TIMETABLES";
            this.btnTimetables.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(314, 389);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(149, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTimetables);
            this.Controls.Add(this.btnMarks);
            this.Controls.Add(this.btnExams);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnSubjects);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Button btnTimetables;
        private System.Windows.Forms.Button btnLogout;
    }
}

