using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCinema.Entities
{
    public class Error : IEntityBase
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        private string stackTrace;
        public string StackTrace
        {
            get { return stackTrace; }
            set { stackTrace = value; }
        }
        private DateTime dateCreated;
    }
}
