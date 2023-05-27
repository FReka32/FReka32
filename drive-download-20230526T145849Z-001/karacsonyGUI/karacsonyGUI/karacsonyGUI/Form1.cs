using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karacsonyGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 40; i++)
            {
                comboBox1.Items.Add(i+1);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nap = Convert.ToInt32(comboBox1.SelectedItem);
            int elkeszitett = Convert.ToInt32(textBox1.Text);
            int eladott = Convert.ToInt32(textBox2.Text);

            if (elkeszitett < 0 || eladott < 0 || elkeszitett-eladott<0)
            {
                label4.Text = "nem lehet negatív, vagy az eladott több!";
            }
            else
            {
                richTextBox1.Text += nap + ".nap\t" +  elkeszitett + " db\t" + eladott + " db\n";
                for (int i = nap; i < 40; i++)
                {
                    comboBox1.Items.Add(i + 1);
                }
                comboBox1.SelectedIndex = 0;
            }

        }
    }
}
