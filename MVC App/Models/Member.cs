using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_App.Models
{
    public class Member
    {
        /// <summary>
        /// ID
        /// </summary>
        public  int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 時間
        /// </summary>
        public DateTime dt { get; set; }
    }
}