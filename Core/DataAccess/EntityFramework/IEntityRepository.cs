using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    //CRUD operasyonlarımı tutacağım interface soyut sınıfıdır. Her entity için tekrar yazmamak için bu işlem yapılır.

    public interface IEntityRepository<T> where T : class, IEntity, new() //class derken referans tip olabilir class değil. 
                                                                          //Ne olmamasını istiyorsam yazarım. Yazabileceklerimin ortak ozellıgı IEntitiy olması yada IEntity implemente olan birşey olabilir. 
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter); //tek bir data getirmek için 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
