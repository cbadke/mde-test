using System.Web;
using System.Web.Optimization;

namespace Mde_test
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Scripts/simplemde.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/simplemde.min.css"));
        }
    }
}
