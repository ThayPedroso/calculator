using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.display.ResetText();
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            this.display.Text = this.display.Text + "0";
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            this.display.Text = this.display.Text + "1";
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            this.display.Text = this.display.Text + "2";
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            this.display.Text = this.display.Text + "3";
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            this.display.Text = this.display.Text + "4";
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            this.display.Text = this.display.Text + "5";
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            this.display.Text = this.display.Text + "6";
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            this.display.Text = this.display.Text + "7";
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            this.display.Text = this.display.Text + "8";
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            this.display.Text = this.display.Text + "9";
        }
    }
}
