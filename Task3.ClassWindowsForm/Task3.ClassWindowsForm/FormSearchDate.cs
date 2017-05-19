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
    public partial class FormSearchDate : Form
    {
        List<DataBase> dataSearch = new List<DataBase>();
        int temp2;
        public FormSearchDate()
        {
            InitializeComponent();
            button3.Hide();
            button4.Hide();
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp2 = 0;
            dataSearch.Clear();
            button3.Hide();
            button4.Hide();
            foreach (DataBase temp in DataBase.dataBase)
            {
                if (temp.course == int.Parse(textBox1.Text))
                {
                    dataSearch.Add(temp);
                }

                if (dataSearch.Count > 0)
                {
                    label2.Text = dataSearch[0].ToString();
                }
                if (dataSearch.Count > 1)
                {
                    button3.Show();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp2++;
            if (dataSearch.Count == temp2 + 1)
            {
                button3.Hide();

            }

            label2.Text = dataSearch[temp2].ToString();


            button4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temp2--;
            if (temp2 == 0)
                button4.Hide();
            label2.Text = dataSearch[temp2].ToString();
            if (dataSearch.Count > 1)
            {
                button3.Show();
            }
        }
    }
}
