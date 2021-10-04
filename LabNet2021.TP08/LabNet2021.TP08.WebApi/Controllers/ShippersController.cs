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
            IList<ShippersModel> shippers = null;

            using (var context = new NorthwindContext())
            {
                shippers = context.Shippers.Select(s => new ShippersModel()
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

        public IHttpActionResult GetShipperByID(int id)
        {
            ShippersModel shippers = null;

            using (var context = new NorthwindContext())
            {
                shippers = context.Shippers
                .Where(s => s.ShipperID == id)
                .Select(s => new ShippersModel()
                {
                    ShipperID = s.ShipperID,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone
                }).FirstOrDefault();
            }

            if (shippers == null)
            {
                return NotFound();
            }

            return Ok(shippers);
        }

        public IHttpActionResult PostNewStudent(ShippersModel shipper)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            using (var context = new NorthwindContext())
            {
                context.Shippers.Add(new Shippers()
                {
                    CompanyName = shipper.CompanyName,
                    Phone = shipper.Phone
                });

                context.SaveChanges();
            }

            return Ok();
        }

        public IHttpActionResult Put(ShippersModel shipper)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            using (var context = new NorthwindContext())
            {
                var existingShipper = context.Shippers.Where(s => s.ShipperID == shipper.ShipperID).FirstOrDefault();

                if (existingShipper != null)
                {
                    existingShipper.CompanyName = shipper.CompanyName;
                    existingShipper.Phone = shipper.Phone;

                    context.SaveChanges();
                }
                else
                {
                    return NotFound();
                }

                return Ok();
            }
        }

        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("NO ES UN ID VALIDO");

            using (var context = new NorthwindContext())
            {
                var shipper = context.Shippers.Where(s => s.ShipperID == id).FirstOrDefault();

                context.Entry(shipper).State = System.Data.Entity.EntityState.Deleted;

                context.SaveChanges();
            }

            return Ok();
        }
    }
}
