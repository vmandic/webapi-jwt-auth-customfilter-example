using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace authtest.Filters
{


    public class MyAuthorizeAttribute : TypeFilterAttribute
    {
        public MyAuthorizeAttribute() : base(typeof(MyAuthorizeFilter))
        {

        }
    }

    public class MyAuthorizeFilter : IAuthorizationFilter
    {
        private readonly ILogger log;

        public MyAuthorizeFilter(ILogger<MyAuthorizeFilter> log)
        {
            this.log = log;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            log.LogInformation("On auth triggered.");

            if (true)
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}