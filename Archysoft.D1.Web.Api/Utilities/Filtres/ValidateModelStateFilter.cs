using Archysoft.D1.Web.Api.Model;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Archysoft.D1.Web.Api.Utilities.Filtres
{
    public class ValidateModelStateFilter :ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                //var response = new ApiResponse(context.ModelState);
                //context.Result = 
            }
        }
    }
}
