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
    public partial class SubtractionQuestions : Form
    {
        private int questionCount;
        private int count;
        int randomNumber1;
        int randomNumber2;
        public SubtractionQuestions(int questionCount)
        {
            InitializeComponent();
            this.questionCount = questionCount;
            this.count = 0;
            GenerateQuestion();
        }

        private void diffAnsTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void diffSubmit_Click(object sender, EventArgs e)
        {
            int answer = int.Parse(diffAnsTxt.Text);
            int diff = randomNumber1 - randomNumber2;
            if (answer == randomNumber1 - randomNumber2)
            {
                MessageBox.Show("Correct!");
                diffAnsTxt.Text = null;
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
            else if (answer != diff)
            {
                MessageBox.Show("Incorrect! \nCorrect answer is: " + diff, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                diffAnsTxt.Text = null;
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
            randomNumber1 = random.Next(0, 20);
            num1Txt.Text = randomNumber1.ToString();
            // Generate a random integer for the second label
            randomNumber2 = random.Next(0, 20);
            num2Txt.Text = randomNumber2.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subtraction subtraction = new Subtraction();
            subtraction.ShowDialog();
        }

        private void SubtractionQuestions_Load(object sender, EventArgs e)
        {

        }
    }
}
