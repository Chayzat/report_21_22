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
    public partial class ConstructForm : Form
    {
        public ConstructForm()
        {
            InitializeComponent();
        }
        private int indexOfFlat; //индекс переносимого пункта из списка Плитка
        private bool flat = false; //флаг переноса изображения плитки
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            flat = true; //устанавливаем флаг переноса плитки
                         // Получаем индекс выбранного элемента
            indexOfFlat = listView1.Items.IndexOf(listView1.GetItemAt(e.X, e.Y));
            if (indexOfFlat != -1) //если удалось определить индекс
            {
                //начинаем операцию перетаскивания элемента
                listView1.DoDragDrop(listView1.Items[indexOfFlat].ImageIndex,
                DragDropEffects.Copy);
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy; //устанавливаем режим перетаскивания
        }
        private int indexOfDecor; //индекс переносимого пункта из списка Декор
        private int sizeOfDecor = 50; //размер изображения декора
                                      //список размещенных элементов декора
        private List<PictureBox> decors = new List<PictureBox>();

        private void listView2_MouseDown(object sender, MouseEventArgs e)
        {
            flat = false; //сбрасываем флаг переноса плитки
                          //определяем индекс выбранного в списке элемента
            indexOfDecor = listView2.Items.IndexOf(listView2.GetItemAt(e.X, e.Y));
            //если удалось определить индекс
            if (indexOfDecor != -1)
            {
                //начинаем операцию перетаскивания элемента
                listView2.DoDragDrop(listView2.Items[indexOfDecor].ImageIndex,
                DragDropEffects.Copy);
            }
        }
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (flat) //если выбрана операция перетаскивания изображения плитки
            {
                //устанавливаем в качестве фонового изображения панели перетаскиваемое из списка
                panel1.BackgroundImage = imageListFlat.Images[indexOfFlat];
            }
            else //если выбрана операция перетаскивания изображения декора
            {
                decors.Add(new PictureBox()); //добавляем в список новый элемент декора
                                              //помещаем новый компонент в панель
                panel1.Controls.Add(decors[decors.Count - 1]);
                //устанавливаем размер компонента
                decors[decors.Count - 1].Width = decors[decors.Count - 1].Height = sizeOfDecor;
                //устанавливаем изображение элемента
                decors[decors.Count - 1].Image = imageListDecor.Images[indexOfDecor];
                //подписываем компонент на событие отпускания клавиши мыши
                decors[decors.Count - 1].MouseUp +=
                new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            }

        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            //если была нажата левая кнопка мыши
            if (e.Button == MouseButtons.Left)
            {
                //создаем копию перетаскиваемого объекта
                PictureBox img = sender as PictureBox;
                //изменяем его положение на панели
                img.Left = img.Left + e.X - img.Width / 2;
                img.Top = img.Top + e.Y - img.Height / 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.BackgroundImage = null;
        }
    }
}
