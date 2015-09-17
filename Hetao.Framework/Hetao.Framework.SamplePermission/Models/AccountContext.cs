using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hetao.Framework.DAL;
using System.Data;
using System.Data.Entity;

namespace Hetao.Framework.SamplePermission
{
    public class AccountContext : DbContextBsae
    {
        public AccountContext()
            : base("SamplePermissionConnection")
        {

        }

        /// <summary>
        /// 账户表
        /// </summary>
        DbSet<Account> Accounts { get; set; }

        /// <summary>
        /// 账户日志
        /// </summary>
        DbSet<AccountLog> AccountLogs { get; set; }
    }
}
