using ProjectOperationServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOperationServices.Services.Interface
{
    public interface IStudentRegistrationServices
    {
        void AddStudentRegistrations(sp_fetch_tblstudent_registrations_Result register);
        void UpdateStudentRegistration(sp_fetch_tblstudent_registrations_Result register);
        void DeleteStudentRegistration(int register_id);
        List<sp_fetch_tblstudent_registrations_Result> getAll();
        sp_fetch_tblstudent_registrations_Result GetStudentRegistrationById(int register_id);
    }
}
