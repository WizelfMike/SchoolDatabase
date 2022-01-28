using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRooms
{
    public abstract class StudentTemp
    {
        public string studentName { get; private set; }
        public string studentClass { get; private set; }

        public StudentTemp(string StudentName, string StudentClass)
        {
            studentName = StudentName;
            studentClass = StudentClass;
        }
        public abstract void CallStudent();
    }
}
