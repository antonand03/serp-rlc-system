using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Raps50_Click(object sender, EventArgs e)
        {
            channelDisplay.Text = "NUVARANDE KANAL: RAPS 50";
        }
        private void Raps51_Click(object sender, EventArgs e)
        {
            channelDisplay.Text = "NUVARANDE KANAL: RAPS 51";
        }
        private void Raps52_Click(object sender, EventArgs e)
        {
            channelDisplay.Text = "NUVARANDE KANAL: RAPS 52";
        }
        private void Raps53_Click(object sender, EventArgs e)
        {
            channelDisplay.Text = "NUVARANDE KANAL: RAPS 53";
        }
        private void Raps54_Click(object sender, EventArgs e)
        {
            channelDisplay.Text = "NUVARANDE KANAL: RAPS 54";
        }
        private void Raps55_Click(object sender, EventArgs e)
        {
            channelDisplay.Text = "NUVARANDE KANAL: RAPS 55";
        }
        private void Insats51_Click(object sender, EventArgs e)
        {
            channelDisplay.Text = "NUVARANDE KANAL: INSATS 51";
        }
        private void Insats52_Click(object sender, EventArgs e)
        {
            channelDisplay.Text = "NUVARANDE KANAL: INSATS 52";
        }
        private void Insats53_Click(object sender, EventArgs e)
        {
            channelDisplay.Text = "NUVARANDE KANAL: INSATS 53";
        }
        private void Insats54_Click(object sender, EventArgs e)
        {
            channelDisplay.Text = "NUVARANDE KANAL: INSATS 54";
        }
        private void Anrop_Click(object sender, EventArgs e)
        {
            channelDisplay.Text = "NUVARANDE KANAL: ANROP STOCKHOLM";
        }
    }
}
