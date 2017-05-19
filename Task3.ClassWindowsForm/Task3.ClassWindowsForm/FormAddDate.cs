using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3.ClassWindowsForm
{
    
    public partial class FormAddDate : Form
    {
        

        public FormAddDate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty || textBox2.Text != String.Empty || textBox3.Text != String.Empty || textBox4.Text != String.Empty)
            {

                DataBase.dataBase.Add(new DataBase(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text)));
                //MessageBox.Show(DataBase.dataBase.Last().ToString());
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
                MessageBox.Show("Введите данные");


        }
    }
}
