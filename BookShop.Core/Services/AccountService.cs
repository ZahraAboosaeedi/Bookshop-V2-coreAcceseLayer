using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BookShop.DataAccessLayer.Entities;
using BookShop.DataAccessLayer.Context;
using BookShop.Core.Interfaces;
using BookShop.Core.Classes;
namespace BookShop.Core.Services
{
    public class AccountService: IAccount
    {

        private DataBaseContext _context;
        public AccountService(DataBaseContext context)
        {
            _context = context;
        }

        public bool ActivateUser(string code)
        {
            User user = _context.Users.FirstOrDefault(u => u.IsActive == false && u.ActiveCode == code);

            if (user !=null)
            {
                user.IsActive = true;
                user.ActiveCode = CodeGenerators.ActiveCode();

                _context.SaveChanges();
                return true;
            }

            else
            {
                return false;
            }
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

        public string GetUserActiveCode(string mobileNumber)
        {
            return _context.Users.FirstOrDefault(u => u.Mobile == mobileNumber).ActiveCode;
        }

        public User LoginUser(string mobileNumber, string password)
        {
            return _context.Users.Include(u=>u.Role).FirstOrDefault(u => u.Mobile == mobileNumber && u.Password == password);
        }

        public bool ResetPassword(string code, string password)
        {
            User user = _context.Users.FirstOrDefault(u => u.ActiveCode==code);

            if (user!=null)
            {
                user.Password = HashGenerators.MD5Encoding(password);
                user.ActiveCode = CodeGenerators.ActiveCode();
                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
