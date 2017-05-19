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
    public partial class FormShowDate : Form
    {
        int temp = 0;
        public FormShowDate()
        {
            InitializeComponent();
            label1.Text = DataBase.dataBase[temp].ToString();
            label2.Text = "Кол-во данных " + DataBase.dataBase.Count.ToString();
            button2.Hide();
            button3.Hide();
            //MessageBox.Show(DataBase.dataBase.Count.ToString());
            if (DataBase.dataBase.Count > 1)
            {
                button3.Show();
            }
            
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp++;
            if (DataBase.dataBase.Count == temp + 1)
            {
                button3.Hide();

            }
            
            label1.Text = DataBase.dataBase[temp].ToString();

           
            button2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp--;
            if (temp == 0)
                button2.Hide();
            label1.Text = DataBase.dataBase[temp].ToString();
            if (DataBase.dataBase.Count > 1)
            {
                button3.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
