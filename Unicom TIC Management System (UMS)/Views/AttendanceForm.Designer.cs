namespace Unicom_TIC_Management_System__UMS_.Views
{
    partial class AttendanceForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-63, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 48);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "ATTENDANCE   DETAILS";
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(248, 110);
            this.textBoxStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(206, 22);
            this.textBoxStudentName.TabIndex = 49;
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentName.Location = new System.Drawing.Point(102, 112);
            this.labelStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(151, 20);
            this.labelStudentName.TabIndex = 48;
            this.labelStudentName.Text = "STUDENT NAME :";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(251, 194);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(206, 24);
            this.comboBoxStatus.TabIndex = 47;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(105, 198);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(84, 20);
            this.labelStatus.TabIndex = 46;
            this.labelStatus.Text = "STATUS :";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(249, 153);
            this.comboBoxSubject.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(206, 24);
            this.comboBoxSubject.TabIndex = 45;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(102, 24);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(64, 20);
            this.labelDate.TabIndex = 44;
            this.labelDate.Text = "DATE :";
            // 
            // btnAttendance
            // 
            this.btnAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.Location = new System.Drawing.Point(357, 228);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(100, 28);
            this.btnAttendance.TabIndex = 43;
            this.btnAttendance.Text = " ADD";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnMarkAttendance_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(99, 229);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(236, 229);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(248, 68);
            this.textBoxStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(206, 22);
            this.textBoxStudentID.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "SUBJECT :";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentID.Location = new System.Drawing.Point(102, 64);
            this.labelStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(115, 20);
            this.labelStudentID.TabIndex = 36;
            this.labelStudentID.Text = "STUDENT ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 35;
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(59, 265);
            this.dgvAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.Size = new System.Drawing.Size(440, 154);
            this.dgvAttendance.TabIndex = 50;
            this.dgvAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DatePicker);
            this.panel2.Controls.Add(this.dgvAttendance);
            this.panel2.Controls.Add(this.textBoxStudentName);
            this.panel2.Controls.Add(this.labelStudentName);
            this.panel2.Controls.Add(this.comboBoxStatus);
            this.panel2.Controls.Add(this.labelStatus);
            this.panel2.Controls.Add(this.comboBoxSubject);
            this.panel2.Controls.Add(this.labelDate);
            this.panel2.Controls.Add(this.btnAttendance);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.textBoxStudentID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelStudentID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(100, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 432);
            this.panel2.TabIndex = 51;
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(251, 24);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(206, 22);
            this.DatePicker.TabIndex = 52;
            this.DatePicker.Visible = false;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 508);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DatePicker;
    }
}