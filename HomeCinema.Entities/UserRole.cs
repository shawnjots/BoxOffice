namespace HomeCinema.Entities
{
    public class UserRole : IEntityBase
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int UserId;
        public int RoleId;
        public virtual Role Role { get; set; }
    }
}