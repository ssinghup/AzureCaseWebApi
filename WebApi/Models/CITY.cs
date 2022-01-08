namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CITY")]
    public partial class CITY
    {
        public int CITYID { get; set; }

        [StringLength(10)]
        public string CITYCODE { get; set; }

        [StringLength(100)]
        public string CITY_NAME { get; set; }
    }
}
