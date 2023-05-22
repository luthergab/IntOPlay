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
    public partial class DivisionQuestions : Form
    {
        private int questionCount;
        private int count;
        int randomNumber1;
        int randomNumber2;
        public DivisionQuestions(int questionCount)
        {
            InitializeComponent();
            this.questionCount = questionCount;
            this.count = 0;
            GenerateQuestion();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Division division = new Division();
            division.ShowDialog();
        }

        private void quoAnsTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void quoSubmit_Click(object sender, EventArgs e)
        {
            float answer = float.Parse(quoAnsTxt.Text);
            float quo = randomNumber1 / randomNumber2;
            if (answer == randomNumber1 / randomNumber2)
            {
                MessageBox.Show("Correct!");
                quoAnsTxt.Text = null;
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
            else if (answer != quo)
            {
                MessageBox.Show("Incorrect! \nCorrect answer is: " + quo, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                quoAnsTxt.Text = null;
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
    }
}
