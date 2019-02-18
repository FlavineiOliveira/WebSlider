using System.Web;
using System.Web.Optimization;

namespace WebSite
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/Shared/highlight.min.js",
                      "~/Scripts/Shared/Slider/Slider.js"
                      ));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/Shared/Button/NewButton.css",
                     "~/css/Shighlightjs - github - theme.css",
                      "~/Content/Shared/Slider/Slider.css"
                      ));

            //Definição de orgem para que os arquivos sejam executados na orgem correta
            var ordem = new BundleFileSetOrdering("meuScript");
            ordem.Files.Add("bootstrap.css");
            ordem.Files.Add("Slider.css");
            ordem.Files.Add("site.css");
            ordem.Files.Add("NewButton.css");
            ordem.Files.Add("Shighlightjs - github - theme.css");
            ordem.Files.Add("bootstrap.js");
            ordem.Files.Add("Slider.js");
            ordem.Files.Add("jquery - 3.3.1.js");
            ordem.Files.Add("highlight.min.js");
            bundles.FileSetOrderList.Insert(0, ordem);
        }
    }
}
