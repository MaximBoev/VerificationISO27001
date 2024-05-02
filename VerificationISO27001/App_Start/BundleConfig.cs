using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace VerificationISO27001.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //styles
            bundles.Add(new StyleBundle("~/bundles/list/css").Include(
                "~/Content/myStyles/list-groups.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/main/css").Include(
                "~/Content/myStyles/style.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/fonta/css").Include(
                "~/Content/font-awesome.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/fontam/css").Include(
                "~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));

            //scripts
            bundles.Add(new ScriptBundle("~/bundles/script/js").Include(
                "~/Scripts/myScripts/script.js"));
        }
    }
}