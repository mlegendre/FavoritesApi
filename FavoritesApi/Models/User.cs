using System;
using System.Collections.Generic;

namespace FavoritesApi.Models
{
    public partial class User
    {
        public User()
        {
            Car = new HashSet<Car>();
            Dog = new HashSet<Dog>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Car> Car { get; set; }
        public virtual ICollection<Dog> Dog { get; set; }
    }
}
