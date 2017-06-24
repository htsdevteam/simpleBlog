using NHibernate.Linq;
using simpleBlog.Models;
using simpleBlog.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace simpleBlog.Controllers
{
    public class LayoutController : Controller
    {
        [ChildActionOnly]
        public ActionResult Sidebar()
        {
            return View(new LayoutSidebar
            {
                IsLoggedIn = Auth.User != null,
                Username = Auth.User != null ? Auth.User.Username : "",
                IsAdmin = User.IsInRole("admin"),
                Tags = Database.Session.Query<Tag>()
                    .Select(tag => new
                    {
                        tag.Id,
                        tag.Name,
                        tag.Slug,
                        PostCount = tag.Posts.Count
                    })
                    .Where(t => t.PostCount > 0)
                    .OrderByDescending(p => p.PostCount)
                    .Select(tag => new SidebarTag
                    {
                        Id = tag.Id,
                        Name = tag.Name,
                        Slug = tag.Slug,
                        PostCount = tag.PostCount
                    }).ToList()
            });
        }
    }
}