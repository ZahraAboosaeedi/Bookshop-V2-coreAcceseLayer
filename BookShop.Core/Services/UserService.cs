using System;
using System.Collections.Generic;
using System.Text;
using BookShop.DataAccessLayer.Context;
using BookShop.DataAccessLayer.Entities;

using System.Linq;
using Microsoft.EntityFrameworkCore;

using BookShop.Core.Interfaces;

namespace BookShop.Core.Services
{
    public class UserService : IUser
    {

        private DataBaseContext _context;   
        public UserService(DataBaseContext context)
        {
            _context = context;
        }
        public bool ExistsPermission(int permissionID , int roleID)
        {
            return _context.RolePermissions.Any(r => r.RoleId == roleID 
            && r.PermissionId == permissionID);


        }

        public int GetUserRole(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Mobile == username).RoleId;
        }
    }
}