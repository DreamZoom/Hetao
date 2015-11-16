using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hetao.Framework.BLL;
using System.Web;

namespace Hetao.Framework.SamplePermission
{
    public class AccountService : ServiceBase<Account>
    {
        public AccountService()
            : base(new AccountContext())
        {

        }

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Account Login(string username, string password,string role)
        {
            
            var account = this.FindAll(m => m.UserName == username && m.Password == password).FirstOrDefault();
            if (account != null)
            {
                account.Log("login", HttpContext.Current.Request.UserHostAddress);
                this.DbContext.SaveChanges();
            }
            return account;
        }


        public Account getUser(string username, string password)
        {

            var account = this.FindAll(m => m.UserName == username && m.Password == password).FirstOrDefault();
           
            return account;
        }
    }
}
