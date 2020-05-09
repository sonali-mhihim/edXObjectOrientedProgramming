using System;
using System.Collections.Generic;
using System.Text;

namespace Mod_1SelfAssessment
{
    class Course
    {
        #region Properties
        public int CourseID { get; private set; }
        public string CourseName { get; private set; }
        public int DurationInWeeks { get; private set; }
        public List<Student> Students { get; private set; } = new List<Student>();
        public List<Teacher> Teachers { get; private set; } = new List<Teacher>();
        public static bool Student { get; internal set; }
        #endregion

        #region Methods
        public Course(int courseID, string courseName, int durationInWeeks)
        {
            this.CourseID = courseID;
            this.CourseName = courseName;
            this.DurationInWeeks = durationInWeeks;
        }

        public void AssignTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }
        public void EnrollStudent(Student student)
        {
            this.Students.Add(student);
        }

        #endregion Methods
    }
}