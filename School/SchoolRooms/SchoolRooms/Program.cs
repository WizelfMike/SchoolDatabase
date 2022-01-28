using System;

namespace SchoolRooms
{
    class Program
    {
        static void Main(string[] args)
        {
            int Index = 1;
            int studentCount = 0;
            bool loops = true;


            Classroom classroom = new Classroom();

            StudentTemp garry = new Y1Student("Garry Nickleson", "Y1A2D3");
            StudentTemp suzan = new Y1Student("Suzan Smith", "Y1A3D2");
            StudentTemp jesse = new Y1Student("Jesse Cassidy", "Y1A6D6");
            StudentTemp will = new Y1Student("Will French", "F4G6O7");
            StudentTemp mike = new Y1Student("Mike English", "D1C5H0");

            classroom.AddStudent(garry);
            classroom.AddStudent(suzan);
            classroom.AddStudent(jesse);
            classroom.AddStudent(will);
            classroom.AddStudent(mike);

            Console.Clear();

            Console.WriteLine("Please select a student's number to learn more about them. \n");

            foreach (StudentTemp student in classroom.ReadRoom())
            {
                Console.WriteLine($"Student: {Index} \n");
                studentCount = classroom.GetStudentCount();
                Index++;
            }

            //classroom.Call(1);

            while (loops)
            {
                int studentnum;

                string Input = Console.ReadLine();
                Int32.TryParse(Input, out studentnum);
                Console.Clear();
                Index = 1;

                if(!Int32.TryParse(Input, out studentnum))
                {
                    Console.WriteLine("Outside of the bounds of the classroom array. Please select a number that corresponds to what you see on screen. \n");
                    foreach (StudentTemp student in classroom.ReadRoom())
                    {
                        Console.WriteLine($"Student: {Index} \n");
                        Index++;
                    }
                }

                if (Int32.TryParse(Input, out studentnum) && studentnum <= studentCount)
                {
                    classroom.Call(studentnum);
                    Console.WriteLine("\n");
                    foreach (StudentTemp student in classroom.ReadRoom())
                    {
                        Console.WriteLine($"Student: {Index} \n");
                        Index++;
                    }
                }

                if (studentnum > studentCount)
                {
                    Console.WriteLine("Outside of the bounds of the classroom array. Please select a number that corresponds to what you see on screen. \n");
                    foreach (StudentTemp student in classroom.ReadRoom())
                    {
                        Console.WriteLine($"Student: {Index} \n");
                        Index++;
                    }
                }
            }

            foreach (StudentTemp name in classroom.ReadRoom())
            {
                Console.WriteLine(name.studentName + name.studentClass);
            }
        }
    }
}
