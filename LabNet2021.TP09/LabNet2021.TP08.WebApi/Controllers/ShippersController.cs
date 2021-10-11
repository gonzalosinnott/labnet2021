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
        ShippersLogic logic = new ShippersLogic();

        public List<ShippersModel> GetAllShippers()
        {
            try
            {
                List<Shippers> shippers = logic.GetAll();

                List<ShippersModel> shippersView = shippers.Select(s => new ShippersModel()
                {
                    ShipperID = s.ShipperID,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone
                }).ToList();

                return shippersView;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public ShippersModel GetShipperByID(int id)
        {
            try
            {
                Shippers shipper = logic.ReturnDataById(id);
                ShippersModel shipperView = new ShippersModel
                {
                    ShipperID = shipper.ShipperID,
                    CompanyName = shipper.CompanyName,
                    Phone = shipper.Phone
                };
                return shipperView;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void PostNewShipper(ShippersModel shipperView)
        {
            try
            {
                var ShipperEntity = new Shippers
                {
                    CompanyName = shipperView.CompanyName,
                    Phone = shipperView.Phone
                };

                logic.Add(ShipperEntity);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Put(ShippersModel shipperView)
        {
            try
            {
                if(logic.Find(shipperView.ShipperID))
                {
                    var ShipperEntity = new Shippers
                    {
                        ShipperID = shipperView.ShipperID,
                        CompanyName = shipperView.CompanyName,
                        Phone = shipperView.Phone
                    };

                    logic.Update(ShipperEntity);
                }
                else
                {
                    throw new Exception("ID NO VALIDO");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                logic.Delete(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
