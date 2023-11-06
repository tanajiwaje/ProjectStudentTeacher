using ProjectOperationServices.Models;
using ProjectOperationServices.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOperationServices.Services.Implements
{
    public class StudentPaymentServices : IStudentPaymentServices
    {
        private readonly IRepository<sp_fetch_tblstudent_payments_Result> _repopayment;
        public StudentPaymentServices(IRepository<sp_fetch_tblstudent_payments_Result> repopayment)
        {
            _repopayment = repopayment;
        }

        public void AddStudentPayment(sp_fetch_tblstudent_payments_Result payment)
        {
            try
            {
                string sp_name = "[sp_tblstudent_payments_Result]{0},{1},{2},{3},{4},{5},{6}";
                object[] parameters = { "Insert", payment.payment_id, payment.registration_id, payment.payment_date, payment.payment_amount, payment.payment_mode, payment.payment_description };
                _repopayment.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public void UpdateStudentPayment(sp_fetch_tblstudent_payments_Result payment)
        {
            try
            {
                string sp_name = "[sp_tblstudent_payments_Result]{0},{1},{2},{3},{4},{5},{6}";
                object[] parameters = { "Update", payment.payment_id, payment.registration_id, payment.payment_date, payment.payment_amount, payment.payment_mode, payment.payment_description };
                _repopayment.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public void DeleteStudentPayment(int payment_id)
        {
            try
            {
                string sp_name = "[sp_tblstudent_payments_Result]{0},{1},{2},{3},{4},{5},{6}";
                object[] parameters = { "delete", payment_id,0, "", 0, "","" };
                _repopayment.ExecuteCommnad(sp_name, parameters);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public List<sp_fetch_tblstudent_payments_Result> getAll()
        {
            try
            {
                string sp_name = "[sp_fetch_tblstudent_payments]{0}";
                object[] parameters = { 0 };
                return _repopayment.ExecuteQuery(sp_name, parameters);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

        public sp_fetch_tblstudent_payments_Result GetStudentPaymentById(int payment_id)
        {
            try
            {
                string sp_name = "[sp_fetch_tblstudent_payments]{0}";
                object[] parameters = { payment_id };
                return _repopayment.ExecuteQuery(sp_name, parameters).First() ;

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }

       
    }
}
