using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public interface IAllComputers
    {
        IEnumerable<Computer> Computers { get;}
        Computer getObjectComputer(int ComputerId);
    }
}
