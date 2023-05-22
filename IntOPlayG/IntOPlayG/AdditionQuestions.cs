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
    public partial class AdditionQuestions : Form
    {
        private int questionCount;
        private int count;
        int randomNumber1;
        int randomNumber2;
        public AdditionQuestions(int questionCount)
        {
            InitializeComponent();
            this.questionCount = questionCount;
            this.count = 0;
            GenerateQuestion();
        }
        private void AdditionQuestions_Load(object sender, EventArgs e)
        {
   
        }

        private void sumAnsTxt_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void addSubmit_Click(object sender, EventArgs e)
        {

            int answer = int.Parse(sumAnsTxt.Text);
            int sum = randomNumber1 + randomNumber2;
            if (answer == randomNumber1 + randomNumber2)
            {
                MessageBox.Show("Correct!");
                sumAnsTxt.Text = null;
                count ++;
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
            else if (answer != sum)
            {
                MessageBox.Show("Incorrect! \nCorrect answer is: " + sum, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumAnsTxt.Text = null;
                count ++;
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
            randomNumber1 = random.Next(0,20);
            num1Txt.Text = randomNumber1.ToString();
            // Generate a random integer for the second label
            randomNumber2 = random.Next(0,20);
            num2Txt.Text = randomNumber2.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addition addition = new Addition();
            addition.ShowDialog();
        }
    }
}
