using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Repository;
using WebApi.Models;
using System.Web.Http.Description;
using System.Globalization;

namespace WebApi.Controllers
{
    [RoutePrefix("api/Booking")]
    public class BookingController : GenericController<BOOKED_TICKET>
    {
        private IGenericRepository<BOOKED_TICKET> repository = null;

        public BookingController()
        {
            this.repository = new GenericRepository<BOOKED_TICKET>();
        }
        public BookingController(IGenericRepository<BOOKED_TICKET> repository) : base(repository)
        {
        }

        [Route("GetFlightTime/{FromCity}/{ToCity}/{date}")]
        public object GetFlightTime(int FromCity, int ToCity, DateTime date)
        {

            using (var context = new ApplicationDBContext())
            {
                var result = (from T1 in context.VW_FLIGHT_TIMESLOT where T1.CITYID_FROM==FromCity && T1.CITYID_TO==ToCity && T1.AVL_DT==date
                              select new
                              {
                                  FLIGHTID = T1.FLIGHTID,
                                  FLIGHT_CODE = T1.FLIGHT_CODE,
                                  FLIGHT_NAME = T1.FLIGHT_NAME,
                                  COMPANY_ID = T1.COMPANY_ID,
                                  COMPANY_NAME = T1.COMPANY_NAME,
                                  TIME_ID = T1.TIME_ID,
                                  CITYID_FROM = T1.CITYID_FROM,
                                  FROM_CITYNAME = T1.FROM_CITYNAME,
                                  CITYID_TO = T1.CITYID_TO,
                                  TO_CITYNAME = T1.TO_CITYNAME,
                                  Departure = T1.Departure,
                                  Arrival = T1.Arrival,
                                  Duration = T1.Duration,
                                  FARE = T1.FARE,
                                  AVL_DT = T1.AVL_DT
                              }).ToList();
                return result.AsEnumerable();
            }

        }


    }
}