using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.Core.Model.Models;

namespace Blog.Core.IRepository
{
    public interface IAdvertisementRepository
    {
        int Add(Advertisement model);
        bool Delete(Advertisement model);
        bool Update(Advertisement model);
        List<Advertisement> Query(Expression<Func<Advertisement, bool>> whereExpression);
    }
}
