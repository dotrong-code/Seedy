using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.Common.Validator.Abstract;
using Seed.Infrastructure.Common;
using Seed.Infrastructure.DTOs.ProductCategory.Create;

namespace Seed.Application.Common.Validator.ProductCategoryVali
{
    public class AddProductCategoryValidator : ProductCategoryValidator<AddProductCategoryRequest>
    {
        public AddProductCategoryValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddCategoryNameRules(request => request.Name, checkExists: true);
            AddCategoryDescriptionRules(descriptionExpression => descriptionExpression.Description);
        }
    }
}
