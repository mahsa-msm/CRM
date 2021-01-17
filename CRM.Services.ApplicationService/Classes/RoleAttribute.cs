using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;


namespace CRM.Services.ApplicationService.Classes
{
    public class RoleAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        string _roleName; 

        public RoleAttribute(string roleName)
        {
            roleName = _roleName;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                string userName = context.HttpContext.User.Identity.Name;
            }
            else
            {
                //Go to login
            }
        }
    }
}
