using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCinema.Entities
{
    public class Customer : IEntityBase
    {

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string middleName;
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string identityCard;
        public string IdentityCard
        {
            get { return identityCard; }
            set { identityCard = value; }
        }

        private Guid uniqueKey;
        public Guid UniqueKey
        {
            get { return uniqueKey; }
            set { uniqueKey = value; }
        }

        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        private string mobile;
        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        private DateTime registrationDate;
        public DateTime RegistrationDate
        {
            get { return registrationDate; }
            set { registrationDate = value; }
        }
    }
}
