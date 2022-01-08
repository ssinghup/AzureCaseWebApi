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
 
   
    public class FlightCompanyController : GenericController<FLIGHT_COMPANY>
    {
        private IGenericRepository<FLIGHT_COMPANY> repository = null;

        public FlightCompanyController()
        {
            this.repository = new GenericRepository<FLIGHT_COMPANY>();
        }
        public FlightCompanyController(IGenericRepository<FLIGHT_COMPANY> repository) : base(repository)
        {
            this.repository = repository;
        }
        

    }
}
