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
    public partial class FormRemoveDate : Form
    {
        public FormRemoveDate()
        {
            InitializeComponent();
            label2.Text = "Кол-во данных " + DataBase.dataBase.Count.ToString();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            
            DataBase.dataBase.Remove(new DataBase("Test", "test", int.Parse(textBox1.Text), 1));
            label2.Text = "Кол-во данных " + DataBase.dataBase.Count.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
