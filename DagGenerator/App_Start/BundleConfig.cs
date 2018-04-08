using System.Web;
using System.Web.Optimization;

namespace DagGenerator
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/dist/scripts/jquery.min.js",
                "~/dist/scripts/popper.min.js",
                "~/dist/scripts/bootstrap.min.js",
                "~/dist/scripts/vis.min.js",
                "~/dist/scripts/bootstrap-slider.js",
                "~/dist/scripts/loadingoverlay.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundle/css").Include(
                "~/dist/css/vis.min.css",
                "~/dist/css/bootstrap.min.css",
                "~/dist/css/font-awesome.min.css",
                "~/dist/css/bootstrap-slider.min.css",
                "~/dist/css/style.css"
                ));
        }
    }
}
