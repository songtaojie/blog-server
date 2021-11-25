﻿using AutoMapper;
using Hx.Sdk.DependencyInjection;
using HxCore.Extras.SqlSugar.Repositories;
using Microsoft.Extensions.DependencyInjection;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HxCore.Services
{
    public abstract class BaseQuery<T>:IScopedDependency
          where T : class, new()
    {
        protected readonly ISqlSugarRepository<T> Repository;
        protected readonly SqlSugarClient Db;
        /// <summary>
        /// AutoMapper映射对象
        /// </summary>
        protected IMapper Mapper { get; }

        public BaseQuery(ISqlSugarRepository<T> repository)
        {
            Repository = repository;
            this.Db = Repository.Context;
            this.Mapper = repository.ServiceProvider.GetRequiredService<IMapper>();
        }
    }
}
