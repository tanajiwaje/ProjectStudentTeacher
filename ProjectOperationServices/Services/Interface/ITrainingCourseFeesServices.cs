using ProjectOperationServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOperationServices.Services.Interface
{
    public interface ITrainingCourseFeesServices
    {
        void AddTrainingCourseFees(sp_fetch_tbltraining_course_fees_Result trainingcoursefees);
        void UpdateTrainingCourseFees(sp_fetch_tbltraining_course_fees_Result trainingcoursefees);
        void DeleteTrainingCourseFees(int trainingcoursefees_id);
        List<sp_fetch_tbltraining_course_fees_Result> getAll();
        sp_fetch_tbltraining_course_fees_Result GetTrainingCourseFeesById(int trainingcoursefeees_id);

    }
}
