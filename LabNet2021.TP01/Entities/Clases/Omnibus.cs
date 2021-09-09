using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Clases
{
    class Omnibus : TransportePublico
    {
        public Omnibus() : base() { }

        public Omnibus(int pasajeros, int id) : base(pasajeros, id) { }
       
        public override void Avanzar()
        {
            throw new NotImplementedException();
        }

        public override void Detenerse()
        {
            throw new NotImplementedException();
        }
    }
}
