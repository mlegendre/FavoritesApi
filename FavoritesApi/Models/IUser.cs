using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FavoritesApi.Models
{
    public interface IUser
    {
        Task<IEnumerable<User>> GetAllUsers();

        Task<User> GetUserById(int id);

        Task<User> UpdateUser(int id);

        void DeleteUser(int id);
        
    }
}
