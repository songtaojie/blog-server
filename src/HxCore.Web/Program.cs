﻿using System;
using System.Linq;
using Hx.Sdk.Core;
using HxCore.Entity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using NLog.Web;

namespace HxCore.Web
{
    /// <summary>
    /// 主程序
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 主函数
        /// </summary>
        /// <param name="args">参数</param>
        public static int Main(string[] args)
        {
            var logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            try
            {
                //var seed = args.Contains("/seed");
                //if (seed)
                //{
                //    args = args.Except(new[] { "/seed" }).ToArray();
                //}
                //var host = CreateHostBuilder(args).Build();
                //if (seed)
                //{
                //    SeedData.EnsureSeedData(host.Services);
                //    return 1;
                //}
                var host = CreateHostBuilder(args).Build();
                SeedData.EnsureSeedData(host.Services);
                host.Run();
                ConsoleHelper.WriteSuccessLine("program success", true);
                return 1;
            }
            catch (Exception ex)
            {
                ConsoleHelper.WriteErrorLine(string.Format("Error Nessage：{0}", ex.Message));
                ConsoleHelper.WriteErrorLine(string.Format("Error StackTrace：{0}", ex.StackTrace));
                logger.Error(ex, "stopped program");
                return 1;
            }
            finally
            {
                // 确保在应用程序退出之前刷新和停止内部计时器/线程（避免Linux上的分段错误）
                NLog.LogManager.Shutdown();
            }
        }
        /// <summary>
        /// 创建Host
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureHxWebHostDefaults(builder =>
            {
                builder.ConfigureAppConfiguration((_, c) =>
                {
                    c.AddEnvironmentVariables();
                });

                builder.UseNLog()
                .UseStartup<Startup>()
                .UseUrls("http://*:5003");
                ////.ConfigureLogging(logging =>
                ////{
                ////    logging.ClearProviders();
                ////    logging.SetMinimumLevel(LogLevel.Warning);
                ////})
                //.UseNLog();
            });

    }
}
