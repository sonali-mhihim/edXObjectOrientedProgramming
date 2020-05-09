using System;
using System.Collections.Generic;
using System.Text;

namespace Mod_1SelfAssessment
{
    class Teacher : Person
    {
        private bool disposed = false;

        #region Properties
        public string Qualification { get; private set; }

        #endregion
        #region Methods
        //Add constructor
        public Teacher(string name, string address, string qualification) 
            : base(name, address)
        {
            this.Qualification = qualification;
            this.Persist();
        }

        public override string ToString()
        {
            var str = $"Teacher::" + base.ToString() + 
                $"Qualification::{this.Qualification}";
            Console.WriteLine(str);
            return str;
        }

        public void GradeTest(Test test)
        {
            test.GradeTest(this.Id, TestResults.Pass);
        }

        protected override string GetSerializedObject()
        {
            return this.ToString();
        }

        protected override void Dispose(bool disposing)
        {
            Console.WriteLine($"Dispose called for Teacher::Id={this.Id}");

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

