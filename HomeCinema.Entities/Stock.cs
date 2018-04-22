using System;
using System.Collections.Generic;

namespace HomeCinema.Entities
{
    public class Stock : IEntityBase
    {
        public Stock()
        {
            Rentals = new List<Rental>();
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        private Guid uniqueKey;
        public Guid UniqueKey
        {
            get { return uniqueKey; }
            set { uniqueKey = value; }
        }

        private bool isAvailable;
        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        public virtual ICollection<Rental> Rentals { get; set; }
    }
}