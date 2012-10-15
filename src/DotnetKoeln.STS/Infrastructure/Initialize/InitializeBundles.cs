using System;
using System.Web.Optimization;
using Aperea.Infrastructure.Bootstrap;

namespace DotnetKoeln.STS.Infrastructure.Initialize
{
    public class InitializeBundles : BootstrapItem
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/resources/js").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/modernizr-*",
                "~/Scripts/jquery.unobtrusive*"
                            ));
            bundles.Add(new StyleBundle("~/resources/css").Include("~/Content/site.css"));

        }

        public override void Execute()
        {
            RegisterBundles(BundleTable.Bundles);
        }
    }
}