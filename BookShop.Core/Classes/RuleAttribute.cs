using System;
using System.Collections.Generic;
using System.Text;
using BookShop.Core.Interfaces;
using BookShop.Core.Services;
using BookShop.DataAccessLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BookShop.Core.Classes
{

    public class RuleAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        IUser _iuser;
        int _permissionID;

        public RuleAttribute(int permissionID)
        {
            _permissionID = permissionID;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if(context.HttpContext.User.Identity.IsAuthenticated)
            {
                string username = context.HttpContext.User.Identity.Name;

                _iuser = (IUser)context.HttpContext.RequestServices.GetService(typeof(IUser));

                int roleID = _iuser.GetUserRole(username);

                if (!_iuser.ExistsPermission(_permissionID, roleID))
                {
                    //Login Again:)
                }


            }
            else
            {
                //Login Again:)
            }
        }
    }
}
 