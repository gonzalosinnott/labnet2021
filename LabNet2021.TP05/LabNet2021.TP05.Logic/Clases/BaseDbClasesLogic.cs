﻿using LabNet2021.TP05.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP05.Logic.Clases
{
    public class BaseDbClasesLogic
    {
        protected readonly NorthwindContext context;

        public BaseDbClasesLogic()
        {
            context = new NorthwindContext();
        }
    }
}
