using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiTier.Models;

namespace MultiTier.Service.Interfaces
{
    public interface IUserService
    {
        void Add(User item);
        void Remove(User item);

        IList<User> GetAll();
    }
}
