namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER")]
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            PROPERTies = new HashSet<PROPERTY>();
            PROPERTies1 = new HashSet<PROPERTY>();
        }

        public int ID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Password { get; set; }

        //[Required(ErrorMessage = "This field is required.")]
        //[DataType(DataType.Password)]
        //[DisplayName("Confirm Password")]
        //[Compare("Password")]
        //public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Address { get; set; }

        public string Role { get; set; }

        public Nullable<bool> Status { get; set; }

       // public string LoginError { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROPERTY> PROPERTies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROPERTY> PROPERTies1 { get; set; }
        
    }
}
