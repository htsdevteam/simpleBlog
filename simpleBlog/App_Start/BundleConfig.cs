using System.Web.Optimization;

namespace simpleBlog.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/admin/styles")
                .Include("~/Content/Styles/bootstrap.css")
                .Include("~/Content/Styles/admin.css"));
            bundles.Add(new StyleBundle("~/styles")
                .Include("~/Content/Styles/bootstrap.css")
                .Include("~/Content/Styles/Site.css"));

            bundles.Add(new ScriptBundle("~/admin/scripts")
                .Include("~/Scripts/jquery-3.1.1.js")
                .Include("~/Scripts/jquery.validate.js")
                .Include("~/Scripts/jquery.validate.unobtrusive.js")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Areas/Admin/Scripts/Forms.js"));

            bundles.Add(new ScriptBundle("~/admin/post/scripts")
                .Include("~/Areas/Admin/Scripts/PostEditor.js"));

            bundles.Add(new ScriptBundle("~/scripts")
                .Include("~/Scripts/jquery-3.1.1.js")
                .Include("~/Scripts/jquery.timeago.js")
                .Include("~/Scripts/jquery.validate.js")
                .Include("~/Scripts/jquery.validate.unobtrusive.js")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Scripts/Frontend.js"));
        }
    }
}