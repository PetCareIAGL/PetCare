using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/foundationJS").Include(
                "~/Scripts/Foundation/vendor/fastclick.js",
                "~/Scripts/Foundation/vendor/jquery*",
                "~/Scripts/Foundation/vendor/modernizr.js",
                "~/Scripts/Foundation/vendor/placeholder.js",
                 "~/Scripts/Foundation/foundation.min.js",

                "~/Scripts/Foundation/foundation/foundation.abide.js",
                "~/Scripts/Foundation/foundation/foundation.accordion.js",
                "~/Scripts/Foundation/foundation/foundation.alert.js",
                "~/Scripts/Foundation/foundation/foundation.clearing.js",
                "~/Scripts/Foundation/foundation/foundation.dropdown.js",
                "~/Scripts/Foundation/foundation/foundation.equalizer.js",
                "~/Scripts/Foundation/foundation/foundation.interchange.js",
                "~/Scripts/Foundation/foundation/foundation.joyride.js",
                "~/Scripts/Foundation/foundation/foundation.js",
                "~/Scripts/Foundation/foundation/foundation.magellan.js",
                "~/Scripts/Foundation/foundation/foundation.offcanvas.js",
                "~/Scripts/Foundation/foundation/foundation.orbit.js",
                "~/Scripts/Foundation/foundation/foundation.reveal.js",
                "~/Scripts/Foundation/foundation/foundation.slider.js",
                "~/Scripts/Foundation/foundation/foundation.tab.js",
                "~/Scripts/Foundation/foundation/foundation.tooltip.js",
                "~/Scripts/Foundation/foundation/foundation.topbar.js"
            ));

            bundles.Add(new StyleBundle("~/Content/foundationCSS").Include(
                "~/Content/Foundation/foundation.css",
                "~/Content/Foundation/foundation.min.css",
                "~/Content/Foundation/normalize.css"
            ));
        }
    }
}
