using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace Ecommerce.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        //required campo obligatorio
        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(50, ErrorMessage = "The filed {0} must be maxium {1} characteres length")]
        [Display(Name = "Ciudad")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [Range(1, double.MaxValue, ErrorMessage = "You must select 0 {0}")]
        public int ProvinceId { get; set; }

        public virtual Province Province { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}
