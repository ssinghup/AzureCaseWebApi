using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Repository;
using WebApi.Models;
using System.Web.Http.Description;

namespace WebApi.Controllers
{
    public class FlightController : GenericController<FLIGHT>
    {
        private IGenericRepository<FLIGHT> repository = null;

        public FlightController()
        {
            this.repository = new GenericRepository<FLIGHT>();
        }
        public FlightController(IGenericRepository<FLIGHT> repository) : base(repository)
        {
        }
    }
}
