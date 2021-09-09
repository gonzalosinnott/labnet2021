using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class TransportePublico
    {
        protected int pasajeros;
        protected int id;

        public TransportePublico() { }

        protected TransportePublico(int pasajeros, int id)
        {
            this.pasajeros = Pasajeros;
            this.id = Id;
        }
        public virtual int Pasajeros { get; set; }

        public virtual int Id { get; set; }

        public abstract void Avanzar();

        public abstract void Detenerse();

        public string getClassType()
        {
            return this.GetType().Name;
        }

        public string ShowVehicleData()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType()} Numero: {this.Id} - Cantidad de Pasajeros: {this.Pasajeros}");

            return sb.ToString();
        }
    }
}
