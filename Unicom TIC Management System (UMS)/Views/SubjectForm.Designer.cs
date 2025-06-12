using System;

namespace Unicom_TIC_Management_System__UMS_.Views
{
    partial class SubjectForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.cobCourse = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupd = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.dgvsubject = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubject)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-43, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 30);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "SUBJECTS   MANAGEMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "SUBJECT NAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "COURSE NAME";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(227, 62);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(163, 22);
            this.txtSubjectName.TabIndex = 10;
            this.txtSubjectName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cobCourse
            // 
            this.cobCourse.FormattingEnabled = true;
            this.cobCourse.Location = new System.Drawing.Point(227, 102);
            this.cobCourse.Name = "cobCourse";
            this.cobCourse.Size = new System.Drawing.Size(163, 24);
            this.cobCourse.TabIndex = 11;
            this.cobCourse.SelectedIndexChanged += new System.EventHandler(this.cob_SelectedIndexChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(305, 145);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(85, 28);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupd
            // 
            this.btnupd.Location = new System.Drawing.Point(198, 145);
            this.btnupd.Name = "btnupd";
            this.btnupd.Size = new System.Drawing.Size(85, 28);
            this.btnupd.TabIndex = 13;
            this.btnupd.Text = "UPDATE";
            this.btnupd.UseVisualStyleBackColor = true;
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(92, 145);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(85, 28);
            this.btndel.TabIndex = 14;
            this.btndel.Text = "DELETE";
            this.btndel.UseVisualStyleBackColor = true;
            // 
            // dgvsubject
            // 
            this.dgvsubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsubject.Location = new System.Drawing.Point(92, 187);
            this.dgvsubject.Name = "dgvsubject";
            this.dgvsubject.RowHeadersWidth = 51;
            this.dgvsubject.RowTemplate.Height = 24;
            this.dgvsubject.Size = new System.Drawing.Size(297, 112);
            this.dgvsubject.TabIndex = 15;
            this.dgvsubject.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvsubject_RowHeaderMouseClick);
            // 
            // SubjectForm
            // 
            this.ClientSize = new System.Drawing.Size(514, 339);
            this.Controls.Add(this.dgvsubject);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupd);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cobCourse);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "SubjectForm";
            this.Text = "SubjectForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.ComboBox cobCourse;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupd;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.DataGridView dgvsubject;
    }
}
