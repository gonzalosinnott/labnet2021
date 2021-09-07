﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO01
{
    public class Perro : Animal
    {
        public Perro(int cantidadPatas) : base(cantidadPatas)
        {

        }

        public override string Caminar()
        {
            return string.Format("Yo avanzo en {0} patas.", cantidadPatas);
        }

        public override string Descripcion()
        {
            throw new NotImplementedException();
        }
    }
}
