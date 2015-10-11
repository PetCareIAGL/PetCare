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
                "~/Scripts/Foundation/foundation*"
            /*
            "~/Scripts/Foundation/foundation.abide.js",
            "~/Scripts/Foundation/foundation.alerts.js",
            "~/Scripts/Foundation/foundation.clearing.js",
            "~/Scripts/Foundation/foundation.cookie.js",
            "~/Scripts/Foundation/foundation.dropdown.js",
            "~/Scripts/Foundation/foundation.forms.js",
            "~/Scripts/Foundation/foundation.interchange.js",
            "~/Scripts/Foundation/foundation.joyride.js",
            "~/Scripts/Foundation/foundation.js",
            "~/Scripts/Foundation/foundation.magellan.js",
            "~/Scripts/Foundation/foundation.offcanvas.js",
            "~/Scripts/Foundation/foundation.orbit.js",
            "~/Scripts/Foundation/foundation.placeholder.js",
            "~/Scripts/Foundation/foundation.reveal.js",
            "~/Scripts/Foundation/foundation.section.js",
            "~/Scripts/Foundation/foundation.tooltips.js",
            "~/Scripts/Foundation/foundation.topbar.js"*/
            ));

            bundles.Add(new StyleBundle("~/Content/foundationCSS").Include(
                "~/Content/Foundation/app.css",
                "~/Content/Foundation/foundation.css",
                "~/Content/Foundation/foundation.mvc.css",
                "~/Content/Foundation/normalize.css"
            ));
        }
    }
}
