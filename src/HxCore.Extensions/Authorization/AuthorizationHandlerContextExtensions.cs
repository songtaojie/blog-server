﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;


namespace Microsoft.AspNetCore.Authorization
{
    /// <summary>
    /// 授权处理上下文拓展类
    /// </summary>
    public static class AuthorizationHandlerContextExtensions
    {
        /// <summary>
        /// 获取当前 HttpContext 上下文
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static DefaultHttpContext GetCurrentHttpContext(this AuthorizationHandlerContext context)
        {
            DefaultHttpContext httpContext;

            // 获取 httpContext 对象
            if (context.Resource is AuthorizationFilterContext filterContext) httpContext = filterContext.HttpContext as DefaultHttpContext;
            else if (context.Resource is DefaultHttpContext defaultHttpContext) httpContext = defaultHttpContext;
            else httpContext = null;

            return httpContext;
        }
    }
}
