using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр22
{
    public partial class Form1 : Form
    {
        List<string> lastnames = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string longestlastname = " ";
                foreach (string lastname in lastnames)
                {
                    if (lastname.Length > longestlastname.Length)
                    {
                        longestlastname = lastname;

                    }
                }
                MessageBox.Show("Самая длинная фамилия: " + longestlastname);
            }
            catch (FormatException ex) { MessageBox.Show(ex.Message); }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            lastnames.Clear();

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                string lastname = textBox1.Text;
                lastnames.Add(lastname);
                textBox1.Clear();
            }
            else
            {
                errorProvider1 = new ErrorProvider();
                errorProvider1.SetError(textBox1, "Строка пустая");
                await Task.Delay(2000);
                errorProvider1.SetError(textBox1, "");
            }
        }

    }
}
