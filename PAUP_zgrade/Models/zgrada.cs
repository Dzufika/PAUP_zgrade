//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PAUP_zgrade.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema; 
 

    public partial class zgrada
    {
        [Display(Name = "ID zgrade")]
        [Key]
        public int idzgrada { get; set; }

        [Display(Name = "Ulica i broj")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} je obavezan podatak")]
        public string ulica { get; set; }

        [Display(Name = "Grad")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} je obavezan podatak")]
        public string grad { get; set; }

        [Display(Name = "Po�tanski broj")]
        public Nullable<int> postanskibroj { get; set; }
    }
}
