using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class TransportePublico
    {
        private int pasajeros;
        private int id;

        public TransportePublico(int pasajeros, int id)
        {
            this.pasajeros = pasajeros;
            this.id = id;
        }
        public int Pasajeros { get; set; }

        public int Id { get; set; }

        public abstract void Avanzar();

        public abstract void Detenerse();
    }
}
