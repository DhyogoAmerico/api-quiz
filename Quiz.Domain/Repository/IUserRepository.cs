using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quiz.Domain.Entity;

namespace Quiz.Domain.Repository
{
    public interface IUserRepository
    {
        Task Insert(User user);
        Task<User> GetUser(string email, string password);
    }
}