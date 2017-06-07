using System.Web.Optimization;

namespace PersonalSite
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            //jQuery
            bundles.Add(new ScriptBundle("~/Scripts/jquery", "https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js").Include("~/Scripts/jquery-3.1.1.min.js"));

            //Bootstrap
            bundles.Add(new ScriptBundle("~/Scripts/bootstrap", "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js").Include("~/Scripts/bootstrap.min.js"));
            bundles.Add(new StyleBundle("~/Styles/bootstrap", "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css").Include("~/Content/bootstrap.min.css"));

            //Prettify
            bundles.Add(new ScriptBundle("~/Scripts/prettify", "https://cdn.rawgit.com/google/code-prettify/master/loader/run_prettify.js").Include("~/Scripts/run_prettify.min.js"));
            bundles.Add(new StyleBundle("~/Styles/prettify", "https://cdn.rawgit.com/google/code-prettify/master/loader/skins/desert.css").Include("~/Content/prettify_desert.min.css"));

            //Custom
            bundles.Add(new ScriptBundle("~/Scripts/custom").Include(
                "~/Scripts/navbarHelper.js",
                "~/Scripts/googleAnalytics.js"
            ));
            bundles.Add(new StyleBundle("~/Styles/custom").Include("~/Content/Site.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}