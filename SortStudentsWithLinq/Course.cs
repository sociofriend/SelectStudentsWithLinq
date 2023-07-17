using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStudentsWithLinq
{
    public class Course
    {
        public string Name { get; set; }
        public int StudentId { get; set; }

        public Course(string name, int studentId)
        {
            Name = name;
            StudentId = studentId;
        }

    }
}
