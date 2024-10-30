using BusinessObjects.Entities;
using Repositories;
using Repositories.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Impl
{
    public class RoleServiceImpl : RoleService
    {
        private RoleRepository repository;

        public RoleServiceImpl() { 
            repository = new RoleRepositoryImpl();
        }
        public bool AddRole(Role role)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRole(int id)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetAllRoles()
        {
            return repository.GetAllRoles();
        }

        public Role GetRoleById(int id)
        {
            throw new NotImplementedException();
        }

        public Role GetRoleByName(string roleName)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRole(Role role)
        {
            throw new NotImplementedException();
        }
    }
}
