using System;
using System.Collections.Generic;
using System.Text;

using BookShop.DataAccessLayer.Entities;

namespace BookShop.Core.Interfaces
{
    public interface IAccount
    {
        bool ExistsMobileNumbers(string MobileNumber);
        void AddUser(User user);

        int GetMinRole();
    }
}
