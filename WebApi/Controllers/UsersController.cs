using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Repository;
using WebApi.Models;

namespace WebApi.Controllers
{
    [RoutePrefix("api/Users")]
    public class UsersController : GenericController<LOGIN_USER>
    {
        private IGenericRepository<LOGIN_USER> _repository = null;

        public UsersController()
        {
            this._repository = new GenericRepository<LOGIN_USER>();
        }

        public UsersController(IGenericRepository<LOGIN_USER> repository) : base(repository)
        {
        }
    }
}
