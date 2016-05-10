using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DryIoc;
using MultiTier.Service.Interfaces;
using MultiTier.Service.Implementations;
using MultiTier.Domain;

namespace MultiTier.Common
{
    public class DryIocBootStarpper
    {
        private readonly IContainer _container = null;
        public DryIocBootStarpper(IContainer container)
        {
            _container = container;
        }

        public void ConfigureContainer()
        {
            //Register Simple Service
            _container.Register<ILoggerService, Log4netService>();
            _container.Register<IUserService, UserService>();

            //Register Simple Repository
            _container.Register<IUserRepository, UserRepository>();
        }
    }
}