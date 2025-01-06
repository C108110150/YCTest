using System.Web;
using System.Web.Optimization;

namespace YCTest
{
    public class BundleConfig
    {
        // 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好可進行生產時，請使用 https://modernizr.com 的建置工具，只挑選您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                  "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.bundle.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/Common").Include(
                     "~/Scripts/Common/VerifyFormat.js",
                     "~/Scripts/Common/VerifyType.js",
                     "~/Scripts/Common/Dialog.js",
                     "~/Scripts/Common/Autocomplete.js",
                     "~/Scripts/Common/Format.js",
                     "~/Scripts/Common/Utility.js",
                     "~/Scripts/Common/CityTown.js",
                     "~/Scripts/Common/WasteCode.js",
                    "~/Scripts/jquery.blockUI.js",
                    "~/Scripts/jquery-ui-1.13.2.min.js",
                     "~/Scripts/style.js"
           ));

            bundles.Add(new StyleBundle("~/Content/Ncss").Include(

                     "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/customCommon").Include(
                     "~/Content/reset.css",
                    "~/Content/font-awesome/css/font-awesome.min.css",
                    "~/Content/bootstrap.min.css",
                    "~/Content/themes/base/jquery-ui.min.css",
                     "~/Content/style_master.css"));

            #region DatePicker

            bundles.Add(new ScriptBundle("~/bundles/DatePickerJs").Include(
                   "~/Scripts/moment.min.js",
                   "~/Scripts/moment-with-locales.min.js",
                   "~/Scripts/bootstrap-datetimepicker.js",
                   "~/Scripts/bootstrap-datepickertw.js",
                   "~/Scripts/Common/DatePickers.js"
                   ));

            bundles.Add(new StyleBundle("~/Content/DatePickerCss").Include(
                  "~/Content/font-awesome/css/all.min.css",
                    "~/Content/bootstrap-datetimepicker.css"
                    ));
            #endregion

            bundles.Add(new StyleBundle("~/Content/LoginCss").Include(
                    "~/Content/reset.css",
                     "~/Content/bootstrap.css",
                    "~/Content/themes/base/jquery-ui.min.css",
                    "~/Scripts/slick/slick.css",
                    "~/Scripts/slick/slick-theme.css",
                     "~/Content/paginationjs/pagination.css",
                    "~/Content/style_login.css"));

            bundles.Add(new StyleBundle("~/Content/MainCss").Include(
                  "~/Content/reset.css",
                   "~/Content/bootstrap.css",
                  "~/Content/themes/base/jquery-ui.min.css",
                  "~/Content/style_main.css"));

            #region Jquery DataTable
            bundles.Add(new StyleBundle("~/Content/DataTableCss").Include(
                 "~/Content/dataTables.bootstrap5.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/DataTableJs").Include(
                "~/Scripts/jquery.dataTables.min.js",
                "~/Scripts/dataTables.min.js",
                "~/Scripts/dataTables.bootstrap5.min.js",
                "~/Scripts/dataTable.js"));
            #endregion

            #region Select2
            bundles.Add(new ScriptBundle("~/bundles/Select2").Include(
                      "~/Scripts/select2.js"
                   ));
            bundles.Add(new StyleBundle("~/Content/Select2").Include(
                "~/Content/css/select2.css"
                ));
            #endregion
            #region BootstrapTable
            bundles.Add(new StyleBundle("~/Content/BootstrapTableCss").Include(
                     "~/Content/BootstrapTable/all.css",
                     "~/Content/BootstrapTable/bootstrap-table.min.css",
                     "~/Content/BootstrapTable/default.min.css",
                     "~/Content/BootstrapTable/hint.min.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/BoostrapTableJs").Include(
                     "~/Scripts/BootstrapTable/bootstrap-table.min.js",
                     "~/Scripts/BootstrapTable/bootstrap-table-locale-all.min.js"
                ));
            #endregion
            #region BoostrapTree
            bundles.Add(new StyleBundle("~/bundles/BoostrapTreeCss").Include(
                    //   "~/Content/BoostrapTreeView/bootstrap-treeview.css",
                    "~/Content/bootstrap-treeview.min.css"
                ));
            bundles.Add(new ScriptBundle("~/bundles/BoostrapTreeJs").Include(
                    "~/Scripts/bootstrap-treeview.min.js"
                 //  "~/Scripts/BoostrapTreeView/bootstrap-treeview.js"
                 ));
            #endregion
            bundles.Add(new StyleBundle("~/Content/LoginCss").Include(
        "~/Content/reset.css",
         "~/Content/bootstrap.css",
        "~/Content/themes/base/jquery-ui.min.css",
        "~/Content/style_login.css"));
            #region 前台
            bundles.Add(new StyleBundle("~/Content/FrontCss").Include(
            /* CSS Plugins */
            "~/Content/Views/Frontend/plugin-swiper-bundle.min.css",
            "~/Content/Views/Frontend/plugin-aos.css",
            "~/Content/Views/Frontend/plugin-magnific-popup.css",
            //"~/Content/Views/Frontend/editor_backend.css",
            //"~/Content/Views/Frontend/plugin-photoswipe-default-skin.css",
            //"~/Content/Views/Frontend/plugin-photoswipe.css",
            //"~/Content/Views/Frontend/plugin-slick.css",
            //"~/Content/Views/Frontend/plugin-slick.min.css",
            //"~/Content/Views/Frontend/plugin-swiper-bundle.css",

            /* CSS Customization */
            "~/Content/Views/Frontend/custom.css"

            ));
            bundles.Add(new ScriptBundle("~/bundles/FrontJs").Include(
            "~/Scripts/Views/Frontend/Plugin/mobiledetect-1.4.2.min.js",
            "~/Scripts/Views/Frontend/Plugin/jQuery/jquery-3.7.1.min.js",
            "~/Scripts/Views/Frontend/Plugin/jQuery/jquery-migrate-3.4.1.min.js",
            "~/Scripts/Views/Frontend/Plugin/jQuery/jquery.lazy-1.7.9.min.js",
            "~/Scripts/Views/Frontend/Plugin/jQuery/jquery.easing-1.4.1.min.js",
            /* Effect Plugin */
            "~/Scripts/Views/Frontend/Plugin/lenis-1.0.28.min.js",
            "~/Scripts/Views/Frontend/Plugin/aos-3.0.0.min.js",
            "~/Scripts/Views/Frontend/Plugin/jQuery/jquery-parallax-1.5.0.min.js",
            "~/Scripts/Views/Frontend/Plugin/jQuery/jquery.magnificpopup-1.1.0.min.js",
            "~/Scripts/Views/Frontend/tabs_dropdown.js",
            "~/Scripts/Views/Frontend/tabs_nav.js",
            /* Main Script */
            "~/Scripts/Views/Frontend/main.js"
            ));

            /* 介接API用 */
            bundles.Add(new Bundle("~/bundles/FrontApiJs").Include(
                "~/Scripts/Common/JWT.js"));

            bundles.Add(new Bundle("~/bundles/FrontHomeJs").Include(
            "~/Scripts/Views/Frontend/Plugin/swiper-bundle-8.4.7.min.js",
            "~/Scripts/Views/Frontend/Plugin/masonry.pkgd-4.2.2.min.js"
            ));
            bundles.Add(new Bundle("~/bundles/FrontCarbonJs").Include(
            "~/Scripts/Views/Frontend/Plugin/gsap/gsap.min.js",
            "~/Scripts/Views/Frontend/Plugin/gsap/SplitText.min.js",
            "~/Scripts/Views/Frontend/Plugin/isotope.pkgd-3.0.6.min.js"
            ));

            // bundles.Add(new Bundle("~/bundles/").Include());
            #endregion
            BundleTable.EnableOptimizations = false;
        }
    }
}
