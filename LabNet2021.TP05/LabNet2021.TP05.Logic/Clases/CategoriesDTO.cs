using LabNet2021.TP05.Entities;
using LabNet2021.TP05.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP05.Logic.Clases
{
    public class CategoriesDTO : BaseDbClasesLogic, ILogic<Categories>
    {
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }
    }
}