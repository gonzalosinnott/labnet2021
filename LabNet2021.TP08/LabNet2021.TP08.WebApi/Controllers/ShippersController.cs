using LabNet2021.TP04.Data;
using LabNet2021.TP04.Entities;
using LabNet2021.TP04.Logic;
using LabNet2021.TP04.Logic.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LabNet2021.TP08.WebApi.Controllers
{
    public class ShippersController : ApiController
    {
        public IHttpActionResult GetAllShippers()
        {
            IList<ShippersDTO> shippers = null;

            using (var context = new NorthwindContext())
            {
                shippers = context.Shippers.Select(s => new ShippersDTO()
                            {
                                ShipperID = s.ShipperID,
                                CompanyName = s.CompanyName,
                                Phone = s.Phone
                            }).ToList();
            }

            if (shippers.Count == 0)
            {
                return NotFound();
            }

            return Ok(shippers);
        }
    }
}
