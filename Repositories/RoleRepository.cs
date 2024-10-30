using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface RoleRepository
    {
        List<Role> GetAllRoles();             // Retrieve a list of all roles
        Role GetRoleById(int id);             // Get a specific role by its ID
        Role GetRoleByName(string roleName);  // Get a specific role by its name
        bool AddRole(Role role);              // Add a new role to the repository
        bool UpdateRole(Role role);           // Update an existing role
        bool DeleteRole(int id);
    }
}
