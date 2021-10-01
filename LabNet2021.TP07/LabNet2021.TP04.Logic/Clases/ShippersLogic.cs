using LabNet2021.TP04.Entities;
using LabNet2021.TP04.Logic.Clases;
using LabNet2021.TP04.Logic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP04.Logic
{
    public class ShippersLogic : BaseDbClasesLogic, IABMLogic<Shippers>
    {
        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public Shippers UpdateOrAddShippersData(int id, string name, string phone)
        {
            Shippers shipper = new Shippers();

            if (name.LongCount() == 0)
            {
                throw new CustomException("El campo NOMBRE es OBLIGATORIO");
            }
            else if(CheckName(name))
            {
                throw new CustomException("YA EXISTE UNA COMPAÑIA CON ESE NOMBRE");
            }
            else
            {
                shipper.ShipperID = id;
                shipper.CompanyName = name;
                shipper.Phone = phone;
                
                return shipper;
            }
        }

        public bool CheckName(string name)
        {
            ShippersLogic auxShippers = new ShippersLogic();
            List<Shippers> auxList = auxShippers.GetAll();

            bool retorno = false;
            foreach (Shippers item in auxList)
            {
                if(item.CompanyName.Equals(name))
                {
                    return true;
                }
            }
            return retorno;
        }

        public int GetId(string id)
        {
            var auxOrder = context.Shippers.SingleOrDefault(x=> x.CompanyName == id);
            return auxOrder.ShipperID;
        }

        public int GetMaxId()
        {
            int maxId = context.Shippers.Select(x => x.ShipperID).Max();

            return maxId + 1;
        }

        public void Add(Shippers newShipper)
        {
            context.Shippers.Add(newShipper);
            context.SaveChanges();
        }
        
        public void Delete(int id)
        {
            try
            {
                var shipperToDelete = context.Shippers.Find(id);

                context.Shippers.Remove(shipperToDelete);

                context.SaveChanges();
            }
            catch (Exception)
            {
                throw new CustomException("EXISTEN ORDENES ASOCIADAS A ESTE DISTRIBUIDOR. NO SE PUEDE ELIMINAR");
            }
        }        

        public void Update(Shippers shipper)
        {
            try
            {
                var shipperUpdate = context.Shippers.Find(shipper.ShipperID);

                shipperUpdate.CompanyName = shipper.CompanyName;
                shipperUpdate.Phone = shipper.Phone;

                context.SaveChanges();
            }
            catch (Exception)
            {
                throw new CustomException("INGRESO DE DATOS ERRONEOS");
            }
        }
    }
}
