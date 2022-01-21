using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perguntas_com_txt
{
    public partial class Form1 : Form
    {
        string ok;
        Random Num = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sumiu (false);

            if(ok == "a")
            {
                label1.Text = "Parabéns! você acertou";
            }
            else
            {
                label1.Text = "Você errou ;-;";
            }
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sumiu(false);

            if (ok == "b")
            {
                label1.Text = "Parabéns! você acertou";
            }
            else
            {
                label1.Text = "Você errou ;-;";
            }
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sumiu(false);

            if (ok == "c")
            {
                label1.Text = "Parabéns! você acertou";
            }
            else
            {
                label1.Text = "Você errou ;-;";
            }
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sumiu(false);

            if (ok == "d")
            {
                label1.Text = "Parabéns! você acertou";
            }
            else
            {
                label1.Text = "Você errou ;-;";
            }
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            richTextBox1.Visible = false;
            sumiu(true);
            label1.Text = "";
            int qual = Num.Next(richTextBox1.Lines.Length);
            string[] questão = richTextBox1.Lines[qual].Split('@');

            label2.Text = qual + "." + questão[0];
            label3.Text = questão[1];
            label4.Text = questão[1];
            label5.Text = questão[1];
            label6.Text = questão[1];
            ok = questão[5];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.LoadFile("perguntas.txt", RichTextBoxStreamType.PlainText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tem certeza");
            richTextBox1.SaveFile("perguntas.txt", RichTextBoxStreamType.PlainText);
            label1.Text = "arquivo salvo com sucesso";
        }

        private void sumiu(Boolean sd)
        {
            button4.Enabled = sd;
            button5.Enabled = sd;
            button6.Enabled = sd;
            button7.Enabled = sd;
        }
    }
}
