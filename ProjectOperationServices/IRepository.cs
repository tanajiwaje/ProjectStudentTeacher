using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOperationServices
{
    public  interface IRepository<TEntity> where TEntity:class
    {
        void ExecuteCommnad(string sp_name, object[] parameters);
        List<TEntity> ExecuteQuery(String sp_name, object[] parameters);
    }
}
