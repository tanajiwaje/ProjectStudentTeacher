using ProjectOperationServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOperationServices.Services.Interface
{
    public interface IStudentDetailServices
    {
        void AddStudentDetails(sp_fetch_tblstudent_details_Result student);
        void UpdateStudentDetails(sp_fetch_tblstudent_details_Result student);
        void DeleteStudentDetails(int student_id);
        List<sp_fetch_tblstudent_details_Result> getAll();
        sp_fetch_tblstudent_details_Result GetStudentDetailById(int student_id);
    }
}
