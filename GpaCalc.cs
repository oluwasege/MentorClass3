using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MentorClass3
{
    public class GpaCalc
    {

        private readonly Db courseInDb = Db.Initialize();

        



        public void CalculateGpa()
        {
            int totalNumberOfCourses = courseInDb.getAllCourses().Count();
            int totalQualityPoint = 0;
            
            int totalCoursesUnit = 0;

            //Tells you to enter a course when you select (2)
            if(totalNumberOfCourses==0)
            {
                Console.Clear();
                Menu.PromptUser("You have not entered an course!!!");
                Menu.PromptUser("Please Add course");
                Menu.PromptUser("Press Enter");
                Console.ReadKey();
            }
            else
            {
                //logic to calculate the Gpa
                foreach (var i in courseInDb.getAllCourses())
                {
                    int qualityPoint = i.getCoursePoint() * i.NumberOfUnits;
                    totalQualityPoint += qualityPoint;
                }
                //Console.WriteLine(totalCourses);

                foreach (var i in courseInDb.getAllCourses())
                {
                    totalCoursesUnit += i.NumberOfUnits;
                }
                // Console.WriteLine(totalCoursesUnit);
                double gpa = Convert.ToDouble(totalQualityPoint) / Convert.ToDouble(totalCoursesUnit);
                foreach (var i in courseInDb.getAllCourses())
                {
                    Console.WriteLine($"\tCourse Code : {i.CourseCode} \tYour score : {i.CourseScore} \tYour Point : {i.getCoursePoint()} ");
                }
                Menu.PromptUser("");
                Menu.PromptUser($"Your Grade Point Average is: {gpa:0.00}");
                Menu.PromptUser("");
                Menu.PromptUser("Press Enter");
                Console.ReadKey();
            }

            

        }
        










    }
}
