﻿using Hx.Sdk.Common.Helper;
using Hx.Sdk.DatabaseAccessor;
using HxCore.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HxCore.Model
{
    /// <summary>
    /// 博客查询实体类
    /// </summary>
    public class BlogQueryModel:IAutoMapper<T_Blog>
    {
        /// <summary>
        /// 博客id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 博客标题
        /// </summary>
        public string Title
        {
            get; set;
        }
        /// <summary>
        /// 发布者
        /// </summary>
        public string Publisher { get; set; }
        /// <summary>
        /// 纯粹的内容，首页列表需要显示的内容
        /// </summary>
        public string PureContent
        {
            get;set;
        }
        /// <summary>
        /// 阅读量
        /// </summary>
        public long ReadCount { get; set; }

        /// <summary>
        /// 被评论次数
        /// </summary>
        public long CmtCount { get; set; }

        /// <summary>
        /// 发布日期
        /// </summary>
        public DateTime? PublishDate { get; set; }

        /// <summary>
        /// 封面图片链接
        /// </summary>
        public string CoverImgUrl { get; set; }

        /// <summary>
        /// 头像链接
        /// </summary>
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 是否是MarkDown编辑的
        /// </summary>
        public string MarkDown { get; set; }
    }

   
}
