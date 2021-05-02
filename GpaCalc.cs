using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MentorClass3
{
    public class GpaCalc
    {
        public double gpa { get; private set; }

        private Db courseInDb = Db.Initialize();

        
        


        public void calc()
        {
            int totalNumberofCourses = courseInDb.getAllCourses().Count();
            int totalCourses = 0;
            
            int totalCoursesUnit = 0;

            foreach(var i in courseInDb.getAllCourses())
            {
                totalCourses += i.getCoursePoint();
            }
            //Console.WriteLine(totalCourses);

            foreach(var i in courseInDb.getAllCourses())
            {
                totalCoursesUnit += i.NumberOfUnits;
            }
            // Console.WriteLine(totalCoursesUnit);
            double gpa = Convert.ToDouble(totalCourses) / Convert.ToDouble(totalCoursesUnit);
            foreach(var i in courseInDb.getAllCourses())
            {
                Console.WriteLine($"Course Code : {i.CourseCode} \tYour score : {i.CourseScore}\tYour Point : {i.getCoursePoint()} ");
            }
            Menu.PromptUser($"Your Grade Point Average is: {gpa}");

        }
        










    }
}
