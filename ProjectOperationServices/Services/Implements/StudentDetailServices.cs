using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOperationServices.Models;
using ProjectOperationServices.Services.Interface;


namespace ProjectOperationServices.Services.Implements
{
    public class StudentDetailServices : IStudentDetailServices
    {

        private readonly Repository<sp_fetch_tblstudent_details_Result> _studentdetails;
        public StudentDetailServices(Repository<sp_fetch_tblstudent_details_Result> studentdetails)
        {
            _studentdetails = studentdetails;
        }

        public int AddStudentDetails(sp_fetch_tblstudent_details_Result student)
        {
            try
            {
                string sp_name = "[sp_tblstudent_details]{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}";
                object[] parameters = { "Insert", student.student_id, student.student_name, student.gender, student.mobile_number, student.email_address, student.password, student.birth_date,student.profile_photo, student.qualification };
                _studentdetails.ExecuteCommnad(sp_name, parameters);
                return 0;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return 1;
            }
        }


        public void UpdateStudentDetails(sp_fetch_tblstudent_details_Result student)
        {
            try
            {
                string sp_name = "[sp_tblstudent_details]{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}";
                object[] parameters = { "Update", student.student_id, student.student_name, student.gender, student.mobile_number, student.email_address, student.password, student.birth_date, student.profile_photo, student.qualification };
                _studentdetails.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public void DeleteStudentDetails(int student_id)
        {
            try
            {
                string sp_name = "[sp_tblstudent_details]{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}";
                object[] parameters = { "Delete", student_id, "", "", "", "","", "", "", "" };
                _studentdetails.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public List<sp_fetch_tblstudent_details_Result> getAll()
        {
            try
            {
                string sp_name = "[sp_fetch_tblstudent_details]{0}";
                object[] parameters = { 0 };
                return _studentdetails.ExecuteQuery(sp_name, parameters);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

        public sp_fetch_tblstudent_details_Result GetStudentDetailById(int student_id)
        {
            try
            {
                string sp_name = "[sp_fetch_tblstudent_details]{0}";
                object[] parameters = { student_id };
                return _studentdetails.ExecuteQuery(sp_name, parameters).First();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

       
    }
}
