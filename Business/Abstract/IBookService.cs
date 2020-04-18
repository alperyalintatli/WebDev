using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
  public interface IBookService
    {
        List<Book> GetAll();
        Book GetById(int id);
        List<Book> GetByAuthorId(int id);
        //List<Book> GetByIsbn(string isbn);
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
    }
}
