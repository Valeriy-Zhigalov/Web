using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
   public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
