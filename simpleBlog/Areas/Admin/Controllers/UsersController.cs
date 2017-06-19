using NHibernate.Linq;
using simpleBlog.Areas.Admin.ViewModels;
using simpleBlog.Infrastructure;
using simpleBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace simpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("users")]
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            return View(new UsersIndex
            {
                Users = Database.Session.Query<User>().ToList()
            });
        }
    }
}