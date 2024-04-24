using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа_1_по_РазКИС
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            
            List <string> lastnames = new List<string>() {"Иванов","Петров","Сидоров","Плотников"};
            foreach (string name in lastnames) 
            {
                string MaxValue = lastnames.Max();
                MessageBox.Show(MaxValue);
                break;
            }
            
        }

    }
}
