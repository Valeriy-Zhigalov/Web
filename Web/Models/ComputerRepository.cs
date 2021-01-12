using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class ComputerRepository : IAllComputers
    {
        private readonly ApplicationDBContext applicationDBContext;

        public ComputerRepository(ApplicationDBContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }

        public IEnumerable<Computer> Computers => applicationDBContext.Computers.Include(c => c.Products);

        Computer IAllComputers.getObjectComputer(int ComputerId) => applicationDBContext.Computers.FirstOrDefault(p => p.ComputerId == ComputerId);
        
         
        
    }
}
