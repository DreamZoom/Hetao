using System.Web;
using System.Web.Optimization;

namespace Hetao.Framework.Cms
{
    public class BundleConfig
    {
        // 有关 Bundling 的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            //Metronic

            bundles.Add(new StyleBundle("~/theme/metronic").Include(
                    "~/Themes/Commons/bootstrap/css/bootstrap.css",
                    "~/Themes/Commons/bootstrap/css/bootstrap-responsive.css",
                    "~/Themes/Commons/font-awesome/css/font-awesome.css",
                    "~/Themes/Metronic/css/metro.css",
                    "~/Themes/Metronic/css/style.css",
                    "~/Themes/Metronic/css/style_responsive.css",
                    "~/Themes/Metronic/css/style_default.css",
                    "~/Themes/Commons/gritter/css/jquery.gritter.css",
                    "~/Themes/Commons/uniform/css/uniform.default.css",
                    "~/Themes/Commons/jquery-easyui/themes/bootstrap/easyui.css",
                    "~/Themes/Commons/jquery-easyui/themes/color.css",
                    "~/Themes/Commons/jquery-easyui/themes/icon.css"
                ));

            bundles.Add(new ScriptBundle("~/js/metronic").Include(
                   "~/Scripts/jquery-{version}.js",
                   "~/Scripts/jquery.unobtrusive*",
                   "~/Scripts/jquery.validate*",
                   "~/Scripts/jquery-ui-{version}.js",
                   "~/Themes/Commons/jquery-slimscroll/jquery.slimscroll.js",
                   "~/Themes/Commons/fullcalendar/fullcalendar/fullcalendar.js",
                   "~/Themes/Commons/bootstrap/js/bootstrap.js",
                   "~/Themes/Commons/breakpoints/breakpoints.js",
                   "~/Themes/Commons/uniform/jquery.uniform.js",
                   "~/Themes/Commons/gritter/js/jquery.gritter.js",
                   "~/Themes/Commons/jquery-easyui/jquery.easyui.js",
                   "~/Themes/Commons/bootstrap-daterangepicker/date.js",
                   "~/Themes/Commons/bootstrap-daterangepicker/daterangepicker.js",
                   "~/Themes/Metronic/js/jquery.blockui.js",
                   "~/Themes/Metronic/js/jquery.cookie.js",
                   "~/Themes/Metronic/js/jquery.pulsate.js",
                   "~/Themes/Metronic/js/app.js"
                ));
        }
    }
}