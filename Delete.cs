using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MentorClass3
{
    class Delete 
    {
        private Db coursesToDelete = Db.Initialize();

        public void DeleteCourse()
        {
            int totalNumberOfCourses = coursesToDelete.getAllCourses().Count();
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
                foreach (var i in coursesToDelete.getAllCourses())
                {
                    Console.WriteLine($"\tCourse Code : {i.CourseCode} \tYour score : {i.CourseScore} \tYour Point : {i.getCoursePoint()} ");
                }
                Menu.PromptUser("");
                Menu.PromptUser("Enter The Course Code of the Course you want to delete");
                string input = Console.ReadLine();
                while(string.IsNullOrEmpty(input))
                {
                    Menu.PromptUser("Course Code cannot be empty");
                    Menu.PromptUser("Enter The Course Code of the Course you want to delete");
                    input = Console.ReadLine();

                }
                if(!string.IsNullOrEmpty(input))
                {
                    Menu.PromptUser("Are you sure you want to delete?\n Enter 'Yes' to delete and 'No' to cancel");
                    string deletePrompt = Console.ReadLine();
                    while(string.IsNullOrEmpty(deletePrompt))
                    {
                        Menu.PromptUser("Answer cannot be Empty");
                        Menu.PromptUser("Are you sure you want to delete?\n Enter 'Yes' to delete and 'No' to cancel");
                        deletePrompt = Console.ReadLine();
                    }

                    if(deletePrompt.ToLower()=="yes")
                    {
                        coursesToDelete.RemoveCourse(input);
                        Console.Clear();
                        foreach (var i in coursesToDelete.getAllCourses())
                        {
                            Console.WriteLine($"\tCourse Code : {i.CourseCode} \tYour score : {i.CourseScore} \tYour Point : {i.getCoursePoint()} ");
                        }

                        Menu.PromptUser("Press Enter");
                        Console.ReadKey();
                    }

                    else if(deletePrompt.ToLower()=="no")
                    {
                        Menu.PromptUser("Cancelled");
                        Menu.PromptUser("Press Enter");
                        Console.ReadKey();
                    }

                    else
                    {
                        Menu.PromptUser("invalild Input");
                    }
                }
               
            }
            
            Console.Clear();
        }
    }
}
