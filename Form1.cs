using System;
using System.Windows.Forms;

namespace GPA2
{
    public partial class Form1 : Form
    {
        private List<double> scores = new List<double>(); // �纤�ṹ

        public Form1()
        {
            InitializeComponent();
        }

        // �ѧ��ѹ������ṹ����ѻവ������
        private void AddScore(double score)
        {
            scores.Add(score);
            UpdateGradeInfo();
        }

        // �ѧ��ѹ�ӹǳ����ô����ʴ���
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

        // ����������ṹ
        private void btnAddScore_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbInputScore.Text, out double score))
            {
                AddScore(score);
                tbInputScore.Clear();
            }
            else
            {
                MessageBox.Show("��سҡ�͡��ṹ���١��ͧ", "��ͼԴ��Ҵ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
