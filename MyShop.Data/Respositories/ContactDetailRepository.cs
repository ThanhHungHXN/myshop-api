﻿using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Respositories
{
    public interface IContactDetailRepository : IRepository<ContactDetail>
    {
    }

    public class ContactDetailRepository : RepositoryBase<ContactDetail>, IContactDetailRepository
    {
        public ContactDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}