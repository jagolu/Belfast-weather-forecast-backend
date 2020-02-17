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
                "~/bundles/Belfast-weather-forecast-Frontend/inline.*",
                "~/bundles/Belfast-weather-forecast-Frontend/polyfills.*",
                "~/bundles/Belfast-weather-forecast-Frontend/scripts.*",
                "~/bundles/Belfast-weather-forecast-Frontend/vendor.*",
                "~/bundles/Belfast-weather-forecast-Frontend/runtime.*",
                "~/bundles/Belfast-weather-forecast-Frontend/main.*"));

            bundles.Add(new StyleBundle("~/Content/Angular")
              .Include("~/bundles/Belfast-weather-forecast-Frontend/styles.*"));
        }
    }
}
