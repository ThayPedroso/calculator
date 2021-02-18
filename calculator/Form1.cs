using System;
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
            this.display_main.ResetText();
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            this.display_main.Text = this.display_main.Text + "0";
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            this.display_main.Text = this.display_main.Text + "1";
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            this.display_main.Text = this.display_main.Text + "2";
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            this.display_main.Text = this.display_main.Text + "3";
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            this.display_main.Text = this.display_main.Text + "4";
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            this.display_main.Text = this.display_main.Text + "5";
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            this.display_main.Text = this.display_main.Text + "6";
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            this.display_main.Text = this.display_main.Text + "7";
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            this.display_main.Text = this.display_main.Text + "8";
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            this.display_main.Text = this.display_main.Text + "9";
        }

        private void btn_addition_Click(object sender, EventArgs e)
        {
            this.display_operation.Text = "+";
            if (this.display_main.Text != "")
            {
                this.display_firstNumber.Text = this.display_main.Text;
            }
            this.display_main.ResetText();
        }

        private void btn_subtraction_Click(object sender, EventArgs e)
        {
            this.display_operation.Text = "-";
            if (this.display_main.Text != "")
            {
                this.display_firstNumber.Text = this.display_main.Text;
            }
            this.display_main.ResetText();
        }

        private void btn_multiplication_Click(object sender, EventArgs e)
        {
            this.display_operation.Text = "*";
            if (this.display_main.Text != "")
            {
                this.display_firstNumber.Text = this.display_main.Text;
            }
            this.display_main.ResetText();
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            this.display_operation.Text = "/";
            if (this.display_main.Text != "")
            {
                this.display_firstNumber.Text = this.display_main.Text;
            }
            this.display_main.ResetText();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            this.display_operation.Text = "%";
            if (this.display_main.Text != "")
            {
                this.display_firstNumber.Text = this.display_main.Text;
            }
            this.display_main.ResetText();
        }
    }
}
