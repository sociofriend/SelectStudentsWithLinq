namespace SortStudentsWithLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student(1, "Yan1"),
                new Student(2, "Yan2"),
                new Student(3, "Yan3"),
                new Student(4, "Yan4"),
                new Student(5, "Yan5"),
                new Student(6, "Yan6"),
                new Student(7, "Yan1"),
                new Student(8, "Yan8"),
                new Student(9, "Yan10")
            };

            Course[] courses =
            {
                new Course("Maths", 1),
                new Course("Astronomy", 2),
                new Course("Maths", 3),
                new Course("Maths", 4),
                new Course("Physics", 5),
                new Course("Maths", 6),
                new Course("Physics", 7),
                new Course("Maths", 8),
                new Course("Biology", 9),
                new Course("Maths", 10),
            };


            var courseQuery = from course in courses
                              where course.Name == "Maths"
                              select course;

            foreach (Course course in courseQuery)
            {
                //for (int i = 0; i < students.Length; i++)
                foreach(Student student in students)
                {
                    if (student.ID == course.StudentId)
                    {
                        Console.WriteLine(student.Surname);
                    }
                }
            }


            var query = from s in students
                        join c in courses
                        on s.ID equals c.StudentId
                        where c.Name == "Maths"
                        select s.Surname;

            foreach(var q in query)
                Console.WriteLine($"Student taking Maths: {q}");
        }
    }
}