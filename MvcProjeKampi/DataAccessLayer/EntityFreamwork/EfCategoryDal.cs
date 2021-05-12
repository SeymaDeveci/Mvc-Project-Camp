using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFreamwork
{
    public class EfCategoryDal: GenericRepository<Category>, ICategoryDal //GenericRepository den miras alma
                                                                          //Category sınıfı üzerinde çalış ve ICategoryDal daki değerleri de al
    {

    }
}
