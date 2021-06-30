using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context; //to be able to use the db context 

        public UserRepository(UserContext context) // a constructor
        {
            _context = context; 
        }

        public AppUser Create( AppUser appUser) // a method to add the user to the database using the dbcontext
        {
            _context.AppUsers.Add(appUser);
            appUser.Id = _context.SaveChanges();

            return appUser;
        }

        public AppUser GetByEmail(string email) // a method to find and get the user by email using the dbcontext
        {
            return _context.AppUsers.FirstOrDefault(u => u.Email == email);
        }

        public AppUser GetById(int id) // a method to find and get the user by id using the dbcontext
        {
            return _context.AppUsers.FirstOrDefault(u => u.Id == id);
        }
    }
}
