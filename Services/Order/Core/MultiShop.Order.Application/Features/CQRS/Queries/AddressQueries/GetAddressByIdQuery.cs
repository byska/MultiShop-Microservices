using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Queries.AddressQueries
{
    public class GetAddressByIdQuery
    {
        //listeleme işlemi yapılırken alınan parametre bilgisi tutulur.
        public int Id { get; set; }
        //controllerda constructor üzerinden çağrılacağı için.
        public GetAddressByIdQuery(int id)
        {
            Id = id;
        }
    }
}
