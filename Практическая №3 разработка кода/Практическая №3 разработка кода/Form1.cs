using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Практическая__3_разработка_кода
{
    public partial class Form1 : Form
    {
        public Dictionary<string, string> nums = new Dictionary<string, string>();
        private int pairCount = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string key = textBox1.Text;
            string value = textBox2.Text;


            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
            {
                nums[key] = value;
               

                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Элемент успешно добавлен в словарь.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Введите ключ и значение перед добавлением в словарь.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          

        }

    }
}

