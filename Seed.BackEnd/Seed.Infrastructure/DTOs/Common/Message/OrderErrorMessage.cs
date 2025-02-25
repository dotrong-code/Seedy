using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.DTOs.Common;

namespace Seed.Infrastructure.DTOs.Common.Message
{
    public static class OrderErrorMessage
    {
        public static Error OrderCreationFailed()
            => Error.Validation("Order.Empty", $"The is required.");

        public static Error OrderNotFound()
            => Error.NotFound("Order.NotFound", $"The order with the given ID was not found.");
    }
}

