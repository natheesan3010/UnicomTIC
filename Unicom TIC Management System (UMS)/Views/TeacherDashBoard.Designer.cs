namespace Unicom_TIC_Management_System__UMS_.Views
{
    partial class TeacherDashBoard
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
            this.btnStudents = new System.Windows.Forms.Button();
            this.panelMain1 = new System.Windows.Forms.Panel();
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
            this.lblHeading.Text = "UNICOM TIC TEACHER\'S DASHBOARD\r\n";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStudents
            // 
            this.btnStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.Location = new System.Drawing.Point(1, 145);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(112, 32);
            this.btnStudents.TabIndex = 10;
            this.btnStudents.Text = "Manage Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // panelMain1
            // 
            this.panelMain1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain1.Location = new System.Drawing.Point(117, 50);
            this.panelMain1.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain1.Name = "panelMain1";
            this.panelMain1.Size = new System.Drawing.Size(478, 311);
            this.panelMain1.TabIndex = 9;
            // 
            // btnExams
            // 
            this.btnExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExams.Location = new System.Drawing.Point(-1, 189);
            this.btnExams.Margin = new System.Windows.Forms.Padding(2);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(112, 32);
            this.btnExams.TabIndex = 13;
            this.btnExams.Text = "Manage Exams";
            this.btnExams.UseVisualStyleBackColor = true;
            this.btnExams.Click += new System.EventHandler(this.btnExams_Click);
            // 
            // btnMarks
            // 
            this.btnMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarks.Location = new System.Drawing.Point(-1, 235);
            this.btnMarks.Margin = new System.Windows.Forms.Padding(2);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(112, 32);
            this.btnMarks.TabIndex = 14;
            this.btnMarks.Text = "Manage Marks";
            this.btnMarks.UseVisualStyleBackColor = true;
            // 
            // btnTimetables
            // 
            this.btnTimetables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimetables.Location = new System.Drawing.Point(-1, 280);
            this.btnTimetables.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimetables.Name = "btnTimetables";
            this.btnTimetables.Size = new System.Drawing.Size(112, 38);
            this.btnTimetables.TabIndex = 15;
            this.btnTimetables.Text = "Manage Timetables";
            this.btnTimetables.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(-1, 329);
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
            this.pictureBox1.Location = new System.Drawing.Point(-1, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 95);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TeacherDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.panelMain1);
            this.Controls.Add(this.btnExams);
            this.Controls.Add(this.btnMarks);
            this.Controls.Add(this.btnTimetables);
            this.Controls.Add(this.btnLogout);
            this.Name = "TeacherDashBoard";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherDashBoard_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Panel panelMain1;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Button btnTimetables;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}