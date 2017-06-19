﻿using NHibernate.Linq;
using simpleBlog.Models;
using System.Linq;
using System.Web;

namespace simpleBlog
{
    public static class Auth
    {
        private const string UserKey = "SimpleBlog.Auth.UserKey";

        public static User User
        {
            get
            {
                if (!HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    return null;
                }
                var user = HttpContext.Current.Items[UserKey] as User;
                if (user == null)
                {
                    user = Database.Session.Query<User>()
                        .FirstOrDefault(u => u.Username
                            == HttpContext.Current.User.Identity.Name);
                    if (user == null)
                    {
                        return null;
                    }
                    HttpContext.Current.Items[UserKey] = user;
                }
                return user;
            }
        }
    }
}