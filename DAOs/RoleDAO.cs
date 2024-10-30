using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOs
{
    public interface RoleDAO
    {
        List<Role> GetRoles();
        bool AddRole(Role role);
        Role GetRole(int id);
        Role GetRoleByName(string roleName);
        bool UpdateRole(Role role);
        bool DeleteRole(int id);
    }
}
