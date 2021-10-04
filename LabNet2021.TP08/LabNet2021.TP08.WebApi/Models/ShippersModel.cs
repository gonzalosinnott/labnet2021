using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabNet2021.TP08.WebApi
{
    public class ShippersModel
    {
        [Key]
        public int ShipperID { get; set; }

        [Display(Name = "NOMBRE DEL DISTRIBUIDOR")]
        [Required(ErrorMessage = "CAMPO OBLIGATORIO")]
        [StringLength(40, ErrorMessage = "El nombre del distribuidor debe tener entre 3 y 40 caracteres", MinimumLength = 3)]
        public string CompanyName { get; set; }

        [Display(Name = "TELEFONO")]
        [Required(ErrorMessage = "CAMPO OBLIGATORIO")]
        [StringLength(24, ErrorMessage = "El numero de telefono debe tener entre 6 y 40 caracteres", MinimumLength = 6)]
        public string Phone { get; set; }
    }
}