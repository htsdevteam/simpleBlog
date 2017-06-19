using simpleBlog.Infrastructure;
using System.Web.Mvc;

namespace simpleBlog.App_Start
{
    public static class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new TransactionFilter());
        }
    }
}