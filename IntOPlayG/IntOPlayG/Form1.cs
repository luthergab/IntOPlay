using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace IntOPlayG
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            player.URL = "Game 8 Bit.mp3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            string name  = namePlayer.Text;
            string age = agePlayer.Text;
            if (name == string.Empty || age == string.Empty)
            {
                MessageBox.Show("PLEASE ENTER BOTH NAME AND AGE...");
            }
            else
            {
                this.Hide();
                GameMenu gameMenu = new GameMenu();
                gameMenu.ShowDialog();
            }
            
        }

        private void namePlayer_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            MessageBox.Show("Thank you for Playing UwU");
            Application.Exit();
        }
    }
}
