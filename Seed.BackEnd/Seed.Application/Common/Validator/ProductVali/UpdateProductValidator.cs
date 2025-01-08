using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.Common.Validator.Abstract;
using Seed.Infrastructure.Common;
using Seed.Infrastructure.DTOs.Product.Update;

namespace Seed.Application.Common.Validator.ProductVali
{
    public class UpdateProductValidator : ProductValidator<UpdateProductRequest>
    {
        public UpdateProductValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddProductNameRules(request => request.Name, isRequired: false);
            AddProductPriceRules(priceExpression => priceExpression.Price, isRequired: false);
            AddProductDescriptionRules(descriptionExpression => descriptionExpression.Description, isRequired: false);
        }
    }
}
