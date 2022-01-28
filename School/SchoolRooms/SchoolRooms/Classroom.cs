using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRooms
{
    class Classroom
    {
        public List<StudentTemp> students { get; private set; }

        public Classroom()
        {
            students = new List<StudentTemp>();
        }

        public void AddStudent(StudentTemp student)
        {
            students.Add(student);
        }

        public int GetStudentCount()
        {
            return students.Count;
        }

        public List<StudentTemp> ReadRoom()
        {
            return students;
        }

        public void Call(int Index)
        {
            students[Index - 1].CallStudent();
        }
    }
}
