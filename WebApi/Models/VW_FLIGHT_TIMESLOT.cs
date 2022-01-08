namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_FLIGHT_TIMESLOT
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FLIGHTID { get; set; }

        [StringLength(10)]
        public string FLIGHT_CODE { get; set; }

        [StringLength(100)]
        public string FLIGHT_NAME { get; set; }

        public int? COMPANY_ID { get; set; }

        [StringLength(100)]
        public string COMPANY_NAME { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TIME_ID { get; set; }

        public int? CITYID_FROM { get; set; }

        public int? CITYID_TO { get; set; }

        [StringLength(30)]
        public string Departure { get; set; }

        [StringLength(30)]
        public string Arrival { get; set; }

        [StringLength(30)]
        public string Duration { get; set; }

        public int? FARE { get; set; }

        public DateTime? AVL_DT { get; set; }

        [StringLength(100)]
        public string FROM_CITYNAME { get; set; }

        [StringLength(100)]
        public string TO_CITYNAME { get; set; }
    }
}
