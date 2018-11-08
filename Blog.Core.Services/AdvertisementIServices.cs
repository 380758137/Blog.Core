using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.Core.IRepository;
using Blog.Core.IServices;
using Blog.Core.Model.Models;
using Blog.Core.Repository;

namespace Blog.Core.Services
{
    public class AdvertisementServices : IAdvertisementServices
    {
        public IAdvertisementRepository dal = new AdvertisementRepository();

        public int Add(Advertisement model)
        {
            return dal.Add(model);
        }

        public bool Delete(Advertisement model)
        {
            return dal.Delete(model);
        }

        public List<Advertisement> Query(Expression<Func<Advertisement, bool>> whereExpression)
        {
            return dal.Query(whereExpression);
        }

        public int Sum(int i, int j)
        {
            return i + j;
        }

        public bool Update(Advertisement model)
        {
            return dal.Update(model);
        }
    }
}
