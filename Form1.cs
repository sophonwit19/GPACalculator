using System;
using System.Windows.Forms;

namespace GPA2
{
    public partial class Form1 : Form
    {
        private List<double> scores = new List<double>(); // เก็บคะแนน

        public Form1()
        {
            InitializeComponent();
        }

        // ฟังก์ชันเพิ่มคะแนนและอัปเดตข้อมูล
        private void AddScore(double score)
        {
            scores.Add(score);
            UpdateGradeInfo();
        }

        // ฟังก์ชันคำนวณค่าเกรดและแสดงผล
        private void UpdateGradeInfo()
        {
            if (scores.Count == 0)
            {
                tbMaxScore.Text = "";
                tbMinScore.Text = "";
                tbGPAX.Text = "";
                tbStudentCount.Text = "";
                return;
            }

            double maxScore = scores.Max();
            double minScore = scores.Min();
            double gpax = scores.Average();
            int studentCount = scores.Count;

            tbMaxScore.Text = maxScore.ToString("0.00");
            tbMinScore.Text = minScore.ToString("0.00");
            tbGPAX.Text = gpax.ToString("0.00");
            tbStudentCount.Text = studentCount.ToString();
        }

        // ปุ่มเพิ่มคะแนน
        private void btnAddScore_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbInputScore.Text, out double score))
            {
                AddScore(score);
                tbInputScore.Clear();
            }
            else
            {
                MessageBox.Show("กรุณากรอกคะแนนให้ถูกต้อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
