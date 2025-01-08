using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.Common.Validator.Abstract;
using Seed.Infrastructure.Common;
using Seed.Infrastructure.DTOs.ProductCategory.Update;

namespace Seed.Application.Common.Validator.ProductCategoryVali
{
    public class UpdateProductCategoryValidator : ProductCategoryValidator<UpdateProductCategoryRequest>
    {
        public UpdateProductCategoryValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddCategoryNameRules(request => request.Name, checkExists: true);
            AddCategoryDescriptionRules(descriptionExpression => descriptionExpression.Description);
        }
    }
}
