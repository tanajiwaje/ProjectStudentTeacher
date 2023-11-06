using ProjectOperationServices.Models;
using ProjectOperationServices.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ProjectOperationServices.Services.Implements
{
    public class TrainingCourseServices : ITrainingCourseServices
    {
        private IRepository<sp_fetch_tbltraining_courses_Result> course;
        public TrainingCourseServices(IRepository<sp_fetch_tbltraining_courses_Result> course)
        {
            this.course = course;
        }

        public void AddTrainingCourse(sp_fetch_tbltraining_courses_Result trainingcourse)
        {
            try
            {
                string sp_name = "[sp_tbltraining_courses]{0},{1},{2}";
                object[] parameters = { "Insert", trainingcourse.course_id, trainingcourse.course_name };
                course.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception) {
              Console.WriteLine(exception.Message);
            }
            
        }
        public void UpdateTrainingCourse(sp_fetch_tbltraining_courses_Result trainingcourse)
        {
            try
            {
                string sp_name = "[sp_tbltraining_courses]{0}{1}{2}";
                object[] parameters = { "Update", trainingcourse.course_id, trainingcourse.course_name };
                course.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            
        }

        public void DeleteTrainingCourse(int trainingcourse_id)
        {
            try
            {
                string sp_name = "[sp_tbltraining_courses]{0}{1}{2}";
                object[] parameters = { "Delete", trainingcourse_id, "" };
                course.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception) {
                Console.WriteLine(exception.Message);
            }
      
        }

        public List<sp_fetch_tbltraining_courses_Result> getAll()
        {
            try {
                string sp_name = "[sp_fetch_tbltraining_courses]{0}";
                object[] parameters = { 0 };
                return course.ExecuteQuery(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

        public sp_fetch_tbltraining_courses_Result GetTrainingCourseById(int trainingcourse_id)
        {
            try
            {
                string sp_name = "[sp_fetch_tbltraining_courses]{0}";
                object[] parameters = { trainingcourse_id };
                return course.ExecuteQuery(sp_name, parameters).First();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
    
        }

       
    }
}
