using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BookShop.DataAccessLayer.Entities;
using BookShop.DataAccessLayer.Context;
using BookShop.Core.Interfaces;
namespace BookShop.Core.Services
{
    public class AccountService: IAccount
    {

        private DataBaseContext _context;
        public AccountService(DataBaseContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.AddAsync(user);
            _context.SaveChanges();
        }

        public bool ExistsMobileNumbers(string MobileNumber)
        {
            return _context.Users.Any(u => u.Mobile == MobileNumber);
        }

        public int GetMaxRole()
        {
            return _context.Roles.Max(r => r.Id);
        }
    }
}
