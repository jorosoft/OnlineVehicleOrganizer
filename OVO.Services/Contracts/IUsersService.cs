﻿using System.Linq;
using OVO.Data.Models;

namespace OVO.Services.Contracts
{
    public interface IUsersService
    {
        IQueryable<User> GetAll();

        IQueryable<User> GetAllAndDeleted();

        void Add(User user);

        void Update(User user);

        void Delete(User user);
    }
}
