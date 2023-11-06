using Microsoft.Win32;
using ProjectOperationServices.Models;
using ProjectOperationServices.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOperationServices.Services.Implements
{
    public class StudentRegistrationServices : IStudentRegistrationServices
    {
        private readonly IRepository<sp_fetch_tblstudent_registrations_Result> _reporegister;

        public void AddStudentRegistrations(sp_fetch_tblstudent_registrations_Result register)
        {
            try
            {
                string sp_name = "[sp_tblstudent_registrations]{0},{1},{2},{3},{4},{5}";
                object[] parameters = { "Insert", register.registration_id, register.student_id, register.course_id, register.birth_date, register.discount };
                _reporegister.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }


        public void UpdateStudentRegistration(sp_fetch_tblstudent_registrations_Result register)
        {
            try
            {
                string sp_name = "[sp_tblstudent_registrations]{0},{1},{2},{3},{4},{5}";
                object[] parameters = { "Update", register.registration_id, register.student_id, register.course_id, register.birth_date, register.discount };
                _reporegister.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public void DeleteStudentRegistration(int register_id)
        {
            try
            {
                string sp_name = "[sp_tblstudent_registrations]{0},{1},{2},{3},{4},{5}";
                object[] parameters = { "Delete", register_id, 0, 0,"", 0 };
                _reporegister.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        public List<sp_fetch_tblstudent_registrations_Result> getAll()
        {
            try
            {
                string sp_name = "[sp_fetch_tblstudent_registrations]{0}";
                object[] parameters = { 0 };
                return _reporegister.ExecuteQuery(sp_name, parameters);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }
        public sp_fetch_tblstudent_registrations_Result GetStudentRegistrationById(int register_id)
        {
            try
            {
                string sp_name = "[sp_fetch_tblstudent_registrations]{0}";
                object[] parameters = {  register_id };
                return _reporegister.ExecuteQuery(sp_name, parameters).First();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

       
    }
}
