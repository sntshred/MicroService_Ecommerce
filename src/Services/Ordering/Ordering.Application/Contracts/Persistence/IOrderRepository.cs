using Ordering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Persistence
{
    public interface IOrderRepository:IAsyncRepository<Order>
    {
        //All the base repos function, in Addition, custom function

        Task<IEnumerable<Order>> GetOrdersByUserName(string username);


    }
}
