using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculatrice
{
    public partial class Form1 : Form
    {
        double [] operands = new double[2] {0, 0};
        int current_operand = 0;
        char operation = '+';
        double result = 0;

        public Form1()
        {
            InitializeComponent();
            this.textBox.Text = operands[current_operand].ToString();
        }

        private void Disable_operation_buttons()
        {
            this.button_plus.Enabled = false;
            this.button_minus.Enabled = false;
            this.button_mul.Enabled = false;
            this.button_div.Enabled = false;
            this.button_mod.Enabled = false;
            this.button_pow.Enabled = false;
            this.button_sqrt.Enabled = false;
            this.button_fibo.Enabled = false;
            this.button_fact.Enabled = false;
        }

        private void operand_updated(object sender, EventArgs e)
        {
            this.textBox.Text = operands[current_operand].ToString();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            operands[current_operand] *= 10;
            if (operands[current_operand] == 0)
                result = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operands[current_operand] *= 10;
            operands[current_operand]++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operands[current_operand] *= 10;
            operands[current_operand] += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operands[current_operand] *= 10;
            operands[current_operand] += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operands[current_operand] *= 10;
            operands[current_operand] += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operands[current_operand] *= 10;
            operands[current_operand] += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            operands[current_operand] *= 10;
            operands[current_operand] += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            operands[current_operand] *= 10;
            operands[current_operand] += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operands[current_operand] *= 10;
            operands[current_operand] += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operands[current_operand] *= 10;
            operands[current_operand] += 9;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (current_operand == 0)
                current_operand++;
            if (operands[0] == 0)
                operands[0] = result;

            operation = '+';
            Disable_operation_buttons();
        }

        private void button_moins_Click(object sender, EventArgs e)
        {
            if (current_operand == 0)
                current_operand++;
            if (operands[0] == 0)
                operands[0] = result;

            operation = '-';
            Disable_operation_buttons();
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            if (current_operand == 0)
                current_operand++;
            if (operands[0] == 0)
                operands[0] = result;

            operation = '*';
            Disable_operation_buttons();
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            if (current_operand == 0)
                current_operand++;
            if (operands[0] == 0)
                operands[0] = result;

            operation = '/';
            Disable_operation_buttons();
        }

        private void button_mod_Click(object sender, EventArgs e)
        {
            if (current_operand == 0)
                current_operand++;
            if (operands[0] == 0)
                operands[0] = result;

            operation = '%';
            Disable_operation_buttons();
        }

        private void button_pow_Click(object sender, EventArgs e)
        {
            if (current_operand == 0)
                current_operand++;
            if (operands[0] == 0)
                operands[0] = result;

            operation = '^';
            Disable_operation_buttons();
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            if (operands[0] == 0)
                operands[0] = result;

            operation = 's';
            Egal();
        }

        private void button_fibo_Click(object sender, EventArgs e)
        {
            if (operands[0] == 0)
                operands[0] = result;

            operation = 'f';
            Egal();
        }

        private void button_fact_Click(object sender, EventArgs e)
        {
            if (operands[0] == 0)
                operands[0] = result;

            operation = '!';
            Egal();
        }

        private void button_egal_Click(object sender, EventArgs e)
        {
            Egal();
        }

        private void Egal()
        {
            if (operands[0] == 0 && operands[1] == 0)
                return;//several clicks on = button

            switch (operation)
            {
                case '^':
                    result = Calculatrice.Pow((int)operands[0], (int)operands[1]);
                    break;
                /*case 's':
                    result = Calculatrice.Sqrt((float)operands[0], (float)operands[0]);
                    break;*/
                case 'f':
                    result = Calculatrice.Fibo((uint)Math.Abs(operands[0]));
                    break;
                case '!':
                    result = Calculatrice.Factorial((uint)Math.Abs(operands[0]));
                    break;
                default:
                    result = Calculatrice.Simple_operation((long)operands[0], operation, (long)operands[1]);
                    break;
            }

            current_operand = 0;
            this.textBox.Text = result.ToString();
            operands[0] = 0;
            operands[1] = 0;

            this.button_plus.Enabled = true;
            this.button_minus.Enabled = true;
            this.button_mul.Enabled = true;
            this.button_div.Enabled = true;
            this.button_mod.Enabled = true;
            this.button_pow.Enabled = true;
            this.button_sqrt.Enabled = true;
            this.button_fibo.Enabled = true;
            this.button_fact.Enabled = true;
        }
    }
}
