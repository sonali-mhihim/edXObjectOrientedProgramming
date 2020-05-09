using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mod_1SelfAssessment
{
    class Uprogram
    {
        public string Name { get; private set; }
        public List<Degree> Degrees { get; private set; } = new List<Degree>();

        #region Method
        //constrcutor
        public Uprogram(string name)
        {
            this.Name = "Information Technology";
        }
        public void AddDegree(Degree degree)
        {
            this.Degrees.Add(degree);

        }
        #endregion
    }
}
