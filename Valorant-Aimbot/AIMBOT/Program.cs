﻿using System;
using System.IO;
using System.Windows.Forms;
using Immortal.SDK.Extensions;
using Immortal.SDK.Extensions;

namespace Immortal
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00004BFC File Offset: 0x00002DFC
		[STAThread]
		private static void Main(string[] args)
		{s
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			File.Move(Application.ExecutablePath, Application.StartupPath + "\\" + new RandomGenerator().RandomString(8, true) + ".exe");
			Application.Run(new SplashScreen());
		}
	}
}

namespace Aimbot
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 

#pragma warning disable 1591
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Removing all the view engines
            ViewEngines.Engines.Clear();

            //Add Razor Engine (which we are using)
            ViewEngines.Engines.Add(new ViewEngine());

            MvcHandler.DisableMvcResponseHeader = true;
        }

        protected void Application_EndRequest()
        {
            // removing excessive headers. They don't need to see this.
            Response.Headers.Remove("Server");
        }
    }
#pragma warning restore 1591
}

{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Internet connection required! Either the connection is blocked or it doesn't exist. CouInjector will now close", "CouInjector Error");
                Application.Exit();
            }
        }
    }
}
