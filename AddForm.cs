using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 n = new Form1();
            n.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        public void Books()
            {
            string[,] inf = { {"Портрет Дориана Грея","Оскар Уайльд", "Роман" },
                {"Герой нашего времени","М. Ю. Лермонтов", "Роман" },
                {"Великий Гэтсби","Френсис Скотт Фицджеральд ", "Роман" }
            };

            }
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
