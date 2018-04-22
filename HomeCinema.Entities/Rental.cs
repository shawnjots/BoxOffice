using System;

namespace HomeCinema.Entities
{
    public class Rental : IEntityBase
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int CustomerId { get; set; }
        public int StockId { get; set; }
        public virtual Stock Stock { get; set; }

        private DateTime rentalDate;
        public DateTime RentalDate
        {
            get { return rentalDate; }
            set { rentalDate = value; }
        }

        private Nullable<DateTime> returnedDate;
        public Nullable<DateTime> ReturnedDate
        {
            get { return returnedDate; }
            set {returnedDate = value; }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}