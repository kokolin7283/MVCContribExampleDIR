using MvcContrib.PortableAreas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCContribExample.Admin
{
    public class AdminAreaRegistration : PortableAreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context, IApplicationBus bus)
        {
            context.MapRoute(
                    "Admin_default",
                    "Admin/{controller}/{action}/{id}",
                    new {action = "Index",id= UrlParameter.Optional},
                    new[] {"MVCContribExample.Admin.Controllers"}
                );
            RegisterAreaEmbeddedResources();
        }
    }
}