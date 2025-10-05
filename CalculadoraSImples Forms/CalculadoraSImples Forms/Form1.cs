using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSImples_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void buttonLess_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void buttonParentheses_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            textBox1.Text += "√";
        }

        private void buttonbuttonBackspace_Click(object sender, EventArgs e)
        {
            string textoAtual = textBox1.Text;

            if (textoAtual.Length > 0)
            {
                string novoTexto = textoAtual.Substring(0, textoAtual.Length - 1);
                textBox1.Text = novoTexto;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("+") || textBox1.Text.StartsWith("*") || textBox1.Text.StartsWith("/") || textBox1.Text.StartsWith(","))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                MessageBox.Show("NÃO É PERMITIDO COMEÇAR COM ESSE SINAL", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("NÃO É PERMITIDO INSERIR LETRAS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string expressao = textBox1.Text.Trim();
            try
            {
                DataTable dt = new DataTable();
                var resultadoObj = dt.Compute(expressao, null);
                string resultadoStr = resultadoObj.ToString().Replace(",", ".");

                textBox1.Text = Convert.ToDouble(resultadoStr).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na expressão: {ex.Message}", "Erro de Cálculo");
            }
        }
    }
}
