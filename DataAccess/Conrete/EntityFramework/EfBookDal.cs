using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Conrete.EntityFramework
{
   public class EfBookDal:EfEntityRepositoryBase<Book,BookStoreContext>,IBookDal
    {
    }
}
