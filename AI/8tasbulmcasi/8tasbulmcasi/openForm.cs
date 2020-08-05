using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _8tasbulmcasi
{
    public partial class openForm : Form
    {     
        private Regex pattern = new Regex(@"^(?!.*(.).*\1)[0-8]{0,9}$");
        public List<char> buttonsList = new List<char>();
        public List<char> finalstateList = new List<char>();
        public string numbers;
        public openForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string start = textBox1.Text.Replace(",", "");
            string final = textBox3.Text.Replace(",", "");
            if (textBox1.Text.Length !=9)
                MessageBox.Show("Sadece 9 deger giriniz");
            else
            {
                foreach (char c in start)
                {
                    buttonsList.Add(c);
                }
                foreach (char c in final)
                {
                    finalstateList.Add(c);
                }
                Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (pattern.IsMatch(textBox3.Text.Replace(",", "")));
            else
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz \n Her rakam 1 sefer yazılabilir ve 0-8 aralığında olmalıdır !!");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                textBox3.SelectionStart = textBox3.Text.Length;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (pattern.IsMatch(textBox1.Text.Replace(",", "")))
            {
                foreach (var item in textBox1.Text)
                {
                    textBox2.Text.Remove(textBox2.Text.IndexOf(item));
                    textBox2.Update();
                }
            }

            else
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz \n Her rakam 1 sefer yazılabilir ve 0-8 aralığında olmalıdır !!");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.SelectionStart = textBox1.Text.Length;
            }               
        }
    }
}
