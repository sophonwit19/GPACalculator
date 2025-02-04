using System;
using System.Windows.Forms;

namespace GPA2
{
    partial class Form1
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

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lblTitle = new Label();
            tbInputScore = new TextBox();
            btnAddScore = new Button();
            lblMaxScore = new Label();
            lblMinScore = new Label();
            lblGPAX = new Label();
            lblStudentCount = new Label();
            tbMaxScore = new TextBox();
            tbMinScore = new TextBox();
            tbGPAX = new TextBox();
            tbStudentCount = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTitle);
            groupBox1.Controls.Add(tbInputScore);
            groupBox1.Controls.Add(btnAddScore);
            groupBox1.Controls.Add(lblMaxScore);
            groupBox1.Controls.Add(lblMinScore);
            groupBox1.Controls.Add(lblGPAX);
            groupBox1.Controls.Add(lblStudentCount);
            groupBox1.Controls.Add(tbMaxScore);
            groupBox1.Controls.Add(tbMinScore);
            groupBox1.Controls.Add(tbGPAX);
            groupBox1.Controls.Add(tbStudentCount);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 220);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "เช็คเกรด";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(150, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(96, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ใส่เกรดของคุณ";
            // 
            // tbInputScore
            // 
            tbInputScore.Location = new Point(30, 33);
            tbInputScore.Name = "tbInputScore";
            tbInputScore.Size = new Size(100, 27);
            tbInputScore.TabIndex = 1;
            // 
            // btnAddScore
            // 
            btnAddScore.Location = new Point(266, 68);
            btnAddScore.Name = "btnAddScore";
            btnAddScore.Size = new Size(100, 119);
            btnAddScore.TabIndex = 2;
            btnAddScore.Text = "เพิ่มคะแนน";
            btnAddScore.Click += btnAddScore_Click;
            // 
            // lblMaxScore
            // 
            lblMaxScore.Location = new Point(30, 70);
            lblMaxScore.Name = "lblMaxScore";
            lblMaxScore.Size = new Size(100, 23);
            lblMaxScore.TabIndex = 4;
            lblMaxScore.Text = "คะแนนสูงสุด  :";
            // 
            // lblMinScore
            // 
            lblMinScore.Location = new Point(30, 100);
            lblMinScore.Name = "lblMinScore";
            lblMinScore.Size = new Size(100, 23);
            lblMinScore.TabIndex = 5;
            lblMinScore.Text = "คะแนนต่ำสุด  :";
            // 
            // lblGPAX
            // 
            lblGPAX.Location = new Point(30, 130);
            lblGPAX.Name = "lblGPAX";
            lblGPAX.Size = new Size(100, 23);
            lblGPAX.TabIndex = 6;
            lblGPAX.Text = "GPAX  :";
            // 
            // lblStudentCount
            // 
            lblStudentCount.Location = new Point(30, 160);
            lblStudentCount.Name = "lblStudentCount";
            lblStudentCount.Size = new Size(100, 23);
            lblStudentCount.TabIndex = 7;
            lblStudentCount.Text = "จำนวนคน  :";
            // 
            // tbMaxScore
            // 
            tbMaxScore.Location = new Point(150, 70);
            tbMaxScore.Name = "tbMaxScore";
            tbMaxScore.ReadOnly = true;
            tbMaxScore.Size = new Size(100, 27);
            tbMaxScore.TabIndex = 8;
            // 
            // tbMinScore
            // 
            tbMinScore.Location = new Point(150, 100);
            tbMinScore.Name = "tbMinScore";
            tbMinScore.ReadOnly = true;
            tbMinScore.Size = new Size(100, 27);
            tbMinScore.TabIndex = 9;
            // 
            // tbGPAX
            // 
            tbGPAX.Location = new Point(150, 130);
            tbGPAX.Name = "tbGPAX";
            tbGPAX.ReadOnly = true;
            tbGPAX.Size = new Size(100, 27);
            tbGPAX.TabIndex = 10;
            // 
            // tbStudentCount
            // 
            tbStudentCount.Location = new Point(150, 160);
            tbStudentCount.Name = "tbStudentCount";
            tbStudentCount.ReadOnly = true;
            tbStudentCount.Size = new Size(100, 27);
            tbStudentCount.TabIndex = 11;
            // 
            // Form1
            // 
            ClientSize = new Size(450, 250);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "เช็คเกรด";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbInputScore;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.Label lblMaxScore;
        private System.Windows.Forms.Label lblMinScore;
        private System.Windows.Forms.Label lblGPAX;
        private System.Windows.Forms.Label lblStudentCount;
        private System.Windows.Forms.TextBox tbMaxScore;
        private System.Windows.Forms.TextBox tbMinScore;
        private System.Windows.Forms.TextBox tbGPAX;
        private System.Windows.Forms.TextBox tbStudentCount;
    }
}
