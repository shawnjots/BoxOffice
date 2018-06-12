using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCinema.Entities
{
    public class User : IEntityBase
    {
        public User()
        {
            UserRoles = new List<UserRole>();
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string hashedPassword;
        public string HashedPassword
        {
            get { return hashedPassword; }
            set { hashedPassword = value; }
        }

        private string salt;
        public string Salt
        {
            get { return salt; }
            set { salt = value; }
        }

        private bool isLocked;
        public bool IsLocked
        {
            get { return isLocked; }
            set { isLocked = value; }
        }

        private DateTime dateCreated;
        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
