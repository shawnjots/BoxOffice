using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCinema.Entities
{
    public class Genre : IEntityBase
    {
        public Genre()
        {
            Movies = new List<Movie>();
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
