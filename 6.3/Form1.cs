using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._3
{
    public partial class Form1 : Form
    {
        private List<Student> Students { get; set; }
        public Form1()
        {
            InitializeComponent();
            Students = new List<Student>();
            Students.Add(new Student("ПРО-31", "Пирожков", 78, 5));
            Students.Add(new Student("ПРО-31", "Казакова", 55, -4));
            Students.Add(new Student("ПРО-32", "Андреев", 33, 3));
            Students.Add(new Student("ПРО-32", "Тарасов", 17, 6));
            Students.Add(new Student("АБД-31", "Коновалова", 6, 7));
            Students.Add(new Student("АБД-31", "Королев", 89, 20));
            Students.Add(new Student("ВП-31", "Антонова", 63, -6));
            Students.Add(new Student("ВП-31", "Кудрявцева", 20, -9));
            Students.Add(new Student("ПРС-31", "Семенова", 45, 20));
            Students.Add(new Student("ПРС-31", "Крылова", 20, -9));
            dataGridView1.DataSource = Students.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Students.Where(u => u.Группа == textBox1.Text).ToList();
            if (textBox1.Text == "")
            {
                dataGridView1.DataSource = Students.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: //0-20

                    dataGridView1.DataSource = Students.Where(u => u.Успеваемость >= 0 && u.Успеваемость <= 20).ToList();


                    break;
                case 1: //21-50

                    dataGridView1.DataSource = Students.Where(u => u.Успеваемость >= 21 && u.Успеваемость <= 50).ToList();

                    break;
                case 2: //51-70

                    dataGridView1.DataSource = Students.Where(u => u.Успеваемость >= 51 && u.Успеваемость <= 70).ToList();

                    break;
                case 3: //71-100

                    dataGridView1.DataSource = Students.Where(u => u.Успеваемость >= 71 && u.Успеваемость <= 100).ToList();

                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Students.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Students.Where(u => u.Рейтинг >= 0).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Students.OrderBy(u => u.Фамилия).ToList();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

