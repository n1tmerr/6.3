using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    internal class Student
    {
        public string Группа { get; set; }
        public string Фамилия { get; set; }
        public int Успеваемость { get; set; }
        public int Рейтинг { get; set; }

        public Student(string _Group, string _Surname, int _Progress, int _Rating)
        {
            Группа = _Group;
            Фамилия = _Surname;
            Успеваемость = _Progress;
            Рейтинг = _Rating;
        }
    }
}
