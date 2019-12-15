using Microsoft.AspNetCore.Antiforgery;
using ThinkAM.StackOverflow.Controllers;

namespace ThinkAM.StackOverflow.Web.Host.Controllers
{
    public class AntiForgeryController : StackOverflowControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
