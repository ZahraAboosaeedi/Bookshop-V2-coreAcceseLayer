using System;
using System.Collections.Generic;
using System.Text;

using BookShop.DataAccessLayer.Entities;

namespace BookShop.Core.Interfaces
{
    public interface IUser
    {
        bool ExistsPermission(int permissionID ,int roleID);

        int GetUserRole(string username);
    }
}
