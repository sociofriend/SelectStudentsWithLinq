﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStudentsWithLinq
{
    public class Student
    {
        public int ID { get; set; }
        public string Surname { get; set; }

        public Student(int id, string surname)
        {
            ID = id;
            Surname = surname;
        }
    }
}
