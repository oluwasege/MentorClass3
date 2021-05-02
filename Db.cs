﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentorClass3
{

    /// <summary>
    /// An mock of singleton design pattern
    /// </summary>
    public class Db
    {
        private List<Course> CourseTable;
        private static Db _instance;
        private Db()
        {
            this.CourseTable = new List<Course>();
            
        }

        public static Db Initialize()
        {
            if (_instance == null)
            {
                _instance = new Db();
            }

            return _instance;
        }

        public void AddCourse(Course c)
        {
            this.CourseTable.Add(c);
        }

        /// <summary>
        /// removeCourse("svy101") when the courseCode in db is SVY101
        /// </summary>
        /// <param name="courseCode"> code of coure to remove</param>
        public void RemoveCourse(string courseCode)
        {
            Course c = this.CourseTable.FirstOrDefault(c => c.CourseCode.ToLower() == courseCode.ToLower());
            this.CourseTable.Remove(c);
        }
        
        
        public IEnumerable<Course> getAllCourses()
        {
           
            return this.CourseTable;
          
        }

        /// <summary>
        /// in the works
        /// </summary>
        /// <param name="c"></param>
        public void UpdateCourse(Course c)
        {

        }

        

        


    }

}

