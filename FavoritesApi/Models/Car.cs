using System;
using System.Collections.Generic;

namespace FavoritesApi.Models
{
    public partial class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public DateTime? Year { get; set; }
        public string Color { get; set; }
        public int UserId { get; set; }
        public int Id { get; set; }

        public virtual User User { get; set; }
    }
}
