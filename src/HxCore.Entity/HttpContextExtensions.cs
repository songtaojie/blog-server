﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hx.Sdk.Extensions
{
    /// <summary>
    /// HttpContext扩展类
    /// </summary>
    public static class HttpContextExtensions
    {
        /// <summary>
        /// 获取 Action 特性
        /// </summary>
        /// <typeparam name="TAttribute"></typeparam>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public static TAttribute GetMetadata<TAttribute>(this HttpContext httpContext)
            where TAttribute : class
        {
            return httpContext.GetEndpoint()?.Metadata?.GetMetadata<TAttribute>();
        }

        /// <summary>
        /// 获取 控制器/Action 描述器
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public static ControllerActionDescriptor GetControllerActionDescriptor(this HttpContext httpContext)
        {
            return httpContext.GetEndpoint()?.Metadata?.FirstOrDefault(u => u is ControllerActionDescriptor) as ControllerActionDescriptor;
        }

        /// <summary>
        /// 获取本机 IPv4地址
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string GetLocalIpAddressToIPv4(this HttpContext context)
        {
            return context.Connection.LocalIpAddress?.MapToIPv4()?.ToString();
        }

        /// <summary>
        /// 获取本机 IPv6地址
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string GetLocalIpAddressToIPv6(this HttpContext context)
        {
            return context.Connection.LocalIpAddress?.MapToIPv6()?.ToString();
        }

        /// <summary>
        /// 获取远程 IPv4地址
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string GetRemoteIpAddressToIPv4(this HttpContext context)
        {
            return context.Connection.RemoteIpAddress?.MapToIPv4()?.ToString();
        }

        /// <summary>
        /// 获取远程 IPv6地址
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string GetRemoteIpAddressToIPv6(this HttpContext context)
        {
            return context.Connection.RemoteIpAddress?.MapToIPv6()?.ToString();
        }

        /// <summary>
        /// 获取完整请求地址
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string GetRequestUrlAddress(this HttpRequest request)
        {
            return new StringBuilder()
                    .Append(request.Scheme)
                    .Append("://")
                    .Append(request.Host)
                    .Append(request.PathBase)
                    .Append(request.Path)
                    .Append(request.QueryString)
                    .ToString();
        }

        /// <summary>
        /// 获取来源地址
        /// </summary>
        /// <param name="request"></param>
        /// <param name="refererHeaderKey"></param>
        /// <returns></returns>
        public static string GetRefererUrlAddress(this HttpRequest request, string refererHeaderKey = "Referer")
        {
            return request.Headers[refererHeaderKey].ToString();
        }
    }
}

