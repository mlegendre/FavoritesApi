using System;
using System.Collections.Generic;

namespace FavoritesApi.Models
{
    public partial class Dog
    {
        public string Breed { get; set; }
        public bool? Sex { get; set; }
        public int UserId { get; set; }
        public int Id { get; set; }

        public virtual User User { get; set; }
    }
}
