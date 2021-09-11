using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Clases
{
    public class Garage
    {
        private List<TransportePublico> vehiculos = new List<TransportePublico>();

        public Garage()
        {
            vehiculos = Vehiculos;
        }

        public List<TransportePublico> Vehiculos { get { return vehiculos; } set { vehiculos = value; } }

        public bool AddVehiculo(int cantidadPasajeros, string tipoVehiculo)
        {
            TransportePublico vehiculo;
            int maxId;
            int id;
            if (tipoVehiculo != null)
            {
                if (!vehiculos.Any())
                {
                    maxId = 0;
                }
                else
                {
                    maxId = CheckSpace(tipoVehiculo);
                }

                id = maxId + 1;

                switch (tipoVehiculo)
                {
                    case "Taxi":
                        vehiculo = new Taxi();
                        vehiculo.Id = id;
                        vehiculo.Pasajeros = cantidadPasajeros;
                        vehiculos.Add(vehiculo);
                        break;
                    case "Omnibus":
                        vehiculo = new Omnibus();
                        vehiculo.Id = id;
                        vehiculo.Pasajeros = cantidadPasajeros;
                        vehiculos.Add(vehiculo);
                        break;
                }

                return true;
            }

            return false;
        }


        public int CheckSpace(string type)
        {
            int count = 0;

            foreach (TransportePublico item in Vehiculos)
            {
                if(item.getClassType() == type)
                {
                    count++;
                }               
            }

            return count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("VEHICULOS EN GARAGE");
            sb.AppendLine("-------------------");
            foreach (TransportePublico item in Vehiculos)
            {
                sb.AppendLine(item.ShowVehicleData());
            }
            return sb.ToString();
        }
    }
}
