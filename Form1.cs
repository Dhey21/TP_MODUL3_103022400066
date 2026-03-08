using System;
using System.Windows.Forms;

namespace TP_MODUL3_103022400066
{
    public partial class Form1 : Form
    {
        private string currentInput = "";
        private double firstNumber = 0;
        private string operation = "";
        private bool isNewInput = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAngka_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string angka = btn.Text;

            if (isNewInput)
            {
                currentInput = angka;
                isNewInput = false;
            }
            else
            {
                currentInput += angka;
            }

            labelOutput.Text = currentInput;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (currentInput != "")
            {
                firstNumber = double.Parse(currentInput);
                operation = "+";
                isNewInput = true;
            }
        }

        private void btnSama_Click(object sender, EventArgs e)
        {
            if (operation != "" && currentInput != "")
            {
                double secondNumber = double.Parse(currentInput);
                double hasil = 0;

                if (operation == "+")
                {
                    hasil = firstNumber + secondNumber;
                }

                labelOutput.Text = hasil.ToString();
                currentInput = hasil.ToString();
                operation = "";
                isNewInput = true;
            }
        }
    }
}