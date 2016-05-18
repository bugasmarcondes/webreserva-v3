using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Owin;
using WebReserva.Models;
using WebReserva.EntityFramework;

[assembly: OwinStartup(typeof(WebReserva.Startup))]

namespace WebReserva
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use(async (ctx, next) =>
            {
                if (ctx.Request.Uri.Segments.Length < 2)
                {
                    throw new ApplicationException("EXCEPTION_REDIRECT_TO_DEMOMDE");
                }
                
                //TODO - NINJECT
                WebReservaRepository repository = new WebReservaRepository(new WebReservaContext());
                WrHotel tenant = repository.GetTenantBasedOnUrl(ctx.Request.Uri.Segments[1].Replace("/", ""));

                if (tenant == null)
                {
                    throw new ApplicationException("EXCEPTION_TENANT_NOT_FOUND");
                }

                ctx.Environment.Add("MultiTenant", tenant);

                await next();
            });
        }
    }
}