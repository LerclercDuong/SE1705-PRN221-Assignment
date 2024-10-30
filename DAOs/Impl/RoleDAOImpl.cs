using BusinessObjects.Context;
using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOs.Impl
{
    public class RoleDAOImpl : RoleDAO
    {
        private KoiFishAdvertisementDBContext _context;

        private static RoleDAOImpl _instance = null;

        public static RoleDAOImpl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RoleDAOImpl();
                }
                return _instance;
            }
        }

        public RoleDAOImpl()
        {
            _context = new KoiFishAdvertisementDBContext();
        }

        public List<Role> GetRoles()
        {
            return _context.Roles.ToList();
        }

        public bool AddRole(Role role)
        {
            bool isSuccess = false;
            try
            {
                _context.Roles.Add(role);
                _context.SaveChanges();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log the error)
            }
            return isSuccess;
        }

        public Role GetRole(int id)
        {
            return _context.Roles.FirstOrDefault(x => x.RoleId == id);
        }

        public Role GetRoleByName(string roleName)
        {
            return _context.Roles.FirstOrDefault(x => x.RoleName.Equals(roleName));
        }

        public bool UpdateRole(Role role)
        {
            bool isSuccess = false;
            try
            {
                _context.Roles.Update(role);
                _context.SaveChanges();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log the error)
            }
            return isSuccess;
        }

        public bool DeleteRole(int id)
        {
            bool isSuccess = false;
            try
            {
                _context.Roles.Remove(GetRole(id));
                _context.SaveChanges();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log the error)
            }
            return isSuccess;
        }
    }
}
