using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRooms
{
    class Y1Student : StudentTemp
    {

        public Y1Student(string StudentName, string StudentClass) : base(StudentName, StudentClass)
        {

        }

        public override void CallStudent()
        {
            Console.WriteLine($"This student's name is {studentName}.\nThey come from the class {studentClass}.");
        }

    }
}
