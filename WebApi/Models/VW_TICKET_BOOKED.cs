namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_TICKET_BOOKED
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BOOKING_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FLIGHT_ID { get; set; }

        [StringLength(100)]
        public string FLIGHT_NAME { get; set; }

        [StringLength(10)]
        public string FLIGHT_CODE { get; set; }

        [StringLength(100)]
        public string COMPANY_NAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FROMCITYID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TOCITYID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TIME_ID { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime BOOKING_DT { get; set; }

        [StringLength(10)]
        public string BOOKING_DATE { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOGIN_USRID { get; set; }

        public DateTime? CURRENT_DT { get; set; }

        public int? STATUS { get; set; }

        public DateTime? CANCELLED_DT { get; set; }

        [StringLength(100)]
        public string PERSON_NAME { get; set; }

        public int? PERSON_AGE { get; set; }

        [StringLength(50)]
        public string PERSON_EMAIL { get; set; }

        [StringLength(20)]
        public string PERSON_MOBILE { get; set; }

        public decimal? BOOKED_FARE { get; set; }

        [StringLength(100)]
        public string FROM_CITYNAME { get; set; }

        [StringLength(100)]
        public string TO_CITYNAME { get; set; }

        [StringLength(30)]
        public string Departure { get; set; }

        [StringLength(30)]
        public string Arrival { get; set; }

        [StringLength(30)]
        public string Duration { get; set; }
    }
}
