using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Hetao.Framework.Contract;

namespace Hetao.Framework.SamplePermission
{
    public class Account : ModelBase
    {
        /// <summary>
        /// 账户名
        /// </summary>
        /// 
        [Key]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime AddTime { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// 用户日志
        /// </summary>
        public virtual ICollection<AccountLog> Logs { get; set; }


        public void Log(string log,string ip)
        {
            this.Logs.Add(new AccountLog() { Ip = ip, Log = log, UserName = this.UserName, LogTime =DateTime.Now });
        }
    }


    public class AccountLog
    {
        public string UserName { get; set; }

        public string Log { get; set; }

        public string Ip { get; set; }

        [Key]
        public DateTime LogTime { get; set; }
    }
}
