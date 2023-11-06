using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using ProjectOperationServices.Models;
namespace ProjectOperationServices
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        StudentTeacherDBEntities db;

        public Repository(StudentTeacherDBEntities db)
        {
            this.db = db;   
        }
        public void ExecuteCommnad(string sp_name, object[] parameters)
        {
            try
            {
                db.Database.ExecuteSqlCommand(sp_name, parameters);
                
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            
        }

        public List<TEntity> ExecuteQuery(string sp_name, object[] parameters)
        {
            return db.Database.SqlQuery<TEntity>(sp_name, parameters).ToList();
        }
    }
}
