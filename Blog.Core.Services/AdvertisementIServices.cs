using System;
using Blog.Core.IServices;

namespace Blog.Core.Repository
{
    public class AdvertisementIServices : IAdvertisementServices
    {
        public int Sum(int i, int j)
        {
            return i + j;
        }
    }
}
