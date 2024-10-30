using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface RoleService
    {
        List<Role> GetAllRoles();                 // Retrieve a list of all roles
        Role GetRoleById(int id);                 // Get a role by its ID
        Role GetRoleByName(string roleName);      // Get a role by its name
        bool AddRole(Role role);                  // Add a new role
        bool UpdateRole(Role role);               // Update an existing role
        bool DeleteRole(int id);
    }
}
