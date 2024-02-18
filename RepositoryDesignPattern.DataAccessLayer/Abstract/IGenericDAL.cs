using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void Insert (T entity);
        void Update (T entity);
        void Delete (T entity);
        List<T> GetList();
        T GetByID(int id);
    }
}
