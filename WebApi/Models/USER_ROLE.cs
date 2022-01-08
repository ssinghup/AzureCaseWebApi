namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USER_ROLE
    {
        public int ID { get; set; }

        public int USERID { get; set; }

        [StringLength(20)]
        public string ROLE_NAME { get; set; }

        public virtual LOGIN_USER LOGIN_USER { get; set; }
    }
}
