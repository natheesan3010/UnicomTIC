namespace Unicom_TIC_Management_System__UMS_.Views
{
    partial class StudentDashBoard
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnMarks = new System.Windows.Forms.Button();
            this.btnTimetables = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightGray;
            this.panelHeader.Controls.Add(this.lblHeading);
            this.panelHeader.Location = new System.Drawing.Point(1, 3);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(600, 41);
            this.panelHeader.TabIndex = 17;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // lblHeading
            // 
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.Black;
            this.lblHeading.Location = new System.Drawing.Point(0, 0);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(600, 41);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "UNICOM TIC STUDENT\'S DASHBOARD";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Location = new System.Drawing.Point(117, 50);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(478, 311);
            this.panelMain.TabIndex = 9;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // btnCourses
            // 
            this.btnCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.Location = new System.Drawing.Point(1, 115);
            this.btnCourses.Margin = new System.Windows.Forms.Padding(2);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(112, 32);
            this.btnCourses.TabIndex = 11;
            this.btnCourses.Text = "View Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjects.Location = new System.Drawing.Point(-1, 160);
            this.btnSubjects.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(112, 32);
            this.btnSubjects.TabIndex = 12;
            this.btnSubjects.Text = "View Subjects";
            this.btnSubjects.UseVisualStyleBackColor = true;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // btnExams
            // 
            this.btnExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExams.Location = new System.Drawing.Point(1, 204);
            this.btnExams.Margin = new System.Windows.Forms.Padding(2);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(112, 32);
            this.btnExams.TabIndex = 13;
            this.btnExams.Text = "View Exams";
            this.btnExams.UseVisualStyleBackColor = true;
            this.btnExams.Click += new System.EventHandler(this.btnExams_Click);
            // 
            // btnMarks
            // 
            this.btnMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarks.Location = new System.Drawing.Point(1, 243);
            this.btnMarks.Margin = new System.Windows.Forms.Padding(2);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(112, 32);
            this.btnMarks.TabIndex = 14;
            this.btnMarks.Text = "View Marks";
            this.btnMarks.UseVisualStyleBackColor = true;
            this.btnMarks.Click += new System.EventHandler(this.btnMarks_Click);
            // 
            // btnTimetables
            // 
            this.btnTimetables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimetables.Location = new System.Drawing.Point(-1, 284);
            this.btnTimetables.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimetables.Name = "btnTimetables";
            this.btnTimetables.Size = new System.Drawing.Size(112, 38);
            this.btnTimetables.TabIndex = 15;
            this.btnTimetables.Text = "View Timetables";
            this.btnTimetables.UseVisualStyleBackColor = true;
            this.btnTimetables.Click += new System.EventHandler(this.btnTimetables_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(-1, 331);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 32);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Unicom_TIC_Management_System__UMS_.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 95);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // StudentDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnSubjects);
            this.Controls.Add(this.btnExams);
            this.Controls.Add(this.btnMarks);
            this.Controls.Add(this.btnTimetables);
            this.Controls.Add(this.btnLogout);
            this.Name = "StudentDashBoard";
            this.Text = "StudentDashBoard";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Button btnTimetables;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}