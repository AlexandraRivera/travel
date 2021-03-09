using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Travel.Models
{
    public class Car
    {


        [Key]
        public int CarId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(50, ErrorMessage = "The filed {0} must be maximun {1} characteres lenght")]
        [Display(Name = "Placa del auto")]
        public string Plate { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(50, ErrorMessage = "The filed {0} must be maximun {1} characteres lenght")]
        [Display(Name = "Modelo del carro")]

        public string Model { get; set; }



        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(50, ErrorMessage = "The filed {0} must be maximun {1} characteres lenght")]
        [Display(Name = "Año del auto")]
        public string Year { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(50, ErrorMessage = "The filed {0} must be maximun {1} characteres lenght")]
        [Display(Name = "Capacidad de personas")]
        public string Capacity { get; set; }


        [Display(Name = "Foto del carro")]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }


        [MaxLength(50, ErrorMessage = "The filed {0} must be maximun {1} characteres lenght")]
        [Display(Name = "Observación del auto")]

        public string Observation { get; set; }

       
        [NotMapped]
        public HttpPostedFileBase LogoFile { get; set; }
        

        public virtual ICollection<Driver> Drivers { get; set; }


    }
}
