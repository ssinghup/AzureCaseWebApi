namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FLIGHT")]
    public partial class FLIGHT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FLIGHT()
        {
            FLIGHT_TIME = new HashSet<FLIGHT_TIME>();
        }

        public int FLIGHTID { get; set; }

        [StringLength(10)]
        public string FLIGHT_CODE { get; set; }

        [StringLength(100)]
        public string FLIGHT_NAME { get; set; }

        public int? COMPANY_ID { get; set; }

        public int? ACTIVE { get; set; }

        public virtual FLIGHT_COMPANY FLIGHT_COMPANY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FLIGHT_TIME> FLIGHT_TIME { get; set; }
    }
}
