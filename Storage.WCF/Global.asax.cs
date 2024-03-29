﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Microsoft.Mef.CommonServiceLocator;
using Microsoft.Practices.ServiceLocation;

namespace Storage.WCF
{
    public class Global : HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var assembly = new AssemblyCatalog(typeof(Global).Assembly);
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(assembly);
            catalog.Catalogs.Add(new DirectoryCatalog("bin"));
            var container = new CompositionContainer(catalog);
            var mefServiceLocator = new MefServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => mefServiceLocator);
            container.ComposeExportedValue<IServiceLocator>(mefServiceLocator);
            container.ComposeExportedValue<CompositionContainer>(container);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}