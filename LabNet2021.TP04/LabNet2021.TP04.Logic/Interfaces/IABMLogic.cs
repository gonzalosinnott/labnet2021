using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP04.Logic
{
    public interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T obj);       
        void Update(T obj);
    }
}
