using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiTier.Models;

namespace MultiTier.Domain
{
    public interface IUserRepository
    {
        void Add(User item);
        void Remove(User item);

        IList<User> GetAll();
    }
}
