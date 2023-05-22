using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntOPlayG
{
    public partial class MultiplicationQuestions : Form
    {
        private int questionCount;
        private int count;
        int randomNumber1;
        int randomNumber2;
        public MultiplicationQuestions(int questionCount)
        {
            InitializeComponent();
            this.questionCount = questionCount;
            this.count = 0;
            GenerateQuestion();
        }

        private void proAnsTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void proSubmit_Click(object sender, EventArgs e)
        {
            int answer = int.Parse(proAnsTxt.Text);
            int pro = randomNumber1 * randomNumber2;
            if (answer == randomNumber1 * randomNumber2)
            {
                MessageBox.Show("Correct!");
                proAnsTxt.Text = null;
                count++;
                if (count == questionCount)
                {
                    MessageBox.Show("Complete!");
                    this.Hide();
                    Record record = new Record();
                    record.ShowDialog();
                }
                else
                {
                    GenerateQuestion();
                }
            }
            else if (answer != pro)
            {
                MessageBox.Show("Incorrect! \nCorrect answer is: " + pro, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                proAnsTxt.Text = null;
                count++;
                if (count == questionCount)
                {
                    MessageBox.Show("Complete!");
                    this.Hide();
                    Record record = new Record();
                    record.ShowDialog();
                }
                else
                {
                    GenerateQuestion();
                }
            }
        }

        private void GenerateQuestion()
        {
            Random random = new Random();
            // Generate a random integer for the first label
            randomNumber1 = random.Next(0, 10);
            num1Txt.Text = randomNumber1.ToString();
            // Generate a random integer for the second label
            randomNumber2 = random.Next(0, 9);
            num2Txt.Text = randomNumber2.ToString();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Multiplication multiplication = new Multiplication();
            multiplication.ShowDialog();
        }
    }
}
