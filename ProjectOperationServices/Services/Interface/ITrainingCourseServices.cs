using ProjectOperationServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProjectOperationServices.Services.Interface
{
    public interface ITrainingCourseServices
    {
     
        void AddTrainingCourse(sp_fetch_tbltraining_courses_Result trainingcourse);
        void UpdateTrainingCourse(sp_fetch_tbltraining_courses_Result trainingcourse);
        void DeleteTrainingCourse(int trainingcourse_id);  
        List<sp_fetch_tbltraining_courses_Result> getAll();
        sp_fetch_tbltraining_courses_Result GetTrainingCourseById(int trainingcourse_id); 
       
    }
}
