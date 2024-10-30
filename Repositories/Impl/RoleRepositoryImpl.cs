using BusinessObjects.Entities;
using DAOs;
using DAOs.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Impl
{
    public class RoleRepositoryImpl : RoleRepository
    {
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
            return RoleDAOImpl.Instance.GetRoles();
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
