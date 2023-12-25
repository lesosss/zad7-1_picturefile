using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad7_1_picturefile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Инициализация объекта SaveFileDialog для сохранения файлов
            file2 = new SaveFileDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            file1.Filter = "(*.jpg)|*.jpg";
            file2.Filter = "(*.jpg)|*.jpg";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // создаем пременную fname строкового типа
            string fname;
            // открываем проводник 
            file1.ShowDialog();
            // используем переменную для хранения имени выбранного файла
            fname = file1.FileName;
            // загружаем файл в элемент picturebox
            pct.Image = Image.FromFile(fname);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (file2.ShowDialog() == DialogResult.OK)
            {
                pct.Image.Save(file2.FileName);
            }
        }
    }
}
