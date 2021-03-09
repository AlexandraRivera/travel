using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Travel.Models
{
    public class Driver
    {

        [Key]
        public int DriverId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(50, ErrorMessage = "The filed {0} must be maximun {1} characteres lenght")]
        [Display(Name = "Nombres")]
        ///[Index("Department_Name_Index", IsUnique = true)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(50, ErrorMessage = "The filed {0} must be maximun {1} characteres lenght")]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }



        [MaxLength(13, ErrorMessage = "El campo cédula es obligatorio")]
        [Required(ErrorMessage = "El campo no puede ir más de 13 caracteres")]
        [Display(Name = "Número de cédula")]
        public string Dni { get; set; }



        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(50, ErrorMessage = "The filed {0} must be maximun {1} characteres lenght")]
        [Display(Name = "Genero")]
        public string Gender { get; set; }


        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(100, ErrorMessage = "The filed {0} must be maximun {1} characteres lenght")]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }


        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(10, ErrorMessage = "The filed {0} must be maximun {1} characteres lenght")]
        [Display(Name = "Número de Celular")]
        [DataType(DataType.PhoneNumber)]
        public string CellPhone { get; set; }



        [Display(Name = "Foto de conductor")]
        [DataType(DataType.ImageUrl)]
        public string FixedPhone { get; set; }


        [Required(ErrorMessage = "El campo no puede ir vacio {0}")]
        [Display(Name = "Fecha de nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataAge { get; set; }


        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(50, ErrorMessage = "The filed {0} must be maximun {1} characteres lenght")]
        [Display(Name = "Tipo de licencia")]
        public string DriverLicense { get; set; }


        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(50, ErrorMessage = "The filed {0} must be maximun {1} characteres lenght")]
        [Display(Name = "Dirección domiciliaria")]
        public string Address { get; set; }


        [Required(ErrorMessage = "The field {0} is required")]
        [Range(1, double.MaxValue, ErrorMessage = "You must select a {0}")]
        [Display(Name = "Provincia")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [Range(1, double.MaxValue, ErrorMessage = "You must select a {0}")]
        [Display(Name = "Ciudad")]
        public int CityId { get; set; }

        public virtual Department Department { get; set; }

        public virtual City City { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [Range(1, double.MaxValue, ErrorMessage = "You must select a {0}")]
        [Display(Name = "Placa")]
        public int CarId { get; set; }

        public virtual Car Car { get; set; }

        [NotMapped]
        public HttpPostedFileBase FixedPhoneFile { get; set; }
        

    }
}
