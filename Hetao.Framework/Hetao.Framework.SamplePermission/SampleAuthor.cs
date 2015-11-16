using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hetao.Framework.Web;
using Hetao.Framework.Web.Auth;
using System.Web;

namespace Hetao.Framework.SamplePermission
{
    public class SampleAuthor : DefaultAuther
    {
        public override string getName()
        {
            return base.getName();
        }

        public override bool LogIn(string username, string password, bool remember)
        {
            AccountService accountService = new AccountService();
            var account =accountService.Login(username, password,"Admin");
            if (account!=null)
            {
                HttpContext.Current.Session["Admin"] = account;
                return true;
            }
            return false;
        }

        public override void LogOut()
        {
            HttpContext.Current.Session["Admin"] = null;
        }

        public override bool ChangePassword(string password, string newpassword)
        {
            AccountService accountService = new AccountService();
            var account = HttpContext.Current.Session["Admin"] as Account;
            if (account == null) return false;
            var account2 = accountService.getUser(account.UserName, password);
            if (account2 == null) return false;

            try
            {
                account2.Password = newpassword;
                accountService.Update(account2);
                return true;
            }
            catch
            {
                throw;
            }
            return false;
        }
    }
}
