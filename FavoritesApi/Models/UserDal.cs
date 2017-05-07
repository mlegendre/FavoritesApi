using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FavoritesApi.Models
{
    public class UserDal : IUser
    {
        private readonly FavoritesContext _context;

        public UserDal(FavoritesContext context)
        {
            _context = context;
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        //public async Task<IEnumerable<User>> GetAllUsers()
        //{
        //    //return await _context.User.AllAsync;
        //    var users = new List<User>();
        //    using (var connection = _context.Database.GetDbConnection())
        //    {
        //        using (var command = connection.CreateCommand())
        //        {

        //        }
        //    }
        //}

        public async Task<User> GetUserById(int id)
        {
            return await _context.User.FirstOrDefaultAsync(u => u.Id == id);
        }

        public Task<User> UpdateUser(int id)
        {
            throw new NotImplementedException();
        }

        //private IEnumerable<User> GetUsers()
        //{
        //    return _context.User.All;
        //}
    }
}
