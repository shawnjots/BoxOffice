using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCinema.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
