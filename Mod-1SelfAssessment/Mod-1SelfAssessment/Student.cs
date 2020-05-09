using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mod_1SelfAssessment
{
    /// <summary>
    /// This class represent the student
    /// </summary>
    class Student : Person
    {
        private bool disposed = false;

        #region Properties
        public string EnrollmentStatus { get; private set; }
        #endregion

        #region Methods
        //Add constructor
        public Student(string name, string address) : base(name, address)
        {
            this.EnrollmentStatus = "Regular";
            this.Persist();
        }

        public void ModifyEnrollmentStatus(string newStatus)
        {
            this.EnrollmentStatus = newStatus;
        }

        public override string ToString()
        {
            var str = $"Student::" + base.ToString() + 
                $"EnrollmentStatus={this.EnrollmentStatus}";
            return str;
        }

        public void TakeTest(Test test)
        {
            test.TakeTest(this.Id);
        }

        protected override string GetSerializedObject()
        {
            return this.ToString();
        }

        protected override void Dispose(bool disposing)
        {
            Console.WriteLine($"Dispose called for Student::Id={this.Id}");

            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //

            disposed = true;
            // Call base class implementation.
            base.Dispose(disposing);
        }
    }
    #endregion
}

