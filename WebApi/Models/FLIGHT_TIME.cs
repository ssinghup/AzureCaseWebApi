namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FLIGHT_TIME
    {
        [Key]
        public int TIME_ID { get; set; }

        public int? FLIGHTID { get; set; }

        public int? CITYID_FROM { get; set; }

        public int? CITYID_TO { get; set; }

        public DateTime? AVL_DT { get; set; }

        [StringLength(30)]
        public string Departure { get; set; }

        [StringLength(30)]
        public string Arrival { get; set; }

        [StringLength(30)]
        public string Duration { get; set; }

        public int? FARE { get; set; }

        public virtual FLIGHT FLIGHT { get; set; }
    }
}
