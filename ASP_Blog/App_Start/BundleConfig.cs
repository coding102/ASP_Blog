using System.Web.Optimization;

namespace ASP_Blog
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/admin/styles")
                .Include("~/content/styles/bootstrap.css")
                .Include("~/content/styles/admin.css"));

            bundles.Add(new StyleBundle("~/styles")
                .Include("~/content/Styles/bootstrap.css")
                .Include("~/content/Styles/site.css"));
        }
    }
}