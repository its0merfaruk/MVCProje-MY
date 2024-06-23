using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal : IRepository<Category>
    {
        void Delete(Category p);
        void Insert(Category p);
        List<Category> List();
        void Update(Category p);
    }
}
