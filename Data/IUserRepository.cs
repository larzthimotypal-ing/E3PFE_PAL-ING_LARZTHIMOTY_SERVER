using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;

namespace Api.Data
{
    public interface IUserRepository
    {
        //Methods to be implemented in the UserRepository Class
        AppUser Create(AppUser appUser);
        AppUser GetByEmail(string email);
        AppUser GetById(int id);
    }
}
