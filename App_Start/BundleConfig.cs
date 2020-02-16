using System.Web.Optimization;

namespace BelfastWF_bkend
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Angular bundles
            bundles.Add(new ScriptBundle("~/bundles/Angular")
              .Include(
                "~/bundles/BelfastWF-fend/inline.*",
                "~/bundles/BelfastWF-fend/polyfills.*",
                "~/bundles/BelfastWF-fend/scripts.*",
                "~/bundles/BelfastWF-fend/vendor.*",
                "~/bundles/BelfastWF-fend/runtime.*",
                "~/bundles/BelfastWF-fend/main.*"));

            bundles.Add(new StyleBundle("~/Content/Angular")
              .Include("~/bundles/BelfastWF-fend/styles.*"));
        }
    }
}
