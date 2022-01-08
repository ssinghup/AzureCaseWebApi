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
    [RoutePrefix("api/BookedTicket")]
    public class BookedTicketController : GenericController<BOOKED_TICKET>
    {
        private IGenericRepository<BOOKED_TICKET> repository = null;

        public BookedTicketController()
        {
            this.repository = new GenericRepository<BOOKED_TICKET>();
        }
        public BookedTicketController(IGenericRepository<BOOKED_TICKET> repository) : base(repository)
        {
        }


        [Route("GetBookedTicket/{LoginUser}")]
        public object GetBookedTicket(int LoginUser=0)
        {

            using (var context = new ApplicationDBContext())
            {
                var result = (from T1 in context.VW_TICKET_BOOKED
                              join T2 in context.LOGIN_USER on T1.LOGIN_USRID equals T2.USERID
                              where (T1.LOGIN_USRID==LoginUser || LoginUser==0)
                              select new
                              {
                                  BOOKING_ID=T1.BOOKING_ID,
                                  FLIGHT_ID=T1.FLIGHT_ID,
                                  FLIGHT_NAME=T1.FLIGHT_NAME,
                                  FLIGHT_CODE=T1.FLIGHT_CODE,
                                  COMPANY_NAME=T1.COMPANY_NAME,
                                  FROMCITYID=T1.FROMCITYID,
                                  TOCITYID= T1.TOCITYID,
                                  TIME_ID=T1.TIME_ID,
                                  BOOKING_DT= T1.BOOKING_DT,
                                  BOOKING_DATE=T1.BOOKING_DATE,
                                  LOGIN_USRID=T1.LOGIN_USRID,
                                  BOOKED_BY=T2.USERNAME,
                                  BOOKED_BY_NAME=T2.FNAME+" "+T2.LNAME,
                                  CURRENT_DT =T1.CURRENT_DT,
                                  STATUS=T1.STATUS,
                                  CANCELLED_DT=T1.CANCELLED_DT,
                                  PERSON_NAME=T1.PERSON_NAME,
                                  PERSON_AGE=T1.PERSON_AGE,
                                  PERSON_EMAIL=T1.PERSON_EMAIL,
                                  PERSON_MOBILE=T1.PERSON_MOBILE,
                                  BOOKED_FARE=T1.BOOKED_FARE,
                                  FROM_CITYNAME=T1.FROM_CITYNAME,
                                  TO_CITYNAME=T1.TO_CITYNAME
                              }).ToList();
                return result.AsEnumerable();
            }

        }



    }
}
