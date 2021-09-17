using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP04.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T newRegion);
        void Delete(int id);
        void Update(T region);
    }
}
