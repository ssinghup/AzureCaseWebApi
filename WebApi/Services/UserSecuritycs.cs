using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;
namespace WebApi.Services
{
    public class UserSecuritycs
    {

        public static bool CheckLoginUser(string UserName, string Password)
        {
            using (ApplicationDBContext db = new ApplicationDBContext())
            {
                return db.LOGIN_USER.Any(user => user.USERNAME.Equals(UserName,
                StringComparison.OrdinalIgnoreCase) && user.USER_PASSWORD == Password);
            }
        }
    }
}