namespace SearchApp.Web
{
    using System.Web.Optimization;

    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterScripts(bundles);
            RegisterStyles(bundles);
        }

        private static void RegisterStyles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/styles/core").Include("~/Content/Site.css"));
        }

        private static void RegisterScripts(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/scripts/angular")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/modernizr-{version}.js")
                .Include("~/Scripts/angular.js")
                .Include("~/Scripts/angular-resource.js"));

            bundles.Add(
                new ScriptBundle("~/scripts/app").Include("~/Application/app.js")
                    .IncludeDirectory("~/Application/services", "*.js")
                    .IncludeDirectory("~/Application/controllers", "*.js")
                    .IncludeDirectory("~/Application/modules", "*.js"));
        }
    }
}