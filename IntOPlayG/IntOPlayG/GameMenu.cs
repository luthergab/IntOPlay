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
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void additionBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addition addition = new Addition();
            addition.ShowDialog();
        }

        private void subtractionBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subtraction subtraction = new Subtraction();
            subtraction.ShowDialog();
        }

        private void multiplicationBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Multiplication multiplication = new Multiplication();
            multiplication.ShowDialog();
        }

        private void divisionBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Division division = new Division();
            division.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for Playing UwU");
            Application.Exit();
        }
    }
}
