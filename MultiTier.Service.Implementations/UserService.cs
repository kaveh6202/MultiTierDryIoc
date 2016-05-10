using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiTier.Models;
using MultiTier.Service.Interfaces;
using MultiTier.Domain;

namespace MultiTier.Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository = null;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void Add(User item)
        {
            _userRepository.Add(item);
        }

        public IList<User> GetAll()
        {
            var users = _userRepository.GetAll();
            //TODO
            return users;
        }

        public void Remove(User item)
        {
            _userRepository.Remove(item);
        }
    }
}
