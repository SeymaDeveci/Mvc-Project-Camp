using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{ 
    //Listeleme ekleme silme güncelleme işlemlerini tek tek yapmak yerine burada tanımladık
    //çünkü DRY prensibine uygun olmalı
    public interface IRepository<T> //T değeri bir typer türüdür.Yani bir Entity'i taşıyor:Oluşturduğumuz tablolardan birini.
    {
        List<T> List();

        T Get(Expression<Func<T, bool>> filter); //Get isminde metot tanımlama türü ise T yani Entity
        void Insert(T p);
        void Delete(T p);
        void Update(T p);

        List<T> List(Expression<Func<T, bool>> filter);  //Şartlı listeleme için metot
    }
}
