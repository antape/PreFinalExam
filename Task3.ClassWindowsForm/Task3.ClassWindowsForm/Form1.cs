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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addDate_Click(object sender, EventArgs e)
        {
            FormAddDate formAddDate = new FormAddDate();
            formAddDate.Show();
        }

        private void removeDate_Click(object sender, EventArgs e)
        {
            if (DataBase.dataBase.Count != 0)
            {
                FormRemoveDate formRemoveDate = new FormRemoveDate();
                formRemoveDate.Show();
            }
            else MessageBox.Show("Данных нет");
            
        }

        private void showDate_Click(object sender, EventArgs e)
        {
            if (DataBase.dataBase.Count != 0)
            {
                FormShowDate formShowDate = new FormShowDate();
                formShowDate.Show();
            }
            else MessageBox.Show("Данных нет");
            
        }

        private void searchDate_Click(object sender, EventArgs e)
        {
            if (DataBase.dataBase.Count != 0)
            {
                FormSearchDate formSearchDate = new FormSearchDate();
                formSearchDate.Show();
            }
            else MessageBox.Show("Данных нет");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}