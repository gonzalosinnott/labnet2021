using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP05.Logic.Interfaces
{
    public interface ILogic<T>
    {
        List<T> GetAll();
    }
}
