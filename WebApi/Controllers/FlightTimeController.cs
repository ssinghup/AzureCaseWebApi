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
    [RoutePrefix("api/FlightTime")]
    public class FlightTimeController : GenericController<FLIGHT_TIME>
    {
        private IGenericRepository<FLIGHT_TIME> repository = null;

        public FlightTimeController()
        {
            this.repository = new GenericRepository<FLIGHT_TIME>();
        }
        public FlightTimeController(IGenericRepository<FLIGHT_TIME> repository):base(repository) 
        {
        }
    }
}
