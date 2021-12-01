﻿using Hx.Sdk.FriendlyException;
using HxCore.Entity;
using HxCore.Entity.Entities;
using HxCore.Enums;
using HxCore.Extras.SqlSugar.Repositories;
using HxCore.IServices;
using HxCore.Model.Admin.Banner;
using SqlSugar;
using System.Threading.Tasks;

namespace HxCore.Services
{
    public class BannerQuery : BaseQuery<T_BannerInfo>, IBannerQuery
    {
        public BannerQuery(ISqlSugarRepository<T_BannerInfo> repository) : base(repository)
        {
        }

        public async Task<SqlSugarPageModel<BannerQueryModel>> QueryNoticePageAsync(BannerQueryParam param)
        {
            var query = this.Db.Queryable<T_BannerInfo>().Where(r => r.Deleted == ConstKey.No)
                   .OrderBy(r => r.OrderSort, OrderByType.Desc)
                   .OrderBy(r => r.CreateTime, OrderByType.Desc)
                   .Select(r => new BannerQueryModel
                   {
                       Id = r.Id,
                       Title = r.Title,
                       Link = r.Link,
                       ImgUrl = r.ImgUrl,
                       OrderSort = r.OrderSort,
                       Target = r.Target,
                       IsEnabled = r.Disabled == ConstKey.No
                   });
            return await query.ToPagedListAsync(param.PageIndex, param.PageSize);
        }
        public async Task<BannerDetailModel> GetDetailAsync(string id)
        {
            var detailModel = await this.Repository.Entities.Where(r=>r.Id == id)
                .Select(r => new BannerDetailModel
                {
                    Id = r.Id,
                    Title = r.Title,
                    Link = r.Link,
                    ImgUrl = r.ImgUrl,
                    OrderSort = r.OrderSort,
                    Target = r.Target,
                    IsEnabled = r.Disabled == ConstKey.No
                })
                .FirstAsync(r => r.Id == id);
            if (detailModel == null) throw new UserFriendlyException("该条数据不存在", ErrorCodeEnum.DataNull);
            return detailModel;
        }

    }
}
