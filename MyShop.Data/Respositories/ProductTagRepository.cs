﻿using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Respositories
{
    public interface IProductTagRepository : IRepository<ProductTag>
    {
    }

    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}