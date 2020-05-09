using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Mod_1SelfAssessment
{
    enum TestResults
    {
        Pass,
        Fail,
        Unknown
    }

    class Test
    {
        public string  Name { get; private set; }
        public int  TakenBy { get; private set; }
        public int  GradedBy { get; private set; }
        public TestResults Result { get; private set; }

        #region Methods
        //constructor
        public Test(string name)
        {
            this.Name = name;
            this.Result = TestResults.Unknown;
        }
        public void TakeTest(int takenBy)
        {
            this.TakenBy = takenBy;
        }

        public void GradeTest(int gradedBy, TestResults result)
        {
            this.GradedBy = gradedBy;
            this.Result = result;
        }

        public void ToString()
        {
            Console.WriteLine($"Name={this.Name}," +
                $" TakenBy={this.TakenBy}" + 
                $" GradedBy={this.GradedBy} " +
                $"Result={this.Result}");
        }
        #endregion
    }
}
