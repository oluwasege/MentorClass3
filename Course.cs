using System;
using System.Collections.Generic;
using System.Text;

namespace MentorClass3
{
   public class Course
    {
        public string CourseCode { get; private set; }
        public double CourseScore { get; private set; }
        public int NumberOfUnits { get; private set; }

        public Course(string code, double score, int numberOfUnits)
        {
            this.CourseCode = code;
            this.CourseScore = score;
            this.NumberOfUnits = numberOfUnits;
        }

        public int getCoursePoint()
        {
            int point = 0;
            if(this.CourseScore>=70&&this.CourseScore<100)
            {
                point = 5;
                
            }
            else if(this.CourseScore>=60)
            {
                point = 4;
                
            }
            else if(this.CourseScore>=50)
            {
                point= 3;
               
            }
            else if(this.CourseScore>=45)
            {
                point = 2;
                
            }
            else if(this.CourseScore>=40)
            {
                point = 1;
            }
            return point;
        }
    }
}
