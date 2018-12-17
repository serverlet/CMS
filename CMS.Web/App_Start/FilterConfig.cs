using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Web.App_Start
{
    /// <summary>
    /// 过滤器
    /// </summary>
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new Filters.GlobalExceptionAttribute());//添加全局异常过滤器
        }
    }
}