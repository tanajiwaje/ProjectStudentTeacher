using ProjectOperationServices.Models;
using ProjectOperationServices.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOperationServices.Services.Implements
{
    public class TrainingCourseFeesServices : ITrainingCourseFeesServices
    {

        private IRepository<sp_fetch_tbltraining_course_fees_Result> repository;
        public TrainingCourseFeesServices(IRepository<sp_fetch_tbltraining_course_fees_Result> repository)
        {
            this.repository = repository;
        }

        public void AddTrainingCourseFees(sp_fetch_tbltraining_course_fees_Result trainingcoursefees)
        {
            try
            {
                string sp_name = "[sp_tbltraining_course_fees]{0},{1},{2},{3},{4},{5}";
                object[] parameters = { "Insert", trainingcoursefees.fee_id, trainingcoursefees.course_id, trainingcoursefees.fees_amount, trainingcoursefees.gst, trainingcoursefees.fee_mode };
                repository.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public void UpdateTrainingCourseFees(sp_fetch_tbltraining_course_fees_Result trainingcoursefees)
        {
            try
            {
                string sp_name = "[sp_tbltraining_course_fees]{0},{1},{2},{3},{4},{5}";
                object[] parameters = { "Update", trainingcoursefees.fee_id, trainingcoursefees.course_id, trainingcoursefees.fees_amount, trainingcoursefees.gst, trainingcoursefees.fee_mode };
                repository.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        public void DeleteTrainingCourseFees(int trainingcoursefees_id)
        {
            try
            {
                string sp_name = "[sp_tbltraining_course_fees]{0},{1},{2},{3},{4},{5}";
                object[] parameters = { "Delete", trainingcoursefees_id, 0,"",0, "" };
                repository.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public List<sp_fetch_tbltraining_course_fees_Result> getAll()
        {
            try
            {
                string sp_name = "[sp_fetch_tbltraining_course_fees]{0}";
                object[] parameters = { 0 };
                return repository.ExecuteQuery(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

        public sp_fetch_tbltraining_course_fees_Result GetTrainingCourseFeesById(int trainingcoursefeees_id)
        {
            try
            {
                string sp_name = "[sp_fetch_tbltraining_course_fees]{0}";
                object[] parameters = { trainingcoursefeees_id };
                return repository.ExecuteQuery(sp_name, parameters).First();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

       
    }
}
