using System;
using System.Web;
using System.Web.Mvc;
using WebReserva.Models;

namespace WebReserva.Controllers.Web
{
    public class MultiTenantController : Controller
    {
        public WrHotel Tenant
        {
            get
            {
                object multiTenant;

                if (!Request.GetOwinContext().Environment.TryGetValue("MultiTenant", out multiTenant))
                {
                    throw new ApplicationException("EXCEPTION_TENANT_NOT_FOUND");
                }

                return (WrHotel) multiTenant;
            }
        }
    }
}