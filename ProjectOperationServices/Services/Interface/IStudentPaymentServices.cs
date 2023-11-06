using ProjectOperationServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOperationServices.Services.Interface
{
    public interface IStudentPaymentServices
    {
        void AddStudentPayment(sp_fetch_tblstudent_payments_Result payment);
        void UpdateStudentPayment(sp_fetch_tblstudent_payments_Result payment);
        void DeleteStudentPayment(int payment_id);
        List<sp_fetch_tblstudent_payments_Result> getAll();
        sp_fetch_tblstudent_payments_Result GetStudentPaymentById(int payment_id);
    }
}
