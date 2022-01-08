namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BOOKED_TICKET
    {
        [Key]
        public int BOOKING_ID { get; set; }

        public int FLIGHT_ID { get; set; }

        public int FROMCITYID { get; set; }

        public int TOCITYID { get; set; }

        public int TIME_ID { get; set; }

        public DateTime BOOKING_DT { get; set; }

        public int LOGIN_USRID { get; set; }

        [StringLength(100)]
        public string PERSON_NAME { get; set; }

        public int? PERSON_AGE { get; set; }

        [StringLength(50)]
        public string PERSON_EMAIL { get; set; }

        [StringLength(20)]
        public string PERSON_MOBILE { get; set; }

        public decimal? BOOKED_FARE { get; set; }

        public DateTime? CURRENT_DT { get; set; }

        public int? STATUS { get; set; }

        public DateTime? CANCELLED_DT { get; set; }
    }
}
