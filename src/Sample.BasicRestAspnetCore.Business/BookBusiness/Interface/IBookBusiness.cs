using System.Collections.Generic;
using Sample.BasicRestAspnetCore.EntitiesDomain;

namespace Sample.BasicRestAspnetCore.Business.BookBusiness.Interface
{
    public interface IBookBusiness
    {
        Book Create(Book person);
        Book FindById(long id);
        List<Book> FindAll();
        Book Update(Book person);
        void Delete(long id);
    }
}