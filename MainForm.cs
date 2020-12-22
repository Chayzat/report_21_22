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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculateForm cf = new CalculateForm();
            cf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConstructForm cf = new ConstructForm();
            cf.Show();
            this.Hide();
        }

        private void pnlBorder_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
