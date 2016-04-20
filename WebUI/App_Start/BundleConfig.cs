using System.Web;
using System.Web.Optimization;

namespace WebUI
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            // JS				jQuery
            bundles.Add(new ScriptBundle("~/js/jquery").Include(
                        "~/assets/plugins/jquery-1.11.1/jquery-1.11.1.min.js"
                        ));

            // JS & CSS		Bootstrap core 
            bundles.Add(new ScriptBundle("~/js/bootstrap").Include(
                        "~/assets/plugins/bootstrap-3.3.2/js/bootstrap.min.js"
                        ));
            bundles.Add(new StyleBundle("~/css/bootstrap").Include(
                        "~/assets/plugins/bootstrap-3.3.2/css/bootstrap.css"
                        ));

            // CSS			Font Awesome
            bundles.Add(new StyleBundle("~/css/font-awesome").Include(
                        "~/assets/plugins/font-awesome-4.4.0/css/font-awesome.min.css"
                        ));

            // JS & CSS		Bootstrap datepicker 
            bundles.Add(new ScriptBundle("~/js/datepicker").Include(
                        "~/assets/plugins/bootstrap-datepicker/js/bootstrap-datepicker.js",
                        "~/assets/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.zh-CN.js"
                        ));
            bundles.Add(new StyleBundle("~/css/datepicker").Include(
                        "~/assets/plugins/bootstrap-datepicker/css/datepicker.css"
                        ));

            // JS & CSS		Bootstrap daterangepicker 
            bundles.Add(new ScriptBundle("~/js/daterangepicker").Include(
                        "~/assets/plugins/bootstrap-daterangepicker-2.1.13/moment.js",
                        "~/assets/plugins/bootstrap-daterangepicker-2.1.13/daterangepicker.js"
                        ));
            bundles.Add(new StyleBundle("~/css/daterangepicker").Include(
                        "~/assets/plugins/bootstrap-daterangepicker-2.1.13/daterangepicker.css"
                        ));

            // CSS			Fontello
            bundles.Add(new StyleBundle("~/css/fontello").Include(
                        "~/assets/plugins/fontello/css/fontello.css"
                        ));

            // jquery.validate
            bundles.Add(new ScriptBundle("~/js/jqueryval").Include(
                        "~/assets/plugins/jquery.validate-1.13.1/dist/jquery.validate.js",
                        "~/assets/plugins/jquery.validate-1.13.1/dist/localization/messages_zh.js",
                        "~/assets/plugins/jquery.validate.unobtrusive/jquery.validate.unobtrusive.js",
                        "~/assets/plugins/jquery.validate.bootstrap/jquery.validate.bootstrap.js"
                        ));

            // JS & CSS		Magnific-Popup 
            bundles.Add(new ScriptBundle("~/js/magnific-popup").Include(
                        "~/assets/plugins/Magnific-Popup-1.0.0/dist/jquery.magnific-popup.js"
                        ));
            bundles.Add(new StyleBundle("~/css/magnific-popup").Include(
                        "~/assets/plugins/Magnific-Popup-1.0.0/dist/magnific-popup.css"
                        ));

            // JS				Modernizr
            bundles.Add(new ScriptBundle("~/js/modernizr").Include(
                        "~/assets/plugins/modernizr-2.6.2/modernizr-*"));

            // JS & CSS		ThemePunch 
            bundles.Add(new ScriptBundle("~/js/themepunch").Include(
                        "~/assets/plugins/rs-plugin/js/jquery.themepunch.tools.min.js",
                        "~/assets/plugins/rs-plugin/js/jquery.themepunch.revolution.min.js"
                        ));
            bundles.Add(new StyleBundle("~/css/themepunch").Include(
                        "~/assets/plugins/rs-plugin/css/settings.css"
                        ));

            // JS				Isotope 
            bundles.Add(new ScriptBundle("~/js/isotope").Include(
                        "~/assets/plugins/isotope-2.2.1/dist/isotope.pkgd.min.js"
                        ));

            // JS				WayPoints 
            bundles.Add(new ScriptBundle("~/js/waypoints").Include(
                        "~/assets/plugins/waypoints-3.1.1/lib/jquery.waypoints.min.js"
                        ));

            // JS				CountTo 
            bundles.Add(new ScriptBundle("~/js/countTo").Include(
                        "~/assets/plugins/jquery-countTo-1.1.0/jquery.countTo.js"
                        ));

            // JS	& CSS		CountDown
            bundles.Add(new ScriptBundle("~/js/countDown").Include(
                        "~/assets/plugins/countdown-2.0.2/jquery.plugin.js",
                        "~/assets/plugins/countdown-2.0.2/jquery.countdown.js"
                        ));
            bundles.Add(new StyleBundle("~/css/countDown").Include(
                        "~/assets/plugins/countdown-2.0.2/jquery.countdown.css"
                        ));

            // JS				Parallax 
            bundles.Add(new ScriptBundle("~/js/parallax").Include(
                        "~/assets/plugins/parallax-2.1.3/deploy/jquery.parallax.min.js"
                        ));

            // JS				Morphext 
            bundles.Add(new ScriptBundle("~/js/morphext").Include(
                        "~/assets/plugins/Morphext-2.4.4/dist/morphext.min.js"
                        ));

            // JS				Vide
            bundles.Add(new ScriptBundle("~/js/vide").Include(
                        "~/assets/plugins/Vide-0.3.7/dist/jquery.vide.min.js"
                        ));

            // CSS			Animate
            bundles.Add(new StyleBundle("~/css/animate").Include(
                        "~/assets/plugins/animate.css-3.4.0/animate.custom.css"
                        ));

            // CSS			Hover
            bundles.Add(new StyleBundle("~/css/hover").Include(
                        "~/assets/plugins/Hover-2.0.2/hover-min.css"
                        ));

            // JS & CSS		Owl carousel
            bundles.Add(new ScriptBundle("~/js/owl-carousel").Include(
                        "~/assets/plugins/OwlCarousel-1.3.3/owl-carousel/owl.carousel.min.js"
                        ));
            bundles.Add(new StyleBundle("~/css/owl-carousel").Include(
                        "~/assets/plugins/OwlCarousel-1.3.3/owl-carousel/owl.carousel.css",
                        "~/assets/plugins/OwlCarousel-1.3.3/owl-carousel/owl.transitions.css"
                        ));

            // JS				jQuery-Browser
            bundles.Add(new ScriptBundle("~/js/jquery-browser").Include(
                        "~/assets/plugins/jquery-browser-plugin-0.0.8/dist/jquery.browser.min.js"
                        ));

            // JS				SmoothScroll
            bundles.Add(new ScriptBundle("~/js/smoothscroll").Include(
                        "~/assets/plugins/smoothscroll-1.2.1/SmoothScroll.js"
                        ));

            // JS				Chat Flot
            bundles.Add(new ScriptBundle("~/js/chart/flot").Include(
                        "~/assets/plugins/flot-0.8.3/jquery.flot.js",
                        "~/assets/plugins/flot-0.8.3/jquery.flot.time.js",
                        "~/assets/plugins/flot-0.8.3/jquery.flot.resize.js",
                        "~/assets/plugins/flot-0.8.3/jquery.flot.pie.js",
                        "~/assets/plugins/flot-0.8.3/jquery.flot.stack.js",
                        "~/assets/plugins/flot-0.8.3/jquery.flot.crosshair.js",
                        "~/assets/plugins/flot-0.8.3/jquery.flot.categories.js",
                        "~/assets/plugins/flot.tooltip-0.8.4/js/jquery.flot.tooltip.js"
                        ));

            // JS				Chat Sparkline
            bundles.Add(new ScriptBundle("~/js/chart/sparkline").Include(
                        "~/assets/plugins/jquery.sparkline-2.1.2/dist/jquery.sparkline.js"
                        ));

            // JS				Chat
            bundles.Add(new ScriptBundle("~/js/chart/chart").Include(
                        "~/assets/plugins/chart/chart.js"
                        ));

            // JS & CSS		SummerNote
            bundles.Add(new ScriptBundle("~/js/summernote").Include(
                        "~/assets/plugins/summernote-0.6.0/dist/summernote.js",
                        "~/assets/plugins/summernote-0.6.0/lang/summernote-zh-CN.js"
                        ));
            bundles.Add(new StyleBundle("~/css/summernote").Include(
                        "~/assets/plugins/summernote-0.6.0/dist/summernote.css"
                        ));

            // JS & CSS		Uploadify
            bundles.Add(new ScriptBundle("~/js/uploadify").Include(
                        "~/assets/plugins/uploadify-2.2/jquery.uploadify.js"
                        ));
            bundles.Add(new StyleBundle("~/css/uploadify").Include(
                        "~/assets/plugins/uploadify-2.2/uploadify.css"
                        ));

            // JS & CSS		jasny-bootstrap
            bundles.Add(new ScriptBundle("~/js/jasny").Include(
                        "~/assets/plugins/jasny-bootstrap-3.1.3/js/jasny-bootstrap.js"
                        ));
            bundles.Add(new StyleBundle("~/css/jasny").Include(
                        "~/assets/plugins/jasny-bootstrap-3.1.3/css/jasny-bootstrap.css"
                        ));

            // JS & CSS		ToastMessage
            bundles.Add(new ScriptBundle("~/js/toastmessage").Include(
                        "~/assets/plugins/jquery-toastmessage-0.2.0/js/jquery.toastmessage.js"
                        ));
            bundles.Add(new StyleBundle("~/css/toastmessage").Include(
                        "~/assets/plugins/jquery-toastmessage-0.2.0/css/jquery.toastmessage.css"
                        ));

            // JS          KnockOut
            bundles.Add(new ScriptBundle("~/js/knockout").Include(
                        "~/assets/plugins/knockout-3.2.0/knockout-3.2.0.js"
                        ));

            // JS	& CSS		Baidu WebUploader
            bundles.Add(new ScriptBundle("~/js/webuploader").Include(
                        "~/assets/plugins/webuploader-0.1.5/webuploader.js"
                        ));
            bundles.Add(new StyleBundle("~/css/webuploader").Include(
                        "~/assets/plugins/webuploader-0.1.5/webuploader.css"
                        ));

            // JS          Dropzone
            bundles.Add(new ScriptBundle("~/js/dropzone").Include(
                        "~/assets/plugins/dropzone-4.0.0/dropzone.js"
                        ));

            // JS & CSS		ms-Dropdown
            bundles.Add(new ScriptBundle("~/js/ms-dropdown").Include(
                        "~/assets/plugins/ms-Dropdown-3.5.2/js/msdropdown/jquery.dd.js"
                        ));
            bundles.Add(new StyleBundle("~/css/ms-dropdown").Include(
                        "~/assets/plugins/ms-Dropdown-3.5.2/css/msdropdown/dd.css"
                        ));

            // JS & CSS		SweetAlert
            bundles.Add(new ScriptBundle("~/js/sweetalert").Include(
                        "~/assets/plugins/sweetalert-1.1.1/dist/sweetalert-dev.js"
                        ));
            bundles.Add(new StyleBundle("~/css/sweetalert").Include(
                        "~/assets/plugins/sweetalert-1.1.1/dist/sweetalert.css"
                        ));

            // JS & CSS    bootgrid
            bundles.Add(new ScriptBundle("~/js/bootgrid").Include(
                        "~/assets/plugins/jquery.bootgrid-1.1.4/jquery.bootgrid.js"));
            bundles.Add(new StyleBundle("~/css/bootgrid").Include(
                        "~/assets/plugins/jquery.bootgrid-1.1.4/jquery.bootgrid.css"));

            // JS & CSS    MediaElementPlayer
            bundles.Add(new ScriptBundle("~/js/mediaelement").Include(
                       "~/assets/plugins/MediaElementPlayer-2.18.1/js/mediaelement-and-player.min.js"));
            bundles.Add(new StyleBundle("~/css/mediaelement").Include(
                        "~/assets/plugins/MediaElementPlayer-2.18.1/css/mediaelementplayer.min.css"));







            // JS & CSS		This App 
            bundles.Add(new ScriptBundle("~/js/app").Include(
                        "~/assets/js/template.js",
                        "~/assets/js/app.js"
                        ));
            bundles.Add(new StyleBundle("~/css/app").Include(
                        "~/assets/css/app.css",
                        "~/assets/css/custom.css"
                        ));

            // JS & CSS		Sign 
            bundles.Add(new ScriptBundle("~/js/sign").Include(
                        "~/assets/js/sign.js"
                        ));
            bundles.Add(new StyleBundle("~/css/sign").Include(
                        "~/assets/css/sign.css"
                        ));
        }
    }
}
