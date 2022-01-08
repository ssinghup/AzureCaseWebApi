namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOGIN_USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOGIN_USER()
        {
            USER_ROLE = new HashSet<USER_ROLE>();
        }

        [Key]
        public int USERID { get; set; }

        [Required]
        [StringLength(30)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(50)]
        public string USER_PASSWORD { get; set; }

        [Required]
        [StringLength(50)]
        public string FNAME { get; set; }

        [Required]
        [StringLength(50)]
        public string LNAME { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public int? ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_ROLE> USER_ROLE { get; set; }
    }
}
