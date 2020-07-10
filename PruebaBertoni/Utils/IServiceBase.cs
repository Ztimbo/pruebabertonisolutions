using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaBertoni.Utils
{
    public interface IServiceBase<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}