using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateForm
{
    public partial class CalculateForm : Form
    {
        public CalculateForm()
        {
            InitializeComponent();
            //заполнение списка "размер плитки" (ширина и высота)
            tileSize[0, 0] = 10; tileSize[0, 1] = 10;

            tileSize[1, 0] = 15; tileSize[1, 1] = 15;

            tileSize[2, 0] = 10; tileSize[2, 1] = 15;

            tileSize[3, 0] = 20; tileSize[3, 1] = 20;

            //заполение списка "количество"
            tileCount[0] = 8;
            tileCount[1] = 10;
            tileCount[2] = 12;
            tileCount[3] = 20;

            for (int i = 0; i < n; i++) //заполняем список "размеры плитки"
                comboBox1.Items.Add(String.Format("{0}x{1}", tileSize[i, 0], tileSize[i, 1]));
            for (int i = 0; i < n; i++) //заполняем список "количество"
                comboBox2.Items.Add(String.Format("{0}", tileCount[i]));
        }

        private static short n = 4; //количество значений
        private short[,] tileSize = new short[n, 2]; //список возможных размеров плитки
        private short[] tileCount = new short[n]; //список для выбора кол-ва плитки
       

        private void CalculateForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sq;
            int sh = Int32.Parse(textBox1.Text.ToString());
            int vs = Int32.Parse(textBox2.Text.ToString());
            sq = sh * vs;
            int sind = comboBox1.SelectedIndex;
            int sitem = Int32.Parse(comboBox2.SelectedItem.ToString());
            int sin, res;
            switch (sind)
            {
                case 0:
                    sin = 100;
                     res = sq / sin / sitem;
                    textBox3.Text = res.ToString();
                    break;
                case 1:
                    sin = 225;
                    res = sq / sin / sitem;
                    textBox3.Text = res.ToString();
                    break;
                case 2:
                    sin = 150;
                    res = sq / sin / sitem;
                    textBox3.Text = res.ToString();
                    break;
                case 3:
                    sin = 400;
                    res = sq / sin / sitem;
                    textBox3.Text = res.ToString();
                    break;
            }
        
          
        }
    }
}
