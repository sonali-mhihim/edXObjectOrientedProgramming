using System;

namespace Mod_1SelfAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var uprogram = new Uprogram("Information Technology");
            var student1 = new Student("Tom", "Millcreek");
            student1.ToString();
            var student2 = new Student("Jarry", "Bothell");
            var student3 = new Student("Harry", "Redmond");
            var course = new Course(1, "programming with c#", 120);

            //Add three students to the course
            course.EnrollStudent(student1);
            course.EnrollStudent(student2);
            course.EnrollStudent(student3);


            //Represent Teacher Object
            var teacher = new Teacher("Rajesh", "teast@test.com", "MBBS");

            //add teacher to the course
            course.AssignTeacher(teacher);

            //creating degree object
            var degree = new Degree("Bachelor");
            //add course to degree
            degree.AddCourse(course);

            //add degree to Uprogram
            uprogram.AddDegree(degree);
            Console.WriteLine($" ProgramName: {uprogram.Name}, " +
                $"DegreeName: {uprogram.Degrees[0].Name}, " +
                $"CourseName: {uprogram.Degrees[0].Courses[0].CourseName}, " +
                $"NumberofStudents: {uprogram.Degrees[0].Courses[0].Students.Count}");

            var programingTest = new Test("Programing");
            student2.TakeTest(programingTest);
            teacher.GradeTest(programingTest);
            programingTest.ToString();

            student1.Dispose();
            student2.Dispose();
            student3.Dispose();
            teacher.Dispose();
        }
    }
}
