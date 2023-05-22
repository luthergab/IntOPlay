using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntOPlayG
{
    public partial class Addition : Form
    {
        public Addition()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameMenu gameMenu = new GameMenu();
            gameMenu.ShowDialog();
        }

        private void ansTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void enterBtn_Click(object sender, EventArgs e)
        {
            string answer = ansTxt.Text;
            int numAnswer;

            int.TryParse(answer, out numAnswer);

            if (answer == string.Empty)
            {
                MessageBox.Show("Please enter a number.");
            }
            else
            {
                MessageBox.Show(numAnswer.ToString());
                this.Hide();
                AdditionQuestions additionQuestions = new AdditionQuestions(numAnswer);
                additionQuestions.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Addition_Load(object sender, EventArgs e)
        {

        }
    }
}
