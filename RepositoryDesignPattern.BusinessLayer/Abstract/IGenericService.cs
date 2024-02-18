using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T: class
    {
        //bu servis aslındda controller tarafında yapacağımız methodları tutacak
        void TInsert(T entity);
        void TUpdate(T entity);
        void TDelete(T entity);
        List<T> TGetList();
        T TGetByID(int id);
    }
}
