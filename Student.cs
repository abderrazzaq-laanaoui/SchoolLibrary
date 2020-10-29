using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public  enum GradLevels  {Freshman, Sophomore, Junior, Senior }
        public GradLevels gradLevel { get; set; }
     
        public override float ComputeGradeAverage()
        {
            return 2.5f;
        }
    }
}
