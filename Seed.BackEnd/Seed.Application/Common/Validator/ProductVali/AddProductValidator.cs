using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.Common.Validator.Abstract;
using Seed.Infrastructure.Common;
using Seed.Infrastructure.DTOs.Product.Create;

namespace Seed.Application.Common.Validator.ProductVali
{
    public class AddProductValidator : ProductValidator<AddProductRequest>
    {
        public AddProductValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddProductNameRules(request => request.Name, checkExists: true);
            AddProductPriceRules(priceExpression => priceExpression.Price);
            AddProductDescriptionRules(descriptionExpression => descriptionExpression.Description);
        }
    }
}
