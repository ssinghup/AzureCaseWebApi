using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Services;
using WebApi.Repository;
using WebApi.Models;
using System.Web.Http.Description;
namespace WebApi.Controllers
{
    [RoutePrefix("api/Login")]
    public class LoginController : GenericController<LOGIN_USER>
    {
        private IGenericRepository<LOGIN_USER> repository = null;

        public LoginController()
        {
            this.repository = new GenericRepository<LOGIN_USER>();
        }
        public LoginController(IGenericRepository<LOGIN_USER> repository) : base(repository)
        {
        }        
   

        [HttpPost]
        [Route("ValidateUser")]
        public IHttpActionResult ValidateUser(LOGIN_USER User)
        {
            LOGIN_USER dt = new LOGIN_USER();
            using (var context = new ApplicationDBContext())
            {
                var result = (from T1 in context.LOGIN_USER
                              where T1.USERNAME == User.USERNAME && T1.USER_PASSWORD == User.USER_PASSWORD
                              select new
                              {
                                  USERID = T1.USERID,
                                  USERNAME = T1.USERNAME,
                                  FNAME = T1.FNAME,
                                  LNAME = T1.LNAME
                              }).SingleOrDefault();
                if (result != null)
                {
                    dt.USERID = result.USERID;
                    dt.USERNAME = result.USERNAME;
                    dt.FNAME = result.FNAME;
                    dt.LNAME = result.LNAME;
                }
                if (dt == null)
                {
                    return NotFound();
                }
                return Ok(dt);
            }
        }

    }
}
