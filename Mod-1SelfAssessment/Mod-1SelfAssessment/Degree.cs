using System;
using System.Collections.Generic;
using System.Text;

namespace Mod_1SelfAssessment
{
    class Degree
    {
        #region Properties
        public string  Name { get;  private set; }
        public List<Course> Courses { get; private set; } = new List<Course>();
        #endregion

        #region Mehods
        // constructor
        public Degree(string name)
        {
            this.Name = name;
        }
        #endregion
        public void AddCourse(Course course)
        {
            this.Courses.Add(course);
        }
    }

}
