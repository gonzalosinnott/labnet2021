using LabNet2021.TP04.Entities;
using LabNet2021.TP04.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabNet2021.TP08.WebApi
{
    public class OrdersModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "FECHA DE ENVIO")]
        [Required(ErrorMessage = "CAMPO OBLIGATORIO")]
        public string ShippedDate { get; set; }

        [Display(Name = "NOMBRE DEL DISTRIBUIDOR")]
        [Required(ErrorMessage = "CAMPO OBLIGATORIO")]
        public int ShipVia { get; set; }

        [Display(Name = "DESTINATARIO")]
        [Required(ErrorMessage = "CAMPO OBLIGATORIO")]
        [StringLength(40, ErrorMessage = "El nombre del transporte debe tener entre 3 y 40 caracteres", MinimumLength = 3)]
        public string ShipName { get; set; }

        [Display(Name = "DIRECCION")]
        [Required(ErrorMessage = "CAMPO OBLIGATORIO")]
        [StringLength(60, ErrorMessage = "La direccion debe tener entre 3 y 60 caracteres", MinimumLength = 3)]
        public string Address { get; set; }

        [Display(Name = "CIUDAD")]
        [Required(ErrorMessage = "CAMPO OBLIGATORIO")]
        [StringLength(15, ErrorMessage = "La ciudad debe tener entre 3 y 15 caracteres", MinimumLength = 3)]
        public string City { get; set; }

        [Display(Name = "PAIS")]
        [Required(ErrorMessage = "CAMPO OBLIGATORIO")]
        [StringLength(15, ErrorMessage = "El pais debe tener entre 3 y 15 caracteres", MinimumLength = 3)]
        public string Country { get; set; }    
    }
}